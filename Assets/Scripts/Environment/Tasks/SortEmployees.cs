using UnityEngine;
using System; 
using System.Collections; 
using System.Diagnostics;
using System.Collections.Generic; 
using Utils;
using Debug = UnityEngine.Debug;
using System.Linq;

namespace Environment.Tasks {
  [CreateAssetMenu(fileName = "SortEmployees", menuName = "Sort Employees")]
   public class SortEmployees : Task {
      
    [SerializeField] TestClass testClass; 
   
    
    
     public (string employeeName, int employeeID, bool hasEngineClearance, DateTime employeeLastEntrenance, DateTime employeeLastExit )[] employeeData; 
            

           
   

    public override void Execute() {
            

          
      var stop = System.Diagnostics.Stopwatch.StartNew();
      stop.Start(); // Start timer
      QuickSortAlgorithm.QuickSortTask(employeeData, 0, employeeData.Length - 1, valueToPrioritize => valueToPrioritize.employeeLastEntrenance);
      stop.Stop();  // Stop timer
//    Debug.Log(stop.ElapsedMilliseconds); // Show time
//    Debug.Log(String.Join("\n", employeeData)); 
//    Debug.Log("Culprit:" + " " + employeeData[0].employeeName); // <------ Debug.log Quicksort output
        
        
      int[] numbers = {1,2,3,4,5,6,7,8,9,10};

      DateTime mintarget = new (100, 08, 09);
      DateTime maxtarget = new (200, 08, 09); 

      BinarySearch.BinarySearchAlgorithm(employeeData, mintarget, maxtarget, x => x.employeeLastEntrenance); 

    }
}



}
