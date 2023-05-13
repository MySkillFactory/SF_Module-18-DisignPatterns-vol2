using System;
namespace StrategyRealExample
{
	class GasHeater : IHeater
	{
		public void Heat()
		{
            Console.WriteLine("Нагрев газом");
        }
	}
}

