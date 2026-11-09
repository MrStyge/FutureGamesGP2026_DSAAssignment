using UnityEngine;
using System; 
using System.Collections; 
using System.Diagnostics;
using System.Collections.Generic; 
using Utils;
using Debug = UnityEngine.Debug;
using System.Linq;

namespace Environment.Tasks {
  [CreateAssetMenu(fileName = "SearchTask", menuName = "Search Task")]
   public class SearchTask : Task {
      
 
   
    
            

           
 public override void Execute() 
 {
    string name1 = "a"; 
    string name2 = "b"; 
    DateTime mintarget = new (1, 08, 09);
    DateTime maxtarget = new (3000, 08, 09); 
 
   
    var stop = System.Diagnostics.Stopwatch.StartNew();
    BinarySearch.BinarySearchAlgorithm<EmployeeInfo, DateTime>(SortEmployees.employeeData, mintarget, maxtarget, x => x.parsedEntranceTime); 
    stop.Stop(); 
    Debug.Log("Binary search done!" + " " + "It took:" + " " + stop.ElapsedTicks + " " + "ticks"); 
    Debug.Log("Binary search done!" + " " + "It took:" + " " + stop.ElapsedMilliseconds + " " + "milliseconds"); 

 }
}



}
