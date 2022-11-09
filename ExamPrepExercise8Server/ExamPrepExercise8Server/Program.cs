using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp; //REMEMBER THE DEBUG/BIN REMOTABLE OBJECT REFERENCE
using ExamPrepExercise8RemotableObject;

namespace ExamPrepExercise8Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel chan = new TcpChannel(1234);
            ChannelServices.RegisterChannel(chan,true);

            RemotingConfiguration.RegisterWellKnownServiceType(System.Type.GetType("ExamPrepExercise8RemotableObject.RemoteClass, ExamPrepExercise8RemotableObject"), "RemoteTest", WellKnownObjectMode.SingleCall);

            Console.WriteLine("Server has started in SingleCall mode on port 1234...");
            Console.WriteLine("Press <ENTER> to terminate the server...");
            Console.ReadLine();
        }
    }
}
