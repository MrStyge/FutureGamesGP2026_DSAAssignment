
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace Utils{
public class GenericQueue<T>
{
  private List<T> queue; 

   public GenericQueue()
   {
    queue = new List<T>(); 
   }

    public void Enqueue(T ValueIn)
    {
    queue.Add(ValueIn); 
    }

    public T Peek()
    {
     if (queue.Count <= 0)
     {
       throw new System.Exception("Error! list is empty. cannot peek!"); 
     }

     return queue[0]; 
    }


    public T Dequeue()
    {
     if (queue.Count <= 0)
     {
       throw new System.Exception("Error! list is empty. cannot dequeue!"); 
     }

     T WhatsOnTopOfQueue = queue[0]; 
     queue.RemoveAt(0); 
     return WhatsOnTopOfQueue; 
    }


    public void Clear()
    {
    queue.Clear(); 
    }
}
}

