using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAula04 {
    class MyClass {

        static void CountTo10() {
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(i);
            }
        }

        static void CountToN(int n) {
            for (int i = 1; i <= n; i++) {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args) {
            CountTo10();
            CountTo10();

            CountToN(5);
            CountToN(2);
        }

    }
}
