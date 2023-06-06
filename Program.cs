using System;

class Program
{
    static void Main()
    {
        string? teammateName;
        int? teammateSkill;
        double? teammateCourage;

        Console.WriteLine("Enter your teammate's name:");
        teammateName = Console.ReadLine();

        Console.WriteLine("Enter your teammate's skill level:");
        teammateSkill = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your teammate's courage factor:");
        teammateCourage = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Name: " + teammateName);
        Console.WriteLine("Skill level:" + teammateSkill);
        Console.WriteLine("Courage factor:" + teammateCourage);
    }
}
