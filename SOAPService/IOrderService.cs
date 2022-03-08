using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using EducationServices;

namespace SOAPService
{
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        Course[] GetCourses();

        [OperationContract]
        string[] GetTitles();

        [OperationContract]
        void Write2File(string sender, Course course);
       

    }
}
