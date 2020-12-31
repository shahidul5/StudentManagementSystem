using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StudentManagementSystem
{
    class MainClass
    {
        public static string jsonFile = @"C:\web development\AsthaIT\assignment-03\StudentManagementSystem\studentDetails.json";
        enum departments
        {
            CSE,
            BBA,
            English
        }
        enum degrees
        {
            BSc,
            BBA,
            BA,
            MBA,
            MSc,
            MA
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Your Option: 1 - Add Student, 2 - Delete Student, 3 - View All Students \n");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    var add = new AddStudent();

                    Console.WriteLine("Enter First Name: ");
                    add.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Middle Name: ");
                    add.MiddleName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name: ");
                    add.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Student ID: ");
                    add.StudentId = Console.ReadLine();
                    Console.WriteLine("Enter Joining Semester Code: ");
                    add.JoiningSemester = Console.ReadLine();
                    Console.WriteLine("Enter Joining Semester Year: ");
                    add.JoiningYear = Console.ReadLine();
                    Console.WriteLine("Choose Department- 1.CSE, 2.BBA, 3.English");
                    int a = Convert.ToInt32(Console.ReadLine());
                    add.Department = a;
                    Console.WriteLine("Choose Degree- 1.BSc, 2.BA, 3.MSc, 4.MBA, 5.MA");
                    int b = Convert.ToInt32(Console.ReadLine());
                    add.Degree = b;

                    string JSONresult = JsonConvert.SerializeObject(add);

                    try
                    {
                        var json = File.ReadAllText(jsonFile);
                        var jsonObj = JObject.Parse(json);
                        var students = jsonObj.GetValue("students") as JArray;
                        var newStudents = JObject.Parse(JSONresult);
                        students.Add(newStudents);
                        jsonObj["students"] = students;
                        string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                        File.WriteAllText(jsonFile, newJsonResult);
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine("Error: " + error.Message.ToString());
                    }
                    break;
                case "2":
                    var delete = new DeleteStudent();
                    delete.DeleteDetails();
                    break;
                case "3":
                    var viewAll = new ViewAllDetails();
                    viewAll.ViewDetails();
                    break;
                default:
                    Console.WriteLine("Invalid Input!!");
                    break;
            }
        }
    }
}