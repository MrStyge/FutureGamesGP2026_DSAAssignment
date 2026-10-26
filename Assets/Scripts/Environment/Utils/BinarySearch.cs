using UnityEngine;
using System.Collections; 
using System.Collections.Generic;
using System; 

public static class BinarySearch 
{
   
public static int BinarySearchAlgorithm(int[] array, int target) 
{
    int left = 0; 
    int right = array.Length - 1; 

    while(left <= right)
    {
        int mid = (left + right) / 2;
        
        if(array[mid] == target)
        {
        return mid; 
        }
        else if(array[mid] < target)
        {
            left = mid + 1; 
        }
        else
        {
            right = mid - 1; 
        }
        
}
return -1; 


}
}
