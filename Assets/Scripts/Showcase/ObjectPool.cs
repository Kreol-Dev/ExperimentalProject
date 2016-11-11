using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ObjectPool<T> where T : new()
{
    Stack<T> pool = new Stack<T>();
    public bool HasFreeObjects {  get { return pool.Count > 0; } }
    public T Get()
    {
        if (pool.Count > 0)
            return pool.Pop();
        else
            return new T();
    }
    

    public void Return(T obj)
    {
        pool.Push(obj);
    }
}