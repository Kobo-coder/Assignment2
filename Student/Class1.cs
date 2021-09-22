using System;


namespace Student
{
    public class Student
    {
        public int id { get; }

        public string GivenName { get; set; }

        public string Surname { get; set; }

        public DateTime StartDate { get; set; }
    
        public DateTime EndDate { get; set; }

        public DateTime GraduationDate { get; set; }

        public Status Status { get { 
            if(EndDate < GraduationDate){
                return Status.Dropout;
            }
            else if(GraduationDate > DateTime.Now && EndDate > DateTime.Now ){
                if(DateTime.Now.Subtract(StartDate) < new TimeSpan(365,0,0,0)){
                    return Status.New;
                }
                else{
                    return Status.Active;
                }
            }
            //else if (GraduationDate <= DateTime.Now && GraduationDate == EndDate){
                return Status.Graduated;
            //} 
        }}
        
        public Student(int id){
            this.id = id;
        }

        public string ToString(){
            return "ID: " + id + ", Name: " + GivenName + " " + Surname + ", StartDate: " + StartDate.ToString("MM/dd/yyyy") + ", EndDate: " + EndDate.ToString("MM/dd/yyyy") + ", GraduationDate: " + GraduationDate.ToString("MM/dd/yyyy") + ", Status: " + Status;
        }
    }
}
