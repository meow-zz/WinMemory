using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WinMemory
{
    // make public for program, used by both Memory.cs and this
    public enum BLOCK_STATE { HIDDEN, ACTIVE, MATCHED };

    class MemoryObject
    {
       
        private string m_Name; // represents one of the dynamically created buttons 
        private BLOCK_STATE m_BlockState;
        private string m_ButtonPicture;
        private bool _isDisposed;

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public BLOCK_STATE State
        {
            get { return m_BlockState; }
            set { m_BlockState = value; }
        }

        public string ButtonPicture
        {
            get { return m_ButtonPicture; }
            set { m_ButtonPicture = value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="newName"></param>
        public MemoryObject(string newName)
        {
            m_Name = newName;
            m_BlockState = BLOCK_STATE.HIDDEN; // hidden as default
            m_ButtonPicture = null;
            // no, this object is not about to be destroyed
            _isDisposed = false;
        }

        ~MemoryObject()
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
                   
                }
            }
            this._isDisposed = true;
        }
    }
}
