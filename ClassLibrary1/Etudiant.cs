using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote
{
    [Serializable]
    public class Etudiant
    {
        int id;
        string nom, prenom;

    public Etudiant(int id , string nom , string prenom)
        {
            this.id = id;
            this.prenom = prenom;
            this.nom = nom;
        }
    }
}
