using Environment.Tasks;
using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;
using Utils; 

namespace Environment {
    public class Computer : MonoBehaviour, IInteractable {
      
      [SerializeField] private List<Task> testTask = new List<Task>(); // Put your stack/queue here :)
      [SerializeField] private List<Task> stackTaskTest = new List<Task>(); 
        private int value;
        
          GenericQueue<Task> myQueue = new GenericQueue<Task>(); 
          GenericStack<Task> myStack = new GenericStack<Task>(); 

         private void Awake()
         {
         myQueue.Clear(); 
         myStack.ClearStack(); 
         for (int i = 0; i < testTask.Count; i++)
         {
          myQueue.Enqueue(testTask[i]); 
         }
        
          for (int i = 0; i < stackTaskTest.Count; i++)
         {
          myStack.Push(stackTaskTest[i]);
         }
       
      
        
         }



        public void OnInteract() {
        myQueue.Dequeue().Execute(); 
        myStack.Pop().Execute(); 

       
        }
    }
}
