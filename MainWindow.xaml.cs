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

namespace Wpf6VARIANTZARUBIN
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Action<object, r, EventArgs> button2_Click;

        public MainWindow()
        {
            InitializeComponent();
            List<Button> Button = new List<Button>();

            
            buttons.AddRange(new Button[5] { Button, Button, buttons, buttons, buttons });

            
            button1_Click += button1_Click;
            button2_Click += button1_Click;
            button3_Click += button1_Click;
            button4_Click += button1_Click;
            button5_Click += button1_Click;
        }


        void button1_Click(object sende.00r, EventArgs e)
        {
            
            Random rnd = new Random(DateTime.Now.Millisecond);

            
            Button btn = buttons[rnd.Next(buttons.Count)];

            
            btn.Visible = !btn.Visible;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }

    internal class buttons
    {
        internal static void AddRange(Button[] button)
        {
            throw new NotImplementedException();
        }
    }
}
