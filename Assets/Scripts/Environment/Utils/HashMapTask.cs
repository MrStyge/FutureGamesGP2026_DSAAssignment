using UnityEngine;
using Utils;
using Environment.Tasks; 
using System; 
 [CreateAssetMenu(fileName = "Hashmap task", menuName = "hashmap")]
public class HashMapTask : Task
{

   public override void Execute()
   {
   DateTime date = new DateTime(2234, 08, 01, 06, 48, 59); 
   DateTime date1 = new DateTime(2234, 08, 08, 05, 36, 10); 
 
    HashScript.Instance.GetValue(date, date1); 
   
   }
}
