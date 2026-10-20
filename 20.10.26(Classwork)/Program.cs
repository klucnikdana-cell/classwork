namespace _20._10._26_Classwork_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point { X = 10,Y = 10  }; // 1 and 2
            /*Console.WriteLine(p);
            p++;
            Console.WriteLine(p);
            p--;
            Console.WriteLine(p);*/ //11

            /*Point p2 = new Point {X = 20,Y = 20};
            Vector v1 = new Vector(p1,p2);
            Vector v2 = new Vector { X = 2, Y = 3 };
            Console.WriteLine($"\tVectors:\n{v1}\n{v2}");
            Console.WriteLine($"Add:\n{v1 + v2}\n");
            Console.WriteLine($"Minus:\n{v1 - v2}\n");
            Console.WriteLine($"Multy:\n{v1 * 10}\n");
            v1 *= 3;
            Console.WriteLine($"Multy: {v1} \n");*/ // 22






            Journal j1 = new Journal("News", 10);
            Journal j2 = new Journal("Sport", 15);

            Console.WriteLine(j1);
            Console.WriteLine(j2);

            j1 = j1 + 5;
            Console.WriteLine("Add: " + j1);

            j1 = j1 - 3;
            Console.WriteLine("Minus: " + j1);

            Console.WriteLine(j1 == j2);
            Console.WriteLine(j1 != j2);
            Console.WriteLine(j1 < j2);
            Console.WriteLine(j1 > j2);

        }
    }
}
