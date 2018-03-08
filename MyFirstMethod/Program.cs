using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAula04 {
    class MyClass {

        /// <summary>
        /// Metodo que conta ate 10
        /// </summary>
        static void CountTo10() {
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Metodo que conta de 1 a um nome definido no main
        /// </summary>
        /// <param name="n">Numero ate ao qual o metodo via contar</param>
        static void CountToN(int n) {
            for (int i = 1; i <= n; i++) {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Metodo main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            CountTo10();
            CountTo10();

            CountToN(5);
            CountToN(2);
        }

    }
}
