using UnityEngine;
using Utils;
using Environment.Tasks; 
using System; 
 [CreateAssetMenu(fileName = "Hashmap task", menuName = "hashmap")]
public class HashMapTask : Task
{

 public override void Execute()
 {

    DateTime date1 = new DateTime(2234, 08, 01, 00, 03, 47); 
    DateTime date2 = new DateTime(2234, 08, 01, 00, 34, 19);

    // Insert a value into the hashmap
    var stopInsert = new System.Diagnostics.Stopwatch();
    stopInsert.Start();
    HashScript.Instance.Insert(date1);
    HashScript.Instance.Insert(date2);
    stopInsert.Stop(); 
    Debug.Log("Hashmap insertion done!" + " " + "It took:" + " " + stopInsert.ElapsedTicks + " " + "ticks"); 
    Debug.Log("Hashmap insertion done!" + " " + "It took:" + " " + stopInsert.ElapsedMilliseconds + " " +  "milliseconds"); 
    // END

    // Get all values between specified range
    var stop = new System.Diagnostics.Stopwatch();
    stop.Start();
    HashScript.Instance.GetValueInRange(date1, date2); 
    stop.Stop(); 
    Debug.Log("Values gotten in range from hashmap!" + " " + "It took:" + " " + stop.ElapsedTicks + " " + "ticks"); 
    Debug.Log("Values gotten in range from hashmap!" + " " + "It took:" + " " + stop.ElapsedMilliseconds + " " +  "milliseconds"); 

    // END 
    
    // Get ONE value from hashmap 
   
    var stopGetValue = new System.Diagnostics.Stopwatch();
    stopGetValue.Start(); 
    HashScript.Instance.GetValue(date2); 
    stopGetValue.Stop(); 
    Debug.Log("One value gotten from hashmap!" + " " + "It took:" + " " + stopGetValue.ElapsedTicks + " " + "ticks"); 
    Debug.Log("One value gotten from hashmap" + " " + "It took:" + " " + stopGetValue.ElapsedMilliseconds + " " +  "milliseconds"); 

    HashScript.Instance.InsertTwo(date1);
    HashScript.Instance.InsertTwo(date2);
    var stopGetValueTwo = new System.Diagnostics.Stopwatch();
    stopGetValueTwo.Start(); 
    HashScript.Instance.GetValueTwo(date2); 
    stopGetValueTwo.Stop(); 
    Debug.Log("One value gotten from hashmap!" + " " + "It took:" + " " + stopGetValueTwo.ElapsedTicks + " " + "ticks" + " " + "(second method)"); 
    Debug.Log("One value gotten from hashmap" + " " + "It took:" + " " + stopGetValueTwo.ElapsedMilliseconds + " " +  "milliseconds" + " " + "(second method)"); 

    // End 

 }
}
