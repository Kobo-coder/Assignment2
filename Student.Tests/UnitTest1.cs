using System;
using Xunit;

namespace Student.Tests
{
    public class StudentUnitTest
    {
        [Fact]
        public void given_student_id_9999_return_9999()
        {
            var testStudent = new Student(9999);
            Assert.Equal(9999, testStudent.id);
        }

        [Fact]
        public void given_student_GivenName_Anton_return_Anton()
        {
            var testStudent = new Student(1);
            testStudent.GivenName = "Anton";

            Assert.Equal("Anton", testStudent.GivenName);
        }

        [Fact]
        public void given_student_Surname_Jakobsen_return_Jakobsen()
        {
        
            var testStudent = new Student(2);
            testStudent.Surname = "Jakobsen";

            Assert.Equal("Jakobsen", testStudent.Surname);
        
        }

        [Fact]
        public void given_student_Startdate_2021_1_1_return_Startdate_2021_1_1()
        {
            var testStudent = new Student(3);
            testStudent.StartDate = new DateTime(2021,1,1);
            
            Assert.Equal(new DateTime(2021,1,1),testStudent.StartDate);
        }
        
        [Fact]
        public void given_student_Enddate_2021_1_2_return_Enddate_2021_1_2()
        {
            var testStudent = new Student(4);
            testStudent.EndDate = new DateTime(2021,1,2);
            
            Assert.Equal(new DateTime(2021,1,2),testStudent.EndDate);
        }

        [Fact]
        public void given_student_Graduationdate_2021_1_3_return_Graduationdate_2021_1_3()
        {
            var testStudent = new Student(5);
            testStudent.GraduationDate = new DateTime(2021,1,4);
            
            Assert.Equal(new DateTime(2021,1,4),testStudent.GraduationDate);
        }

        [Fact]
        public void given_student_StartDate_2021_1_1_EndDate_2023_1_1_GraduationDate_23_1_1_return_status_new()
        {
            var testStudent = new Student(6);
            testStudent.StartDate = new DateTime(2021,1,1);
            testStudent.EndDate = new DateTime(2023,1,1);
            testStudent.GraduationDate = new DateTime(2023,1,1);
            
            Assert.Equal(Status.New,testStudent.Status);
        }

        [Fact]
        public void given_student_StartDate_2015_1_1_EndDate_2023_1_1_GraduationDate_23_1_1_return_status_active()
        {
            var testStudent = new Student(7);
            testStudent.StartDate = new DateTime(2015,1,1);
            testStudent.EndDate = new DateTime(2023,1,1);
            testStudent.GraduationDate = new DateTime(2023,1,1);
            
            Assert.Equal(Status.Active,testStudent.Status);
        }
        
        [Fact]
        public void given_student_StartDate_2015_1_1_EndDate_2020_1_1_GraduationDate_2020_1_1_return_status_graduated()
        {
            var testStudent = new Student(8);
            testStudent.StartDate = new DateTime(2015,1,1);
            testStudent.EndDate = new DateTime(2020,1,1);
            testStudent.GraduationDate = new DateTime(2020,1,1);
            
            Assert.Equal(Status.Graduated,testStudent.Status);
        }

        [Fact]
        public void given_student_StartDate_2015_1_1_EndDate_2019_1_1_GraduationDate_2020_1_1_return_status_dropout()
        {
            var testStudent = new Student(9);
            testStudent.StartDate = new DateTime(2015,1,1);
            testStudent.EndDate = new DateTime(2019,1,1);
            testStudent.GraduationDate = new DateTime(2020,1,1);
            
            Assert.Equal(Status.Dropout,testStudent.Status);
        }
        
        [Fact]
        public void given_student_StartDate_2015_1_1_EndDate_2019_1_1_GraduationDate_2020_1_1_Name_Bob_Surname_Bobson_return_FancyString()
        {
            var testStudent = new Student(10);
            testStudent.StartDate = new DateTime(2015,1,1);
            testStudent.EndDate = new DateTime(2019,1,1);
            testStudent.GraduationDate = new DateTime(2020,1,1);
            testStudent.GivenName = "Bob";
            testStudent.Surname = "Bobson";
            
            Assert.Equal("ID: 10, Name: Bob Bobson, StartDate: 01/01/2015, EndDate: 01/01/2019, GraduationDate: 01/01/2020, Status: Dropout",testStudent.ToString());
        }
    }
}