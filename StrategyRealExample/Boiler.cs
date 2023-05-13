using System;
namespace StrategyRealExample
{
	public class Boiler
	{
        //  Мощность
        protected int Power;

        // Модель
        protected string Model;
        public Boiler(int power, string model, IHeater heater)
        {
            Power = power;
            Model = model;
            Heater = heater;
        }

        // Интерфейс подключения отопителя
        public IHeater Heater { private get; set; }

        // Запуск отопителя
        public void Start()
        {
            Heater.Heat();
        }
    }
}

