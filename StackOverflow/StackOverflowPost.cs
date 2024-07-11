namespace ClassesExercise.StackOverflow;

public class StackOverflowPost
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; } = DateTime.Now;

    public int Votes { get; private set; }

    public void UpVote()
    {
        Votes++;
    }

    public void DownVote()
    {
        Votes--;
    }
}