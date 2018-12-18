using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Serveur
{
    class Serveur
    {
        static void Main(string[] args)
        {
            TcpChannel chnl = new TcpChannel(1111);
            ChannelServices.RegisterChannel(chnl, false);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(UsinePileImpl), "UsinePile", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PileImp), "Pile", WellKnownObjectMode.Singleton);

            Console.WriteLine("Server launched");
            Console.ReadLine();

        }
    }
}
