using System;
namespace DarkSoulsScripting.Injection.Structures
{

    internal class MoveableAddressOffset
    {

        private Int64 offset = 0;
        private DSAsmCaller FuncCallerInstance { get; }

        public Int64 Location
        {
            get { return (Int64)FuncCallerInstance.CodeHandle.GetHandle() + offset; }
            set { offset = (value - (Int64)FuncCallerInstance.CodeHandle.GetHandle()); }
        }

        public MoveableAddressOffset(DSAsmCaller _funcCaller, IntPtr loc)
        {
            FuncCallerInstance = _funcCaller;
            Location = (Int64)loc;
        }
    }

}
