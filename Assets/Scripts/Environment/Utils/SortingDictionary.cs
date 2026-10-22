using UnityEngine;
 using System.Collections; 
 using System; 
namespace Utils
{
public static class SortingDictionary 
{
   

 public static void QuickSortDictionary<T, TKey>(T[] array, int start, int end, Func<T, TKey> key) where TKey: IComparable<TKey>  
 {
    
             if(end <= start) return; 
             int pivot = Partition(array, start, end, key); 
             QuickSortDictionary(array, start, pivot -1, key); 
             QuickSortDictionary(array, pivot + 1, end, key); 
           
        
   
  
 }
    

 public static int Partition<T, TKey>(T[] array, int start, int end, Func<T, TKey> key) where TKey: IComparable<TKey>
 {
        
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
}










