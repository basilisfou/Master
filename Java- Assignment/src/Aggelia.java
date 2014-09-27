import java.io.IOException;
import java.util.*;

public class Aggelia 
{
	private String insertAdvertisement = "";
	Scanner keyboard = new Scanner(System.in);
	
	public void readMachine() throws IOException 
	{
		System.out.println("Give the advertisment letter by letter: " );	
		
		char ch = readChar();
		
		while (ch != '.') //each time one character is being read
		{
			//the user can not use this punctuation
			if( ch != ';' && ch!= ',' && ch!= '!' && ch!='?')
				insertAdvertisement = insertAdvertisement + ch;
			//read next character
			ch = readChar();	
		}
		//adding the last fast full stop
		insertAdvertisement = insertAdvertisement + ".";
	}
	
	/* reads the next character of input and returns this character. 
	 * The next input is becoming in the same line from the position that 
	 * had stopped previous */ 
	public char readChar() throws IOException 
	{
		int charAsInt = -1;
		
		charAsInt = System.in.read();
		
		return (char)charAsInt;
	}
	
	public int countLetters()
	{
		return (insertAdvertisement.length());
	}
	
	public int countWords(String testAdvertisement)
	{
		//when the user doesn't type any letter
		if(testAdvertisement == null || testAdvertisement.isEmpty())
			return 0;
		
		int count = 0; // variable that counts the words
		//loop that runs all the string
		for(int number = 0; number < testAdvertisement.length(); number++)
		{
			//when the character in a specific position is not a blank character
			if(testAdvertisement.charAt(number) != ' ')
			{
				count++;
				//loop that finds the next blank , until the end of the string
				while(testAdvertisement.charAt(number) != ' ' && number < testAdvertisement.length()-1)
					number++;
			}
		
	    }
    return count;   
	}

	public double charge()
	{
		char ch;
		double payment = 0;
		
		if(countLetters() <= 25)
			payment =  5 * countWords(insertAdvertisement);	
		else if( 25 < countLetters() && countLetters() <= 100)
		{
			payment = 3.5 * countWords(insertAdvertisement.substring(25, insertAdvertisement.length())) + countWords(insertAdvertisement.substring(0, 24))*5 ;
			ch = insertAdvertisement.charAt(24);
				if(ch!= ' ')//if the method substring cuts a word in the middle 
					payment= payment - 5; // in this situation the half word is being charged from the second level of charging
		}
		else 
		{
			payment = 2*countWords(insertAdvertisement.substring(101, insertAdvertisement.length()))+ 3.5 * countWords(insertAdvertisement.substring(25, 99)) + countWords(insertAdvertisement.substring(0, 24))*5 ;
			ch = insertAdvertisement.charAt(24);
			if(ch!= ' ')
				payment= payment - 5;
				
			ch = insertAdvertisement.charAt(99);
		  	if(ch!= ' ')
		  		payment= payment- 3.5;
		}
		return payment;
	}
	
	public int countLines(String testAdvertisement)
	{
		int countLine = 0;// variable that counts the lines
		//when the user doesn't type any letter
		if(testAdvertisement == null || testAdvertisement.isEmpty())
			return 0;
		
		countLine = (testAdvertisement.length() - 1 ) / 11;
		
		if(( testAdvertisement.length() - 1  % 11) != 0 )
			countLine++;

    return countLine;   
	}
	public void writeOutPut()
	{
		int numberOfLetters = countLetters();
		System.out.println("1: You gave as an advertisment: " + insertAdvertisement);
		System.out.println("2: Your advertisment has " + numberOfLetters + " letters." );
		System.out.println("3: The number of words are: " + countWords(insertAdvertisement));
		System.out.println("4: the charge is: " + charge()+ " €");
		System.out.println("5: the number of lines is: " + countLines(insertAdvertisement));	
	}
}