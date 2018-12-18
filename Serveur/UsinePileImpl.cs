using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remote;
namespace Serveur
{
    class UsinePileImpl : MarshalByRefObject, Remote.UsinePile
    {
        public Pile creationPile(int size)
        {
            return new PileImp(size);
        }
    }
}
