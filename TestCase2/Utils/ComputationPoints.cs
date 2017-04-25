using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestCase2.Models;

namespace TestCase2.Utils
{
    public class ComputationPoints
    {
        private List<MyPoint> _Data;

        public ComputationPoints(List<MyPoint> Data)
        {
            _Data = Data;
        }

        public List<MyPoint> Compute()
        {
            int count = 0;
            SortPoint(_Data);
            foreach(MyPoint p in _Data)
            {
                p.Index = count.ToString();
                count++;
            }
            return _Data;
        }
        private void SortirovkaOnX(List<MyPoint> list)
        {
            MyPoint temp;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].X > list[j].X)
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
        private void SortirovkaOnY(List<MyPoint> list)
        {
            MyPoint temp;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].X == list[j].X)
                    {
                        if (list[i].Y > list[j].Y)
                        {
                            temp = list[i];
                            list[i] = list[j];
                            list[j] = temp;
                        }
                    }
                }
            }
        }
        private void SortPoint(List<MyPoint> list)
        {
            SortirovkaOnX(list);
            SortirovkaOnY(list);
        }

    }
}