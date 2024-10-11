using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!"); 


        
        //create job 1 instance
        
        Job job1  = new Job("Software Engineer", "Microsoft", 2019, 2022);

        //create job 2 instance

        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        // Display job details 
        
        //job1.DisplayDetails();
        //job2.DisplayDetails();

        // Create resume & add jobs
        
        Resume myResume = new Resume("John Doe");
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display 
        
        myResume.Display();
    }

        

        
}

    



