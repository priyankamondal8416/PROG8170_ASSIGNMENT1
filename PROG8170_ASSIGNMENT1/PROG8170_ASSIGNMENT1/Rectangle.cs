using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_ASSIGNMENT1
{
    public class Rectangle
    {
        private int length;
        private int width;

        // Default Constructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }


        // Parameterized Constructor
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        // Get Length
        public int GetLength()
        {
            return length;
        }

        // Set Length
        public int Setlength(int length)
        {
            this.length = length;
            return this.length;
        }

        // Get Width
        public int GetWidth()
        {
            return width;
        }

        // Set Width
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        //Get Perimeter
        public int GetPerimeter()
        {
            return (length * 2) + (width * 2);
        }

        //Get Area
        public int GetArea()
        {
            return length * width;
        }
    }
}
