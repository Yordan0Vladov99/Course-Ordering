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

namespace EducationServices
{
    /// <summary>
    /// Interaction logic for OrderCourse.xaml
    /// </summary>
    public partial class OrderCourse : UserControl
    {
        public EventHandler<OrderServiceEventArgs> Order;

        public ComboBox CBOTitles
        {
            get
            {
                return cboTitles;
            }
        }
        public OrderCourse()
        {
            InitializeComponent();
            Dispatcher.Invoke(new Action( () => {
                var values = Enum.GetValues(typeof(ServiceType));
                List<string> valueArray = new List<string>();
                foreach (var value in values)
                {
                     valueArray.Add(value.ToString());
                }
                cboTypes.ItemsSource = valueArray.ToArray();
            }));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CancelOrder(object sender, RoutedEventArgs e)
        {
            txtQty.Text = "0";
        }

        private void PlaceOrder(object sender, RoutedEventArgs e)
        {
            Order?.Invoke(this, new OrderServiceEventArgs(cboTitles.Text, cboTypes.Text, int.Parse(txtQty.Text)));
        }
    }
}
