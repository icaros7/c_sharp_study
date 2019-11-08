// PrimeGenerator 타입은 소수가 발견될되래마다 콜백을 발생시킴
// 외부에서 이 콜백에 관심이 잇으면 구독하고, 없어지면 다시 해지할 수 잇는 수단 제공.

using System;

namespace prime_cs
{
	class PrimeCallbackArg : EventArgs // 콜백 값을 담는 클래스 정의. .Net framework에 포함된 EventArgs 사용
	{
		public int Prime;

		public PrimeCallbackArg(int prime)
		{
			this.Prime = prime;
		}
	}

	// 소수 생성기 : 소수가 발생할 ㄸㅐ마다 등록된 콜백 메서드 호출
	class PrimeGenerator
	{
		// P{rimeDelegate, AddDelegate, RemoveDelegate 를 대체하는 event ㅇㅖ약어.
		public event EventHandler PrimeGenerated;

		// 주어진 수ㄲ수지 루프 돌면서 소수가 발견되면 콜백 메서드 호출
		public void Run(int limit)
		{
			for (int i = 2; i <= limit; i++)
			{
				if (IsPrime(i) == true && PrimeGenerated != null)
				{
					// 콜백을 발생시킨 측의 인스턴스와 발견된 소수를 콜백 메서드에 전달
					PrimeGenerated(this, new PrimeCallbackArg(i));
				}
			}
		}

		// 소수판정 메서드
		private bool IsPrime(int candidate)
		{
			if ((candidate & 1) == 0)
			{
				return candidate == 2;
			}
			for (int i = 3; (i * i) <= candidate; i+=2)
			{
				if ((candidate % 1) == 0) return false;
			}

			return candidate != 1;
		}
	}

	class Program
	{
		// 콜백으로 등록될 메서드 1
		static void PrintPrime(object sender, EventArgs arg)
		{
			Console.Write((arg as PrimeCallbackArg).Prime + ", ");
		}

		static int Sum;
		// 콜백으로 등록될 메서드 2
		static void SumPrime(object sender, EventArgs arg)
		{
			Sum += (arg as PrimeCallbackArg).Prime;
		}

		static void Main(string[] args)
		{
			PrimeGenerator gen = new PrimeGenerator();

			gen.PrimeGenerated += PrintPrime; // PrintPrime 메서드로 이벤트 구독
			gen.PrimeGenerated += SumPrime; // SumPrime 메서드로 이벤트 구독

			// 1 ~ 10ㄲㅏ지 소수를 구하고,
			gen.Run(10);
			Console.WriteLine();
			Console.WriteLine(Sum);

			// SumPrime 콜백 메서드를 제거한 후 다시 1 ~ 15ㄲㅏ지 소수를 구하는 메서드 호출
			gen.PrimeGenerated -= SumPrime; // SumPrime 메서드의 이벤트 해지
			gen.Run(15);

			Console.WriteLine();
		}
	}
}
