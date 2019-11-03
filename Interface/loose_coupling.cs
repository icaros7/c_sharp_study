using System;

namespace loose_coupling
{
	interface IPower
	{
		void TurnOn();
	}

	class Monitor : IPower
	{
		public void TurnOn()
		{
			Console.WriteLine("Monitor: Turn On");
		}
	}

	class Computer : IPower
	{
		public void TurnOn();
		{
			Console.WriteLine("Computer: Boot On");
		}
	}

	class Switch
	{
		public void PowerOn(IPower machine) // 특정 타입 -> 인터페이스. 만약 느슨한 결합이 없으면 Computer, Monitor ㄸㅏ로.
		{
			machine.TurnOn();
		}
	}
}
