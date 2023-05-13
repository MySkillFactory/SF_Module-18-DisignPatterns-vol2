using System;
using FinalTask_YouTubeExplode.Commands;

namespace FinalTask_YouTubeExplode.Models
{
    class CommandSender
    {
        IAction _action;

        // Инициализация команды
        public void SetAction(IAction action)
        {
            _action = action;
        }

        // Получить информацию о видео
        public async Task GetInfoVideo()
        {
            _action.GetInfo();
        }

        // Скачать видео
        public async Task DownLoadVideo()
        {
            _action.Download();
        }
    }
}

