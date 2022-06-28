Random random = new Random();

/*
 * Snack 11
 * Dare la possibilità di inserire due parole.
 * Verificare tramite una funzione che le due parole abbiano la stessa
 * lunghezza. Se hanno la stessa lunghezza, stamparle entrambe,
 * altrimenti stampare la più lunga delle due.
 */

string PrintStrings(string first, string second)
{
    if (first.Length == second.Length)
    {
        return first + " " + second;
    }
    else if (first.Length > second.Length)
    {
        return first;
    }
    else
    {
        return second;
    }
}

Console.WriteLine("Inserisci una parola");
string firstString = Console.ReadLine();
Console.WriteLine("Inserisci un'altra parola");
string SecondString = Console.ReadLine();
Console.WriteLine(PrintStrings(firstString, SecondString));


/*
 * Snack 10
 * Fai inserire un numero, che chiameremo N, all'utente.
 * Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
 * Ogni volta che ne crei uno, stampalo a schermo
*/
Console.WriteLine("\nSNACK 10\n");

Console.WriteLine("Inserisci un numero");
string? input10 = Console.ReadLine();
while (!int.TryParse(input10, out _))
{
    Console.WriteLine("Inserisci un numero");
    input10 = Console.ReadLine();
}

for (int i = 0; i < int.Parse(input10); i++)
{
    int[] array = new int[10];
    for (int j = 0; j < array.Length; j++)
    {
        array[j] = random.Next(1, 101);
    }
    Console.WriteLine($"Array {i + 1}: [{ string.Join(", ", array) }]");
}

/*
 * Snack 6
 * In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all'utente il suo nome e comunicagli se può partecipare o meno alla festa
*/

Console.WriteLine("\nSNACK 6\n");

string[] guests = {
    "Nick Carraway",
    "Daisy Buchanan",
    "Tom Buchanan",
    "Jordan Baker",
    "Myrtle Wilson",
    "George Wilson",
    "Owl Eyes",
    "Klipspringer",
    "Meyer Wolfsheim"
};

Console.WriteLine("Inserisci il tuo nome, verificheremo se sei sulla lista per la festa del signor Gatsby");
string? input6 = Console.ReadLine();
bool isInGuest = false;

for (int i = 0; i < guests.Length && !isInGuest; i++)
{
    if (guests[i].ToLower() == input6.ToLower())
    {
        isInGuest = true;
    }
}

string output6 = isInGuest ? "Puoi partecipare alla festa" : "Mi dispiace, non puoi partecipare alla festa";
Console.WriteLine(output6);

/*
 * Snack 5
 * Il software deve chiedere all'utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo
*/
Console.WriteLine("\nSNACK 5\n");

Console.WriteLine("Inserisci un numero, se il numero è pari verrà stampato, altrimenti verrà stampato il numero successivo");
string? input50 = Console.ReadLine();
while (!int.TryParse(input50, out _))
{
    Console.WriteLine("Inserisci un numero");
    input50 = Console.ReadLine();
}

int output50 = int.Parse(input50) % 2 == 0 ? int.Parse(input50) : int.Parse(input50) + 1;
Console.WriteLine(output50);

/*
 * Snack 4
 * Calcola la somma e la media dei numeri da 2 a 10
*/

Console.WriteLine("\nSNACK 4\n");
int sum2 = 0;
int begin = 2;
int end = 10;

for (int i = begin; i <= end; i++)
{
    sum2 += i;
}

float avg = sum2 / (10 - 2);

Console.WriteLine($"La somma dei numeri da {begin} a {end} è {sum2}\nLa media è {avg}");

/*
 * Snack 3
 * Il software deve chiedere per 10 volte all’utente di inserire un numero.
 * Il programma stampa la somma di tutti i numeri inseriti.
*/

Console.WriteLine("\nSNACK 3\n");

Console.WriteLine("Inserisci 10 numeri, verrà stampata la loro somma");
int sum = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Inserisci {i + 1}° numero");
    string? input = Console.ReadLine();
    while (!int.TryParse(input, out _))
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

string output = "";
if (!string.IsNullOrEmpty(input3) && !string.IsNullOrEmpty(input4))
{
    output += input3.Length > input4.Length ? input3 + " " + input4 : input4 + " " + input3;
}
Console.WriteLine(output);

/* 
 * Snack 1
 * L'utente inserisce due numeri in successione. Il software stampa il maggiore
*/

Console.WriteLine("\nSNACK 1\n");

Console.WriteLine("Inserisci due numeri, verrà stampato il maggiore");

Console.WriteLine("Inserisci il primo numero");
string? input1 = Console.ReadLine();
while (!int.TryParse(input1, out _)) {
    Console.WriteLine("Inserisci un numero");
    input1 = Console.ReadLine();
}

Console.WriteLine("Inserisci il secondo numero");
string? input2 = Console.ReadLine();
while (!int.TryParse(input2, out _) )
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
