﻿// See https://aka.ms/new-console-template for more information

int mount = DateTime.Now.Month;

switch (mount)
{
    case 1:
        Console.WriteLine("Ocak ayındasınız");
        break;
    case 2:
        Console.WriteLine("Şubat ayındasınız");
        break;
    case 4:
        Console.WriteLine("Nisan ayındasınız");
        break;
    case 3:
        Console.WriteLine("Mart ayındasınız");
        break;
    default:
    break;
}

switch (mount)
{   
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış mevsimindesiniz.");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar mevsimindesiniz.");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz mevsimindesiniz.");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar mevsimindesiniz.");
        break;
    default:
    break;
}
