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
				
				
				parent = focusNode;
				
				if (key < focusNode.key) {
					focusNode = focusNode.leftChild;
					
					if (focusNode == null) {
						
						parent.leftChild = newNode;
						return;
					}
					
				} else { 
					
					focusNode = focusNode.rightChild;
					
					if (focusNode == null) {
						
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