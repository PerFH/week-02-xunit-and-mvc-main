using SpaceAcademy;

Console.Write("Drivstoff (heltall 0–100): ");
int fuel = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Sikkerhet godkjent? Skriv ja: ");
bool approved = Console.ReadLine() == "ja";
//bool canLaunch = fuel >= 50 && approved;
if (LaunchPolicy.CanLaunch(fuel, approved))
{
    Console.WriteLine("Klar for oppskyting.");
}
else
{
    Console.WriteLine("Oppskyting avvist.");
}
