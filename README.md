# Array-Rotation-Question
An Interwiew Question Asked Me in Some Interwiev.

Have the function ```ArrayRotation(arr)``` take the ```arr``` parameter being passed which will be an array of non-negative integers and circularly rotate the array starting from the Nth element where N is equal to the first integer in the array. For example: if ```arr``` is [2, 3, 4, 1, 6, 10] then ypur program should rotatethe array starting from the 2nd position because the first elemnt in the array is 2. The final array will therefore be [4, 1, 6, 10, 2, 3],, and your proogram should return the new array as a string , so for this example yor progam would return 4161023. The first element in the array will always be an integer greater than or equal to 0 and less than size of the array.

My Answer is in C#:

```C#
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

```
