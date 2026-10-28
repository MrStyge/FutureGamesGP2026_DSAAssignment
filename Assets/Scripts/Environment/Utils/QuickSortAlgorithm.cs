using UnityEngine;
using System.Collections; 
using System; 
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using Random=UnityEngine.Random;
public static class QuickSortAlgorithm 
{
   

 public static void QuickSortTask<T, TKey>(T[] array, int start, int end, Func<T, TKey> key) where TKey: IComparable<TKey> 
 { 
             
            if(end <= start) return; 
            int pivot = Partition(array, start, end, key); 
            QuickSortTask(array, start, pivot -1, key); 
            QuickSortTask(array, pivot + 1, end, key);  
 }
    

 public static int Partition<T, TKey>(T[] array, int start, int end, Func<T, TKey> key) where TKey: IComparable<TKey>
 {
  
          int randomPivot = Random.Range(start,end); 
          T temp1 = array[randomPivot]; 
       
           array[randomPivot] = array[end]; 
           array[end] = temp1; 
           
          T pivot = array[end];

            
            TKey currentKey = key(pivot); 
            int i = start - 1;
            T temp;

        for(int j = start; j <= end - 1; j++)
         {
         if(key(array[j]).CompareTo(currentKey) < 0)
           {
            i++; 
            temp = array[i]; 
            array[i] = array[j]; 
            array[j] = temp; 
           }
          }
            i++;
            temp = array[i]; 
            array[i] = array[end]; 
            array[end] = temp; 
            return i;
        
 }


}










