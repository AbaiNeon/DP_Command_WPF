using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Паттерн_Команда
{
    public class SliderReceiver
    {
        //счетчик
        public int count = 1;
        Stopwatch clock = new Stopwatch();

        public Data RMC()
        {
            BitmapImage bitmap = null;

            if (count % 3 == 1)
            {
                bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri("2.jpg", UriKind.RelativeOrAbsolute);
                bitmap.EndInit();
                bitmap.Freeze();
            }
            else if (count % 3 == 2)
            {
                bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri("3.jpg", UriKind.RelativeOrAbsolute);
                bitmap.EndInit();
                bitmap.Freeze();
            }
            else if (count % 3 == 0)
            {
                bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri("1.jpg", UriKind.RelativeOrAbsolute);
                bitmap.EndInit();
                bitmap.Freeze();
            }
            count++;

            //
            string strCom;
            if (clock.IsRunning)
            {
                clock.Stop();
                strCom = "Sleep(" + clock.Elapsed.Seconds + ");\n";
            }

            strCom = "RMC();\n";

            //засекаем время
            clock = Stopwatch.StartNew();

            Data data = new Data() { bi = bitmap, str = strCom};

            return data;
            
        }

        public Data LMC()
        {
            BitmapImage bitmap = null;

            if (count % 3 == 1)
            {
                bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri("3.jpg", UriKind.RelativeOrAbsolute);
                bitmap.EndInit();
                bitmap.Freeze();
            }
            else if (count % 3 == 2)
            {
                bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri("2.jpg", UriKind.RelativeOrAbsolute);
                bitmap.EndInit();
                bitmap.Freeze();
            }
            else if (count % 3 == 0)
            {
                bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri("1.jpg", UriKind.RelativeOrAbsolute);
                bitmap.EndInit();
                bitmap.Freeze();
            }

            count++;

            //
            string strCom;
            if (clock.IsRunning)
            {
                clock.Stop();
                strCom = "Sleep(" + clock.Elapsed.Seconds + ");\n";
            }

            strCom = "LMC();\n";

            //засекаем время
            clock = Stopwatch.StartNew();

            Data data = new Data() { bi = bitmap, str = strCom };

            return data;
        }
    }
}
