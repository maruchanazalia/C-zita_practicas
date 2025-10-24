using System;
class Prueba
{
    enum Estado { amor, odio }
    static void Main(String[] args)
    {
        Console.WriteLine("Bienvenido a aprender con la concha de tu madre zandy");
        Console.WriteLine("que esta harta de todo y me la paso aqui haciendo mmds");

        Console.WriteLine("pruebita");


        //Tipos de datos se dividen en dos 
        // tipos de valor y tipos de referencia 
        // ahora veremos los ejemplos y declaraciones 


        //tipos de valor 
        int edad = 21; //32 bits
        long dineroDeseado = 777777777777777; //entero largo 64 bits
        short añoDondeMeMadrearon = 2025; //16 bits
        byte efectivo = 200;
        float calificacionE = 6.45F;
        double salario = 12377.5;
        decimal number = 7.77m;
        bool esDev = true;
        char miVato = 'E';

        // Tipos de referencia
        string migajera = "zandy";
        object yo = 3;
        dynamic x = "hola"; x = 5;
        //arrays
        int[] numeros = { 1, 2, 3 };

        //Tipos especiales
        int? puntos = null;

        DateTime hoy = DateTime.Now;


        Console.WriteLine("Mi name:"+ migajera + " edad: "+ edad);



    }
}
