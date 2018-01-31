import java.util.Hashtable;
import java.util.Enumeration;

public class HashtableTimes
{
	
	
	
	public static void main(String[] args)
	{
		Enumeration names;
		String key;
 
   // Create a Hash table
   Hashtable<String, String> hashtable = 
              new Hashtable<String, String>();
 
   // Add Key and Value pairs to Hash table
   hashtable.put("Key1","Banana");
   hashtable.put("Key2","Dragon Fruit");
   hashtable.put("Key3","Kiwi");
   hashtable.put("Key4","Pineapple");
   hashtable.put("Key5","Strawberry");
 
   names = hashtable.keys();
   while(names.hasMoreElements()) {
      key = (String) names.nextElement();
      System.out.println("Key: " +key+ " & Value: " +
      hashtable.get(key));
   }
	}
}