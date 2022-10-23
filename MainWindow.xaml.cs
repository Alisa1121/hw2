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

namespace _13
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
            int n;
            int x, y, z, flag = 1;
            int res = 0;
            List<int> prime_number = new List<int>();
            string number = textbox1.Text;
            bool transform = int.TryParse(textbox1.Text, out n);
            if (textbox1.Text.Length == 0 || !transform)
            {
                MessageBox.Show("重新輸入!");
            }
            else
            {
                for (x = 2; x < n; x++)
                {
                    for (y = 2; y < x; y++)
                    {
                        if (x % y == 0)
                        {
                            flag = 0;
                            break;
                        }
                    }
                    if (flag != 0 && y == x)
                    {
                        prime_number.Add(x);
                    }
                    flag = 1;
                }
                textbox2.AppendText(n + "的質數為: ");
                for (x = 0; x < prime_number.Count; x++)
                {
                    if (x == prime_number.Count - 1)
                    {
                        textbox2.AppendText(prime_number[x].ToString());
                    }
                    else
                    {
                        textbox2.AppendText(prime_number[x].ToString() + ", ");
                    }
                }
                for (x = 0; x < prime_number.Count; x++)
                {
                    z = 1;
                    textbox3.AppendText(prime_number[x].ToString() + "的倍數: ");
                    do
                    {
                        res = prime_number[x] * z;
                        z++;
                        textbox3.AppendText(res.ToString() + " ");
                    } while (prime_number[x] * z <= n);
                    textbox3.AppendText("\r\n");
                }
            }
        }
    }
}
