using System;
using System.Collections.Generic;
using System.Text;

namespace Maru.Net.Models
{
    public abstract class Singleton<T>
        where T : Singleton<T>, new()
    {
        private static T Instance { get; set; }

        public T GetInstance()
        {
            if (Instance.Equals(null)) {
                return new T();
            } else {
                return Instance;
            }
        }
    }
}
