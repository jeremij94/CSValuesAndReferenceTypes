/ Step1: Declare and initialize variables for the following types:


namespace CSValuesAndReferenceTypes
{
    class Program
    {

        static void Main(string[] args)

        {
            string myStringEx = "This is a string.";

            int benFrank = 100;

            char middleInitial = 'A';

            // This is a bool example.

            bool isFireWet = false;
            bool isFireDry = false;
            Console.WriteLine(isFireDry);
            //End of Bool

            double doubleExample = 64373.14948;

            decimal SeptemberRent = 1034.53m;


            //Step 2: Interpolate these values in Console.Writeline();

            string myNiece = "Cadence";
            int? nieceAge = 2;

            Console.WriteLine($"My niece,{myNiece}, is one of my best friends. She is only {nieceAge}, but she has so much love, energy, and personality. Anytime I am overwhelmed or feeling down, she can run up and hug me, melting it all away. Whatever she needs, I got her!");





        }


    }

}
