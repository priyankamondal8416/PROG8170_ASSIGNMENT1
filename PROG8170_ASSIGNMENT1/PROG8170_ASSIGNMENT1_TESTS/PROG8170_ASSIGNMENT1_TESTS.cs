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

        [Test]
        public void GetWidth_input4_expectWidthEquals4()
        {
            // Arrange Data
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            // Act on data
            int width = testRectangle.GetWidth();

            // Assert
            Assert.AreEqual(width, w);
        }


        [Test]
        public void GetArea_input_Lenght5_Width5_expectAreaEquals25()
        {
            // Arrange Data
            int l = 5;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l, w);

            // Act on data
            int area = testRectangle.GetArea();
            int valueTocheck = (l * w);

            // Assert
            Assert.AreEqual(area, valueTocheck);
        }

        [Test]
        public void GetPerimeter_input_Lenght5_Width5_expectAreaEquals20()
        {
            // Arrange Data
            int l = 5;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l, w);

            // Act on data
            int perimeter = testRectangle.GetPerimeter();
            int valueTocheck = ((l * 2) + (w * 2));

            // Assert
            Assert.AreEqual(perimeter, valueTocheck);
        }

        [Test]
        public void SetLenght_inputLength5_expectLengthEquals5()
        {
            // Arrange Data
            int l = 5;

            Rectangle testRectangle = new Rectangle();

            // Act on data
            int lenght = testRectangle.Setlength(l);            

            // Assert
            Assert.AreEqual(lenght, l);
        }

        [Test]
        public void SetWidth_inputWidth5_expectWidthEquals5()
        {
            // Arrange Data
            int w = 5;

            Rectangle testRectangle = new Rectangle();

            // Act on data
            int widht = testRectangle.SetWidth(w);

            // Assert
            Assert.AreEqual(widht, w);
        }

    }
}
