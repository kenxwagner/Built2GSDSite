//This code failed.

//Find most frequently used word excluding commonly used words.
// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY CLASS AND METHOD NEEDED
import java.util.List;
// CLASS BEGINS, THIS CLASS IS REQUIRED
public class Solution
{        
    // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
    List<String> retrieveMostFrequentlyUsedWords(String literatureText, 
                                                 List<String> wordsToExclude)
    {
    String wordCheck="";
	int count=0;
	
	for (int i=0; i<literatureText.length;i++){
		
		String tempWordCheck = literatureText[i];
		int tempCount=0;
			
			for (int k=0; k<wordsToExclude.length; k++){
				if (wordsToExclude[k].equals(tempWordCheck)){
					tempCount=0;
					i++;
					}else {
			
				for (int j=0; j<arr.length;j++){
					if(arr[j].equals(tempWordCheck))
					tempCount++;
					}
				if (tempCount>count){
					wordCheck = tempWordCheck;
					count = tempCount;
					}
				}
			}
			System.out.println("The most used word is:"+wordCheck+". frequency:" +count);
		}	
    }
    // METHOD SIGNATURE ENDS
}

//reordering data from a log file. Every line in the log file is a space delimited list of strings.

//Return a list of string representing the reordered log file data

import java.util.List;
import java.util.Collections;
// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY CLASS AND METHOD NEEDED
// CLASS BEGINS, THIS CLASS IS REQUIRED
public class Solution
{ 
	// METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
    public List<String> reorderLines(int logFileSize, List<String> logLines) 
	{
		for(int i=0; i<logFileSize;i++){
		    Collections.sort(logLines);
		}
	}
	// METHOD SIGNATURE ENDS
}