using System;

Random rand = new Random();
int so = 0;

Console.WriteLine("Truong hop  1 : ");
for( int i = 0; i < 10; i++)
{
    so = rand.Next();
    Console.WriteLine("So ngau nhien la : {0} ", so);
}

Console.WriteLine("Truong hop  2 : ");
for ( int i = 0; i < 10; i++)
{
    so = rand.Next(5);
    Console.WriteLine("So ngau nhien la : {0} ", so);
}

Console.WriteLine("Truong hop  3 : ");
for (int i = 0; i < 10; i++)
{
    so = rand.Next(-10 , 5);
    Console.WriteLine("So ngau nhien la : {0}", so);
}
