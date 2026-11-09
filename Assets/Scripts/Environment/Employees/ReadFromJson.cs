using UnityEngine;
using System; 
using System.Collections; 
using System.Collections.Generic; 


namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "ReadFromJson", menuName = "ReadFromJson")]
    public class ReadFromJson : Task {
      public TextAsset EmployeeJSON; 
      static public int arrayLength;
       
       
       
 
      

     


      public override void Execute() {
       
         EmployeeInfo[] employees = JsonUtility.FromJson<EmployeesHelper>(EmployeeJSON.text).Employees; 
         arrayLength = employees.Length; 
        
       
         int i = 0; 

        foreach (EmployeeInfo employee in employees)
        {
          
        
          
          string lastEntrenance = employee.lastEntranceInEngineRoom; 
          employee.parsedEntranceTime = DateTime.Parse(lastEntrenance); 
          
          // Parse the last exit 

          string lastExit = employee.lastExitFromEngineRoom; 
          employee.parsedExitTime = DateTime.Parse(lastExit); 
   
   
 
         
        
        
         HashScript.Instance.Insert(employee.parsedEntranceTime); 
        
        
         i++; 
      
   
   }
     SortEmployees.employeeData = employees;
  

  
        }
    }





  



    
}
