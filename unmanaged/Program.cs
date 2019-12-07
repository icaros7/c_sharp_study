using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Unman
{
class Program
{
	static void Main(string[] args)
	{
		while (true)
		{
			UnmanagedMemoryManager m = new UnmanagedMemoryManager();
			m = null;

			GC.Collect();
			Console.WriteLine(Process.GetCurrentProcess().PrivateMemorySize64);
		}
	}
}

class UnmanagedMemoryManager
{
	IntPtr pBuffer;
	bool _disposed;

	public UnmanagedMemoryManager()
	{
		pBuffer = Marshal.AllocCoTaskMem(4096 * 1024);
	}

	public void Dispose()
	{
		if (_disposed == false)
		{
			Marshal.FreeCoTaskMem(pBuffer);
			_disposed = true;
		}
	}

	~UnmanagedMemoryManager()
	{
		Dispose();
	}
}
}
