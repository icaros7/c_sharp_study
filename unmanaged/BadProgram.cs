using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace unmanaged
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

	public UnmanagedMemoryManager()
	{
		pBuffer = Marshal.AllocCoTaskMem(4096 * 2048);
	}
    }
}
