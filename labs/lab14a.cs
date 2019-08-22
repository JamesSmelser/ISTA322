// Name: C# Lab14a
// Author: James Smelser
// Date: August 12, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Calculator : IDisposable
    {
        private bool disposed = false;
        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }
        public int Divide(int first, int second)
        {
            return first / second;
        }
        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            this.Dispose();
        }
        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine("Calculator being disposed");
            }
            disposed = true;
            GC.SuppressFinalize(this);
        }
        //public void Dispose()
        //{
        //    Console.WriteLine("Calculator being disposed");
        //}
    }
}
