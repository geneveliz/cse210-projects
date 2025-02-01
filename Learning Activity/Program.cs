using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of the Job class
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        // Creating an instance of the Resume class
        Resume myResume = new Resume("Allison Rose");

        // Adding jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Displaying resume information using the Display method
        myResume.Display();
    }
}

