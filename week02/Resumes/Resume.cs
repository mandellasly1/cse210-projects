using System;


public class Resume
{
    // Member variable for the person's name
    public string _name;

    // Member variable for the list of jobs
    public List<Job> _jobs = new List<Job>();

    // Method to display resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display(); // Calls the Display method from Job class
        }
    }

}

