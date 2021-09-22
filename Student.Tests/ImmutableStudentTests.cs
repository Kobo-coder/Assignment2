using System;
using Xunit;

namespace Student.Tests
{
    public class ImmutableStudentUnitTest
    {
        
        [Fact]
        public void fancy_to_string_test()
        {
            var testStudent = new ImmutableStudent() {
                id = 1,
                GivenName = "Bob",
                Surname = "Bobson",
                StartDate = new DateTime(2015,1,1),
                EndDate = new DateTime(2019,1,1),
                GraduationDate = new DateTime(2020,1,1)
                };
            Assert.Equal("ImmutableStudent { id = 1, GivenName = Bob, Surname = Bobson, StartDate = 01.01.2015 00.00.00, EndDate = 01.01.2019 00.00.00, GraduationDate = 01.01.2020 00.00.00, Status = Dropout }",testStudent.ToString());
        }

        [Fact]
        public void testStudent1_equal_testStudent2_returns_true()
        {
            var testStudent1 = new ImmutableStudent() {
                id = 1,
                GivenName = "Bob",
                Surname = "Bobson",
                StartDate = new DateTime(2015,1,1),
                EndDate = new DateTime(2019,1,1),
                GraduationDate = new DateTime(2020,1,1)
            };

            var testStudent2 = new ImmutableStudent() {
                id = 1,
                GivenName = "Bob",
                Surname = "Bobson",
                StartDate = new DateTime(2015,1,1),
                EndDate = new DateTime(2019,1,1),
                GraduationDate = new DateTime(2020,1,1)
            };
            Assert.Equal(testStudent1,testStudent2);
        }

        [Fact]
        public void testStudent3_equal_testStudent4_returns_false()
        {
            var testStudent3 = new ImmutableStudent() {
                id = 3,
                GivenName = "Bob",
                Surname = "Bobson",
                StartDate = new DateTime(2015,1,1),
                EndDate = new DateTime(2019,1,1),
                GraduationDate = new DateTime(2020,1,1)
            };

            var testStudent4 = new ImmutableStudent() {
                id = 4,
                GivenName = "Bob",
                Surname = "Bobson",
                StartDate = new DateTime(2015,1,1),
                EndDate = new DateTime(2019,1,1),
                GraduationDate = new DateTime(2020,1,1)
            };
            Assert.NotEqual(testStudent3,testStudent4);
        }
    }
}