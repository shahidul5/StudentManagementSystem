namespace StudentManagementSystem
{
    class AddStudent
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string studentId;
        private string joiningSemester;
        private string joiningYear;
        private int department;
        private int degree;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string JoiningSemester
        {
            get { return joiningSemester; }
            set { joiningSemester = value; }
        }
        public string JoiningYear
        {
            get { return joiningYear; }
            set { joiningYear = value; }
        }
        public int Department
        {
            get { return department; }
            set { department = value; }
        }
        public int Degree
        {
            get { return degree; }
            set { degree = value; }
        }
    }
}
