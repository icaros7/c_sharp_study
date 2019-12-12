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

	public void Dispose(bool disposing)
	{
		if (_disposed == false)
		{
			Marshal.FreeCoTaskMem(pBuffer);
			_disposed = true;
		}

		if (disposing == false)
		{
			// disposing이 false인 경우 명시적으로 Dispose()를 호출한 경우다. ㄸㅏ라서 종료 큐에서 자신을 제거하여 GC의 부담 감소.
			GC.SuppressFinalize(this);
		}
	}

	public void Dispose()
	{
		Dispose(false);
	}

	~UnmanagedMemoryManager()
	{
		Dispose(true);
	}
}
}
