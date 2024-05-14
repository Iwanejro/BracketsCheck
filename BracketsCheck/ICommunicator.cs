using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketsCheck
{
    public interface ICommunicator
    {
        string AskForExpression();
        void WriteMessage(string message);
    }
}
