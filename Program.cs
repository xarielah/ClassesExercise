using ClassesExercise.StackOverflow;
using ClassesExercise.Time;
namespace ClassesExercise;

/// <summary>
/// Dump bootstrap class to run all different classes.
/// </summary>
public class Program()
{
    public static async Task Main()
    {
        Console.WriteLine("========== StopWatch ==========");

        var sw = new Stopwatch();
        sw.Start();
        await Task.Delay(5000);
        sw.Stop();

        Console.WriteLine("================================");
        Console.WriteLine();

        Console.WriteLine("========== StackOverflow Post ==========");

        var soPost = new StackOverflowPost()
        {
            Title = "Learning C#!",
            Description = "I'm learning how to use classes and constructors in C#.",
        };

        soPost.UpVote();
        soPost.UpVote();
        soPost.UpVote();
        soPost.DownVote();

        Console.WriteLine("1. Votes: " + soPost.Votes); // 2

        soPost.DownVote();
        soPost.DownVote();
        soPost.DownVote();
        Console.WriteLine("2. Votes: " + soPost.Votes); // -1

        Console.WriteLine("================================");
    }
}
