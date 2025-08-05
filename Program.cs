// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola desde Visual Studio Code y .NET");


Console.WriteLine("Ejercicio 1 - ¿Cual es tu nombre? ");
Console.Write("¿Cuál es tu nombre? ");
string nombre = Console.ReadLine();
Console.WriteLine($"Hola, {nombre}, ¡bienvenido a .NET!");

Console.WriteLine("Ejercicio 2 - Suma de dos números");
Console.Write("Ingresa el primer número: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Ingresa el segundo número: ");
int num2 = int.Parse(Console.ReadLine());
int suma = num1 + num2;
Console.WriteLine($"La suma es: {suma}");
