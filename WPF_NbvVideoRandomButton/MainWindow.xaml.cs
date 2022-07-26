using System;
using System.Collections.Generic;
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
using System.Diagnostics;

namespace WPF_NbvVideoRandomButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int numberOfWebsites = 11;
            int website = random.Next(0, numberOfWebsites);
            switch (website)
            {
                case 0:
                    Process.Start("cmd", "/c start https://www.youtube.com/watch?v=ha20sG3LBeg&ab_channel=NBV");
                    break;
                case 1:
                    Process.Start("cmd", "/c start https://www.youtube.com/watch?v=peTRHjzxW5w&ab_channel=NBV");
                    break;
                case 2:
                    Process.Start("cmd", "/c start https://www.youtube.com/watch?v=48a2nG9MEsA&ab_channel=NBV");
                    break;
                case 3:
                    Process.Start("cmd", "/c start https://www.youtube.com/watch?v=qztdP28l8To&t=1s&ab_channel=NBV");
                    break;
                case 4:
                    Process.Start("cmd", "/c start https://www.youtube.com/watch?v=cBuPYGU61xY&ab_channel=NBV");
                    break;
                case 5:
                    Process.Start("cmd", "/c start https://www.youtube.com/watch?v=EzMCwMU8A9Y&t=79s&ab_channel=NBV");
                    break;
                case 6:
                    Process.Start("cmd", "/c start https://www.youtube.com/watch?v=6nVbr_H5IY0&ab_channel=NBV");
                    break;
                case 7:
                    Process.Start("cmd", "/c start https://www.youtube.com/watch?v=G88KxaLpsUs&ab_channel=NBV");
                    break;
                case 8:
                    Process.Start("cmd", "/c start https://youtu.be/gYw-074Eu88");
                    break;
                case 9:
                    Process.Start("cmd", "/c start https://youtu.be/ak0I0yjoTkE");
                    break;
                case 10:
                    Process.Start("cmd", "/c start https://youtu.be/bOpiVisVYyI");
                    break;
                default:
                    break;

            }

            
        }
    }
}
