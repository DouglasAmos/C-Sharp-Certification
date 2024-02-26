

public class ParametersChallenge
{

    public void ParamChallengeMethod()
    {
        string internalDomain = "contoso.com";
        string externalDomain = "hayworth.com";
        
        string[,] corporate =
    {
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
    };

        string[,] external =
    {
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
    };

    

    for (int i = 0; i < corporate.GetLength(0); i++)
    {
            // display internal email addresses
            string firstTwo = corporate[i, 0].Substring(0, 2).ToLower();
            string emailName = firstTwo + corporate[i, 1].ToLower();
            Console.WriteLine(emailName + "@" + internalDomain);
    }

    for (int i = 0; i < external.GetLength(0); i++)
    {
            string firstTwo = external[i, 0].Substring(0, 2).ToLower();
            string emailName = firstTwo + external[i, 1].ToLower();
            Console.WriteLine(emailName + "@" + externalDomain);
    }

    




    }




}