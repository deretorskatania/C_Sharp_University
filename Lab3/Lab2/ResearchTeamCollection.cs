using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ResearchTeamCollection
    {
        private List<ResearchTeam> ResearchTeams = new List<ResearchTeam>();

        public int GetMinInRegistrationNumber
        {
            get
            {
                return ResearchTeams.Select(t => t.RegistrationNumber).Min();
            }
        }

        public List<ResearchTeam> GetTwoYears
        {
            get
            {
                return ResearchTeams.Where(t => t.Timing == TimeFrame.TwoYears).ToList();
            }
        }

        public void AddDefaults()
        {
            //List<ResearchTeam> ResearchTeams = new List<ResearchTeam>();
            Person person = new Person("Tetiana", "Deretorska", new DateTime(2001, 02, 22));
            Person person1 = new Person("Olha", "Deretorska", new DateTime(2001, 02, 22));
            Paper paper = new Paper(person,"Science",  new DateTime(2020, 11, 20));

            ResearchTeam researchTeam = new ResearchTeam("Nature2", TimeFrame.TwoYears);
            researchTeam.NameOfOrganisation = "Organization1";
            researchTeam.RegistrationNumber = 23;
            researchTeam.AddPerson(person);
            researchTeam.AddPerson(person1);
            researchTeam.AddPapers(paper);
            researchTeam.AddPapers(paper);
            ResearchTeams.Add(researchTeam);

            // List<ResearchTeam> ResearchTeams = new List<ResearchTeam>();
            Person personw = new Person("Olia", "Melnyk", new DateTime(2001, 02, 22));
            Paper paperw = new Paper( personw, "Science",new DateTime(2020, 11, 20));
            ResearchTeam researchTeamw = new ResearchTeam("Nature1", TimeFrame.Long);
            researchTeamw.NameOfOrganisation = "Organization2";
            researchTeamw.RegistrationNumber = 21;
            researchTeamw.AddPerson(person);
            researchTeamw.AddPapers(paper);
            ResearchTeams.Add(researchTeamw);


        }
        public void AddResearchTeam(params ResearchTeam[] researchTeams)
        {
            ResearchTeams = new List<ResearchTeam>();
            foreach (ResearchTeam researchteam in researchTeams)
            {
                ResearchTeams.Add(researchteam);
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var researchTeam in ResearchTeams)
            {
                stringBuilder.Append(researchTeam);
            }
            return stringBuilder.ToString();
            //return string.Format("ResearchTeam:\n{0}", string.Join("\n", ResearchTeams.Select(x => x.ToString()).ToArray()));
        }

        public virtual string ToShortList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var researchTeam in ResearchTeams)
            {
                stringBuilder.Append(researchTeam.ToShortString());
            }
            return stringBuilder.ToString();
        }

        public void SortByRegistrationNumber()
        {
            ResearchTeams.Sort();
        }
        public void SortByExploreTheme()
        {
            ResearchTeams.Sort(new ResearchTeam());
        }
        public void SortByCountOfPublishing()
        {
            ResearchTeams.Sort(new ResearchTeamComparer());
        }
        public List<ResearchTeam> NGroup(int value)
        {
            return ResearchTeams.Where(t => t.People.Count == value).ToList();
        }
    }
}
