using System;
using System.Collections.Generic;

namespace Aula5 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine(  );
            List<int> lista = new List<int>();
            lista.Add(1 * 2);
            lista.Add(1 * 3);
            foreach(int obj in lista) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Lista concluida");
        }
    }
}
