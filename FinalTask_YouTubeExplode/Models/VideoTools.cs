using System;
using AngleSharp.Dom;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace FinalTask_YouTubeExplode.Models
{
	public class VideoTools
	{
		private string _url {get; set;}
        private YoutubeClient youtube;

        public VideoTools(string url)
		{
			_url = url;
            youtube = new();
        }

        /// <summary>
        /// Вывод информации о видео
        /// </summary>
		public async Task GetInfo()
		{
            try
            {
                Console.WriteLine("Информация о видео:");

                Video video = await youtube.Videos.GetAsync(_url);

                Console.WriteLine($"Video Id: {video.Id}");
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine("Video info:");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Duration: {video.Duration}");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            Flag.Status = true;
        }

        /// <summary>
        /// Скачивание видео
        /// </summary>
		public async Task Download()
		{
            try
            {
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(_url);

                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);

                string fileName = $"video-{DateTime.Now.ToString("HHmmddMMyyyy")}.{streamInfo.Container}";

                await youtube.Videos.Streams.DownloadAsync(streamInfo, fileName);

                Console.WriteLine($"Фаил {fileName} был скачан в папку:\n" +
                    $"{AppDomain.CurrentDomain.BaseDirectory}{Path.DirectorySeparatorChar}");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            Flag.Status = true;
        }
	}
}

