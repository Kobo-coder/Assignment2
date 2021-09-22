using System;

namespace Student
{
    public class Student
    {
        public int id { get; }

        public string GivenName { get; set; }
        
        public string Surname { get; set; }
        

        public Student(int id){
            this.id = id;
        }
    }
}
