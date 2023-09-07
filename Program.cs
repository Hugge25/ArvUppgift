using System.Formats.Asn1;
using ArvUppgift;


static void TG(string text)
{
    foreach(char c in text)
    {
        Console.Write(c);
        Thread.Sleep(50);
    }
    Console.WriteLine();
}

static void TGS(string text)
{
    foreach(char c in text)
    {
        Console.Write(c);
        Thread.Sleep(200);
    }
    Console.WriteLine();
}

TG("Hej, vad vill du ha för form? 1 eller 2");
Console.WriteLine("1. Rektangle");
Thread.Sleep(500);
Console.WriteLine("2. Triangle");
Console.WriteLine("3. Stäng av programmet");
string Num = Console.ReadLine();
while(Num != "3")
{
    switch(Num)
    {
        case "1":
            Console.WriteLine("Rektangle");
            TG("Ange den höjd och bredd du vill ha");
            Rectangle r = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            
            Console.WriteLine("Vill du veta arean eller omkretsen?");
            TGS("1. Area");
            TGS("2. Omkrets");
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
                    TGS("Ange 1 eller 2");
                    break;
            }
            break;
        
        case "2":
            Console.WriteLine("Triangle");
            TG("Ange den höjd och bredd du vill ha");
            Triangle t = new Triangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            
            Console.WriteLine("Vill du veta arean eller omkretsen?");
            TGS("1. Area");
            TGS("2. Omkrets");
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
                    TGS("Ange 1 eller 2");
                    break;
            }
            break;
        
        case "3":
            TG("Stänger av programmet");
            TGS("...");
            break;

        default:
            TGS("Ange 1 eller 2");
            break;
        
    }

}

