using UnityEngine;
using System.Collections.Generic; 
using System; 

 public class HashScript                
 {  
    private static HashScript instance;

    public static HashScript Instance
    {
    get
    {
     if (instance == null)
     {
      instance = new HashScript(); 
     }
     return instance; 
    }
    }

    
    private List<DateTime>[] hashMap; 

    public HashScript() {
    
        hashMap = new List<DateTime>[1024]; 

        for(int i = 0; i < hashMap.Length; i++)
        {
         hashMap[i] = new List<DateTime>(); 
        }
    }
 
 
 private static int CalculateHash(DateTime valueToHash, int hashMapLength)
 {

    if(hashMapLength == 0) {

       return -1; 
    }
    string valueString = valueToHash.ToString("yyyyMMddHHmmss"); 
    long valueToHashLong = long.Parse(valueString); 
    long rawHash = valueToHashLong % hashMapLength; 
    return (int)Math.Abs(rawHash); 
 }



 public void Insert(DateTime valueToInsert)
 {
    int hash = CalculateHash(valueToInsert, hashMap.Length); 

    if(hashMap[hash].Count == 0) {

        hashMap[hash].Add(valueToInsert); 
    }

    else {

    int i;

    for(i = 0; i < hashMap[hash].Count; i++) {
    
    }

    hashMap[hash].Add(valueToInsert); 
   }
 }


 public List<DateTime> GetValue(DateTime inValueToSearchMin, DateTime inValueToSearchMax)
 {
    List<DateTime> tempList = new List<DateTime>(); 
    int indexMin = CalculateHash(inValueToSearchMin, hashMap.Length); 
    int indexMax = CalculateHash(inValueToSearchMax, hashMap.Length); 
    
    for(int i = 0; i < hashMap[indexMin].Count; i++) {
        if (hashMap[indexMin][i] == inValueToSearchMin) {
            tempList.Add(hashMap[indexMin][i]); 
        }
    }
    
    for(int j = 0; j < hashMap[indexMax].Count; j++) {
        if(hashMap[indexMax][j] == inValueToSearchMax) {
           tempList.Add(hashMap[indexMax][j]); 
        }
    }


    if(tempList.Count == 0) {
     
    }
  
    for(int k = 0; k < hashMap.Length; k++)
    {
        for(int l = 0; l < hashMap[k].Count; l++)
        {
            if(hashMap[k][l] > inValueToSearchMin && hashMap[k][l] < inValueToSearchMax)
            {
             Debug.Log("Value found!" + hashMap[k][l] + "\n"); 

            }        
        }
    }


    Debug.Log("didnt find it"); 
    return tempList; 
   


 }

 }
