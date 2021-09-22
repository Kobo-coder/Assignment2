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
    }
}
