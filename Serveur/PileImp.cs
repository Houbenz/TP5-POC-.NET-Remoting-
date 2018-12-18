using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remote;
namespace Serveur
{
    public class PileImp : MarshalByRefObject, Remote.Pile
    {

        Etudiant[] pile;

        public PileImp(int size)
        {
            pile = new Etudiant[size];
        }


       
        public Etudiant depiler()
        {
            Etudiant etudiant = pile[pile.Length];
            pile[pile.Length] = null;

            return etudiant;

        }

        public bool empiler(Etudiant etudiant)
        {

            for(int i = 0; i < pile.Length; i++)
            {
                if(pile[i] == null)
                {
                    pile[i] = etudiant;
                    return true;
                }
            }
            return false;
        }

        public int lire_taille_courante()
        {
            int co = 0;
            for(int i = 0; i < pile.Length; i++)
            {
                if (pile[i] != null)
                {
                    co++;
                }
                else
                    return co;
            }

            return co;
        }

        public int lire_taille_max()
        {
            return pile.Length;
        }

        public void vider()
        {
            for(int i = 0; i < pile.Length; i++)
            {
                pile[i] = null;

            }
        }
    }
}
