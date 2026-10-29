using UnityEngine;
using System; 
using System.Collections; 
using System.Collections.Generic; 
using Utils;

namespace Environment.Tasks {
       [CreateAssetMenu(fileName = "TreeTask", menuName = "DFS search")]
       public class TreeTask : Task {
       string targetValue = "10"; 
      public Node CreateExampleTree()
      {
       Node node4 = new Node("4");
       Node node7 = new Node("7");
       Node node8 = new Node("8");
       Node node10 = new Node("10");
       
       Node node3 = new Node("3", node4, null, null);
       Node node6 = new Node("6", node7, null, null);
        
      Node node2 = new Node("2", node3, null, null); 
      Node node5 = new Node("5", node6, node8, null); 
      Node node9 = new Node("9", node10, null, null); 

       Node root = new Node("1", node2, node5, node9);
       return root;
      }

      public override void Execute() {

      Node myTree = CreateExampleTree(); 
      bool found = DfsSearch.DFS(myTree, targetValue); 
      
      Debug.Log(found.ToString());

     
    
    }
}
}
