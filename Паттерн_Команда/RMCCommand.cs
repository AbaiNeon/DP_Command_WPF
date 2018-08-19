using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерн_Команда
{
    class RMCCommand : ICommand
    {
        SliderReceiver _sliderReceiver;

        public RMCCommand(SliderReceiver sliderReceiver)
        {
            _sliderReceiver = sliderReceiver;
        }

        public Data Execute()
        {
            Data data =_sliderReceiver.RMC();
            return data;
        }
    }
}
