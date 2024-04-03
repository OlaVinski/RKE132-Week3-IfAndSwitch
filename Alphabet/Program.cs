// ALPHABET

char letter;
Console.WriteLine("Enter an alphabet");
letter = Convert.ToChar(Console.ReadLine().ToLower());

switch (letter)
{
    case 'a':
        Console.WriteLine("Vowel");
        break;
    case 'e':
        Console.WriteLine("Vowel");
        break;
    case 'i':
        Console.WriteLine("Vowel");
        break;
    case 'o':
        Console.WriteLine("Vowel");
        break;
    case 'u':
        Console.WriteLine("Vowel");
        break;
    default:
        Console.WriteLine("Not a vowel");
        break;
}