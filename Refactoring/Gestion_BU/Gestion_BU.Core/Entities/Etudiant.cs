using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_BU.Core.Entities
{
    public class Etudiant
    {
        public string AdresseEmail { get; private set; }
        public int UniversiteId { get; private set; }
        public int NbTelechargementMaximum { get; set; }
        public int NbLivreTelecharges { get; set; }

        public Etudiant(string emailAddress, int universityId, Forfait forfait)
        {
            AdresseEmail = emailAddress;
            UniversiteId = universityId;
            if (forfait == Forfait.Standard)
            {
                NbTelechargementMaximum = 10;
            }
            else if (forfait == Forfait.Premium)
            {
                NbTelechargementMaximum = 10 * 2;
            }
        }
    }
}
