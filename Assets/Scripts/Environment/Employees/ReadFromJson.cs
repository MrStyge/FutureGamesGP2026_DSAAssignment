using UnityEngine;
using System; 
using System.Collections; 
using System.Collections.Generic; 


namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "ReadFromJson", menuName = "ReadFromJson")]
    public class ReadFromJson : Task {
      public TextAsset EmployeeJSON; 


        public override void Execute() {
            Employees employeesInJson = JsonUtility.FromJson<Employees>(EmployeeJSON.text); 
            foreach (EmployeeInfo employee in employeesInJson.employees)
   {
 
     // Parse the name 
     string employeeName = employee.name; 
   
     // Parse the EmployeeID

     string inputInt = employee.employeeId; 
     int employeeID = int.Parse(inputInt);

    // Parse the hasEngineRoomClearance

    string inputName = employee.hasEngineRoomClearance; 
    bool hasClearance = bool.Parse(inputName); 

    // Parse the lastEntranceInEngineRoom 
    
    string lastEntrenance = employee.lastEntranceInEngineRoom; 
    DateTime lastEntranceInEngineRoom = DateTime.Parse(lastEntrenance); 
    
    // Parse the last exit 

    string lastExit = employee.lastExitFromEngineRoom; 
    DateTime lastExitFromEngineRoom  = DateTime.Parse(lastExit); 
   
   

    Debug.Log("Employee found!" + "\n" +
              "Employees name:" + " " + employeeName + "\n" +
              "Employees ID:" + " "  + employeeID + "\n" +
              "Employees clearance:" + " " + hasClearance + "\n" +
              "Employees last enternance in Engine room:" + " " + lastEntranceInEngineRoom + "\n" +
              "Employees last exit in Engine room:" + " " + lastExitFromEngineRoom); 

    
   
   }

        }
    }
}
