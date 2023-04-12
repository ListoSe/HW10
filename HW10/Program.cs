using System;
using static System.Math;
class Program1
{
    //--------------1------------------------
    static int[] getModedArr(int[] A, Predicate<int> fun)
    {
        int counter = 0;
        foreach (int i in A)
        {
            if (fun(i))
            {
                counter++;
            }
        }
        int[] B = new int[counter];
        for (int i = 0; i < counter; i++)
        {
            if (fun(A[i]))
            {
                B[i] = A[i];
            }
        }
        return B;
    }
    //--------------------2--------------------------

    record MarksStudent(int[] marks);

    //----------------------1---------------------
    static void Main(string[] args)
    {
        int[] arr = new int[5];
        var rnd = new Random();
        //==========================================
        /*for (int i = 0; i < 5; i++)
        {
            arr[i] = rnd.Next(-7, 8);
            Console.WriteLine(arr[i]);
        }
        Console.WriteLine();
        arr = getModedArr(arr, a => a >= 0);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Console.WriteLine();
        arr = getModedArr(arr, a => (a % 7) == 0);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Console.WriteLine();*/
        //--------------------2--------------------------
        MarksStudent[] markList = new MarksStudent[3];
        int[] arrMark = new int[3];

        for (int i = 0; i < 3; i++)
        {
            arrMark[i] = rnd.Next(1, 13);
            Console.WriteLine(arrMark[i]);
        }
        Console.WriteLine();
        markList[0] = new MarksStudent(arrMark);

        for (int i = 0; i < 3; i++)
        {
            arrMark[i] = rnd.Next(1, 13);
            Console.WriteLine(arrMark[i]);
        }
        Console.WriteLine();
        markList[1] = new MarksStudent(arrMark);

        for (int i = 0; i < 3; i++)
        {
            arrMark[i] = rnd.Next(1, 13);
            Console.WriteLine(arrMark[i]);
        }
        Console.WriteLine();
        markList[2] = new MarksStudent(arrMark);
        //cod wowod max serednyy ozenky
        float max = 0;
        float[] avg = new float[3];
        for (int i = 0; i < markList.Length; i++)
        {
            for (int j = 0; j < markList[i].marks.Length; j++)
            {
                avg[i] += markList[i].marks[j];
            }
            avg[i] /= 3;
        }
        for(int i = 0; i < 3; i++)
        {
            if (avg[i] > max)
            {
                max = avg[i];
            }
        }
        Console.WriteLine($"Max: {max}");
    }
}
