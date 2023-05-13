using System;
namespace PrototypeTask
{
    public abstract class BaseClass
    {
        protected private int Id;

        public BaseClass(int id)
        {
            Id = id;
        }

        public abstract BaseClass Clone();

        public void GetId()
        {
            Console.WriteLine($"Id: {Id}");
        }
    }
}

