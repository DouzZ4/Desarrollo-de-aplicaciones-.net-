// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola desde Visual Studio Code y .NET");


Console.WriteLine("Ejercicio 1 - ¿Cual es tu nombre? ");
Console.WriteLine("Modifica el programa para que solicite al usuario su nombre y luego le salude.");
Console.Write("¿Cuál es tu nombre? ");
string nombre = Console.ReadLine();
Console.WriteLine($"Hola, {nombre}, ¡bienvenido a .NET!");


Console.WriteLine("Ejercicio 2 - Suma de dos números");
Console.WriteLine("Escribe un programa para que solicite al usuario dos números y luego muestre su suma.");
Console.Write("Ingresa el primer número: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Ingresa el segundo número: ");
int num2 = int.Parse(Console.ReadLine());
int suma = num1 + num2;
Console.WriteLine($"La suma es: {suma}");


Console.WriteLine("Ejercicio 3 - Verificar si un número es par o impar");
Console.Write("Ingresa un número: ");
int numero = int.Parse(Console.ReadLine());
if (numero % 2 == 0)
{
    Console.WriteLine($"El número {numero} es par.");
}
else
{
    Console.WriteLine($"El número {numero} es impar.");
}


Console.WriteLine("Ejercicio 4 - programa solicitud datos de usuario");
Console.WriteLine("Escribe un programa que solicite al usuario su nombre completo y número de cédula, y luego muestre un mensaje con esos datos.");
Console.Write("Nombre completo: ");
string nombre2 = Console.ReadLine();
Console.Write("Numero de cedula: ");
int cedula = int.Parse(Console.ReadLine());
Console.Write("Correo electrónico: ");
string correo = Console.ReadLine();
Console.WriteLine($"Nombre: {nombre2} \nNúmero de cédula: {cedula} \n Correo electrónico: {correo}.");