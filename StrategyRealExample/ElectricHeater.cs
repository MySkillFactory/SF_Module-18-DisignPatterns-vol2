using System;
namespace StrategyRealExample
{
    /// <summary>
    /// Реализация электрического отопления
    /// </summary>
    public class ElectricHeater : IHeater
	{
        public void Heat()
        {
            Console.WriteLine("Нагрев электричеством");
        }
    }
}

