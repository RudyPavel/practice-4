int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

while (number > 0)
{
    int ostatok = number % 10;
    
    result += ostatok;
    
    number = number / 10;
}

Console.WriteLine(result);