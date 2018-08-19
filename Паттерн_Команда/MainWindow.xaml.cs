using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Паттерн_Команда
{
    public partial class MainWindow : Window
    {
        //ICommand[] commands = new ICommand[2];
        ICommand RMCCommand;
        ICommand LMCCommand;

        public MainWindow()
        {
            InitializeComponent();

            //count = 1;

            //кликабельная картинка---------------------------
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri("1.jpg", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            bitmap.Freeze();

            image.Source = bitmap;

        }

        private void ImageMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SliderReceiver sliderReceiver = new SliderReceiver();
            LMCCommand = new LMCCommand(sliderReceiver);
            //SetCommandLMC(LMCCommand);
            Data data = LMCCommand.Execute();

            // для работы с UI
            image.Source = data.bi;
            txtBoxwithCommands.Text += data.str;
        }

        

        private void ImageMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            SliderReceiver sliderReceiver = new SliderReceiver();
            RMCCommand = new RMCCommand(sliderReceiver);
            Data data = RMCCommand.Execute();

            // для работы с UI
            image.Source = data.bi;
            txtBoxwithCommands.Text += data.str;
        }

        //private void SetCommandRMC(ICommand command)
        //{
        //    RMCCommand = command;
        //}
        //private void SetCommandLMC(ICommand command)
        //{
        //    LMCCommand = command;
        //}
    }
}
