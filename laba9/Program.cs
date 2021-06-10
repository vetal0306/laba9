using System;

namespace laba9
{
    class Program
    {      
        static void Main(string[] args)
        {
            int n = 4;
            int[,] a = new int[n, n];
            int[] temp = new int[n];

            Random ran = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = ran.Next(1, 5);
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.WriteLine();
            }

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    temp[j] = a[i, j];
                Array.Sort(temp);
                for (int k = 0; k < n; k++)
                {
                    a[i, k] = temp[k];
                    Console.Write("{0}\t", a[i, k]);
                }
                Console.WriteLine();
            }

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    temp[j] = a[j, i];
                Array.Sort(temp);
                for (int k = 0; k < n; k++)
                    a[k, i] = temp[k];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0}\t", a[i, j]);
                Console.WriteLine();
            }

        }



        #region
        /*
        static void Main(string[] args)
        {
            Console.WriteLine(" Сортування бульбашкою");
            Console.Write("Введiть елементи масиву: ");
            var parts = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);
            }
            Console.WriteLine("Вiдсортований масив: {0}", string.Join(", ", BubbleSort(array)));
            Console.ReadLine();
        }

        //метод обміну елементів
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        //сортування бульбашкою
        static int[] BubbleSort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);

                    }
                }
            }
            return array;
        }
        */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Сортування вибором");
            Console.Write("Введіть елементи масиву: ");
            var s = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            var a = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                a[i] = Convert.ToInt32(s[i]);
            }
            Console.WriteLine("Впорядкований масив: {0}", string.Join(", ", SelectionSort(a)));
            Console.ReadLine();
        }

        static int IndexOfMin(int[] array, int n)
        {
            int result = n;
            for (var i = n; i < array.Length; ++i)
{
                if (array[i] < array[result])
{
                    result = i;
                }
            }
            return result;
        }
        //метод для обміну елементів
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }
        //сортування вибором
        static int[] SelectionSort(int[] array, int currentIndex =
        0)
        {
            if (currentIndex == array.Length)

                return array;
            var index = IndexOfMin(array, currentIndex);
            if (index != currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }
            return SelectionSort(array, currentIndex + 1);
        }
        */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Сортування включенням");
            Console.Write("Введіть елементи масиву: ");
            var parts = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);
            }
            Console.WriteLine("Впорядкований масив: {0}", string.Join(", ", InsertionSort(array)));
            Console.ReadLine();
        }

        //метод обміну елементів
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        //сортування вставками
        static int[] InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
                array[j] = key;
            }

            return array;
        }
        */
        #endregion
    }   
    
}
        
