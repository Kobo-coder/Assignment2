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

        

    }
}
