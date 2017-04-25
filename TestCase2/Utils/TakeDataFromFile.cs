using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using TestCase2.Models;
using System.Web;

namespace TestCase2.Utils
{
    public class TakeDataFromFile
    {
        private string _FilePath;
        public TakeDataFromFile(string fPath)
        {
            _FilePath = fPath;
        }
        public List<MyPoint> TakePoints()
        {
            List<MyPoint> list = new List<MyPoint>();
            StreamReader sReader = new StreamReader(_FilePath);
            string line;
            while ((line = sReader.ReadLine()) != null)
            {
                MyPoint p = new MyPoint();
                p.X = int.Parse(line.Split(';')[0]);
                p.Y = int.Parse(line.Split(';')[1]);
                list.Add(p);
            }
            sReader.Close();
            return list;
        }
    }
}