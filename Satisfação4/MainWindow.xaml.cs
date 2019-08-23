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

namespace Satisfação4
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcularClick(object sender, RoutedEventArgs e)
        {

            EquacaoIIGrau eq = new EquacaoIIGrau();
            eq.SetABC(double.Parse(A.Text), double.Parse(B.Text),
                double.Parse(C.Text));
            D.Text = eq.Delta().ToString();
            double r, s;
            if (eq.X1(out r))
            {
                eq.X2(out s);
                X.Text = r.ToString();
                Y.Text = s.ToString();
            }
            else
            {
                X.Text = "Raiz Complexa";
               Y.Text = "Raiz Complexa";
                MessageBox.Show("A equação não é do II grau ou não tem raízes reais");
            }

        }
    }
}
