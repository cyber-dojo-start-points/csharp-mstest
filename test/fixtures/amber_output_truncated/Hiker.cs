using System;

public class Hiker
{
    public int Answer()
    {
        // The test below fails, and the learner has put a print inside a loop
        // to see what was happening. MSTest keeps what a test printed with
        // that test and prints it back, indented, under "Standard output" for
        // a test that failed, so all of this arrives on stdout ahead of the
        // summary. It is far more than the 50K the runner keeps of a stream,
        // and the summary is what falls off the end, leaving no counts for a
        // colour to be read from.
        for (var i = 0; i < 10000; i++)
        {
            Console.WriteLine("debug: i is " + i);
        }
        return 6 * 9;
    }
}
