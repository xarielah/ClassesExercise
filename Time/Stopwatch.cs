namespace ClassesExercise.Time;
public class Stopwatch
{
    private DateTime _startTime = DateTime.Now;
    private bool _started = false;

    public void Start()
    {
        if (_started == true)
            throw new InvalidOperationException("Cannot start Stopwatch twice, must be stopped first.");
        this._startTime = DateTime.Now;
        ToggleStart();
    }

    private void ToggleStart()
    {
        _started = !_started;
    }

    public void Stop()
    {
        if (!_started)
            throw new InvalidOperationException("Cannot be stopped a Stopwatch that wasn't started yet");
        Console.WriteLine(DateTime.Now.Subtract(_startTime).TotalSeconds + "s");
        ToggleStart();
    }
}
