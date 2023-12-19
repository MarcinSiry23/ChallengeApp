int[] counter = new int[10];
counter[0] = 0;
counter[1] = 0;
counter[2] = 0;
counter[3] = 0;
counter[4] = 0;
counter[5] = 0;
counter[6] = 0;
counter[7] = 0;
counter[8] = 0;
counter[9] = 0;

Console.WriteLine("Podaj liczbę: ");
var number = Console.ReadLine();
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

foreach (var letter in letters)
{
    if (letter == '0')
    {
        counter[0]++;
    }
    else if (letter == '1')
    {
        counter[1]++;
    }
    else if (letter == '2')
    {
        counter[2]++;
    }
    else if (letter == '3')
    {
        counter[3]++;
    }
    else if (letter == '4')
    {
        counter[4]++;
    }
    else if (letter == '5')
    {
        counter[5]++;
    }
    else if (letter == '6')
    {
        counter[6]++;
    }
    else if (letter == '7')
    {
        counter[7]++;
    }
    else if (letter == '8')
    {
        counter[8]++;
    }
    else if (letter == '9')
    {
        counter[9]++;
    }
}

Console.WriteLine("0 => " + counter[0]);
Console.WriteLine("1 => " + counter[1]);
Console.WriteLine("2 => " + counter[2]);
Console.WriteLine("3 => " + counter[3]);
Console.WriteLine("4 => " + counter[4]);
Console.WriteLine("5 => " + counter[5]);
Console.WriteLine("6 => " + counter[6]);
Console.WriteLine("7 => " + counter[7]);
Console.WriteLine("8 => " + counter[8]);
Console.WriteLine("9 => " + counter[9]);