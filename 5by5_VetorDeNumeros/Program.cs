/*  Faça um programa que leia 10 numeros inteiros e imprima os seguintes itens:
		a) somente os valores pares
		b) somente os valores impares
		c) somente a primeira e a ultima posição
*/

int[] numeros = new int[10];
int[] pares = new int[10], impares = new int[10];
int contPares = 0, contImpares = 0;
int option;

do
{
    Console.WriteLine("Digite 10 numeros:");
    for (int i = 0; i < 10; i++)
    {
        numeros[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < 10; i++)
    {
        if (numeros[i] % 2 == 0)
        {
            pares[contPares] = numeros[i];
            contPares++;
        }
        else
        {
            impares[contImpares] = numeros[i];
            contImpares++;
        }
    }

    Console.WriteLine("\nNúmeros pares");
    for (int i = 0; i < contPares; i++)
    {
        Console.Write(pares[i] + " ");
    }

    Console.WriteLine("\n\nNúmeros impares");
    for (int i = 0; i < contImpares; i++)
    {
        Console.Write(impares[i] + " ");
    }

    Console.WriteLine("\n\nPrimeiro valor:");
    Console.WriteLine(numeros[0]);

    Console.WriteLine("\nÚltimo valor:");
    Console.WriteLine(numeros[9]);

    do
    {
        Console.WriteLine("\n\nDeseja sair do programa?");
        Console.WriteLine("1 - Sair");
        Console.WriteLine("2 - Continuar");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);
} while(option == 2);
