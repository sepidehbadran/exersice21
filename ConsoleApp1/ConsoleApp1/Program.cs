// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter the num");
int n = Convert.ToInt32(Console.ReadLine());

int f1 = 1;

int f2 = 1;

int f3 = 1;

int counter = 2;
 while(counter < n)
{
    f3 = f1 + f2;
    counter++;
    f1 = f2;
    f2 = f3;
}
Console.WriteLine(f3);
















