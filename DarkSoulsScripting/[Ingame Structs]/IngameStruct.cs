using System;
using System.ComponentModel;

namespace DarkSoulsScripting
{
    public abstract class IngameStruct
    {
        public int Address
        {
            get { return AddressReadFunc(); }
        }

        private Func<int> _addressReadFunc;
        internal Func<int> AddressReadFunc
        {
            get => _addressReadFunc;
            set
            {
                _addressReadFunc = value;
                InitSubStructures();
            }
        }

        protected abstract void InitSubStructures();

        //[Browsable(false)]
        //internal virtual int StructSize
        //{
        //    get => throw new NotImplementedException();
        //}

        //public IngameStruct(Func<int> addrReadFunc)
        //{
        //    AddressReadFunc = addrReadFunc;
        //    InitStructMembers();
        //}

        //public IngameStruct(int addr)
        //{
        //    int addrDeref = addr;
        //    AddressReadFunc = () => addrDeref;
        //    InitStructMembers();
        //}

        //public IngameStruct()
        //{
        //    AddressReadFunc = () => 0;
        //    InitStructMembers();
        //}

        //internal abstract void OverwriteWith(dynamic other);
    }
}
