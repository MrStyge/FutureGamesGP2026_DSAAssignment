using UnityEngine;
using System.Collections.Generic;
public class Node 
{
    public Node left; 
    public Node right; 
    public Node middle;
    public string textData; 
   
    public Node(string textData, Node left, Node middle, Node right)
    {
        this.textData = textData; 
        this.left = left; 
        this.middle = middle; 
        this.right = right; 
    }

    public Node (string textData)
    {
    this.textData = textData; 
    this.left = null; 
    this.middle = null; 
    this.right = null; 
    }
   


     
}
