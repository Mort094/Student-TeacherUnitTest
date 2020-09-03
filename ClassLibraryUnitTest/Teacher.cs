using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryUnitTest
{
    
    public class Teacher : Person
    {
        private string _name;
        private string _address;
        private int _salery;

        public Teacher()
        {


        }

        public int Salery
        {
            get => _salery;
            set
            {
                if (value >= 0)
                    _salery = value;
                else
                    throw new ArgumentOutOfRangeException();

            }
        }

    }
}
