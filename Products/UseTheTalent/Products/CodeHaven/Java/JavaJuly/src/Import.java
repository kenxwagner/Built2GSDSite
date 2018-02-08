import java.util.Scanner;

public class Import {

	static Scanner userInput = new Scanner(System.in);
	
	public static void main(String[]args)
	{
		System.out.print("Give the number of the episode you like of Star Wars: ");
		
		if (userInput.hasNextInt())
		{
			int numberEntered = userInput.nextInt();
			
			System.out.println("You like Episode " + numberEntered);
		}else {
			System.out.println("Enter and integer please.");
		}
		
	}
}
