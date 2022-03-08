using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationServices
{
    public class Course
    {
        private static int instances = 0;
        private string id; 
        private ServiceType serviceType;
        private string title;
        private int numOfStudents;


        public Course(ServiceType service, string title, int numOfStudents)
        {

            id = string.Format("{0:D4}-2022",instances);
            instances++;
            
            Service = service;
            Title = title;
            NumOfStudents = numOfStudents;
        }

       public Course() : this(ServiceType.CLASS_ROOM, "default", 0)
        {

        }

        public Course(Course course) : this(course.Service, course.Title, course.NumOfStudents)
        {

        }

        public string ID
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }

        public static int MAX_NUMBER_IN_COURSE
        {
            get
            {
                return 10;
            }

            private set
            {

            }
        }

        public ServiceType Service
        {
            get
            {
                return serviceType;
            }
            set
            {
                serviceType = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public int NumOfStudents
        {
            get
            {
               return numOfStudents;
            }
            set
            {
                numOfStudents = value;
            }
        }

        public override string ToString()
        {
            return ID + " " + Service.ToString() + " " + Title + " " + NumOfStudents;
        }
    }
}
