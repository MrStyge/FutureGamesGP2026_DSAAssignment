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
 public class SearchTask : Task 
 {
      
 
   
    
            

           
 public override void Execute() 
 { 
    DateTime mintarget = new (2234, 08, 09, 22, 00, 00);
    DateTime maxtarget = new (2234, 08, 09, 23, 00, 00); 
    List<EmployeeInfo> suspectsExit = new List<EmployeeInfo>();
    List<EmployeeInfo> suspectsEntrance = new List<EmployeeInfo>();
    var stop = System.Diagnostics.Stopwatch.StartNew();
    BinarySearch.BinarySearchAlgorithm<EmployeeInfo, DateTime>(SortEmployees.employeeData, mintarget, maxtarget, x => x.parsedEntranceTime, suspectsEntrance);
    stop.Stop(); 
    QuickSortAlgorithm.QuickSortTask(SortEmployees.employeeData, 0, SortEmployees.employeeData.Length - 1, valueToPrioritize => valueToPrioritize.parsedExitTime); 

    BinarySearch.BinarySearchAlgorithm<EmployeeInfo, DateTime>(SortEmployees.employeeData, mintarget, maxtarget, x => x.parsedExitTime, suspectsExit); 
    
   
    Debug.Log("Binary search done!" + " " + "It took:" + " " + stop.ElapsedTicks + " " + "ticks"); 
    Debug.Log("Binary search done!" + " " + "It took:" + " " + stop.ElapsedMilliseconds + " " + "milliseconds"); 

    foreach(EmployeeInfo suspect in suspectsEntrance) {
        if(suspectsExit.Contains(suspect)) {
            Debug.Log("The murderer is" + " " + suspect.name); 
        }
    }
    
 }
 }
}
