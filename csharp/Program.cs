using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

  
public class Veiculo{
	public virtual void mover(){
	  Console.Write("Movendo");
	}
}

public class Automovel : Veiculo {
	public override void mover(){
	  Console.Write("Acelerador");
	}
}

public class Fusca: Automovel{
	public override void mover(){
	  Console.Write("Passeando");
	}
}

class Program
{
 static void Main()
	{
	  Veiculo veiculo = new Fusca();
		veiculo.mover();
	}
}
