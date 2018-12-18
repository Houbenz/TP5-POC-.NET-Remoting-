using Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Client2
{
    class Client2
    {
        static void Main(string[] args)
        {

            TcpChannel chnl = new TcpChannel();
            ChannelServices.RegisterChannel(chnl, false);


            //Pile pile = (Pile)Activator.GetObject(typeof(Pile), "tcp://localhost:1111/Pile");

            UsinePile usinePile = (UsinePile)Activator.GetObject(typeof(UsinePile), "tcp://localhost:1111/UsinePile");

            Console.WriteLine("Client 2");
            Console.WriteLine("donnez la taille de la pile a creer : ");
            Pile pile = usinePile.creationPile(int.Parse(Console.ReadLine()));


            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Etudiant" + i);
                String nom = Console.ReadLine();
                String prenom = Console.ReadLine();
                int id = int.Parse(Console.ReadLine());
                pile.empiler(new Etudiant(id, nom, prenom));
            }

            //pile.empiler(new Etudiant(11,"houssein","hhoo"));

            Console.WriteLine("taille courante : " + pile.lire_taille_courante());

            Console.WriteLine("taille max : " + pile.lire_taille_max());




        }
    }
}
