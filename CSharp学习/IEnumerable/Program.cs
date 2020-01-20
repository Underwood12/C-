using System;
using System.Collections.Generic;
using System.Collections;

namespace IEnumerableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strList = new string[] { "1", "5", "7", "2", "4", "8", "3" };
            MyIenumerable my = new MyIenumerable(strList);
            var test = my.GetEnumerator();
            while (test.MoveNext())
            {
                Console.WriteLine(test.Current);
            }
            Console.ReadLine();
        }
    }
    public class MyIenumerable : IEnumerable
    {
        string[] strList;
        public MyIenumerable(string[] _strList)
        {
            strList = _strList;
        }
        public IEnumerator GetEnumerator()
        {
            return new MyIEnumerator(strList);
        }
    }

    public class MyIEnumerator : IEnumerator
    {
        string[] strList;
        int position;
        public MyIEnumerator(string[] _StrList)
        {
            strList = _StrList;
            position=-1;
        }
        public object Current
        {
            get
            {
               return  strList[position];
            }
        }

        public bool MoveNext()
        {
            position++;
            if (position < strList.Length) return true;
            else return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
