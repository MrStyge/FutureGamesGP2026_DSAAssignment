using UnityEngine;
using System.Collections.Generic; 

 public class HashScript                 
 {  

    private List<int>[] hashMap; 

    public HashScript() {
    
        hashMap = new[] {new List<int>()}; 
    }

 private static int CalculateHash(int valueToHash, int hashMapLength)
 {

    if(hashMapLength == 0) {

       return -1; 
    }

    return valueToHash % hashMapLength; 
 }



 public void Insert(int valueToInsert)
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


 public List<int> GetValue(int inValueToSearchMin, int inValueToSearchMax)
 {
    List<int> tempList = new List<int>(); 

    for (int i = 0; i < hashMap.Length; i++) {

         for(int j = 0; j < hashMap[i].Count; j++) {

             if (hashMap[i][j] > inValueToSearchMin && hashMap[i][j] < inValueToSearchMax) {
                 Debug.Log("FOUND IT!" + " " + hashMap[i][j]); 
                 tempList.Add(hashMap[i][j]); 
             }
         }
    }

    if(tempList.Count == 0) {
     
    }

    return tempList; 
    Debug.Log("didnt find it"); 


 }

 }
