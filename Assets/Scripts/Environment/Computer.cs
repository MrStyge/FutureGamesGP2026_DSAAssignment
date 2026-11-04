using Environment.Tasks;
using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;
using Utils; 

namespace Environment {
    public class Computer : MonoBehaviour, IInteractable {
       
       [SerializeField] private List<Task> queueTasks = new List<Task>(); // Put your stack/queue here :)
        public static Computer Instance {get; private set;} 
        private int value;
          GenericQueue<Task> myQueue = new GenericQueue<Task>(); 
        

         private void Awake()
         {
        
         if(Instance != null && Instance != this)
         {
          Destroy(gameObject);
          return; 
         }
         Instance = this; 
         myQueue.Clear(); 
         for (int i = 0; i < queueTasks.Count; i++)
         {
          myQueue.Enqueue(queueTasks[i]); 
         }
        
        
       
      
        
         }



        public void OnInteract() {
        myQueue.Dequeue().Execute(); 
      

       
        }
    }
}
