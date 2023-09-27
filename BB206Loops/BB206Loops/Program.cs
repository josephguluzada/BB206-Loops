namespace BB206Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-10a qeder cut ededlerin cemini tapan alqoritm

            #region Custom loop
            //var i = 1;

            //var sum = 0; // sum = 0  2+4+6+8

            //if (i % 2 == 0)
            //{
            //    sum += i;
            //}
            //i++;
            //if (i % 2 == 0)
            //{
            //    sum += i;
            //}
            //i++;
            //if (i % 2 == 0)
            //{
            //    sum += i;
            //}
            //i++;
            //if (i % 2 == 0)
            //{
            //    sum += i;
            //}
            //i++;
            //if (i % 2 == 0)
            //{
            //    sum += i;
            //}
            //i++;

            //Console.WriteLine("i: " + i + " " + "Sum: " + sum);
            #endregion

            #region While
            //var i = 1;

            //var sum = 0;

            //while (i < 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum = sum + i;
            //    }
            //    i++;
            //}

            //Console.WriteLine("Sum " + sum);
            #endregion

            #region For
            //var sum = 0;

            //for (int i = 1; i < 10; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        sum += i;
            //    }
            //}

            //Console.WriteLine("Sum: " + sum);
            #endregion

            #region Do-While
            //string name;

            //do
            //{
            //    Console.WriteLine("Adiniz daxil edin:");
            //    name = Console.ReadLine();
            //}
            //while (name.Length < 4);
            #endregion

            #region Continue
            //var i = 0;

            //while (i<=10)
            //{
            //    if(i == 5)
            //    {
            //        i++;
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}
            #endregion

            #region Break
            //var i = 0;

            //while (i < 10)
            //{
            //    if (i == 7)
            //    {
            //        Console.WriteLine("Tapdim seni " + i);
            //        i++;
            //        break;
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}
            #endregion
        }
    }
}