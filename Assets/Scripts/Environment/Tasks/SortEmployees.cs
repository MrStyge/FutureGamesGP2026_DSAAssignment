using UnityEngine;
using System; 
using System.Collections; 
using System.Collections.Generic; 

namespace Environment.Tasks {
       [CreateAssetMenu(fileName = "SortEmployees", menuName = "Sort Employees")]
       public class SortEmployees : Task {
      
      
            public (string employeeName, int employeeID, bool hasEngineClearance, DateTime employeeLastEntrenance, DateTime employeeLastExit )[] employeeData = 
            new (string employeeName, int employeeID, bool hasEngineClearance, DateTime employeeLastEntrenance, DateTime employeeLastExit)[5]; 





       public override void Execute() {
            
          for(int i = 0; i<3; i++)
            {
              Debug.Log("Employee found!" + "\n" +
              "Employees name:" + " " + employeeData[i].employeeName + "\n" +
              "Employees ID:" + " "  + employeeData[i].employeeID + "\n" +
              "Employees clearance:" + " " + employeeData[i].hasEngineClearance + "\n" +
              "Employees last enternance in Engine room:" + " " + employeeData[i].employeeLastEntrenance + "\n" +
              "Employees last exit in Engine room:" + " " + employeeData[i].employeeLastExit); 
           }
          
          
        
    }
}
}
