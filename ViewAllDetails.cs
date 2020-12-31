using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace StudentManagementSystem
{
    class ViewAllDetails
    {
        public void ViewDetails()
        {
            var json = File.ReadAllText(MainClass.jsonFile);
            try
            {
                var jObject = JObject.Parse(json);
                if(jObject != null)
                {
                    JArray students = (JArray)jObject["students"];
                    if(students != null)
                    {
                        foreach(var item in students)
                        {
                            Console.WriteLine("ID: " + item["StudentId"]);
                            Console.WriteLine("Name: " + item["FirstName"] +" " +item["MiddleName"]+ " " + item["LastName"]);
                            Console.WriteLine("Joining Batch: " + item["JoiningSemester"] + "-"+ item["JoiningYear"]);
                            Console.WriteLine("Department: " + item["Department"]);
                            Console.WriteLine("Degree: " + item["Degree"]);
                            Console.WriteLine("\n");
                        }
                    }
                }
            }
            catch(Exception error)
            {
                Console.WriteLine("Error: " + error.Message.ToString());
            }
        }
    }
}
