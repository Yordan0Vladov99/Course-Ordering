using EducationServices;
using SOAPService;
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
using System.Windows.Shapes;

namespace ClientsApp
{
    /// <summary>
    /// Interaction logic for ClientsApp.xaml
    /// </summary>
    public partial class ClientApp : Window
    {
        IOrderService client;
        public ClientApp()
        { 
            InitializeComponent();
            Random random = new Random();
            Title = String.Format($"Order Course {1 + random.Next(1000)}");

            Dispatcher.Invoke(new Action(() =>
            {
                client = new OrderService();
                //Course[] courses = client.GetCourses();
                string[] titles = client.GetTitles();
                CtrOrderCourse.CBOTitles.ItemsSource = titles;
                CtrOrderCourse.Order += OrderCourse_OrderHandler;
            }));
        }
        private void OrderCourse_OrderHandler(object sender, OrderServiceEventArgs e)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                ServiceType service = ServiceType.CLASS_ROOM;

                if (e.type.Equals("CLASSROOM"))
                {
                    service = ServiceType.CLASS_ROOM;
                }
                else if (e.type.Equals("ONLINE"))
                {
                    service = ServiceType.ONLINE;

                }
                else if (e.type.Equals("ON_DEMAND"))
                {
                    service = ServiceType.ON_DEMAND;

                }
                else if (e.type.Equals("INTENSIVE"))
                {
                    service = ServiceType.INTENSIVE;
                }
                else if (e.type.Equals("HIGH_LEVEL"))
                {
                    service = ServiceType.HIGH_LEVEL;
                }
                client.Write2File(Title, new Course(service,e.title,e.qty));
            }));
        }
    }


}
