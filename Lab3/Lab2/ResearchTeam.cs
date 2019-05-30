using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ResearchTeam: Team, IComparer<ResearchTeam>
    {
        private string _themeResearch;       
        private TimeFrame _timing;
        private List<Person> _people;
        private List<Paper> _papers;
       
        public ResearchTeam()
        {
            _themeResearch = "УкрTeam conferation";
            _timing = TimeFrame.TwoYears;
        }

        public ResearchTeam(string themeResearch, TimeFrame timing)
        {
            _themeResearch = themeResearch;
            _timing = timing;
            _people = new List<Person>();
            _papers = new List<Paper>();
        }
        public ResearchTeam(string themeResearch,  TimeFrame timing, List<Person> people, List<Paper> papers)//List<Paper> papers)
        {
            _themeResearch = themeResearch;         
            _timing = timing;
            _people = new List<Person>();
            _papers = new List<Paper>();
        }

        public string ThemeResearch
        {
            get { return _themeResearch; }
            set { _themeResearch = value; }
        }
        
        public TimeFrame Timing
        {
            get { return _timing; }
            set { _timing = value; }
        }

        public List<Person> People

        {
            get { return _people; }
            set { _people = value; }
        }
        public List<Paper> Papers
        {
            get { return _papers; }
            set { _papers = value; }
        }
        public Team GetTeam
        {
            get => this;
            set
            {
                base.NameOfOrganisation = value.NameOfOrganisation;
                RegistrationNumber = value.RegistrationNumber;
            }
        }

        public Paper LinkToPublication
        {
            get
            {
                DateTime timeMax = new DateTime(1900, 1, 1);
                Paper pap = new Paper();

                if (_papers == null)
                    return null;
                else
                {
                    foreach (Paper paper in _papers)
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

        public int Compare(ResearchTeam x, ResearchTeam y)
        {
            if (x.ThemeResearch.Length > y.ThemeResearch.Length)
                return 1;
            else if (x.ThemeResearch.Length < y.ThemeResearch.Length)
                return -1;
            else return 0;
        }

        public bool this[TimeFrame toCompare]
        {
            get => _timing == toCompare;
        }

        public void AddPapers(params Paper[] paper)
        {
            _papers = _papers.Concat(paper).ToList();
        }
        public void AddPerson(params Person[] person)
        {
            _people = _people.Concat(person).ToList();
        }

        /*public override object DeepCopy()
        {
            ResearchTeam copy = (ResearchTeam)MemberwiseClone();
            copy._themeResearch = String.Copy(_themeResearch);
            copy._timing = _timing;
            copy._people = _people;
            copy._papers = _papers;
            return copy;
        }*/

        public IEnumerator<Person> GetEnumerator()
        {
            bool flag;
            foreach (Person person in People)
            {
                flag = false;
                foreach (Paper paper in Papers)
                {
                    if (paper._author == person)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    yield return person;
            }
        }
        

        public IEnumerable<Paper> GetEnumeratorPaper(int n)
        {
            if (n < 0) yield break;
            DateTime nowDate = DateTime.Now;
            DateTime tempDate = nowDate.AddYears(-n);
            foreach (Paper paper in Papers)
            {
                if (tempDate < paper._publicationDate)
                {
                    yield return paper;
                }
            }
        }

        public string StringPapers()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var paper in _papers)
            {
                stringBuilder.Append(paper);
            }
            return stringBuilder.ToString();
        }
        public string StringPerson()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var person in _people)
            {
                stringBuilder.Append(person);
            }
            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return string.Format("Theme Researchteam:{0}, \n Time: {1}, \n Persons : {2}, \n Papers : {3}, \n Name Organization : {4} , \n Registration Number : {5} \n", _themeResearch, _timing, StringPerson(), StringPapers(), NameOfOrganisation, RegistrationNumber);
        }

        public string ToShortString()
        {

            return string.Format("ThemeResearch: {0}, \n Time Frame:{1}", _themeResearch, _timing);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ResearchTeam)obj);
        }

        public static bool operator ==(ResearchTeam left, ResearchTeam right)
        {
            return ReferenceEquals(left, right);
        }

        public static bool operator !=(ResearchTeam left, ResearchTeam right)
        {
            return !ReferenceEquals(left, right);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_themeResearch != null ? _themeResearch.GetHashCode() : 0);                
                hashCode = (hashCode * 397) ^ (int)_timing;
                hashCode = (hashCode * 397) ^ (_papers != null ? _papers.GetHashCode() : 0);
                return hashCode;
            }
        }

    }
    public enum TimeFrame
    {
        Year,
        TwoYears,
        Long
    }
}
