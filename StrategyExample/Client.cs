using System;
namespace StrategyExample
{
    /// <summary>
    /// Клиентский код
    /// </summary>
    public class Client
	{
		public IStrategy ClientStrategy { get; set; }

		public Client(IStrategy strategy)
		{
			ClientStrategy = strategy;
		}

        // Выполнение стратегии
        public void ExecuteAlgorithm()
        {
            ClientStrategy.Algorithm();
        }
    }
}

