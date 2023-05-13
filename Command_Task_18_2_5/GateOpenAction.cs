using System;
namespace Command_Task_18_2_5
{
    /// <summary>
    /// Команда открытия ворот
    /// </summary>
    class GateOpenAction : IAction
    {
        Gate _gate;

        public GateOpenAction(Gate gate)
        {
            _gate = gate;
        }

        public void Run()
        {
            _gate.Open();
        }

        public void Undo()
        {
            _gate.Close();
        }
    }
}

