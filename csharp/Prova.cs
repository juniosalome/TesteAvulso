using System;

public class Prova{
	public static void Main(){
		int[] a = new int[10];
		int i = 0;
		
		while(i<10){
			a[i]=i + (i>0 ? a[i-1] : 0);
			i++;
		}
	
		Console.WriteLine(a[9]);
	
	}

}
