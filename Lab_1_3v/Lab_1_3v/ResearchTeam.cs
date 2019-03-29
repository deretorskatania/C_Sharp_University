using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_3v
{
   
    class ResearchTeam
    {
        private string _themeResearch;
        private string _organisationName;
        private int _registrationNumber;
        private TimeFrame _timing;
        private Paper[] _listOfPublications;
        //private List<Paper> _papers { get; set; }

        public ResearchTeam() { }

        public ResearchTeam(string themeResearch, string organisationName, TimeFrame timing, int registrationNumber)//List<Paper> papers)
        {
            _themeResearch = themeResearch;
            _organisationName = organisationName;
            _timing = timing;
            _registrationNumber = registrationNumber;
            _listOfPublications = null;
            // _papers = papers;
        }

        public string ThemeResearch
        {
            get { return _themeResearch; }
            set { _themeResearch = value; }
        }

        public string OrganisatoinName
        {
            get { return _organisationName; }
            set { _organisationName = value; }
        }

        public TimeFrame Timing
        {
            get { return _timing; }
            set { _timing = value; }
        }

        /*public List<Paper> ListOfPublications
        {
            get
            { return _papers; }
            set
            {
                _papers.Add(value);
            }
        }*/

        public Paper[] ListOfPublications
        {
            get { return _listOfPublications; }
            set { _listOfPublications = value; }
        }



        public Paper LinkToPublication
        {
            get
            {
                DateTime timeMax = new DateTime(1900, 1, 1);
                Paper pap = new Paper();

                if (_listOfPublications == null)
                    return null;
                else
                {
                    foreach (Paper paper in _listOfPublications)
                    {
                        if (DateTime.Compare(paper._publicationDate, timeMax) == 1)
                        {
                            timeMax = paper._publicationDate;
                            pap = paper;
                        }

                    }
                    return pap;
                }

            }
        }

        public bool this[TimeFrame toCompare]
        {
            get => _timing == toCompare;
        }

        public void AddPapers(params Paper[] pap)
        {
            _listOfPublications = _listOfPublications.Concat(pap).ToArray();            
        }

        public override string ToString()
        {
            
            string str = " ";
            
            foreach (var paper in _listOfPublications)
            {
                str += paper.ToString() + "\n";
            }
            return string.Format("ThemeResearch: {0},\n Name: {1},\n Time Frame:{2},\n Code{3}, \n Paper{4}", _themeResearch, _organisationName, _timing, _registrationNumber, str);


        }

        public string ToShortString()
        {
            
            return string.Format("ThemeResearch: {0},\n Name: {1},\n Time Frame:{2},\n Code{3}", _themeResearch, _organisationName, _timing, _registrationNumber);
        }

        
    }
    public enum TimeFrame
    {
        Year,
        TwoYears,
        Long
    }

}

