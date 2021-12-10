
Console.WriteLine(@"Oh, Hi ...
SOME GAME I TOTALLY MADE FOR CLASS

So, like,  you are in a room, or something.
It's --totallty-- dark
Please enter your credit card number unlock 
 The NEW RED SKIN for only 15$ or maybe free
 Discord Nitro. Also you might get FREE PLEX

=================");
Console.Write("Credit Card Number:");
string line = Console.ReadLine();
line = line.Replace(" ","").Replace("-","");
System.Text.RegularExpressions.Regex isValidCC = new System.Text.RegularExpressions.Regex(@"\d{16}");
if(isValidCC.IsMatch(line)){
	Console.BackgroundColor = ConsoleColor.Red;
    Console.Clear();
	Console.ForegroundColor = ConsoleColor.White;

	Console.WriteLine(@"Thank you.

You are an IDIOT.

Have a Less dumb day.");
	for(var i = 0; i <64 ;i++){
		
			Console.Beep();
		
	}
}
else{

    Console.Clear();
	Console.WriteLine(@"You have failed. Please execute this program again for maximum joy sounds");
}

Console.WriteLine("Press any key to exit.");
var foo = Console.ReadLine();



