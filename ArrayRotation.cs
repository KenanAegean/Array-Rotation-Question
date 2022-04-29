using System;

class MainClass
{
    public static string ArrayRotation(int[] arr)
    {
        
        int initial = arr[0];
        int[] tempArray = new int[10];
        string res = "";
        
        for(int j = 0; j < arr.Length; j++)
        {
            tempArray[j] = arr[j];
        }
        
        int k = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if(initial < arr.Length)
            {
                arr[i] = tempArray[initial];
                initial++;
                res += arr[i];
            }
            else
            {
                arr[i] = tempArray[k];
                res += arr[i];
                k++;
            }
        }
        return res;
    }
    
    static void Main()
    {
        int[] arr ={3,2,5,8,4,6,4};
        Console.WriteLine(ArrayRotation(arr));
    }
}