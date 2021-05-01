using System.IO;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public static class Process
    {
        public static void Launch(string fileName)
        {
            if (!string.IsNullOrWhiteSpace(fileName))
            {
                var startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = $"{fileName}",
                    UseShellExecute = true,
                    CreateNoWindow = true
                };
                var process = new System.Diagnostics.Process { StartInfo = startInfo };
                process.Start();
            }
            else
            {
                Console.WriteLine($"Select a valid file");
            }
        }
    }

    public static class Downloader
    {
        public static async Task<string> GetVideo()
        {
            var fileName = string.Empty;

            var httpClient = new HttpClient
            {
                BaseAddress = new Uri($"http://203.124.40.59:9000/")
            };

            var task = httpClient.GetAsync("paredox/videos/2");

            //Show download in progress
            while(!task.IsCompleted)
            {
                Console.WriteLine($"Downloading video form {httpClient.BaseAddress}");
            }

            var response = await task;

            Console.WriteLine("Downloading completed.");

            response.EnsureSuccessStatusCode();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var extension = response.Content.Headers.ContentType.ToString().Split('/')[1];
                fileName = $"D:/Videos/{DateTime.Now:yyyyddMMhhmmssfff}.{extension}";

                var stream = await response.Content.ReadAsStreamAsync();

                var fs = File.Create(fileName);

                await stream.CopyToAsync(fs);
                
                fs.Close();

                Console.WriteLine($"{fileName} Video file downloaded...");
            }

            return fileName;
        }
    }

    public class ExecuteDemo
    {
        public static async Task Main_Download(string[] args)
        {
            var filename = await Downloader.GetVideo();
            
            Process.Launch(filename);
            
            Console.ReadKey();
        }
    }
}
