using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleApplication3
{
	public partial class Form1 : Form 
	{
		public Form1()
		{
			InitializeComponent();
			
		}
	
	}
	// make sure you can remember the rules of the binary search trees
	class Node
	{
		public int value;
		public Node left;
		public Node right;
		
		public Node (int initial)
		{
			
			value = initial;
			left = null;
			right = null;
		}
	}
	class Tree
	{
		Node Top;
		
		public Tree()
		{
			top = null;
		}

			public Tree(int initial)
			{
				top new Node(initial);
				
			}
		
		public void Add(int value)
		{
			// non-recurse add
			if (top == null) // empty tree
			{
				//Add item as base node
				Node NewNode = new Node(value);
				top = NewNode;
				return;
			}
			Node currentnode =  top;
			bool added = false;
			do
			{
				//traverse tree
				if (value < currentnode.value)
				{
					// go to the left
					if (currentnode.left == null)
					{
					//Add item
					Node NewNode = new Node(value);
					currentnode.left = NewNode;
					added = true;
					}
					else
					{
					currentnode = currentnode.left;
					}
					
				}
				if (value >= currentnode.value)
				{
					// go to the right
					if (currentnode.right == null)
					{
					//Add item
					Node NewNode = new Node(value);
					currentnode.right = NewNode;
					added = true;
					}
					else
					{
						// go right
					currentnode = currentnode.right;
					}
					
				}
				
				
			} while (!added);
		}
		
		public void AddRc(int value)
		{
			// recurse add
			AddR(ref top, value);
		}
		
		private void AddR(ref Node N, int value)
		{
			//private recursive search for where to add the new node
			if (N == null)
			{
				//Node doesn't exist so add it here
				Node NewNode = new Node(value);
				N = NewNode; //Set the old Node reference to the newly created node which attaches it to the tree
				return; // End the function call and fall back
			}
			if (value < N.value)
			{
				AddR(ref N.left, value);
				return;
			}
			if (value >= N.value)
			{
				AddR(ref N.right, value);
				return;
			}
			
			
			
		}
		
public void Print (Node N, ref string s)
{
	//write out the tree in sorted order to the string newstring
	// implement using recursion
	if (N == null) {N = top;}
	if (N.left != null)
	{
		Print(N.left, ref s);
		s = s + N.value.ToString().PadLeft(3);
	}
	else
	{
		s = s + N.value.ToString().PadLeft(3);
	}
	if (N.right != null)
	{
		Print(N.right, ref s);
	}
	
}
		
		}
	}
	
}