﻿using System;
namespace PrototypeRealExamlpe
{
    /// <summary>
    /// Обычная точка на карте
    /// </summary>
    public class Point : ILocation
	{
        // Широта и долгота
        double Latitude;
        double Longitude;

        public Point(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public ILocation Clone()
        {
            return new Point(Latitude, Longitude);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Новая точка на карте с координатами {Longitude}, {Latitude}");
        }
    }
}

