using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WinMemory
{
    class Memory : IDisposable
    {
        public enum GAME_STATE { INACTIVE, STARTED, GAMEOVER };

        #region Variables
        // dynamically created list which contains the possible images/types of memory blocks
        private Dictionary<int, string> m_objListDict;

        // the blocks/"images" for the memory game
        private List<MemoryObject> m_gameBlocks;

        // defines the game matris (sum of rows+cols must be an even number)
        private int m_gameSize;

        private GAME_STATE m_gameState;

        // used to mark the buttons which have been pushed
        private int m_firstButtonID;
        private int m_secondButtonID;

        private Random m_Rand; // random object used for generating the game table

        private bool _isDisposed;

        // used to access functions from frmMain in Memory class
        private frmMain _mainform; 

        // score. number of button clicks
        int m_GameBtnClicks; // number of button clicks
        int m_GameBlckMatcAttemps; // number of (both failed and success) matches of blocks
        int m_GameBlckMatches; // number of matches

        #endregion

        #region Properties

        public GAME_STATE GameStatus
        {
            get { return m_gameState; }
            set { m_gameState = value; }
        }

        #endregion

        #region Functions

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="size"></param>
        public Memory(int size, frmMain mainForm)
        {
            // now we can call functions from frmMain, gg.
            _mainform = mainForm;
            
            // no, this object is not about to be destroyed
            _isDisposed = false;

            m_Rand = new Random();

            m_gameSize = size;

            m_gameBlocks = new List<MemoryObject>();
            m_objListDict = new Dictionary<int,string>();

            m_firstButtonID = -1;
            m_secondButtonID = -1;

            CreateGameMatris();

            GameStatus = GAME_STATE.STARTED;
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~Memory()
        {
            this.Dispose(false);
            
        }

        /// <summary>
        /// Safe cleanup for objects
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Safe cleanup for objects
        /// </summary>
        public virtual void Dispose(bool Disposing)
        {
            if (!this._isDisposed)
            {
                if (Disposing)
                {
                    // Release resourses

                    for (int j = 0; j < m_gameSize; j++)
                    {
                        m_gameBlocks[j].Dispose();
                    }
                    m_gameBlocks.Clear();
                    m_gameBlocks = null;
                }
            }
            this._isDisposed = true;
        }

        /// <summary>
        /// Used to check if game object exists,
        /// </summary>
        /// <returns></returns>
        public bool IsDisposed()
        {
            return (_isDisposed);
        }

        private void CreateGameMatris()
        {
            // Fill gameblocks with MemoryObject objects, adding button names
            for (int i = 0; i < m_gameSize; i++)
            {
                m_gameBlocks.Add(new MemoryObject("button"+i.ToString()));
                m_gameBlocks[i].State = BLOCK_STATE.HIDDEN;
                
            }

            // maximum types of pictures/objects. Refer to Resources. This value could be generated dynamically.
            //int max_num_of_types = 20;

            List<int> tmpPossibleValues = new List<int>();
            for (int k = 0; k < (m_gameSize / 2); k++)
            { // Add possible values (game plan / half because there will be 50% doublettes)
                tmpPossibleValues.Add(k + 1); // +1 because the "bild" serie starts from 1 and goes to 20, not 0-19.
            }

            List<int> tmpPossiblePlaces = new List<int>();
            for (int m = 0; m < m_gameSize; m++)
            { // create list of possible array indexes to put values into 
                tmpPossiblePlaces.Add(m); 
            }

            // continue as long as there´s still values to be put into the gaming field
            while (tmpPossibleValues.Count > 0)
            {
                // random number generation
                int randInt = m_Rand.Next(1, tmpPossibleValues.Count + 1);
                int valueStore = tmpPossibleValues[randInt - 1];

                // remove the selected int from the List
                tmpPossibleValues.RemoveAt(randInt - 1);


                // pick 2 random blocks to place these in
                int id1 = 0;
                int id2 = 0;

                while (true) // infinite loop until 2 different values are found.
                {
                    int t1 = m_Rand.Next(1, tmpPossiblePlaces.Count + 1);
                    id1 = tmpPossiblePlaces[t1 - 1];
                    int t2 = m_Rand.Next(1, tmpPossiblePlaces.Count + 1);
                    id2 = tmpPossiblePlaces[t2 - 1];
                    if (t1 != t2)
                    {
                        // remove the random blocks from temp list and exit while(true), warning: removing the 
                        // lower index value before the higher results in a improperly deletion of the higer value as the index
                        // changes
                        if (t2 > t1)
                        {
                            tmpPossiblePlaces.RemoveAt(t2 - 1);
                            tmpPossiblePlaces.RemoveAt(t1 - 1);
                        }
                        else
                        {
                            tmpPossiblePlaces.RemoveAt(t1 - 1);
                            tmpPossiblePlaces.RemoveAt(t2 - 1);
                        }
                        break;
                    }

                }

                // put the values into the random generated places
                m_gameBlocks[id1].ButtonPicture = String.Format("bild{0}", valueStore);
                m_gameBlocks[id2].ButtonPicture = String.Format("bild{0}", valueStore);
   
            } // while myInitList.Count > 0

        }

        /// <summary>
        /// Main game function with weird name
        /// </summary>
        /// <param name="name"></param>
        public void ButtonClicked(string button)
        {
            int button_index = int.Parse(button.Remove(0,6));

            if (GameStatus == GAME_STATE.STARTED)
            {

                // we´ve recieved a name of the button clicked, now find the equ in our m_gameBlocks LIST.
                
                //MemoryObject thisObj = m_gameBlocks.Find(delegate(MemoryObject p) { return p.Name == button.Name; });
                //MessageBox.Show(String.Format("button found: {0}",thisObj.Name));
                if (m_gameBlocks[button_index].State != BLOCK_STATE.MATCHED && m_gameBlocks[button_index].State != BLOCK_STATE.ACTIVE)
                {
                    if (m_firstButtonID == -1)
                    {
                        // set the block state to Active
                        m_gameBlocks[button_index].State = BLOCK_STATE.ACTIVE;

                        // use this to check our gameblock list for the picture name to reveal
                        string pictureName = GetButtonPicture(button);

                        // change background image
                        _mainform.ChangePicture(button_index, pictureName);
                        // Set m_firstButton to the ID 
                        m_firstButtonID = button_index;

                        // add click to counter
                        m_GameBtnClicks++;
                        _mainform.AddToCounter(true, m_GameBtnClicks);
                    }
                    else if (m_secondButtonID == -1)
                    {
                        if (button_index != m_firstButtonID)
                        { // check if user tries to matche the same button twice.
                            // set the block state to Active
                            m_gameBlocks[button_index].State = BLOCK_STATE.ACTIVE;

                            // use this to check our gameblock list for the picture name to reveal
                            string pictureName = GetButtonPicture(button);

                            // change background image
                            _mainform.ChangePicture(button_index, pictureName);
                            // Set m_firstButton to the ID 
                            m_secondButtonID = button_index;

                            // add click to counter
                            m_GameBtnClicks++;
                            _mainform.AddToCounter(true, m_GameBtnClicks);

                            // match and se if they´re the same
                            MatchButtons();
                        }
                    }
                }
            } // GAME_STATUS started
        }

        /// <summary>
        /// Used by Form1.cs to check/set what pictures to use on the buttons
        /// </summary>
        public string GetButtonPicture(string buttonName)
        {
            // remove "button" from the string and int parse the number followed
            int buttonNum = int.Parse(buttonName.Remove(0,6));

            // return name of the picture to use 
            return m_gameBlocks[buttonNum].ButtonPicture;
        }

        /// <summary>
        /// Matches the picturenames (as id) of the both buttons to be matched
        /// </summary>
        private void MatchButtons()
        {
            if (m_gameBlocks[m_firstButtonID].ButtonPicture == m_gameBlocks[m_secondButtonID].ButtonPicture)
            {   // woho! they´re a match!
                m_gameBlocks[m_firstButtonID].State = BLOCK_STATE.MATCHED;
                m_gameBlocks[m_firstButtonID].State = BLOCK_STATE.MATCHED;

                m_GameBlckMatches++;
            }
            else
            {
                m_gameBlocks[m_firstButtonID].State = BLOCK_STATE.HIDDEN;
                m_gameBlocks[m_secondButtonID].State = BLOCK_STATE.HIDDEN;

                MessageBox.Show("not a match");
                _mainform.ChangePicture(m_firstButtonID, "defaultbild");
                _mainform.ChangePicture(m_secondButtonID, "defaultbild");
            }

            // add match attemp to counter
            m_GameBlckMatcAttemps++;
            _mainform.AddToCounter(false, m_GameBlckMatcAttemps);

            // reset button ids so new matches can occur
            m_firstButtonID = -1;
            m_secondButtonID = -1;

            // game over?
            if (m_GameBlckMatches == (m_gameSize / 2))
            {
                _mainform.InvokeGameOver(m_GameBtnClicks, m_GameBlckMatcAttemps);
            }
        }

        #endregion
    }
}
