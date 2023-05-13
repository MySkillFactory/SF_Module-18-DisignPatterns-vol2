using System;
namespace PrototypeExamlpe
{
    /// <summary>
    /// Общий интерфейс для клонирования похожих объектов
    /// </summary>
    public abstract class Prototype
	{
		protected int Id;

		public Prototype(int id)
		{
			Id = id;
		}

        // Метод для клонирования самого себя
        public abstract Prototype Clone();
    }
}

