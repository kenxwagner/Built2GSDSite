public class BinaryTree {
	Node root;
	
	public void addNode(int key, String name) {
		//Create a Node that will be initialized 
		
		Node newNode = new Node(key, name);
		
		if (root == null) {
		
			root = newNode;
			
		}
		
	}
}