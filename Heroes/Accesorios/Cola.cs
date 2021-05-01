using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Accesorios
{
    public class Cola<T>
    {
        private List<T> cola;

        public Cola() {
            cola = new List<T>();
        }

        public void encolar(T t) {
            cola.Add(t);
        }

        public T desencola() {
            T aux = cola[0];
            cola.RemoveAt(0);
            return aux;
        }

        public bool isEmpty() {
            return (cola.Count == 0) ;
        }
    }
}
