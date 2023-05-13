using System;
using FinalTask_YouTubeExplode.Models;

namespace FinalTask_YouTubeExplode.Commands
{
	public class Command : IAction
	{
        VideoTools _video;

        public Command(VideoTools video)
		{
            _video = video;
		}

        public void Download()
        {
            _video.Download();
        }

        public void GetInfo()
        {
            _video.GetInfo();
        }
    }
}

