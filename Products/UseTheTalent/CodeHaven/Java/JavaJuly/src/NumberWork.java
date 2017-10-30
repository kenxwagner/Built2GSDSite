
public class NumberWork {

	public static void main(String[] args)
{
	
	byte bigByte = 127; // Minimum value -128 Maximum value 127
	short bigShort = 32767; // Minimum value -32768 Maximum value 32767
	int bigInt = 2147483647; // Minimum value -2147483648 Maximum value 2147483647
	long bigLong = 9223372036854775807L; // Minimum value -9223372036854775808L
	float bigFloat = 3.14F; // You must end a float with an F
	double bigDouble = 3.1234567890D; // The D is not required with doubles
	double sum = (bigFloat - bigDouble + bigLong + bigInt)/(bigByte * bigShort);
	System.out.println(Float.MAX_VALUE); // Float is precise to 6 decimal places
	System.out.println(Double.MAX_VALUE); // Double is precise to 15 decimal places
	System.out.println(sum);
}
}
