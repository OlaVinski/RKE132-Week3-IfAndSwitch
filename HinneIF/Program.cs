// HINNE IF

char letter;
Console.WriteLine("Mis hinde said?");
letter = Convert.ToChar(Console.ReadLine().ToUpper());

if (letter == 'A')
{
    Console.WriteLine("Suurepärane!");
}
else if (letter == 'B')
{
    Console.WriteLine("Väha hea!");
}
else if (letter == 'C')
{
    Console.WriteLine("Hea!");
}
else if (letter == 'D')
{
    Console.WriteLine("Rahuldav");
}
else if (letter == 'E')
{
    Console.WriteLine("Kasin");
}
else if (letter == 'F')
{
    Console.WriteLine("Puudulik");
}
else
{
    Console.WriteLine("vale väärtus");
}
