using System.Formats.Asn1;
using ArvUppgift;

Console.WriteLine("Hej, vad vill du ha för form? 1 eller 2");
Console.WriteLine("1. Rektangle");
Console.WriteLine("2. Triangle");
string Num = Console.ReadLine();
switch(Num)
{
    case "1":
        Console.WriteLine("Rektangle");
        Console.WriteLine("Ange den höjd och bredd du vill ha");
        Rectangle r = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        
        Console.WriteLine("Vill du veta arean eller omkretsen?");
        Console.WriteLine("1. Area");
        Console.WriteLine("2. Omkrets");
        string Rnum = Console.ReadLine();
        switch(Rnum)
        {
            case "1":
                Console.WriteLine(r.Area());
                break;

            case "2":
                Console.WriteLine(r.Circumferance());;
                break;

            default:
                Console.WriteLine("Ange 1 eller 2");
                break;
        }
        break;
    
        case "2":
        Console.WriteLine("Triangle");
        Console.WriteLine("Ange den höjd och bredd du vill ha");
        Triangle t = new Triangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        
        Console.WriteLine("Vill du veta arean eller omkretsen?");
        Console.WriteLine("1. Area");
        Console.WriteLine("2. Omkrets");
        string Tnum = Console.ReadLine();
        switch(Tnum)
        {
            case "1":
                Console.WriteLine(t.Area());
                break;

            case "2":
                Console.WriteLine(t.Circumferance());
                break;
                
            default:
                Console.WriteLine("Ange 1 eller 2");
                break;
        }
        break;
        
        default:
                Console.WriteLine("Ange 1 eller 2");
                break;
    
}