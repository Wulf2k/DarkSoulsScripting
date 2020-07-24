#pragma once

using namespace System;
using namespace System::Reflection;
using namespace DarkSoulsScripting;


namespace DarkSoulsWrapper {

	public ref class HookWrap
	{

	public:static int RInt32(__int64 value)
		{
			int val;
			val = DarkSoulsScripting::Hook::RInt32((Memloc)value);
			return val;
		}
	};
}

__declspec(dllexport) int RInt32(__int64 value)
{
	DarkSoulsWrapper::HookWrap hook;
	return hook.RInt32(value);
}