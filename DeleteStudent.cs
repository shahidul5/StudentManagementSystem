using System;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;

namespace StudentManagementSystem
{
    class DeleteStudent
    {
        public void DeleteDetails()
        {
            var json = File.ReadAllText(MainClass.jsonFile);
            try
            {
                var jObject = JObject.Parse(json);
                JArray students = (JArray)jObject["students"];
                Console.Write("Enter Student ID: (must be XXX-XX-XXX format)");
                var studentId = Console.ReadLine();
                var studentToDeleted = students.FirstOrDefault(obj => obj["StudentId"].Value<string>() == studentId);
                students.Remove(studentToDeleted);
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(MainClass.jsonFile, output);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message.ToString());
            }
        }
    }
}