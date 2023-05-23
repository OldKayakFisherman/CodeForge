// See https://aka.ms/new-console-template for more information
using CommonLib;


int numberOfNonces = 7;

for (int i = 0; i < numberOfNonces; i++)
{
    Console.WriteLine(RandomUtility.GenerateRandomNonce());    
}

Console.ReadLine();
