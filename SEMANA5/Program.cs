Console.WriteLine("BIENVENIDO.");
Console.WriteLine("Ingresa numeros enteros en cada apartado.");

Console.WriteLine("-------------------------");
Console.WriteLine("Ingresa tu primer numero:");
string n0 = Console.ReadLine();
int da1  = Convert.ToInt32(n0);

Console.WriteLine("-------------------------");

Console.WriteLine("Ingresa tu segundo numero:");
string n1 = Console.ReadLine();
int da2 = Convert.ToInt32(n1);
Console.WriteLine("-------------------------");
Console.WriteLine("Los numeros pares entre "+n0+" y "+n1+" son:");

for(int indice = da1; indice< da2; indice++)
{
    if (indice %  2 == 0 )
    {
        Console.WriteLine("");
        Console.WriteLine(indice);
        

    }

}
Console.WriteLine("Adios");

