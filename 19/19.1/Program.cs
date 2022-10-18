
string Polindrome()
{
    System.Console.Write("Введите число:");
    string number = System.Console.ReadLine();
    string result = $"Число {number} является полиндромом";

    int[] array = new int[number.Length];
    for (int i = 0; i<number.Length;i++)
    {

        array[i] = Convert.ToInt32(number.Substring(i,1));
    }

    int [] revers = new int [array.Length];
    for (int i = 0; i < revers.Length; i++)
    {
        revers[i] = array[array.Length -1 - i];
    }

    bool find = false;
    for (int i=0; i<array.Length; i++)
        if (array[i] != revers[i])
        {
            find = true;
            break;
        }
    
    if (find)
        result = $"Число {number} не является полиндромом";
    return result;
}