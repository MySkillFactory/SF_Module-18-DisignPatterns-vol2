using System;
namespace FinalTask_YouTubeExplode.Commands
{
    /// <summary>
    /// Общий интерфейс команд
    /// </summary>
    public interface IAction
	{
        void GetInfo();

        void Download();
	}
}

