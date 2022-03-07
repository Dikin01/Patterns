using System;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "\tLo - rem ip\tsum   -  ( dolor  ) “sit-amet”  , “con-sect-\tetur” adipiscing elit  .    Ut - posuere porttitor augue, in dictum mi imperdiet sit amet. " +
                " Proin a  vulputate dolor, eu sollicitudin mi. Integer tellus sapien, mattis    a laoreet ut, congue sed lacus." +
                "\n\n\n\tQuisque efficitur odio erat, et bibendum erat      ultricies eget. Aenean eget suscipit velit. Sed semper blandit consequat." +
                "Proin    vitae magna   in quam pulvinar scelerisque sed a lorem. Etiam quis sollicitudin sem. " +
                "Curabitur tincidunt,    sem vel posuere sagittis, nisi lacus congue     libero, at aliquet  mi  metus eget arcu." +
                "\n\tInteger vehicula risus turpis, sit amet ultricies nulla molestie non. Donec accumsan volutpat  mattis. Donec suscipit mi a sem varius, id   finibus est mollis.Fusce vel venenatis orci." +
                " Nulla ullamcorper mi    dolor, vel congue elit molestie vel.    Sed sed porta nisl.";
                
            StandartTextCorrector corrector = new StandartTextCorrector();
            string formattedText = corrector.Correct(text);
            Console.WriteLine(formattedText);

        }

        private static string TextInput()
        {
            string text = "";
            string newString = "";
            do
            {
                newString = Console.ReadLine() + "\n";
                text += newString;
            }
            while (!newString.Equals("q"));

            Console.WriteLine(text);
            return text;
        }
    }
}
