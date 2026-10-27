using UnityEngine;
using System; 
using System.Collections; 
using System.Collections.Generic; 


namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "ReadFromJson", menuName = "ReadFromJson")]
    public class ReadFromJson : Task {
      public TextAsset EmployeeJSON; 
      static public int arrayLength;
      [SerializeField] private SortEmployees sortEmployeesTask; 
      [SerializeField] private HashMap hasMapTask; 
      

     


      public override void Execute() {
        EmployeeInfo[] employees = JsonUtility.FromJson<Employees>(EmployeeJSON.text).employees; 
         arrayLength = employees.Length; 
    (string employeeName, int employeeID, bool hasEngineClearance, DateTime employeeLastEntrenance, DateTime employeeLastExit )[] tempTuple = 
    new (string employeeName, int employeeID, bool hasEngineClearance, DateTime employeeLastEntrenance, DateTime employeeLastExit)[arrayLength]; 
         
         int i = 0; 

        foreach (EmployeeInfo employee in employees)
        {
          
          // Parse the name 
          string employeeName = employee.name; 

          // Parse the EmployeeID

          string inputInt = employee.employeeId; 
          int myEmployeeID = int.Parse(inputInt); 

          // Parse the hasEngineRoomClearance

          string inputName = employee.hasEngineRoomClearance; 
          bool hasClearance = bool.Parse(inputName); 

          // Parse the lastEntranceInEngineRoom 
          
          string lastEntrenance = employee.lastEntranceInEngineRoom; 
          DateTime myLastEntranceInEngineRoom = DateTime.Parse(lastEntrenance); 
          
          // Parse the last exit 

          string lastExit = employee.lastExitFromEngineRoom; 
          DateTime myLastExitFromEngineRoom  = DateTime.Parse(lastExit); 
   
   
 
         
         tempTuple[i] = 
        (employeeName: employeeName, employeeID: myEmployeeID, hasEngineClearance: hasClearance, employeeLastEntrenance: myLastEntranceInEngineRoom, employeeLastExit: myLastExitFromEngineRoom); 
        
         // hashmap
         i++; 
      
   
   }
    sortEmployeesTask.employeeData = tempTuple;

  
        }
    }





  



    
}
