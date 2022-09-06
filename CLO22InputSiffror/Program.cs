// Heltal = int = int32


// Deklarera och tilldela värdet 0
int age = 0;

Console.WriteLine("Ange din ålder");
string input = Console.ReadLine();

age = int.Parse(input);
float days = 365.25f * age;
Console.WriteLine("Du har levt " + days + " dagar");

