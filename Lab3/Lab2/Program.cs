using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Team team1 = new Team("Горішок", 099);
            Team team2 = new Team("Горішок", 099);
            if (team1 == team2)
            {
                Console.WriteLine("однаковi");
            }
            Console.WriteLine("Хеш код для першого об'кта:" + team1.GetHashCode() + "\nХеш код для другого об'кта:" + team2.GetHashCode() + "\n");

            try
            {
                team1.RegistrationNumber = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            List<Person> people = new List<Person>();
            people.Add(new Person());
            List<Paper> papers = new List<Paper>();
            papers.Add(new Paper());
            ResearchTeam researchTeam = new ResearchTeam();
            researchTeam.People = people;
            researchTeam.Papers = papers;
            // Console.WriteLine(researchTeam);

            Team team = new Team();
            team = researchTeam.GetTeam;
            //Console.WriteLine(team);

            ResearchTeam researchTeam1 = new ResearchTeam();
            researchTeam1 = (ResearchTeam)researchTeam.DeepCopy();
            //researchTeam.DeepCopy();
            researchTeam.ThemeResearch = "Some Organization";
            //Console.WriteLine(researchTeam);
            //Console.WriteLine(researchTeam1);

            researchTeam1.AddPerson(new Person("Olha", "Melnyk", new DateTime(2019, 03, 23)));
            researchTeam1.AddPerson(new Person("Tetiana", "Deretorska", new DateTime(1999, 05, 26)));


            //researchTeam1.AddPapers(new Paper("Name Ukr", new Person("Olha","Polop",new DateTime(1998, 03, 23)),new DateTime(2018, 03, 23)));
            Console.WriteLine(researchTeam1);
            //Console.WriteLine(researchTeam1);
            foreach (Person person in researchTeam1)
            {
                Console.WriteLine(person);
            }
            /*foreach(Paper paper in researchTeam1.GetEnumeratorPaper(4))
            {
                Console.WriteLine(paper);
            }
            */



            /*string userInput;
            int n, m;
            Console.WriteLine("Input n&m:");
            userInput = Console.ReadLine();
            n = Convert.ToInt32(userInput);
            userInput = Console.ReadLine();
            m = Convert.ToInt32(userInput);



            Person person = new Person("Olha", "Melnyk", new DateTime(1999, 06, 01));
            Person personTwo = new Person("Tania", "Deretorska", new DateTime(1999, 05, 26));
            person.PersonBirthdayYear = 1995;

            List<Paper> paper = new List<Paper>();
            paper.Add(new Paper() {_publicationName = "Name Publication", _author = person, _publicationDate = new DateTime(2017, 12, 23)});
            paper.Add(new Paper() {_publicationName = "Name Publication1", _author = personTwo, _publicationDate = new DateTime(2019, 12, 23)});
            

            Paper[] papers = { new Paper() { _publicationName = "Name Publication", _author = person, _publicationDate = new DateTime(2017, 02, 23) },
                               new Paper() { _publicationName = "Name Publication1", _author = person, _publicationDate = new DateTime(2017, 12, 23) }
                             };

            ResearchTeam researchTeam = new ResearchTeam("thema", "organization", TimeFrame.Long, 9);

            Console.WriteLine(researchTeam.ToShortString());

            Console.WriteLine("Long = " + researchTeam[TimeFrame.Long] + "\n" + "TwoYears = " + researchTeam[TimeFrame.TwoYears] + "\n" + "Year = " + researchTeam[TimeFrame.Year] + "\n");
            researchTeam.ListOfPublications = papers;

            Console.WriteLine(researchTeam.ToString());


            Paper[] listOfPublications1 = { new Paper() { _publicationName = "Name Publication2", _author = person, _publicationDate = new DateTime(2018, 12, 23) },
                                            new Paper() { _publicationName = "Name Publication3", _author = person, _publicationDate = new DateTime(2019, 12, 23) }
                                          };

            researchTeam.AddPapers(listOfPublications1);

            Console.WriteLine(researchTeam.ToString());
            Console.WriteLine("Last Publication: " + researchTeam.LinkToPublication);


            Paper[] papers1 = new Paper[n * m];
            Paper[,] papers2 = new Paper[n, m];
            Paper[][] papers3 = new Paper[n][];
            Paper paperToCompare = new Paper() { _publicationName = "Name Publication1", _author = person, _publicationDate = new DateTime(2017, 12, 23) };

            int Start = Environment.TickCount;
            for (int i = 0; i < n * m; i++)
            {
                papers1[i] = paperToCompare;
            }
            Console.WriteLine("Duration of operation: " + (Environment.TickCount - Start));


            //Start = Environment.TickCount;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    papers2[i, j] = paperToCompare;
                }
            Console.WriteLine("Duration of operation: " + (Environment.TickCount - Start));

            int k = m;
            for (int j = 0; j < n; j++)
            {
                papers3[j] = new Paper[k--];
            }

            //Start = Environment.TickCount;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - i; j++)
                {
                    papers3[i][j] = paperToCompare;
                }
            }
            Console.WriteLine("Duration of operation: " + (Environment.TickCount - Start));*/

            ResearchTeamCollection researchTeamCollection = new ResearchTeamCollection();
            researchTeamCollection.AddDefaults();
            //Console.WriteLine(researchTeamCollection.ToString());
            researchTeamCollection.SortByRegistrationNumber();
            Console.WriteLine(researchTeamCollection.ToString());
            researchTeamCollection.SortByExploreTheme();
            //Console.WriteLine(researchTeamCollection.ToString());
            researchTeamCollection.SortByRegistrationNumber();
            //Console.WriteLine(researchTeamCollection.ToString());
            int minNumberOfRegistration = researchTeamCollection.GetMinInRegistrationNumber;
            Console.ReadLine();
        }
    }
}
