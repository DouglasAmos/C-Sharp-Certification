using System;

public class DoWhileStatementsEx
{

    public void DWPractice()
    {
        Random random = new Random();
        int current = 0;
        do
        {
            current = random.Next(1, 11);
            Console.WriteLine(current);
        } while (current != 7);


    }

    public void DWPracticeTwo()
    {
        Random random = new Random();
        int current = random.Next(1, 11);

        while (current >= 3)
        {
            Console.WriteLine(current);
            current = random.Next(1, 11);
        }
        Console.WriteLine($"Last number: {current}");
    }

    public void DWPracticeThree()
    {
        Random random = new Random();
        int current = random.Next(1, 11);
        do
        {
            current = random.Next(1, 11);
            if (current >= 8) continue;
            Console.WriteLine(current);

        } while (current != 7);
    }

    public void DWChallengeGame()
    {
        int hero = 10;
        int monster = 10;
        Random random = new Random();

        do{
            monster -= random.Next(1,11);
            Console.WriteLine($"The monster was attacked and is now at {monster} health!");
            if(monster <= 0) continue;

            hero -= random.Next(1,11);
            Console.WriteLine($"The monster struck back and the hero is now at {hero} health");

        } while (hero > 0 && monster > 0);

        Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


        
    }




}