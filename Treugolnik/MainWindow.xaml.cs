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
using System.Windows.Media.Animation;

namespace TriangleApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();  
            View.FontFamily = new System.Windows.Media.FontFamily("Bahnschrift SemiBold SemiConden");
            Text1.FontFamily = new System.Windows.Media.FontFamily("Bahnschrift SemiBold SemiConden");
            Text2.FontFamily = new System.Windows.Media.FontFamily("Bahnschrift SemiBold SemiConden");
            Text3.FontFamily = new System.Windows.Media.FontFamily("Bahnschrift SemiBold SemiConden");
            Text4.FontFamily = new System.Windows.Media.FontFamily("Bahnschrift SemiBold SemiConden");
            Text5.FontFamily = new System.Windows.Media.FontFamily("Bahnschrift SemiBold SemiConden");
            Pervoe.FontFamily = new System.Windows.Media.FontFamily("Bahnschrift SemiBold SemiConden");
            Vtoroe.FontFamily = new System.Windows.Media.FontFamily("Bahnschrift SemiBold SemiConden");
            Tretie.FontFamily = new System.Windows.Media.FontFamily("Bahnschrift SemiBold SemiConden");
            ButtonClick.FontFamily = new System.Windows.Media.FontFamily("Bahnschrift SemiBold SemiConden");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Pervoe.Text))
            {
                MessageBox.Show("Не все данные были введены ");
                return;
            }
            else if (string.IsNullOrEmpty(Vtoroe.Text))
            {
                MessageBox.Show("Не все данные были введены ");
                return;
            }
            else if (string.IsNullOrEmpty(Tretie.Text))
            {
                MessageBox.Show("Не все данные были введены ");
                return;
            }
            try
            {
                double pervoe = Convert.ToDouble(Pervoe.Text);
                double vtoroe = Convert.ToDouble(Vtoroe.Text);
                double tretie = Convert.ToDouble(Tretie.Text);
                int i = 0;
                if ((pervoe == vtoroe && pervoe == tretie) && (vtoroe + pervoe >= tretie && vtoroe + tretie >= pervoe && pervoe + tretie >= vtoroe))
                {
                    View.Text = "Равносторонний";
                    i = 1;
                }
                else if ((pervoe == vtoroe || pervoe == tretie || vtoroe == tretie) && (vtoroe + pervoe >= tretie && vtoroe + tretie >= pervoe && pervoe + tretie >= vtoroe))
                {
                    View.Text = "Равнобедренный";
                    i = 2;
                }
                else if ((pervoe != vtoroe || pervoe != tretie || vtoroe != tretie) && (vtoroe + pervoe >= tretie && vtoroe + tretie >= pervoe && pervoe + tretie >= vtoroe))
                {
                    View.Text = "Разносторонний";
                    i = 3;
                }
                else
                {

                    if (vtoroe + pervoe <= tretie)
                    {
                        MessageBox.Show($"Треугольник не может существовать, так как {pervoe} + {vtoroe} =< {tretie}");
                        return;
                    }
                    else if (vtoroe + tretie <= pervoe)
                    {
                        MessageBox.Show($"Треугольник не может существовать, так как {vtoroe} + {tretie} =< {pervoe}");
                        return;
                    }
                    else if (pervoe + tretie <= vtoroe)
                    {
                        MessageBox.Show($"Треугольник не может существовать, так как {pervoe} + {tretie} =< {vtoroe}");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введен неверный тип данных");
                return;
            }          
        }
    }
}
