using System.Security.Authentication;

namespace Object_Thompson_Lillian
{
    public class Program
    {
        static void Main(string[] args)
        {   
            
            Computer myComputer = new Computer("Apple", "All-in-One", true);
            IBootUp myBootUp = myComputer;
            Console.WriteLine(myComputer.Equals(myBootUp));

            Computer myOtherComputer = new Computer("Apple", "All-in-One", true);
            Console.WriteLine(myComputer.Equals(myOtherComputer ));

            string myString = myComputer.ToString();
            string myOtherString = myString;

            // will print out this onto the coding
            myString = "HOLA!!!!!!"

            Console.WriteLine(myString)
            Console.WriteLine(myOtherString)

            string myString = myComputer.ToString();
            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myComputer.ToString());
            
            Console.WriteLine(myComputer.GetType());
            Console.WriteLine(myBootUp.GetType());

            myOtherComputer.PowerOnOff();

            Console.WriteLine(myString == myOtherComputer.ToString());
            Console.WriteLine(myString);
            Console.WriteLine(myOtherComputer.ToString());

            Console.WriteLine(myString.Contains('i'));

            Console.WriteLine(myString.ToUpper());


        }
    }
}