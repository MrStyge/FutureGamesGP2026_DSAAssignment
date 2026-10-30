using UnityEngine;
using System; 
using System.Collections; 
using System.Diagnostics;
using System.Collections.Generic; 
using Utils;
using Debug = UnityEngine.Debug;
using System.Linq;

namespace Environment.Tasks {
  [CreateAssetMenu(fileName = "SecretTask", menuName = "Secret Task")]
   public class SecretTask: Task {

   

      
  
   
    
            

           
    public override void Execute() {
        
      List<int> list = new List<int>();

      list.Add(8);
      list.Add(2); 
      list.Add(1); 
      list.Add(3); 
      list.Add(9); 

  //  for(int i = 0; i < list.Count; i++)
  //  {
  //   Debug.Log(list[i]);
  //  }

      Debug.Log(list[0] + " " + list[1] + " " + list[2] + " " + list[3] + " " + list[4]);
      ComparisonFunction(list, 0); 
    
    }

    


public void ComparisonFunction(List<int> list, int index)
{
  
  for(int i = index; i < list.Count - 1; i++)
  {
    while(list[i] > list[i + 1])                          
    {
    int temp = list[index];  // temp gets index value 
    list[index] = list[index + 1]; // index gets value of index + 1; 
    list[index + 1] = temp; // index + 1 gets temp; 
    Debug.Log("TEST"); 
    ComparisonFunction(list, i + 1);  
  }

    Debug.Log("Current state of the list:" + " " + list[0] + " " + list[1] + " " + list[2] + " " + list[3] + " " + list[4]);

  }


  




 
}
 

}




}
