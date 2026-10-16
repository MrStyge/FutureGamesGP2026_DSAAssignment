using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class GenericStack<T>
{
    private List<T> stack; 
    
   public GenericStack()
   {
    stack = new List<T>(); 
   }

   public void Push(T ValueInStack)
    {
     stack.Add(ValueInStack);
    }

    public T Peek()
    {
      if(stack.Count == 0)
        {
             throw new System.Exception("Error!"); 
        }
    return stack[stack.Count - 1]; 
    }

    public T Pop()
    {
     if(stack.Count == 0)
        {
             throw new System.Exception("Error!"); 

        }
   
   T WhatsOnTopOfStack = stack[stack.Count - 1]; 
   stack.RemoveAt(stack.Count - 1);
   return WhatsOnTopOfStack; 


    }

    public void ClearStack()
    {
    stack.Clear(); 
    }

    

  
}
