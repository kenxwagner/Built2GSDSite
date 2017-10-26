using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericName
{
  class MyProgram
  {
	public interface IShape{
			void Draw();
		}
	class Circle: IShape {
		public void Draw() {	
				Console.WriteLine("Circle Draw");
			}
		}
	  	  
    static void Main(string[] args)
    {
		IShape c = new Circle();
		c.Draw();
		
    }
  }

}
