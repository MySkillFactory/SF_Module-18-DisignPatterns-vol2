using System;
namespace PrototypeRealExamlpe
{
    /// <summary>
    /// Известное место на карте
    /// </summary>
    public class Place : ILocation
	{
        string Address;

        public Place(string adress)
		{
            Address = adress;
		}

        public ILocation Clone()
        {
            return new Place(Address);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Новый объект по адресу {Address}.");
        }
    }
}

