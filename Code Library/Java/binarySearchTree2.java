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
				}
			}
			
			
		}
		
	}
}