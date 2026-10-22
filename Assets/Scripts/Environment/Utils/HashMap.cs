using UnityEngine;
using System; 
using System.Collections; 
using System.Collections.Generic; 
using Utils;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "Hashmap", menuName = "hashmap")]
      public class HashMap : Task {
      
  
    public Dictionary<int, EmployeeInfo> employeeHashMap = new Dictionary<int, EmployeeInfo>();
      

           
   

      public override void Execute() {
            
     
       // SortingDictionary.QuickSortDictionary(employeeHashMap, 0, employeeHashMap.Length - 1, x => x); 

         

      
    }
}
}
