using Class_Library;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Classes
{
    public class ConsoleNotificationSender : INotificationSender
    {
        private static string Separator = "*---*";

        public ConsoleNotificationSender() { }

        public void SendNotification(IMessage message)
        {
            //var minWidth = 20;
            //char fillerChar = ' ';

            //var table = new ConsoleTable(
            //    (
            //        message.Header ?? ""
            //    )
            //);

            //table.AddRow(message.Content);

            //table.Options.EnableCount = false;

            var header = message.Header ?? "";
            var body = message.Content;

            Console.WriteLine();

            Console.WriteLine(
                @$"{Separator}
    --Subject--
{header}

    --Content--
{body}
{Separator}"
            );
        }
    }
}
