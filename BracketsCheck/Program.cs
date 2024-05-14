using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketsCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICommunicator communicator = new ConsoleCommunicator();

            communicator.WriteMessage("Aby wyjść z programu wprowadź puste wyrażenie.\n\n");

            do
            {
                var expression = communicator.AskForExpression();
                if (string.IsNullOrWhiteSpace(expression))
                {
                    return;
                }

                var bracketsChecker = new BracketsChecker(); // nowa instancja na każdą pętlę, żeby wyczyścić stack
                var result = bracketsChecker.CheckExpression(expression);
                communicator.WriteMessage(result);

                communicator.WriteMessage("\n");
            } while (true);
        }
    }
}
