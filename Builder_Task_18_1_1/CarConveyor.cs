using System;
namespace Builder_Task_18_1_1
{
    /// <summary>
    ///  Конвейер автомобилей
    /// </summary>
    public class CarConveyor : Conveyor
	{
        public CarConveyor()
        {
            _product = new Product("Автомобиль");
        }

        public override void BuildDoors()
        {
            _product["doors"] = "4";
        }

        public override void BuildEngine()
        {
            _product["engine"] = "249 л.с.";
        }

        public override void BuildFrame()
        {
            _product["frame"] = "Рама автомобиля";
        }

        public override void BuildWheels()
        {
            _product["wheels"] = "4";
        }
    }
}

