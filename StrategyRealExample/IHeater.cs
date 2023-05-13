using System;
namespace StrategyRealExample
{
    /// <summary>
    /// Общий интерфейс отопительных котлов
    /// </summary>
    public interface IHeater
	{
        // Нагрев
        void Heat();
	}
}

