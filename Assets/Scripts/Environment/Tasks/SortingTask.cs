using UnityEngine;
using System; 
using System.Collections; 
using System.Collections.Generic; 
using Utils;

namespace Environment.Tasks {
       [CreateAssetMenu(fileName = "SortTask", menuName = "Sort Task")]
       public class SortingTask : Task {
       

 public override void Execute() 
 {
   var stop = System.Diagnostics.Stopwatch.StartNew();
   QuickSortAlgorithm.QuickSortTask(SortEmployees.employeeData, 0, SortEmployees.employeeData.Length - 1, valueToPrioritize => valueToPrioritize.employeeLastEntrenance);
   stop.Stop(); 
   Debug.Log("Array sorted!" + " " + "It took:" + " " + stop.ElapsedTicks + " " + "ticks"); 
   Debug.Log("Array sorted!" + " " + "It took:" + " " + stop.ElapsedMilliseconds + " " +  "milliseconds"); 
   Debug.Log(String.Join("\n", SortEmployees.employeeData)); 

    
 }


}
}
