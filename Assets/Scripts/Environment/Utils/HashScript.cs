using UnityEngine;
using System.Collections.Generic; 
using System; 

 public class HashScript                
 {  
    private static HashScript instance;

    public static HashScript Instance {
        get {
            if (instance == null) {
                instance = new HashScript(); 
            }
        
           return instance; 
        }
    }

    
    private List<DateTime>[] hashMap; 

    public HashScript() {
    
        hashMap = new List<DateTime>[1009]; 

        for(int i = 0; i < hashMap.Length; i++) {
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
     long rawHash = (int) (valueToHashLong % hashMapLength);    
     return (int)Math.Abs(rawHash); 

 }

 private static int CalculateHashTwo(DateTime valueToHash, int hashMapLength)
 {
  if(hashMapLength == 0) {
   return - 1;
  }
  
  // using formula "hash * 33 + c" 
  string currentString = valueToHash.ToString(); 
  int intValue = 5381;  
  foreach(char l in currentString) {
  intValue = intValue * 33 + l; 
  }

  return (int)Math.Abs(intValue % hashMapLength);
  

 }



 public void Insert(DateTime valueToInsert)
 {
    int hash = CalculateHash(valueToInsert, hashMap.Length); 

    if (!hashMap[hash].Contains(valueToInsert)) {
        hashMap[hash].Add(valueToInsert); 
     }
    
 }

 public void InsertTwo(DateTime valueToInsert)
 {
    int hash = CalculateHashTwo(valueToInsert, hashMap.Length); 

    if (!hashMap[hash].Contains(valueToInsert)) {
        hashMap[hash].Add(valueToInsert); 
     }
    
 }


 public List<DateTime> GetValueInRange(DateTime inValueToSearchMin, DateTime inValueToSearchMax)
 {
    List<DateTime> tempList = new List<DateTime>(); 
  
    for(int n = 0; n < hashMap.Length; n++) {

        for(int l = 0; l < hashMap[n].Count; l++) {

            if(hashMap[n][l] > inValueToSearchMin && hashMap[n][l] < inValueToSearchMax) {
                Debug.Log("Value found!" + " " + hashMap[n][l] + "\n"); 
                tempList.Add(hashMap[n][l]); 
            }        
        }  
    }
    return tempList;
 }

 public void GetValue(DateTime value)
 {
    int hashValue = CalculateHash(value, hashMap.Length); 
    
    if(hashMap[hashValue][0] == value) {
        Debug.Log("Found the value!"); 
    }
    else {
        for (int i = 0; i < hashMap[hashValue].Count; i++) {
            if(hashMap[hashValue][i] == value)
            {
                Debug.Log("Found the value in subarray!"); 
                return;
            }
        }
    }

   
 }

  public void GetValueTwo(DateTime value)
 {
    int hashValue = CalculateHashTwo(value, hashMap.Length); 
    
    if(hashMap[hashValue][0] == value) {
        Debug.Log("Found the value!" + "(second method)"); 
    }
    else {
        for (int i = 0; i < hashMap[hashValue].Count; i++) {
            if(hashMap[hashValue][i] == value)
            {
                Debug.Log("Found the value in subarray!" + "(second method)"); 
                return;
            }
        }
    }

   
 }

 }

 

 

