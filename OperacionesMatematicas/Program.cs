//Ingresar por pantalla 2 números y calcular las 4 operaciones aritméticas con dichos números.
//Imprimir en pantalla el resultado de cada operación  

int num1, num2, sum, rest;
double prod, coc;

Console.WriteLine("Ingresa el primer número");

num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa el segundo número diferente de 0");
num2 = Convert.ToInt32(Console.ReadLine());

sum = num1 + num2;
rest = num1 - num2;
prod = num1 * num2;
coc = num1 / num2;

Console.WriteLine("La suma de " + num1 + " + " + num2 + " = " + sum);
Console.WriteLine("La resta de " + num1 + " - " + num2 + " = " + rest);
Console.WriteLine("La Multiplicación de " + num1 + " x " + num2 + " = " + prod);
Console.WriteLine("La división de " + num1 + " / " + num2 + " = " + coc);