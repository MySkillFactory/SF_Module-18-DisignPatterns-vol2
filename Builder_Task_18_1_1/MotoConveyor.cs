using System;
namespace Builder_Task_18_1_1
{
    /// <summary>
    ///  Конвейер мотоциклов
    /// </summary>
    public class MotoConveyor : Conveyor
	{
        public MotoConveyor()
        {
            _product = new Product("Мотоцикл");
        }

        public override void BuildDoors()
        {
            _product["doors"] = "0";
        }

        public override void BuildEngine()
        {
            _product["engine"] = "70 л.с.";
        }

        public override void BuildFrame()
        {
            _product["frame"] = "Рама мотоцикла";
        }

        public override void BuildWheels()
        {
            _product["wheels"] = "2";
        }
    }
}

