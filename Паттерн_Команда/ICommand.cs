using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерн_Команда
{
    interface ICommand
    {
        Data Execute();
    }
}
