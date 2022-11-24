public class Program
{
    public static void Main(string[] args)
    {
        Queue<char> Q1 = new Queue<char>();
        char flower = 'a';
        char rose = 'b';
        int x = 0;
        int i = 0;
        Console.WriteLine("Input: ");
            while (flower == 'J' || flower == 'G' || flower == 'O' || flower == 'R' || flower == 'a')
            {
                flower = char.Parse(Console.ReadLine());
            if (flower == 'J')
            {
                if (flower != rose)
                {
                    Q1.Push('J');
                    x++;
                    rose = 'z';
                }
                else
                {
                    Console.WriteLine("Invalid patten");

                }
            }
            else if(flower == 'G')
            {
             
                    if(flower != rose)
                    {
                        rose = 'z';
                        Q1.Push('G');
                        x++;
                        i++;
                    }
                
                else if(i>3)
                {
                    Console.WriteLine("invalid patten");
                }
                else
                {
                    Console.Write("Invalid patten");
                }
            }
            else if (flower == 'O')
            {
                if(flower != rose)
                {
                    rose = 'x';
                    Q1.Push('O');
                    x++;
                }
                else
                {
                    Console.WriteLine("Invalid patten");
                }
            }
            else if(flower == 'R')
            {
                if(x == 0)
                {
                    Console.WriteLine("Invalid patten");
                }
                else
                {
                    rose = 'x';
                    Q1.Push('R');
                    rose= Q1.Get(Q1.GetLength()-2);
                    x++;    
                }
            }
        }
    int n = 0;
       while(n<Q1.GetLength())
        
            {    
                Console.Write("{0}",Q1.Get(n));
                n++;
            }
    }   
}