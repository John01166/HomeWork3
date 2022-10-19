


// int  x = System.Console.ReadLine();

// for (x=0; x>0; x++)
// {
//     num[i] = x%10;
//     x = x/10;
// }

// System.Console.WriteLine(num);

int result = 0;
int  x = Convert.ToInt32(System.Console.ReadLine());
int x1 = x;
while (x1 >0)
{
    result = result *10 +x1%10;
    x1/=10;
}
System.Console.WriteLine(result);
if (result == x)  
    System.Console.WriteLine($"Число {result} является зеркальным");
else 
    System.Console.WriteLine($"Число {result} не является зеркальным");
