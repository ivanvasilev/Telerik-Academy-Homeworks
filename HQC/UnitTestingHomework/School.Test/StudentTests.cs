namespace School.Test
{
    using System;
    using System.Diagnostics;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void StudentShouldNotThrowAnException()
        {
            var student = new Student("Jimmy Hendrix", 10000);
        }

        [TestMethod]
        public void StudentShouldReturnExpectedName()
        {
            var student = new Student("Jimmy Hendrix", 10000);

            Assert.AreEqual("Jimmy Hendrix", student.Name);
        }

        [TestMethod]
        public void StudentShouldReturnExpectedId()
        {
            var student = new Student("Jimmy Hendrix", 10000);

            Assert.AreEqual(10000, student.ID);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowNullReferenceExceptionForNullName()
        {
            var student = new Student(null, 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowNullReferenceExceptionForEmptyName()
        {
            var student = new Student(string.Empty, 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentShouldThrowArgumentExceptionForInvalidId_Low()
        {
            var student = new Student("Jimmy Hendrix", 100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentShouldThrowArgumentExceptionForInvalidId_High()
        {
            var student = new Student("Jimmy Hendrix", 1000000);
        }

        [TestMethod]
        public void StudentShouldNotThrowExceptionWhenAttendingCourse()
        {
            var student = new Student("Jimmy Hendrix", 10000);
            var course = new Course("Music");
            student.AttendCourse(course);
        }

        [TestMethod]
        public void StudentShouldNotThrowExceptionWhenLeavesCourse()
        {
            var student = new Student("Jimmy Hendrix", 10000);
            var course = new Course("Music");
            student.AttendCourse(course);
            student.LeaveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowExceptionWhenAttendingNullCourse()
        {
            var student = new Student("Jimmy Hendrix", 10000);
            Course course = null;
            student.AttendCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowExceptionWhenLeavingNullCourse()
        {
            var student = new Student("Jimmy Hendrix", 10000);
            Course course = null;
            student.LeaveCourse(course);
        }
    }
}
