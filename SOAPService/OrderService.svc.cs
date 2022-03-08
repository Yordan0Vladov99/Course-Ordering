using EducationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EducationService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EducationService.svc or EducationService.svc.cs at the Solution Explorer and start debugging.

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class OrderService : IOrderService
    {
        private Dictionary<string, Course> courses;
        List<string> titles;

        public OrderService()
        {
            Random random = new Random();
            courses = new Dictionary<string, Course>();
            titles = new List<string>();

            int numberOfTitles = 6 + random.Next(7);

            for(int i = 1; i <= numberOfTitles; i++)
            {
                titles.Add("Title No." + i);

            }

            int numberOfCourses = 6 + random.Next(15);

            for(int i = 0; i < numberOfCourses; i++)
            {
                int qty = 6 + random.Next(15);
                ServiceType service = ServiceType.CLASS_ROOM;
                int serviceType = random.Next(5);

                if(serviceType == 0)
                {
                    service = ServiceType.ONLINE;
                }
                else if (serviceType == 1)
                {
                    service = ServiceType.ON_DEMAND;

                }
                else if (serviceType == 2)
                {
                    service = ServiceType.INTENSIVE;
                }
                else if (serviceType == 3)
                {
                    service = ServiceType.HIGH_LEVEL;
                }

                int titleInd = random.Next(titles.Count);
                String title = titles[titleInd];
                Course c = new Course(service, title, qty);
                courses.Add(c.ID,c);
            }

        }

        public string[] GetTitles()
        {
            lock (titles)
            {
                string[] titleArray = new string[titles.Count];
                int i = 0;

                foreach(string title in titles)
                {
                    titleArray[i] = title;
                    i++;
                }

                return titleArray;
            }
        }

        public Course[] GetCourses()
        {
            lock (courses)
            {
                Course[] courseArray = new Course[courses.Count];
                int i = 0;

                foreach (KeyValuePair<string, Course> product in courses)
                {
                    courseArray[i] = product.Value;
                    i++;
                }
                return courseArray;
            }
        }

        public void Write2File(string sender, Course course)
        {
            lock (courses)
            {

                
                var systemPath = System.Environment.
                            GetFolderPath(
                                Environment.SpecialFolder.CommonApplicationData
                            );
                var Filepath = Path.Combine(systemPath, "courses.txt");
                int newQty = course.NumOfStudents;
                while (newQty > Course.MAX_NUMBER_IN_COURSE)
                {
                    newQty -= Course.MAX_NUMBER_IN_COURSE;
                    Course newCourse = new Course(course.Service, course.Title,  Course.MAX_NUMBER_IN_COURSE);
                    File.AppendAllText(Filepath, sender + " " + newCourse + "\n");
                }
                course.NumOfStudents = newQty;
                File.AppendAllText(Filepath, sender + " " + course + "\n");
            }
           
        }
    }
}
