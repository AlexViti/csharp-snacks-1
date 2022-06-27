/* 
 * Snack 1
 * L'utente inserisce due numeri in successione. Il software stampa il maggiore
*/

Console.WriteLine("Snack 1");
Console.WriteLine("Inserisci il primo numero");
string input1 = Console.ReadLine();
while (!int.TryParse(input1)) {
    Console.WriteLine("Inserisci un numero");
    input1 = Console.ReadLine();
}
Console.WriteLine("Inserisci il secondo numero");
string input2 = "" + Console.ReadLine();
while (!int.TryParse(input2) )
{
    Console.WriteLine("Inserisci un numero");
    input2 = Console.ReadLine();
}

int num1 = int.Parse(input1);
int num2 = int.Parse(input2);

if (num1 > num2)
{
    Console.WriteLine("Il primo numero è maggiore: " + num1);
}
else if (num1 < num2)
{
    Console.WriteLine("Il secondo numero è maggiore: " + num2);
}
else
{
    Console.WriteLine("I numeri sono uguali: " + num1);
}

/*
 * Snack 2
 * L'utente inserisce due parole in successione.
 * Il software stampa prima la parola più lunga e poi quella più corta
*/ 