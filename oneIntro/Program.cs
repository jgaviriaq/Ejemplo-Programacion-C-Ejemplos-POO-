using System; //usando una Libreria generica

namespace oneIntro //   espacio del nombre (carpeta del proyecto)
{
    class Program // el archivo donde estoy codificando alguan funcionalidad especifica
    {
        
        //Atributos (propiedades)
        //color,marca,placa,modelo,etc


        //Métodos (Funciones)
        // arrancar,acelerar,frenar,etc
        
        static void Main(string[] args) //metodo
        {
            Console.WriteLine("Hola a todos,como van pues"); //instrucciones,pasos,tareas,actividades

            Console.WriteLine("Numero uno");
            int numUno = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Numero dos");
            int numDos = int.Parse(Console.ReadLine());

             /*   
            //Forma Estructurada

            //Console.WriteLine("El número es : " + numUno);
            //Console.WriteLine($"El número es :  {numUno}");

            int suma = numUno + numDos;

            Console.WriteLine($"La suma de :  {numUno} y {numDos} es {suma}");


            //Console.WriteLine($"La suma de {numero1} y {numero2} es {suma}");

            */

                //Forma orientada a objetos 

                //Instanciar la class Operaciones (objeto   de la class operaciones)

                //class      objeto(instancia) (= new son palabras reservadas)  constructorDeLaClass     
                //Operaciones myOperation = new Operaciones()
                var   myOperation = new Operaciones() {
                       numeroUno = numUno,
                       numeroDos = numDos   
                };


                // verificar(mostrar) el valor que tiene almacenado la propiedad
                    Console.WriteLine(myOperation.numeroUno);


                //Llevar el valor como parametro a un metodo
                //Para hacer esto debo llamar el metodo de la clase mediante su instancia(un objeto)


                   // myOperation.nuestraSuma(myOperation.numeroUno, myOperation.numeroDos); ojoooooooooooooo


               // myOperation.nuestraSuma(myOperation.numeroUno, myOperation.numeroDos);
                    myOperation.imprimirSuma();


        }
    }



}
