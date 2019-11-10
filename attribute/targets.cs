using System;
using System.AttributeUsageAttribute;

namespace target_cs
{
	class Program
	{
		#if pass
		[return: MarshalAs(UnmanagedType.I4)]
		#else
		[MarshalAs(UnmanagedType.I4)]
		#endif
		static int Main(string[] args)
		{
			return 0;
		}
	}
}
