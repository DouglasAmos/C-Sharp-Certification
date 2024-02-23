

using System.Linq.Expressions;

public class ModifyContent
{
    public void ModifyContentMethod()
    {

        /*
        string message = "What is the value <span>between the tags</span>?";

        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        int openingPosition = message.IndexOf(openSpan);
        int closingPosition = message.IndexOf(closeSpan);

        openingPosition += 6;

        //Console.WriteLine(openingPosition);
        //Console.WriteLine(closingPosition);

        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
        */

        /*
        string message = "(What if) there are (more than) one (set of parentheses)?";
        while (true)
        {

            int openingPosition = message.IndexOf('(');
            if (openingPosition == -1) break;

            openingPosition += 1;
            int closingPosition = message.IndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            message = message.Substring(closingPosition + 1);
           


        }
        */

        /*
        string message = "Help (find) the {opening symbols}";
        Console.WriteLine($"Searching THIS Message: {message}");
        char[] openSymbols = { '[', '{', '(' };
        int startPosition = 5;
        int openingPosition = message.LastIndexOfAny(openSymbols);
        Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

        openingPosition = message.IndexOfAny(openSymbols, startPosition);
        Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");
        */


        /*
        string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

        // The IndexOfAny() helper method requires a char array of characters. 
        // You want to look for:

        char[] openSymbols = { '[', '{', '(' };

        // You'll use a slightly different technique for iterating through 
        // the characters in the string. This time, use the closing 
        // position of the previous iteration as the starting index for the 
        //next open symbol. So, you need to initialize the closingPosition 
        // variable to zero:

        int closingPosition = 0;

        while (true)
        {
            int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

            if(openingPosition == -1) break;

            string currentSymbol = message.Substring(openingPosition, 1);

            char matchingSymbol = ' ';

            switch (currentSymbol)
            {
                case "[":
                    matchingSymbol = ']';
                    break;
                case "{":
                    matchingSymbol = '}';
                    break;
                case "(":
                    matchingSymbol = ')';
                    break;
            }

            openingPosition += 1;
            closingPosition = message.IndexOf(matchingSymbol, openingPosition);

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));


        }
        */

        /*
        string data = "12345John Smith          5000  3  ";
        string updatedData = data.Remove(5, 20);
        Console.WriteLine(updatedData);
        */

        /*
        string message = "This--is--ex-amp-le--da-ta";
        message = message.Replace("--", " ");
        message = message.Replace("-", "");
        Console.WriteLine(message);
        */

        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "";
        string output = "";

        // Your work here

        Console.WriteLine(quantity);
        Console.WriteLine(output);



    }



}