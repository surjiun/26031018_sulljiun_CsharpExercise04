namespace _26031018_sulljiun_0923
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04-16
            if(true)
            {
                Console.WriteLine("1~ 100까지 짝수 출력");
                for (var i = 1; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.WriteLine();

            //04-17
            if (true)
            {
                Console.WriteLine("0~10까지 숫자 출력(for문 사용)");
                var i = 0;
                while(i<=10)
                {
                    Console.WriteLine($"{i}");
                    ++i;
                }
                
            }
            Console.WriteLine();

            //04-18
            if (true)
            {
                Console.WriteLine("0~10까지 숫자 출력(do-while문 사용)");
                var i = 0;
                do
                {
                    Console.WriteLine($"{i}");
                    ++i;
                } while (i <= 10);

            }
            Console.WriteLine();

            //04-19
            if (true)
            {
                Console.WriteLine("예시 이미지대로 출력");
                for (var i = 0; i < 8; i++)
                {
                    for (var j = 0; j < 7 - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (var j = 0; j < i * 2 + 1; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            //04-20
            if (true)
            {
                Console.WriteLine("숫자 5개 입력 받은 후 가장 큰 수와 가장 작은 수 출력 출력");
                int[] intarray = new int[5];
                

                for (var i = 0;i < intarray.Length;i++)
                {
                    intarray[i] = Int32.Parse(Console.ReadLine());

                }
                var max_value = intarray[0];
                var min_value = intarray[0];

                for (var i = 1; i < intarray.Length; i++)
                {
                    if (intarray[i] > max_value)
                    {
                        max_value = intarray[i];
                    }

                    if (intarray[i] < min_value)
                    {
                        min_value = intarray[i];
                    }
                }
                Console.WriteLine($"가장 큰 수 : {max_value}");
                Console.WriteLine($"가장 작은 수 : {min_value}");
            }


        }
    }
}
