
Console.WriteLine("Hello Method!");
Console.WriteLine("==========================================");
//Methode A
void DireBonjour()
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Bonjour {i}");
    }
}
DireBonjour();
//Methode 2
void Bonjour() => Console.WriteLine("Bonjour b !");
Bonjour();
int add(int x, int y) => x + y;
int res = add(5, 6);
Console.WriteLine($"La somme de 5 et 6 est {res}");
Console.WriteLine("====================Exemple======================");
//Methode Void
void Addition(int a, int b)
{
    Console.WriteLine($"La somme de {a} et {b} est {a + b}");
}
Addition(5, 6);
void substraction(int a, int b)
{
    Console.WriteLine($"La soustraction de {a} et {b} est {a - b}");
}
substraction(5, 6);
void multiplication(int a, int b)
{
    Console.WriteLine($"La multiplication de {a} et {b} est {a * b}");
}
multiplication(5, 6);
void division(int a, int b)
{
    if (b != 0)
    {
        Console.WriteLine($"La division de {a} et {b} est {a / b}");
    }
    else
    {
        Console.WriteLine("Erreur : Division par zéro impossible");
    }
}
division(5, 6);
//Methode Return
int Addition2(int a, int b)
{
    return a + b;
}
int resultatAddition = Addition2(5, 6);
Console.WriteLine($"La somme de 5 et 6 est {resultatAddition}");
//Methode static 
static void DireBonjour1(string nom)
{
    Console.WriteLine($"Bonjour {nom}");
}
DireBonjour1("Hassan");
//Méthode params  //Permet d'envoyer un nombre indéfini d'arguments.
void AfficherNombres(params int[] nombres)
{
    foreach (int nombre in nombres)
    {
        Console.Write($"{nombre} ");
    }
    Console.WriteLine();
}
AfficherNombres(1, 2, 3, 4, 5);//1 2 3 4 5

Console.WriteLine("=================ref , out  =========================");
void ModifierValeur(ref int nombre)
{
    nombre += 10;
}
int valeur = 5;
Console.WriteLine("Avant : " + valeur);
ModifierValeur(ref valeur);
Console.WriteLine("Après : " + valeur);

void CalculerSomme(int a, int b, out int somme)
{
    somme = a + b;
}
int resultat;
CalculerSomme(3, 7, out resultat);
Console.WriteLine("La somme est : " + resultat);



Console.WriteLine("=================Tuple =========================");
(int Somme, double Moyenne) CalculerSommeEtMoyenne(int a, int b)
{
    int somme = a + b;
    double moyenne = (double)somme / 2;
    return (somme, moyenne);
}
var resulta = CalculerSommeEtMoyenne(8, 12);
Console.WriteLine($"Somme : {resulta.Somme}, Moyenne : {resulta.Moyenne}");

List<(string Nom, int Score)> joueurs = new List<(string, int)>
{
    ("Alice", 95),
    ("Bob", 88),
    ("Charlie", 92)
};

foreach (var joueur in joueurs)
{
    Console.WriteLine($"Joueur : {joueur.Nom}, Score : {joueur.Score}");
}

(string, int, double) GetPersonInfo()
{
    return ("Alice", 25, 65.5);
}
var person = GetPersonInfo();
Console.WriteLine($"Nom : {person.Item1}, Âge : {person.Item2}, Poids : {person.Item3} kg");

void AfficherInfos((string Nom, int Age) personne)
{
    Console.WriteLine($"Nom : {personne.Nom}, Âge : {personne.Age}");
}
var personne = ("Bob", 30);
AfficherInfos(personne);


Console.WriteLine("=================Exercice Calculatrice =========================");
int a1 = ReadNamber("Entrer le premier nombre : ");
int b1 = ReadNamber("Entrer le deuxième nombre : ");
void Messege(string message)
{
    Console.WriteLine("****************");
    Console.WriteLine(message);
    Console.WriteLine("****************");
}
int ReadNamber(string message)
{
    Console.WriteLine("****************");
    Console.WriteLine(message);
    Console.WriteLine("****************");
    int Number = 0;
    bool isConverted = int.TryParse(Console.ReadLine(), out Number);
    return Number;
}
char ReadCharacter(string message)
{
    Console.WriteLine("****************");
    Console.WriteLine(message);
    Console.WriteLine("****************");
    char input = 'C';
    bool isConverted = char.TryParse(Console.ReadLine(), out input);
    return input;
}
char Input = ReadCharacter("Entrer l'opération à effectuer : ");
int Addition1(int a1, int b1)
{
    return a1 + b1;
}

int substraction1(int a1, int b1)
{
    return a1 - b1;
}

int multiplication1(int a1, int b1)
{
    return a1 * b1;
}

int division1(int a1, int b1)
{
    if (b1 != 0)
    {
        return a1 / b1;
    }
    else
    {
        return 0;
    }
}
double calcl = 0;
switch (Input)
{
    case '+':
        calcl = Addition1(a1, b1);
        break;
    case '-':
        calcl = substraction1(a1, b1);
        break;
    case '*':
        calcl = multiplication1(a1, b1);
        break;
    case '/':
        calcl = division1(a1, b1);
        break;
    default:
        Messege("Erreur : Opération invalide");
        break;
}
Console.WriteLine("Résultat : " + calcl);

Console.WriteLine("=================Exercice =========================");
int Factorielle(int n)
{
    return (n == 1 || n == 0) ? 1 : n * Factorielle(n - 1);
}
Console.WriteLine(Factorielle(5));
Console.WriteLine("=================Exercice =========================");
int Somme(int n)
{
    return (n == 0) ? 0 : n + Somme(n - 1);
}
Console.WriteLine(Somme(5));
Console.WriteLine("=================Exercice =========================");
int Fibonacci(int n)
{
    return (n <= 1) ? n : Fibonacci(n - 1) + Fibonacci(n - 2);
}
Console.WriteLine(Fibonacci(6));