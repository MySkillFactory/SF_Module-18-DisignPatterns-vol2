using System;
namespace PrototypeRealExamlpe
{
    /// <summary>
    /// Общий интерфейс для объектов на карте
    /// </summary>
    public interface ILocation
	{
        // Метод для клонирования
        ILocation Clone();

        // Метод для получения информации об объекте
        void GetInfo();
    }
}

