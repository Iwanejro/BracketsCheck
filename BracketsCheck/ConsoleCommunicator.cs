using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketsCheck
{
    internal class ConsoleCommunicator : ICommunicator
    {
        public string AskForExpression()
        {
            Console.WriteLine(Messages.AskMessage);
            return Console.ReadLine();
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
