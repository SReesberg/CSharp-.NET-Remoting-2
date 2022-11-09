using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrepExercise8RemotableObject
{
    public class RemoteClass: MarshalByRefObject    //REMEMBER TO INHERIT THIS
    {
        public RemoteClass()
        {

        }
        public string Read()
        {
            string path = @"..\..\Files\file.txt";

            FileStream fs = new FileStream(path, FileMode.Open);
            BufferedStream bs = new BufferedStream(fs);
            StreamReader sr = new StreamReader(bs);

           string content = sr.ReadToEnd();

            return content;


        }
    }
}
