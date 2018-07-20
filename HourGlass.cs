using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codejam4
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter size of Matrix(>=3)");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size >= 3)
            {
                int[,] array = new int[size, size];
                Console.WriteLine("Enter Elements:");
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        array[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                int result = hourglassSum(array, size);
                Console.WriteLine("Maximum Sum= " + result);
            }
            else
            {
                Console.WriteLine("Matrix size should be greater than equal to 3");
            }
        }
        static int hourglassSum(int[,] arr, int size)
        {
            int sum = 0;

            ArrayList list = new ArrayList();
            for (int f_loop = 0; f_loop < size - 2; f_loop++)
            {
                sum = 0;
                for (int s_loop = 0; s_loop < size - 2; s_loop++)
                {
                    sum = arr[f_loop, s_loop] + arr[f_loop, s_loop + 1] + arr[f_loop, s_loop + 2] + arr[f_loop + 1, s_loop + 1] + arr[f_loop + 2, s_loop] + arr[f_loop + 2, s_loop + 1] + arr[f_loop + 2, s_loop + 2];
                    list.Add(sum);
                }

            }
            list.Sort();
            list.Reverse();
            return (int)list[0];
        }

    }
}
