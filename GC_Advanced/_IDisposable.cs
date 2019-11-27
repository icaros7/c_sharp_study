using System;
using System.IO;

namespace _IDisposable
{
	class Program
	{
		static void Main(string[] args)
		{
			FileLogger log = null;
			try
			{
				log = new FileLogger("output.log");
	
				log.write("start");
				log.write("end");
			}
			finally
			{
				log.Dispose();
			}
		}
	}

	class FileLogger : IDisposable
	{
		FileStream _fs;
		string fileName;

		public FileLogger(string fileName)
		{
			if (File.Exists(fileName))
			{
				Console.WriteLine("New File Mode");
				_fs = new FileStream(fileName, FileMode.Create);
			}
			else
			{
				Console.WriteLine("Open exist file");
				_fs = new FileStream(fileName, FileMode.Open);
			}
			this.fileName = fileName;
		}

		public void write(string txt)
		{
			File.AppendAllText(this.fileName, "\r" + txt + Environment.NewLine);
		}

		public void Dispose()
		{
			_fs.Close();
		}
	}
}
