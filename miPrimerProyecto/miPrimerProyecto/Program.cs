﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerProyecto {
    internal class Program {
        static void Main(string[] args) {
            //Uso de matrices.
            int[,] matriz = new int[,] {
                {5,4,5,2,1},
                {1,2,8,9,3}
            };
            for (int i = 0;i<2; i++) {
                for (int j = 0;j<5; j++) {
                    Console.Write("{0} ",matriz[i,j]);
                }
                Console.WriteLine("\n");
            }
            //Pausa
            Console.ReadKey();
        }
    }
}
