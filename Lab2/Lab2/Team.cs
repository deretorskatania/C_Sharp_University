using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Team:INameAndCopy
    {   public string Name { get; set; }

        private string _nameOfOrganisation;
        private int _registrationNumber;

        public string NameOfOrganisation { get; set; }
        public int RegistrationNumber {
            get { return _registrationNumber; }
            set
            {
                if (value > 0)
                    _registrationNumber = value;
                else
                    throw new ArgumentException($"Номер реєстрацiї має бути бiльше нуля"); ;

            }
        }

        public Team() { }

        public Team(string nameOfOrganisation, int registrationNumber)
        {
            _nameOfOrganisation = nameOfOrganisation;
            _registrationNumber = registrationNumber;
        }

        public virtual object DeepCopy()
        {

            Team copy = (Team)MemberwiseClone();

            return copy;

        }

        public override bool Equals(object ob)
        {
            var team = ob as Team;
            return team != null
                && _nameOfOrganisation == team._nameOfOrganisation
                && _registrationNumber == team._registrationNumber;
        }
        public static bool operator ==(Team teamOne, Team teamTwo)
        {
            return ReferenceEquals(teamOne, teamTwo) ||
                (
                    !ReferenceEquals(teamOne, null)
                    && !ReferenceEquals(teamTwo, null)
                    && teamOne._nameOfOrganisation == teamTwo._nameOfOrganisation
                    && teamOne._registrationNumber == teamTwo._registrationNumber
                );
        }
        public static bool operator !=(Team teamOne, Team teamTwo)
        {
            return !(teamOne == teamTwo);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (NameOfOrganisation != null ? _nameOfOrganisation.GetHashCode() : 0);                
                hashCode = (hashCode * 397) ^ _registrationNumber.GetHashCode();
                return hashCode;
            }
          
        }
        public override string ToString()
        {
            return string.Format("Name organization: {0}, \n Registration Number: {1}", _nameOfOrganisation, _registrationNumber);

        }

    }
}
