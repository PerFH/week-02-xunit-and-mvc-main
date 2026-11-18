using SpaceAcademy;

namespace SpaceAcademy.ConsoleApp;

public class MissionController
{
    private MissionBoard _board;
    private MissionView _view;

    public MissionController(MissionBoard board, MissionView view)
    {
        _board = board;
        _view = view;
    }

    public void Run()
    {
        bool running = true;
        while (running)
        {
            _view.ShowMenu();
            string choice = _view.ReadInput("Valg: ");
            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    _view.ShowTasks(_board.GetAll());
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    _view.ShowMessage("Ukjent menyvalg.");
                    break;
            }
        }
    }

    private void AddTask()
    {
        string title = _view.ReadInput("Tittel: ");
        if (string.IsNullOrWhiteSpace(title))
        {
            _view.ShowMessage("Tittel kan ikke være tom.");
            return;
        }
        var task = _board.Add(title);
        _view.ShowMessage($"Opprettet oppdrag {task.Id}.");
    }

    private void CompleteTask()
    {
        if (int.TryParse(_view.ReadInput("ID; "), out int id))
        {
           if (_board.Complete(id))
            {
                _view.ShowMessage($"Oppdrag {id} fullført");
            }
            else
            {
                _view.ShowMessage($"Fant ikke oppdrag med ID: {id}");
                CompleteTask();
            }
        }
        else
        {
            _view.ShowMessage("ID må være ett heltall");
            Run();
        }

        // TODO: Les ID, tolk tekst, kall modellen, vis resultat.
       // _view.ShowMessage("Fullføring er ikke koblet til ennå.");
    }
}
/*

3. Implementer fullføring i kontrolleren
Åpne MissionController.cs og finn metoden CompleteTask().

Du skal erstatte den midlertidige meldingen med funksjonalitet som fullfører et oppdrag.

Metoden skal gjøre følgende:

Be brukeren om en ID ved hjelp av _view.ReadInput("ID: ").
Bruke int.TryParse() til å kontrollere om teksten er et heltall.
Hvis teksten ikke er et heltall, vise ID må være et heltall. og gå tilbake til menyen.
Hvis teksten er et heltall, kalle _board.Complete(id).
Hvis modellen returnerer true, vise Oppdrag 1 fullført. når ID-en er 1, og tilsvarende melding for andre ID-er.
Hvis modellen returnerer false, vise Fant ikke oppdraget.
Bruk _view.ShowMessage() til å vise meldingene.

Ikke bruk Console.ReadLine() eller Console.WriteLine() direkte i kontrolleren. Disse oppgavene håndteres allerede av View.

Du skal heller ikke endre MissionBoard.Complete(). Modellen vet allerede hvordan den finner og fullfører et oppdrag.


*/