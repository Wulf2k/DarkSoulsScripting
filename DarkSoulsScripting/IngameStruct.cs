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

        public readonly Func<int> AddressReadFunc = () => 0;

        [Browsable(false)]
        public virtual int Size
        {
            get => throw new NotImplementedException();
        }

        protected virtual void InitStructMembers()
        {

        }

        public IngameStruct(Func<int> addrReadFunc)
        {
            AddressReadFunc = addrReadFunc;
            InitStructMembers();
        }

        public IngameStruct(int addr)
        {
            int addrDeref = addr;
            AddressReadFunc = () => addrDeref;
            InitStructMembers();
        }

        public IngameStruct()
        {
            AddressReadFunc = () => 0;
            InitStructMembers();
        }


        public abstract void OverwriteWith(dynamic other);
    }
}
