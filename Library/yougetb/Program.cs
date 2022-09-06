// See https://aka.ms/new-console-template for more information
using YoutubeExplode;
class Program
{
    static void Main(string[] args)
    {
        Program.readvideo();
    }
    async Task readvideo()
    {
        var youtube = new YoutubeClient();
        var link = Console.ReadLine();
        var video = await youtube.Videos.GetAsync("https://youtube.com/watch?v=u_yIGGhubZs");
        await Task.Delay(200);
        var title = video.Title;
        var author = video.Author.ChannelTitle;
        var duration = video.Duration;
        Console.WriteLine($"{Environment.NewLine}Video Link : {link}");
        Console.WriteLine($"{Environment.NewLine}Video Title: {title}");
        Console.WriteLine($"{Environment.NewLine}Video Author: {author}");
        Console.WriteLine($"{Environment.NewLine}Video duration: {duration}");
    }
}

