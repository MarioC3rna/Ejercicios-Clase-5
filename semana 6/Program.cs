using System.Reflection.Emit;

static void Suma()
{
    //Ejercicio 1
    int Num1, Num2, Resul = 0;

    Console.WriteLine("Ingrese N1");
    Num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese N2");
    Num2 = Convert.ToInt32(Console.ReadLine());

    Resul = Num1 + Num2;
}

static int Sumatoria(int Num1, int Num2, int Num3)
{
    int Resul = 0;
    Resul = Num1 + Num2 + Num3;
    return Resul;

}

static string dato()
{
    // Ejercicio 2
    string Nom;
    Console.WriteLine("Ingrese nombre");
    Nom = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Saludos " + Nom);
    return dato;

}
static void Edad()
{
    //Ejercicio 3
    int Edad, Año;
    Console.WriteLine("Ingresa su año de nacimiento");
    Año = Convert.ToInt32(Console.ReadLine());
    Edad = 2024 - Año;
    Console.WriteLine("Su edad es:" + Edad);
}

do
{
    Console.WriteLine("Suma ----------> 1");
    Console.WriteLine("Nombre --------> 2");
    Console.WriteLine("Edad ----------> 3");
    Console.WriteLine("Salida --------> 3");
    int Opc = Convert.ToInt32(Console.ReadLine());
} switch (opc);

}
Suma();
Nombre();
Edad();

int promedio = Sumatoria(20, 25, 40) / 3;
Console.WriteLine("Promedio = " + promedio);

string nombre = dato();
Console.WriteLine("este es su nombre" + dato);



//-----------------------------------------------------------------------------------------

int num;
int max = int.MinValue;
int min = 0;
Console.WriteLine("Ingrese valores --Ingrese 0 para finalizar---");
do
{
    Console.Write("Ingrese un número: ");
    num = int.Parse(Console.ReadLine());

    if (num != 0)
    {

        if (num > max)
        {
            min = num;
        }
        if (num < min)
        {
            min = num;
        }
    }
} while (num != 0);

Console.WriteLine("El mayor es " + max);
Console.WriteLine("El menor es " + min);
Console.ReadLine();

//--------------------------------------------------------------------------------

//ADIVNA EL NUMERO

Console.WriteLine("Piensa en un número");

Console.Write("Ingresa un Numero");
int numero= int.Parse(Console.ReadLine());

Console.WriteLine("Multiplica tu numero por 2");
int Resul = numero * 2;

Console.WriteLine("Ahora sumale 8");
    Resul += 8;

Console.WriteLine("Ahora por 5");
Resul *= 5;

Console.Write("Dime el resultado final ");
int rFinal = int.Parse(Console.ReadLine());

string ResultadoF2= rFinal.ToString();
ResultadoF2 = ResultadoF2.Substring(0, ResultadoF2.Length - 1);

rFinal = int.Parse(ResultadoF2) - 4;

Console.WriteLine("Este es el numero que pensaste " + rFinal+"?");


//-----------------------------------------------------------------------------------------

//CONTADOR DE PALABRAS 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese alguna frase ");
        string frase = Console.ReadLine();

        Console.WriteLine("Esta es la frase que ingreso  " + frase);

        int CPalabras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        int CVocales = ContarVocales(frase);

        Console.WriteLine("El numero de palabras es " + CPalabras);
        Console.WriteLine("El numero de vocales es" + CVocales);
    }
    static int ContarVocales(string frase)
    {
        int contador = 0;
        foreach (char c in frase.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                contador++;
            }
        }
        return contador;
    }
}

//--------------------------------------------------------------------------------------------------


//Palindromos
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una palabra ");
        string palabra = Console.ReadLine().ToLower();

        bool esPalindromo = true;

        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - 1 - i])
            {
                esPalindromo = false;
                break;
            }
        }

        if (esPalindromo)
        {
            Console.WriteLine("La palabra es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra no es un palíndromo.");
        }
    }
}
