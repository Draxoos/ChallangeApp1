int number = 2137274;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

Console.WriteLine("Wyniki dla liczby" + numberInString);

foreach (char num in numbers)
{
    var counter = 0;

    foreach (char let in letters)
    {
        if (num == let)
        {
            counter++;
        }
    }
    Console.WriteLine(num + " = " + counter);
}
