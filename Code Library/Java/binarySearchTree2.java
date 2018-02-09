//
public class BinaryTree {
	Node root;
	
	public void addNode(int key, String name) {
		//Create a Node that will be initialized 
		
		Node newNode = new Node(key, name);
		
		if (root == null) {
		
			root = newNode;
			
		} else {
			// root set as Node to start
			Node focusNode = root;
			
			Node parent;
			
			while (true){
				
				// root is top parent
				parent = focusNode;
				
				// check if new node goes on left
				if (key < focusNode.key) {
					// Focus on left child
					focusNode = focusNode.leftChild;
					// if left child has no children
					if (focusNode == null) {
						
						// new node is on the left of it
						parent.leftChild = newNode;
						return;
					}
					
				} else { // this is used when node goes on the right
					
					focusNode = focusNode.rightChild;
					
					// if right child has no children
					
					if (focusNode == null) {
						
						// place new node on right 
						
						parent.rightChild = newNode;
						return;
					}
				}
			}
			
			
		}
		
	}
	public static void main(String[] args) {
		
		public void inOrderTraverseTree(Node focusNode) {
       if (focusNode != null) {
            // Traverse the left node
            inOrderTraverseTree(focusNode.leftChild);
            // Visit the currently focused on node
            System.out.println(focusNode);
            // Traverse the right node
            inOrderTraverseTree(focusNode.rightChild);
        }		
	}
	}