using System;
namespace PrototypeTask
{
    /// <summary>
    /// Первая реализация прототипа
    /// </summary>
    public class ImplementationOne : BaseClass
	{
		public ImplementationOne(int id) : base(id)
        { }

        public override BaseClass Clone()
        {
            return new ImplementationOne(Id);
        }
    }

    /// <summary>
    /// Вторая реализация прототипа
    /// </summary>
    public class ImplementationTwo : BaseClass
    {
        public ImplementationTwo(int id) : base(id)
        { }

        public override BaseClass Clone()
        {
            return new ImplementationOne(Id);
        }
    }
}

