using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

public class X {
	public int Foo() { return 2; }
	public virtual int Bar() { return 1; }
}

public class Y: X {
	public new int Foo() { return 0; }
	public override int Bar() { return 5; }
}
class Program01
{
 static void Main()
	{
		X x = new X();
		Y y = new Y();

		int v1 = x.Foo();
		int v2 = x.Bar();
		int v3 = y.Foo();
		int v4 = y.Bar();
		int v5 = ((X)y).Foo();
		int v6 = ((X)y).Bar();

		Console.WriteLine(v1+" "+v2+" "+v3+" "+v4+" "+ v5+" "+v6);
	}
}
