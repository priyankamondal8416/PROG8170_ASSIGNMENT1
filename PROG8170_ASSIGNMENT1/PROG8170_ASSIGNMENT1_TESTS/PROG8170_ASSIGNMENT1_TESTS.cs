using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG8170_ASSIGNMENT1;
using NUnit.Framework;

namespace PROG8170_ASSIGNMENT1_TESTS
{
    [TestFixture]
    class PROG8170_ASSIGNMENT1_TESTS
    {
        [Test]
        public void GetLength_input3_expectLengthEquals3()
        {
            // Arrange Data
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            // Act on data
            int length = testRectangle.GetLength();

            // Assert
            Assert.AreEqual(length, l);
        }
        

    }
}
