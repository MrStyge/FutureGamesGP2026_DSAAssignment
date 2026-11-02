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
      
  
    private HashScript hashScript; 
   
    public (string employeeName, int employeeID, bool hasEngineClearance, DateTime employeeLastEntrenance, DateTime employeeLastExit )[] employeeData; 
            

           
 public override void Execute() 
 {
    hashScript = new HashScript(); 
    var stop = System.Diagnostics.Stopwatch.StartNew();
    stop.Start(); // Start timer
    QuickSortAlgorithm.QuickSortTask(employeeData, 0, employeeData.Length - 1, valueToPrioritize => valueToPrioritize.employeeLastEntrenance);
    stop.Stop();  // Stop timer
    // Debug.Log(stop.ElapsedMilliseconds); // Show time
    Debug.Log("Array sorted!"); 
    Debug.Log(String.Join("\n", employeeData)); 

    int[] arr = new int[] {2,3,4,5,6}; 

      
    hashScript.Insert(2); 
    hashScript.Insert(3); 
    hashScript.Insert(4);
    hashScript.Insert(5);
    hashScript.Insert(40);  
    hashScript.GetValue(2, 6);
      

      


      
        
        
     

 }
}



}
