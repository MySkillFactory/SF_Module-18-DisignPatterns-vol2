using System;
namespace Command_Task_18_2_5
{
    /// <summary>
    /// Отправитель команд
    /// </summary>
    class Pult
	{
        IAction _action;

        // Инициализация команды
        public void SetAction(IAction action)
		{
            _action = action;
		}

        // Команда открытия
        public void OpenButton()
        {
            _action.Run();
        }

        // Отмена команды
        public void CloseButton()
        {
            _action.Undo();
        }
    }
}

