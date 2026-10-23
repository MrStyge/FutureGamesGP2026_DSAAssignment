using UnityEngine;
using System; 
using System.Collections; 
using System.Diagnostics;
using System.Collections.Generic; 
using Utils;
using Debug = UnityEngine.Debug;

namespace Environment.Tasks {
  [CreateAssetMenu(fileName = "SortEmployees", menuName = "Sort Employees")]
   public class SortEmployees : Task {
      
    [SerializeField] TestClass testClass; 
  
    public (string employeeName, int employeeID, bool hasEngineClearance, DateTime employeeLastEntrenance, DateTime employeeLastExit )[] employeeData = 
    new (string employeeName, int employeeID, bool hasEngineClearance, DateTime employeeLastEntrenance, DateTime employeeLastExit)[4]; 
            
            

           
   

    public override void Execute() {
            
//     SortingScript.InsertionSort(employeeData, valueToPrioritize => valueToPrioritize.employeeLastEntrenance); // sortera efter last enternance in room 
//     Debug.Log(String.Join("\n", employeeData)); 
//     Debug.Log("Culprit:" + " " + employeeData[0].employeeName); 

        
//     TEST LISTA 
//     int[] sortedArray = testClass.objectList.ToArray(); // spara kopian 
//     SortingScript.InsertionSort(sortedArray, numberToPrioritize => numberToPrioritize); // tryck in originala och prioritizera samma värde, dvs, sortera efter bara värden
//     Debug.Log(String.Join(",", sortedArray)); 

//     QUICK SORT
          
       var stop = System.Diagnostics.Stopwatch.StartNew();
       stop.Start(); // Start timer
       QuickSortAlgorithm.QuickSortTask(employeeData, 0, employeeData.Length - 1, valueToPrioritize => valueToPrioritize.employeeName);
       stop.Stop();  // Stop timer
       Debug.Log(stop.ElapsedMilliseconds); 
       Debug.Log(String.Join("\n", employeeData)); 
       Debug.Log("Culprit:" + " " + employeeData[0].employeeName); 
          
         
        
      
    }
}
}
