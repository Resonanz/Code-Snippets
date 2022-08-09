using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPFAsyncAwait
{    public partial class MainWindow : Window
    {
        bool flasherFlag = false;

        //public static MainWindow AppWindow; // Make MainWindow accessible from outside class
        public MainWindow()
        {
            InitializeComponent();
            MyTextbox.Clear();
        }

        private async void Button_Click_ToggleLED_Async(object sender, RoutedEventArgs e)
        {
            MyTextbox.AppendText("Awaited blink..." + "\n");

            LED1.Fill = new SolidColorBrush(Colors.Green);

            await Task.Run(() =>
            {
                Task.Delay(1000).Wait();
            });

            LED1.Fill = new SolidColorBrush(Colors.Red);
        }

        private async void Button_Click_FlashLED_Async(object sender, RoutedEventArgs e)
        {
            flasherFlag = !flasherFlag;

            MyTextbox.AppendText("Awaited flasher..." + "\n");

            while (flasherFlag == true)
            {
                LED2.Fill = new SolidColorBrush(Colors.Green);

                await Task.Delay(100);

                LED2.Fill = new SolidColorBrush(Colors.Red);

                await Task.Delay(100);
            }
        }

        private void Button_Click_ToggleLED(object sender, RoutedEventArgs e)
        {
            MyTextbox.AppendText("Non-await... my LED does not toggle properly :-(" + "\n");

            LED3.Fill = new SolidColorBrush(Colors.Green);

            Task.Delay(2000).Wait();

            LED3.Fill = new SolidColorBrush(Colors.Red);
        }
    }
}
