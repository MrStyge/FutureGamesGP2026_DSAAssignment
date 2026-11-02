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
      
  [SerializeField] SortEmployees sortEmployees;
   
    
            

           
    public override void Execute() {
        
      DateTime mintarget = new (100, 08, 09);
      DateTime maxtarget = new (200, 08, 09); 

      BinarySearch.BinarySearchAlgorithm(sortEmployees.employeeData, mintarget, maxtarget, x => x.employeeLastEntrenance); 

    }
}



}
