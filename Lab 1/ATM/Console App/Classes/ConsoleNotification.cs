using Class_Library;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Classes
{
    public class ConsoleNotification : INotification
    {
        public void SendNotification(IMessage message)
        {
            char paddingChar = ' ';
            int paddedWidth = 20;

            var table = new ConsoleTable(
                (message.Header ?? "")
                    .PadLeft(paddedWidth / 2, paddingChar)
                    .PadRight(paddedWidth / 2, paddingChar)
            );

            table.AddRow(message.Content);
        }
    }
}
