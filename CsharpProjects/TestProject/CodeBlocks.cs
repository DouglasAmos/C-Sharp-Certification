
//using System;

public class CodeBlock
{


    public void CodeBlocksMethod()
    {

        bool flag = true;
        int value = 0;
        if (flag)
        {
            value = 10;
            Console.WriteLine($"Inside of a code block: {value}");
        }
        Console.WriteLine($"Outside of code block: {value}");

    }

    public void CodeBlocksExercise(){
        bool flag = true;
        if (flag)
            Console.WriteLine(flag);
        

    }
}