using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构__线性表
{
    class SeqList<T> : IListDS<T>
    {
        T[] data;
        int count = 0;
        public T this[int index] => throw new NotImplementedException();
        public SeqList(int size)
        {
            data = new T[size];
            count = 0;
        }
        public SeqList():this(10)
        {

        }

        public void Add(T item)
        {
            if(count==data.Length)
            {
                Console.WriteLine("当前顺序表已经存满，不允许再存入！");
            }
            else{
                data[count]=item;
                count++;
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public T Delete(int index)
        {
            throw new NotImplementedException();
        }

        public T GetEle(int index)//索引
        {
            if(index>=0&&index<=count-1)
                {
              return data[index];
                }
            else{
                Console.Write("索引不存在");
                return default(T);
}
        }
        
        public int GetLength()
        {
            return count;
        }

        public void Insert(T item, int index)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            if(count==0) return true;
            else return false;
        }

        public int Locate(T value)
        {
            throw new NotImplementedException();
        }
    }
}
