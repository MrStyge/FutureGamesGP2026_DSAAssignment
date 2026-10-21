using UnityEngine;
using System; 
using System.Collections; 
using System.Collections.Generic; 
namespace Utils
{
public class SortingScript 
{
    
   public static void InsertionSort<T, TKey>(T[] arrayToSort, Func<T, TKey> key) where TKey: IComparable<TKey>
   {
         int n = arrayToSort.Length;
     for(int i = 0; i<arrayToSort.Length; i++)
    {
         T placeholder = arrayToSort[i]; 
         TKey currentKey = key(placeholder); 
         int j = i - 1; 

     while(j >=0 && key(arrayToSort[j]).CompareTo(currentKey) > 0)
     {
         arrayToSort[j + 1] = arrayToSort[j]; 
         j = j - 1; 
     }
         arrayToSort[j + 1] = placeholder; 
    
    }
   }
}
}

