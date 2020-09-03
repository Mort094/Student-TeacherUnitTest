using System;

namespace ClassLibraryUnitTest
{
    public enum GenderType
    {
        male, female
    }
    public class Person
    {
        private string _name;
        private string _address;

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length >= 2)
                    _name = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                if (value != null)
                    _address = value;
                else
                    throw new ArgumentNullException();
            }
        }

        public GenderType Gender
        { get; set; }
    }
}