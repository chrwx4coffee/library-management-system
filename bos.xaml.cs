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

namespace KKU_Kutuphane
{
    /// <summary>
    /// bos.xaml etkileşim mantığı
    /// </summary>
    public partial class bos : Page
    {
        public bos()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Red);
        }
    }
}
