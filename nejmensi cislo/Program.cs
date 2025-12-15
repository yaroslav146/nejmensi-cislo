float cislo1;
float cislo2;
float cislo3;
bool zkouska;

do
{
    Console.Write("zadejte cislo1 totiž čislo A: ");
    if (float.TryParse(Console.ReadLine(), out cislo1) == true)
        zkouska = true;
    else zkouska = false;
} while (zkouska == false);
do
{
    Console.Write("zadejte cislo2 totiž čislo B: ");
    if (float.TryParse(Console.ReadLine(), out cislo2) == true)
        zkouska = true;
    else zkouska = false;
} while (zkouska == false);
do
{
    Console.Write("zadejte cislo3 totiž čislo C: ");
    if (float.TryParse(Console.ReadLine(), out cislo3) == true)
        zkouska = true;
    else zkouska = false;
} while (zkouska == false);
Console.WriteLine();

if (cislo1 < cislo2 && cislo1 < cislo3)
{ Console.WriteLine($"Nejmenší číslo je čislo A: {cislo1}"); }
if (cislo2 < cislo1 && cislo2 < cislo3)
{ Console.WriteLine($"Nejmenší číslo je čislo B: {cislo2}"); }
if (cislo3 < cislo1 && cislo3 < cislo2)
{ Console.WriteLine($"Nejmenší číslo je čislo C: {cislo3}"); }
if (cislo1 == cislo2 && cislo2 < cislo3)
{ Console.WriteLine($"Číslo A a číslo B jsou jsou nejmenší čísla, nebo-li: {cislo2}"); }
if (cislo1 == cislo3 && cislo3 < cislo2)
{ Console.WriteLine($"Číslo A a číslo C jsou jsou nejmenší čísla, nebo-li: {cislo2}"); }
if (cislo2 == cislo3 && cislo3 < cislo1)
{ Console.WriteLine($"Číslo B a číslo C jsou jsou nejmenší čísla, nebo-li: {cislo2}"); }