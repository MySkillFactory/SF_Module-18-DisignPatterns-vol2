using System;
namespace BuilderExample
{
    /// <summary>
    /// Реализация продукта - сложного объекта
    /// </summary>
    public class Product
    {
        // Список частей, из которых состоит объект
        List<object> parts = new List<object>();

        // Метод для поэтапного процесса создания
        public void Add(string part)
        {
            parts.Add(part);
        }
    }
}

