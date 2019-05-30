using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Paper
    {
        public Person _author { get; set; }
        public string _publicationName { get; set; }
        public DateTime _publicationDate { get; set; }

        public Paper() { }

        public Paper(Person author, string publicationName, DateTime publicationDate)
        {
            _author = author;
            _publicationName = publicationName;
            _publicationDate = publicationDate;
        }

        public override string ToString()
        {
            return string.Format("PublicationName: \n {0},\n  Author: {1},\n  PublicationDate: {2}", _publicationName, _author, _publicationDate);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Paper)obj);
        }

        protected bool Equals(Paper other)
        {
            return string.Equals(_publicationName, other._publicationName) && string.Equals(_author, other._author) && _publicationDate.Equals(other._publicationDate);
        }

        public static bool operator ==(Paper left, Paper right)
        {
            return ReferenceEquals(left, right);
        }

        public static bool operator !=(Paper left, Paper right)
        {
            return !ReferenceEquals(left, right);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_author != null ? _author.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_publicationName != null ? _publicationName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ _publicationDate.GetHashCode();
                return hashCode;
            }
        }

    }
}
