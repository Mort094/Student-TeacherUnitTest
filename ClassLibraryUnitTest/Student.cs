using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace ClassLibraryUnitTest
{
  
    public class Student : Person
    {
        private int _semester;

        public Student()
        {
            

        }

        public int Semester
        {
            get => _semester;
            set
            {
                if (1 <= value && value <= 8)
                    _semester = value;
                else
                    throw new ArgumentOutOfRangeException();

            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
