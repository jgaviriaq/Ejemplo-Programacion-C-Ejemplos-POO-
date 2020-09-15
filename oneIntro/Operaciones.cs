using System;

namespace oneIntro //   espacio del nombre (carpeta del proyecto)
{

        class Operaciones // el archivo donde estoy codificando alguan funcionalidad especifica
        {
                //Atributos(propiedades)
                public                                             int          numeroUno                   { get; set;}
              //modificador de acceso(agente identificador)     tipo dato       nombrePropiedad(atributo)   metodos para recibir(set) y para entregar (get) el valor de la propiedad

                public int numeroDos {get; set;}


                //Metodos(funciones)    
               /* public                      void         nuestraSuma(int n1, int n2)
                {   
               //modificador de acceso   tipo retorno   nombre del Metodo  (args o parametros)     
                    int suma = n1  + n2;
                    Console.WriteLine($"La suma de {n1 } y {n2} es {suma}");
                }*/

                // separar responsabilidades en los métodos        

                public int calcularSuma(int n1, int n2)
                {
                      int resultadoSuma = 0;

                      resultadoSuma = n1 + n2;

                      return resultadoSuma;          
                }    

                public void imprimirSuma()
                {
                         Console.WriteLine("La suma es "+ calcularSuma(numeroUno, numeroDos));

                }    

        }


}