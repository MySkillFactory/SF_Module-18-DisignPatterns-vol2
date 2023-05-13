using System;
namespace Command_Task_18_2_5
{
    /// <summary>
    /// Общий интерфейс команд
    /// </summary>
    interface IAction
    {
        void Run();
        void Undo();
    }
}

