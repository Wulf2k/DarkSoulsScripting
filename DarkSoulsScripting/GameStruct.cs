using System;
using System.ComponentModel;

namespace DarkSoulsScripting
{
    public abstract class GameStruct
    {
        public IntPtr Address
        {
            get { return AddressReadFunc(); }
        }

        private Func<IntPtr> _addressReadFunc;
        internal Func<IntPtr> AddressReadFunc
        {
            get => _addressReadFunc;
            set
            {
                _addressReadFunc = value;
                InitSubStructures();
            }
        }

        protected abstract void InitSubStructures();
    }
}
