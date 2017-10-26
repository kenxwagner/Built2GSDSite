/* Java doesn't allow you to inherit from more than one
 * class. So, what do you do when you want do you do
 * when you want to add additional functionality?
 * You create an interface. Interfaces are empty
 * classes. They provide all of the methods you must
 * use, but none of the code.
 */
 
// This is how you define an interface. They normally
// have a name that is an adjective. Adjectives modify
// nouns. Most objects have noun names


public interface Drivable {
	
	double PI = 3.14;
	
	int getWheel();
	
	void setWheels(int numWheels);
	
	double getSpeed();
	
	void setSpeed(double spdeed);

}
