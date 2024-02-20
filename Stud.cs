using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase_4PraProTest
{
    public class Stud
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.Name = "PAVAN";

            // Act
            string studentName = student.Name;

            // Assert
            Assert.AreEqual("PAVAN", studentName);
        }

        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "Gandhinagar 4th cross Bly";

            // Act
            string studentAddress = student.Address;

            // Assert
            Assert.AreEqual("Gandhinagar 4th cross Bly", studentAddress);
        }
    }
}
