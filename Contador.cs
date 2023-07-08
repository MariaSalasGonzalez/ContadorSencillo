// Universidad Nacional / Escuela de Informatica
// EIF-206 Programacion III / Quiz 1
// Academico: Walter Leon Chavarria / Estudiante: Maria Salas Gonzalez
// I Ciclo 2020

using System;
namespace c1{
    public class Contador{
        public void contadorMultiplo(){
        int n, contador;
        Console.WriteLine(); 
        Console.WriteLine("A continuacion digite un numero, el cual se imprimira desde el numero 1 hasta el numero deseado.");
        Console.Write("Numero -> ");
        Console.Write(" ");
        n = Convert.ToInt32(Console.ReadLine());
        contador = 1;
            while (contador <= n){
            Console.WriteLine("Numero: " + contador);
            contador = contador + 1;
                if (contador % 3 == 0) {
                Console.WriteLine("El numero " + contador + " es multiplo 3");
                }
            }
        }
    }
}