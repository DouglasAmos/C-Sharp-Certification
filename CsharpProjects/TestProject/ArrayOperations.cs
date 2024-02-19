

public class ArrayOperations
{
    public void ArrayOperator()
    {

        /*
        string[] pallets = { "B14", "A11", "B12", "A13" };

        Console.WriteLine("Sorted...");
        Array.Sort(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Console.WriteLine("Reversed...");
        Array.Reverse(pallets);
        foreach(var pallet in pallets)
        {
            Console.WriteLine($" -- {pallet}");
        }
        */

        /*
        string[] pallets = { "B14", "A11", "B12", "A13" };
        Console.WriteLine("");

        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets, 6);
        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

        pallets[4] = "C01";
        pallets[5] = "C02";

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"--{pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets, 3);
        Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"--{pallet}");
        }
        */

        /*
        string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Console.WriteLine(valueArray);
        Array.Reverse(valueArray);
        //String result = new string(valueArray);
        string result = String.Join(",", valueArray);
        Console.WriteLine(result);

        string[] items = result.Split(',');
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
        */

        /*
        string pangram = "The quick brown fox jumps over the lazy dog";

        string[] splitSentence = pangram.Split(' ');
        string[] newSentence = new string[splitSentence.Length];

        for (int i = 0; i < splitSentence.Length; i++)
        {
            char[] letters = splitSentence[i].ToCharArray();
            Array.Reverse(letters);
            newSentence[i] = new string(letters);
        }

        string result = String.Join(" ", newSentence);
        Console.WriteLine(result);
        */

        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

        string[] orderArray = orderStream.Split(',');

        for (int i = 0; i < orderArray.Length; i++)
        {
            if (orderArray[i].Length == 4)
            {
              Console.WriteLine(orderArray[i]);  
            }
            else
            {
                Console.WriteLine(orderArray[i] + " - Error");
            }
            
        }












    }




}