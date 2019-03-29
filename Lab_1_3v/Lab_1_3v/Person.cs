using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_3v
{
    class Person
    {
        private string _personName;
        private string _personLastName;
        private DateTime _personBirthday;

        public Person() { }

        public Person(string personName, string personLastName, DateTime personBirthday)
        {
            _personName = personName;
            _personLastName = personLastName;
            _personBirthday = personBirthday;
        }

        public string PersonName
        {
            get { return _personName; }
            set { _personName = value; }
        }

        public string PersonLastName
        {
            get { return _personLastName; }
            set { _personLastName = value; }
        }

        public DateTime PersonBirthday
        {
            get { return _personBirthday; }
            set { _personBirthday = value; }
        }

        public int PersonBirthdayYear
        {
            get { return _personBirthday.Year; }
            set { _personBirthday = new DateTime(value, _personBirthday.Month, _personBirthday.Day); }
        }

        public override string ToString()
        {
            return string.Format("  PersonName: {0},\n   PersonLastName: {1},\n   PersonBirthday: {2}", _personName, _personLastName, _personBirthday);
        }

        public string ToShortString()
        {
            return string.Format("PersonName: {0}, PersonLastName: {1}", _personName, _personLastName);
        }
    }
}
