using System;

public class Hiker
{
    public int Answer()
    {
        // Console is there to be called: cyber-dojo.sh puts every System.*.dll
        // of the shared framework on the compiler command line, and
        // System.Console.dll is one of them. Neither of these arrives on the
        // stream it was written to, though. MSTest takes both streams over
        // while a test runs and keeps what the test printed with that test,
        // and it prints that back, indented under "Standard output" and
        // "Error output", only for a test that failed. This test passes, so
        // both lines are dropped and the run shows the summary alone.
        Console.WriteLine("debug on stdout: answer was called");
        Console.Error.WriteLine("debug on stderr: answer was called");
        return 6 * 7;
    }
}
