using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int action = 1;

            while (action == 1)
            {
                action = 0;

                Console.WriteLine("Skriv in ditt meddelande:");
                var text = Console.ReadLine();
                var message = new Message {MessageText = text, Datestamp = DateTime.Now};

                using (var context = new MessageDbContext())
                {
                    context.Messages.Add(message);

                    //Spara till db
                    context.SaveChanges();
                }
                Console.WriteLine("Meddelandet sparades ner.");

                Console.WriteLine("Vill du fortsätta? J/N");
                string answer = Console.ReadLine();

                if (answer == "J" || answer == "j")
                {
                    action = 1;
                }
                if (answer == "N" || answer == "n")
                {
                    //Avsluta applikationen
                    Environment.Exit(0);
                }
            }
        }


    }
}
