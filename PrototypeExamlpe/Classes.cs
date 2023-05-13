using System;
namespace PrototypeExamlpe
{
    /// <summary>
    ///  Первая конкретная реализация клонированного объекта
    /// </summary>
    public class ClassOne : Prototype
	{
        public ClassOne(int id) : base(id)
        { }

        public override Prototype Clone()
        {
            return new ClassOne(Id);
        }
    }

    /// <summary>
    ///  Вторая конкретная реализация клонированного объекта
    /// </summary>
    public class ClassTwo : Prototype
    {
        public ClassTwo(int id) : base(id)
        { }

        public override Prototype Clone()
        {
            return new ClassOne(Id);
        }
    }
}

