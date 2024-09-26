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
using lab_2.DataModel;

namespace lab_2
{
    /// <summary>
    /// Логика взаимодействия для UserControlweather.xaml
    /// </summary>
    public partial class UserControlweather : UserControl
    {
        public UserControlweather()
        {
            InitializeComponent();
        }
        public UserControlweather(Weather weather)
        {
            InitializeComponent();
            System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["weatherViewSource"];
            myCollectionViewSource.Source = new List<Weather>() { weather};
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
