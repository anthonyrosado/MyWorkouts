

using System;
using System.Linq;
using System.Security.Cryptography;



class Program
{
   /* public static void Switch() {
        for (int a = 30; a >= 0; a--)
        {
            Console.WriteLine("Switch Sides");
            Console.Write("Time: {0}", a);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
    }*/
    public static void Main(string[] args)
    {

        Wod();
    }

    public static void WorkoutList()
    {
        string[] Exercises = { "2-Hand Swing", "Push-Up", "1-Hand Swing(Switching Hands)", "Goblet Squat", "Double Front Squat", "Bodyweight Row", "Kb/dumbell Row", "Pull-Up", "1-Leg Suitcase Deadlift", "1-Leg Stiff Leg Deadlift", "Static Lunge", "Floor Press", "Plank", "Get-Up Sit-Up", "Dead Clean", "Clean And Press", "Press", "Snatch", "High-Pull", "Windmill", "Turkish Get-Up", "Jumping Jacks", "Sumo Deadlift", "Mountain Climber", "Burpee", "Sit-Up", "Leg raise", "Crunches", "Wiper", "V-Sit", "Bridge Thrust", "split jump", "Diamond PushUp", "Reverse grip PullUp", "Close grip PushUp", "Jump Squat" };

        // Create a Random object  
        Random rand = new Random();
        // Generate a random index less than the size of the array.  
        int index = rand.Next(Exercises.Length);
        // Display the result.  
        //Console.WriteLine($"Exercise: {Exercises[index]}");  

        //Console.ReadKey(); 
        for (int a = 10; a >= 0; a--)
        {
            Console.WriteLine($"Next Exercise: {Exercises[index]}");
            Console.Write("Ready: {0}", a);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
        

        for (int a = 30; a >= 0; a--)
        {
            Console.WriteLine("Go!");
            Console.Write("Time: {0}", a);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
        /*if (index == 2) {
            Switch();
        }*/
    }
    public static void RestBetweenExercise()
    {
        for (int a = 15; a >= 0; a--)
        {
            Console.WriteLine($"Rest");
            Console.Write("Time: {0}", a);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
    }
    public static void RestBetweenRounds()
    {
        for (int a = 30; a >= 0; a--)
        {
            Console.WriteLine($"Next Round");
            Console.Write("Ready: {0}", a);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
    }

    public static void CoolDown()
    {
        for (int a = 120; a >= 0; a--)
        {
            
            Console.Write("Cooldown: {0}", a);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.Write("Stretch: Up to you.");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
        }
    }
    public static void Round()
    {
        WorkoutList();
        RestBetweenExercise();
        WorkoutList();
        RestBetweenExercise();
        WorkoutList();
        RestBetweenExercise();
        WorkoutList();
        RestBetweenRounds();
    }
    public static void Wod()
    {
        Console.WriteLine("Round 1");
        System.Threading.Thread.Sleep(3000);
        Console.Clear();
        Round();
        Console.WriteLine("Round 2");
        System.Threading.Thread.Sleep(3000);
        Console.Clear();
        Round();
        Console.WriteLine("Round 3");
        System.Threading.Thread.Sleep(3000);
        Console.Clear();
        Round();
        Console.WriteLine("Round 4");
        System.Threading.Thread.Sleep(3000);
        Console.Clear();
        Round();
        Console.WriteLine("Round 5");
        System.Threading.Thread.Sleep(3000);
        Console.Clear();
        Round();
        Console.WriteLine("Round 6");
        System.Threading.Thread.Sleep(3000);
        Console.Clear();
        Round();
        Console.WriteLine("Round 7");
        System.Threading.Thread.Sleep(3000);
        Console.Clear();
        Round();
        CoolDown();     
    }
}