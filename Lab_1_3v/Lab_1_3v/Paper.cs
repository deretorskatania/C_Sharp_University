using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_3v
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
            return string.Format("PublicationName: \n {0},\n  Author: {1},\n  PublicationDate: {2}", _publicationName, _author,  _publicationDate);
        }



    }
}
