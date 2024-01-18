public class ForLoop
{
    public static void ForLoopPracticeNums()
    {

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            if (i == 7) break;
        }


    }

    //We do this to run the array backwards
    public static void ForLoopPracticeWords()
    {
        string[] names = { "Alex", "Eddie", "David", "Michael" };
        for (int i = names.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(names[i]);
        }
    }

    public static void ForLoopPracticeChange()
    {
        string[] names = { "Alex", "Eddie", "David", "Michael" };
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == "David") names[i] = "Sammy";
        }
        foreach (var name in names) Console.WriteLine(name);
    }
}