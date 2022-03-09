# Course-Ordering
A System that provides that enables the user to order and save courses from a WCF Service. Clients order courses with WPF User Interfaces, where the user can select the course type, title and number of participants.
When the number of participants exceeds a given threshold, the service automatically generates additional courses to account for all the students.
Client orders are stored on a .txt file on web server of the course organizer.

The system is consisted of several projects:

  1) EducationServices - a C#.NET Library with following content:
  
   EducationServices - an enum type, which defines the course types: ONLINE, CLASS_ROOM, INTENSIVE, ON_DEMAND, HIGH_LEVEL
  
   Course - a C#.NET class that represents a given course. Each course has its own unique ID, represented as a string which starts with the course number, followed by "-" and the current year. The class also contains a public static constant MAX_NUMBER_IN_COURSE, which defines the maximum number of students that can participate in a course, by default 10. 
   
Each course contains the following attributes:

   - type, represented by the ServiceType variable serviceType
   
   - title, represented by the string title
   
   - number of students, represented by the int numOfStudents
  
The Course class contains set and get Properties for the private attributes, constructors (default, parameterized and copy) and redefined ToString() methhod.

   OrderCourse - A WPF UserControl, which represents the user interface and contains the following elements:
   
   - A 'Course Title' label and the ComboBox cboTitles, which lets the user choose the course title by selecting given titles from a dropdown menu. The contents of the combo box are initialized by calling an order service.
     
   - A 'Course Type' label and the ComboBox cboTypes, which lets the user choose the course type by selecting given titles from a dropdown menu. The contents of the combo box are initialized to the values of ServiceType

  - A 'Number of students' label and the TextFiled txtQty, where the user can specify the number of participants in the course (by default 0)
  
  - An 'Order' button, which submits the order

  - A 'Cancel' button, which sets the number of students to 0

  OrderServiceEventArgs - C#.NET class used for representing the Order event, which is of type EventHandler<OrderServiceEventArgs>.
  
  OrderCourse - C#.NET class that defines the Order event and created when the 'Order' button is pressed
  
  2) SOAPService - a WCF project, which defines a SOAP web service. This service implements the IOrderService interface whic has the following methods:
  - GetCourses, which returns an array of Course objects
  - GetTitles, which returns a string array
  - Write2File, which receives writes the sender and the course to a text file
  
  The OrderService class implements the IOrderService interface, which contains the following attributes:
   - courses (Dictionary<string, Course>) - a table where which contains key-value pairs of course ids and their corresponding courses
   - titles (List<string>) - a list that contains the titles of the available courses
  
  OrderService implements the IOrderService interface, where:
   - GetCourses() returns the courses attribute in a thread-safe manner
   - GetTitles() returns the titles attribute in a thread-safe manner
   - Write2File(string sender, Course course) logs and given course and its sender to a text file. If the course's participants exceed the predefined limit, new courses are generated and logged to accomodate the excess students
  
  3) ClientsApp
  
  
 
 
    
     

  
