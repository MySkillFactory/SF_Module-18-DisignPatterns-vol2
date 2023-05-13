using System;
namespace Builder_Task_18_1_1
{
	public class ScooterConveyor : Conveyor
	{
		public ScooterConveyor()
		{
            _product = new Product("Скутер");
		}

        public override void BuildDoors()
        {
            _product["doors"] = "0";
        }

        public override void BuildEngine()
        {
            _product["engine"] = "25 л.с.";
        }

        public override void BuildFrame()
        {
            _product["frame"] = "Рама скутера";
        }

        public override void BuildWheels()
        {
            _product["wheels"] = "2";
        }
    }
}

