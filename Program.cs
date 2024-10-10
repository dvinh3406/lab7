internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("nhap mot so tu ban phim");
        int so = int.Parse(Console.ReadLine());
        switch (so)
        {
            case 2:
                 Console.WriteLine("thu 2");
                break;
             case 3:
                 Console.WriteLine("thu 3");
                break;
             case 4:
                 Console.WriteLine("thu 4");
                break;
             case 5:
                 Console.WriteLine("thu 5");
                break;
             case 6:
                 Console.WriteLine("thu 6");
                break;
             case 7:
                 Console.WriteLine("thu 7");
                break;
             case 8:
                 Console.WriteLine("CN");
                break;    
            default:
            Console.WriteLine("so vua nhap khong phai nam trong khoang can nhap");
                break;
        }
        
        {







        }
    }
}