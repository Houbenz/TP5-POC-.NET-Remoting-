using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote
{

  
    public interface  Pile
    {

        bool empiler(Etudiant etudiant);
        Etudiant depiler();
        void vider();
        int lire_taille_courante();
        int lire_taille_max();
    }
}
