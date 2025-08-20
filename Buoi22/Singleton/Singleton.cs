using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhCsharp.Buoi22.Singleton
{
    public class Singleton<T> where T : class
    {
        private static readonly Lazy<T> _instance = new Lazy<T>(() => new T());

        // Private constructor to prevent instantiation
        private Singleton() { }

        // Public method to get the single instance of the class
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Singleton instance is working!");
        }
    }
}
