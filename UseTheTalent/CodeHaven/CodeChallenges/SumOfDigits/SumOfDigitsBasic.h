#include<iostream>
using namespace std;

int sumOfNumbers(int);

int sumOfNumbersFrom1ToN(int n)
{	
	int result = 0;
	
	for (int x=1; x<=n; x++)
		result += sumOfNumbers(x);
	
	return result;	
}
int sumOfNumbers(int x_)
{
	int sum = 0;
	while (x !=0)
	{
		sum += x%10;
		x = x /10;
	}
	return sum;
}

int main()
{
	int n=123;
	cout << "Sum of numbers 1 to " << n << " is "
		 << sumOfNumbersFrom1ToN(n);
		 return 0;
	
}