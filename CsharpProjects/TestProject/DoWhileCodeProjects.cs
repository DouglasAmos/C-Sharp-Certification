using System;

public class DoWhileStatementsCodeChallenges
{



    public void CodeProject1()
    {
        string? result;
        string valEntered = "";
        int numValue = 0;
        bool validNumber;

        Console.WriteLine("Please enter an integer between 5 and 10");


        do
        {

            result = Console.ReadLine();
            if (result != null)
            {
                valEntered = result;
            }

            validNumber = int.TryParse(valEntered, out numValue);

            if (validNumber == true)
            {
                if (numValue <= 5 || numValue >= 10)
                {
                    validNumber = false;
                    Console.WriteLine("Please enter a valid number between 5 and 10.");
                }

            }
            else
            {
                Console.WriteLine("Sorry, you didn't enter a valid number.  Please try again.");

            }


        } while (validNumber == false);

        Console.WriteLine($"Awesome! {numValue} is just what I was looking for!");



    }

    public void CodeProject2()
    {
        string? result;
        string role = "";
        bool validEntry = false;

        do
        {
            Console.WriteLine("Please enter your role name (Administrator, Manager, or User)");
            result = Console.ReadLine();
            if (result != null)
            {
                role = result.Trim();
            }

            if (role.ToLower() == "administrator" || role.ToLower() == "manager" || role.ToLower() == "user")
            {
                validEntry = true;
            }

            else
            {
                Console.WriteLine("The role you entered is not valid.  Please try again.");
            }

        } while (validEntry == false);

        Console.WriteLine($"Thank you for correct input of {role}.  Welcome.");



    }

    public void CodeProject3()
    {
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

        string myString = "";
        int periodLocal = 0;

        for (int i = 0; i < myStrings.Length; i++)
        {
            myString = myStrings[i];
            periodLocal = myString.IndexOf(".");

            string mySentence;

            while (periodLocal != -1)
            {
                mySentence = myString.Remove(periodLocal);
                myString = myString.Substring(periodLocal + 1);
                myString = myString.TrimStart();
                periodLocal = myString.IndexOf(".");

                Console.WriteLine(mySentence);
            }

            mySentence = myString.Trim();
            Console.WriteLine(mySentence);
        }

    }
}