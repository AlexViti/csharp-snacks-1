/*
 * Snack 4
 * Calcola la somma e la media dei numeri da 2 a 10
*/

Console.WriteLine("SNACK 4\n");
int sum2 = 0;
int begin = 2;
int end = 10;

for (int i = begin; i <= end; i++)
{
    sum2 += i;
}

float avg = sum2 * 1f / (10 - 2);

Console.WriteLine($"La somma dei numeri da {begin} a {end} è {sum2}\nLa media è {avg}");

/*
 * Snack 3
 * Il software deve chiedere per 10 volte all’utente di inserire un numero.
 * Il programma stampa la somma di tutti i numeri inseriti.
*/

Console.WriteLine("Snack 3");
Console.WriteLine("Inserisci 10 numeri");
int inp;
int sum = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Inserisci {i + 1}° numero");
    string? input = Console.ReadLine();
    while (!int.TryParse(input, out inp))
    {
        Console.WriteLine("Inserisci un numero");
        input = Console.ReadLine();
    }
    int num = int.Parse(input);
    sum += num;
}

Console.WriteLine($"La somma è {sum}");

/*
 * Snack 2
 * L'utente inserisce due parole in successione.
 * Il software stampa prima la parola più lunga e poi quella più corta
*/

Console.WriteLine("Inserisci due parole");
string? input3 = Console.ReadLine();
string? input4 = Console.ReadLine();

string output = input3.Length > input4.Length ? input3 + " " + input4 : input4 + " " + input3;
Console.WriteLine(output);

/* 
 * Snack 1
 * L'utente inserisce due numeri in successione. Il software stampa il maggiore
*/

int integer;
Console.WriteLine("Snack 1");
Console.WriteLine("Inserisci il primo numero");
string? input1 = Console.ReadLine();
while (!int.TryParse(input1, out integer)) {
    Console.WriteLine("Inserisci un numero");
    input1 = Console.ReadLine();
}
Console.WriteLine("Inserisci il secondo numero");
string? input2 = Console.ReadLine();
while (!int.TryParse(input2, out integer) )
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
