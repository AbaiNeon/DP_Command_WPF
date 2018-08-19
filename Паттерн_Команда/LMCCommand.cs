using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерн_Команда
{
    public class LMCCommand : ICommand
    {
        SliderReceiver _sliderReceiver;

        public LMCCommand(SliderReceiver sliderReceiver)
        {
            _sliderReceiver = sliderReceiver;
        }

        public Data Execute()
        {
            Data data = _sliderReceiver.LMC();
            return data;
        }
    }
}
