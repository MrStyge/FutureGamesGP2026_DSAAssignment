using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "EmployeeArray", menuName = "EmployeeArray")]
    public class EmployeeArray<T> : Task {

        public EmployeeInfo[] employeesArray = new EmployeeInfo[3];  

        public override void Execute() 
        {
    

        }


          
        public void PutDataInArray(T GottenValue)
        {
            
        }

    }

    
}
