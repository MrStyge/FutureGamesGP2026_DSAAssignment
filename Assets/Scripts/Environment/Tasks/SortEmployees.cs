using UnityEngine;
using System; 
using System.Collections; 
using System.Collections.Generic; 
using Utils;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "SortEmployees", menuName = "Sort Employees")]
      public class SortEmployees : Task {
      
   [SerializeField] TestClass testClass; 
    
      
        public (string employeeName, int employeeID, bool hasEngineClearance, DateTime employeeLastEntrenance, DateTime employeeLastExit )[] employeeData = 
        new (string employeeName, int employeeID, bool hasEngineClearance, DateTime employeeLastEntrenance, DateTime employeeLastExit)[4]; 
            
            

           
   

      public override void Execute() {
            
        SortingScript.InsertionSort(employeeData, valueToPrioritize => valueToPrioritize.employeeLastEntrenance); // sortera efter last enternance in room 
        Debug.Log(String.Join("\n", employeeData)); 
        Debug.Log("Culprit:" + " " + employeeData[0].employeeName); 

        
        // LISTAN 
      //  int[] sortedArray = testClass.objectList.ToArray(); // spara kopian 
      //  SortingScript.InsertionSort(sortedArray, numberToPrioritize => numberToPrioritize); // tryck in originala och prioritizera samma värde, dvs, sortera efter bara värden
   //     Debug.Log(String.Join(",", testClass.objectList)); 


      
    }
}
}
