 using UnityEngine;
 using System.Collections; 
 using System.Collections.Generic;
 using System; 

 public static class BinarySearch 
 {
 public static void BinarySearchAlgorithm<T, TKey>(T[] array, TKey min, TKey max, Func<T, TKey> keySelector, List<T> results = null) where TKey: IComparable <TKey>
 {
     results?.Clear(); 
     IComparer<TKey> comparer = System.Collections.Generic.Comparer<TKey>.Default; 
     int minValue = SearchMinValue<T, TKey>(array, min, keySelector, comparer); 
     int maxValue = SearchMaxValue<T, TKey>(array, max, keySelector, comparer); 
  
     for(int i = minValue; i <= maxValue; i++ ) {
         T suspects = array[i]; 
         results?.Add(array[i]); 
        // Debug.Log("These are the suspects!" + " " + suspects); 
      }
  
 }






 private static int SearchMinValue<T, TKey>(T[] array, TKey min,Func<T, TKey> keySelector, IComparer<TKey> comparer) 
 {

     int left = 0; 
     int right = array.Length - 1; 
     int result = -1;
    

     while(left <= right) { // while left is smaller or equal to right, do the following 
         int mid = (left + right) / 2; // declare mid 
     
         if(comparer.Compare(keySelector(array[mid]),min) >= 0)  { // if the middle of the array is bigger or equal to minimum
             right = mid - 1; 
             result = mid;  
         } else {
           left = mid + 1; 
         }     
     }

      return result; 
 }


 public static int SearchMaxValue<T, TKey>(T[] array, TKey max, Func<T, TKey> keySelector, IComparer<TKey> comparer)
 {

     int left = 0; 
     int right = array.Length - 1; 
     int result = -1;
     

     while(left <= right) { // while left is smaller or equal to right, do the following 
         int mid = (left + right) / 2; // declare what mid is 
     
         if(comparer.Compare(keySelector(array[mid]),max) > 0) { // if the middle of the array is bigger than max 
             right = mid - 1; 
         } else {
            result = mid; 
            left = mid + 1; 
         }
     }
    
     return result; 
 }


 }

