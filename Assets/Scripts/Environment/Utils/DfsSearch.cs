using UnityEngine;
using Utils; 
using System.Collections.Generic;

public class DfsSearch : MonoBehaviour
{
  
   public Node root; 

   public static bool DFS(Node node, string targetValue)
   {
    if (node == null)
    {
        return false;    
    }
    if(node.textData == targetValue)
    {
        return true; 
    }
       Debug.Log(node.textData + " ");
       if (DFS(node.left, targetValue)) return true;
       if (DFS(node.middle, targetValue)) return true;
       if (DFS(node.right, targetValue) )return true; 

         return false; 
    
   }

}
