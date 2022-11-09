using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamPrepExercise8RemotableObject;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace ExamPrepExercise8Client
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ExamPrepExercise8RemotableObject.RemoteClass rc;

            rc = (ExamPrepExercise8RemotableObject.RemoteClass)Activator.GetObject
                (typeof(ExamPrepExercise8RemotableObject.RemoteClass), "tcp://localhost:1234/ExamPrepExercise8RemotableObject");

            rc = new ExamPrepExercise8RemotableObject.RemoteClass();

            Console.WriteLine("Press any key to read the contents from a file...");
            Console.ReadLine();

           
            Console.Write(rc.Read());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to terminate the application...");
            Console.ReadLine();

        }
    }
}
