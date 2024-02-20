using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase_4PraProTest
{
    public class Teach
    {
        [Test]
        public void Test_CreateTeacher()
        {
            // Arrange
            var teacher = new Teacher();
            teacher.TeacherID = 104;
            teacher.TeacherName = "Mrs.SUNEELA";

            // Act & Assert
            Assert.AreEqual(104, teacher.TeacherID);
            Assert.AreEqual("Mrs.SUNEELA", teacher.TeacherName);
        }
    }
}

