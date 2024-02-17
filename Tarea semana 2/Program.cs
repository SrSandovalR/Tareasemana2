

//1. Conversión de datos:
Console.WriteLine("CONVERSIONES DE DATOS: ");

int decimal1 = 123;
Console.WriteLine("Numero decimal: {0}", decimal1);


int float1 = 123;
float float1_float = (float)float1;
Console.WriteLine("Numero flotante: {0}", float1_float);


float entero1 = 123.45F;
int entero1_int = (int)entero1;
Console.WriteLine("Numero entero: {0}", entero1_int);


char letra = 'A';
int num1 = (int)letra;
Console.WriteLine("Numero entero: {0}", num1);


int num2 = 65;
char letra2 = (char)num2;
Console.WriteLine("Caracter: {0}", letra2);


Console.Read();
Console.Clear();


//2. Operaciones con tipos de datos:

Console.WriteLine("OPERACIONES CON TIPOS DE DATOS: ");



int suma1 = 5;
int suma11 = 3;
int suma = suma1 + suma11;
Console.WriteLine("La suma es: " + suma);


decimal resta1 = 5.5m;
decimal resta11 = 3.3m;
decimal resta = resta1 - resta11;
Console.WriteLine("La resta es: " + resta);



float numero1 = 5.5f;
float numero11 = 3.3f;
float multiplicacion = numero1 * numero11;
Console.WriteLine("La multiplicación es: " + multiplicacion);


int division1 = 10;
int division11 = 2;
int division = division1 / division11;
Console.WriteLine("La división es: " + division);


int numerodemodulo1 = 10;
int numerodemodulo2 = 3;
int modulo = numerodemodulo1 % numerodemodulo2;
Console.WriteLine("El módulo es: " + modulo);

Console.Read();
Console.ReadLine();
Console.Clear();




//3. Uso de char y string:


Console.WriteLine("USO DE CHAR Y STRING: ");

string mayuscula = "sandoval";
string resultado = mayuscula.ToUpper();
Console.WriteLine("Texto en mayúsculas: " + resultado);


Console.WriteLine(" ");

string minuscula = "SANDOVAL";
string resultadotexto = minuscula.ToLower();
Console.WriteLine("Texto en minúsculas: " + resultadotexto);

Console.WriteLine(" ");

string cadena = "Guatemala";
char[] array = cadena.ToCharArray();
Array.Reverse(array);
Console.WriteLine("Texto al revés: " + new string(array));

Console.WriteLine(" ");

Console.Write("Escribe una cadena de texto: ");
string texto = Console.ReadLine();
Console.Write("Escribe la palabra que quieres buscar: ");
string palabra = Console.ReadLine();

if (texto.Contains(palabra))
{
    Console.WriteLine(" ");
    Console.WriteLine("La palabra '" + palabra + "' se encuentra en el texto.");
}
else
{
    Console.WriteLine(" ");
    Console.WriteLine("La palabra '" + palabra + "' no se encuentra en el texto.");
}


Console.Read();
Console.ReadLine();
Console.Clear();

//4. Uso de tipos de datos numéricos:



Console.WriteLine("USO DE TIPOS DE DATOS NUMERICOS: ");

Console.WriteLine(" ");

double baseTriangulo = 5.0;
double alturaTriangulo = 10.0;
double area = (baseTriangulo * alturaTriangulo) / 2;
Console.WriteLine("El área del triángulo es: " + area);

Console.WriteLine(" ");

double radio = 3.0;
double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
Console.WriteLine("El volumen de la esfera es: " + volumen);

Console.WriteLine(" ");

double x1 = 1.0, y1 = 2.0;
double x2 = 4.0, y2 = 6.0;
double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("La distancia entre los dos puntos es: " + distancia);

Console.WriteLine(" ");

double celsius = 20.0;
double fahrenheit = (celsius * 9.0 / 5.0) + 32;
Console.WriteLine("La temperatura en grados Fahrenheit es: " + fahrenheit);

Console.WriteLine(" ");

double fahrenheit2 = 68.0;
double celsius2 = (fahrenheit2 - 32) * 5.0 / 9.0;
Console.WriteLine("La temperatura en grados Celsius es: " + celsius2);



Console.Read();
Console.ReadLine();
