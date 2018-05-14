﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Classes
{
    class reestablish
    {
        public reestablish()
        {
            Test("SaveInfo/Work.SAVE","|");
            Test("SaveInfo/Logs.SAVE", "");
            Test("SaveInfo/Save.SAVE", "");
            Test("SaveInfo/SaveD.SAVE", "1");
        }

        private void Test(string path,string write)
        {
            if (!File.Exists(path))
            {
                StreamWriter file = new StreamWriter(path);
                file.Write(write);
            }
        }
    }
}