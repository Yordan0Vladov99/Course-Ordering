using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationServices
{
    public class OrderServiceEventArgs : EventArgs
    {
        public string title;
        public string type;
        public int qty;

        public OrderServiceEventArgs(string title, string type, int qty)
        {
            this.title = title;
            this.type = type;
            this.qty = qty;
        }
            
    }
}
