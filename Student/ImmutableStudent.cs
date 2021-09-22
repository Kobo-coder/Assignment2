using System;


namespace Student
{
    public record ImmutableStudent
    {
        public int id { get; init; }

        public string GivenName { get; init; }

        public string Surname { get; init; }

        public DateTime StartDate { get; init; }
    
        public DateTime EndDate { get; init; }

        public DateTime GraduationDate { get; init; }

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
    }
}
