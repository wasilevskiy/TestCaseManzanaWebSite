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
            MyPoint minPoint = GetMinPoint();
            double[] array = new double[_Data.Count];
            int c = 0;
            foreach (MyPoint p in _Data)
            {
                array[c] = Math.Atan2(GetKatetY(minPoint, p), GetKatetX(minPoint, p));
                c++;
            }
            Sort(ref _Data, array);
            return _Data;
        }

        private void Sort(ref List<MyPoint> list, double[] array)
        {
            double tempArr;
            MyPoint tempPoint;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        tempArr = array[i];
                        array[i] = array[j];
                        array[j] = tempArr;
                        tempPoint = list[i];
                        list[i] = list[j];
                        list[j] = tempPoint;
                    }
                }
            }
        }
        private MyPoint GetMinPoint()
        {
            int min = _Data[0].X;
            int index = 0;
            for (int i = 0; i < _Data.Count; i++)
            {
                if (min > _Data[i].X)
                {
                    min = _Data[i].X;
                    index = i;
                }
            }
            return _Data[index];
        }
        private int GetKatetY(MyPoint minPoint, MyPoint p)
        {
            return (p.Y - minPoint.Y);
        }
        private int GetKatetX(MyPoint minPoint, MyPoint p)
        {
            return (p.X - minPoint.X);
        }

    }
}