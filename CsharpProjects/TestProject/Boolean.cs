using System;
public class BooleanEx
{

    public void booleanMethod()
    {


        /*
                Console.WriteLine("a" == "a");
                Console.WriteLine("a" == "A");
                Console.WriteLine(1 == 2);

                string myValue = "a";
                Console.WriteLine(myValue == "a");
                */

        /* string value1 = " a";
         string value2 = "A ";
         Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
         */

        /*
                Console.WriteLine("a" != "a");
                Console.WriteLine("a" != "A");
                Console.WriteLine(1 != 2);

                string myValue = "a";
                Console.WriteLine(myValue != "a");
                */

        /*
                Console.WriteLine(1 > 2);
                Console.WriteLine(1 < 2);
                Console.WriteLine(1 >= 1);
                Console.WriteLine(1 <= 1);
                */


        /*
                string pangram = "The quick brown fox jumps over the lazy dog";
                Console.WriteLine(pangram.Contains("fox"));
                Console.WriteLine(pangram.Contains("cow"));
                */


        /*
                string pangram = "The quick brown fox jumps over the lazy dog.";
                Console.WriteLine(!pangram.Contains("fox"));
                Console.WriteLine(!pangram.Contains("cow"));
                */

        /*
                int a = 7;
                int b = 6;
                Console.WriteLine(a != b);
                string s1 = "Hello";
                string s2 = "Hello";
                Console.WriteLine(s1 != s2);
                */

        int saleAmount = 1001;
        //int discount = saleAmount > 1000 ? 100 : 50;
        Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");




    }
}

