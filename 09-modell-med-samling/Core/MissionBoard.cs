namespace SpaceAcademy;

public class MissionBoard
{
    private List<MissionTask> _tasks = new List<MissionTask>();
    private int _nextId = 1;
    public int Count { get { return _tasks.Count; } }

    public MissionTask Add(string title)
    {
        var task = new MissionTask(_nextId, title);
        _nextId++;
        _tasks.Add(task);
        return task;
    }

    public List<MissionTask> GetAll()
    {
        return new List<MissionTask>(_tasks);
    }

    public bool Complete(int id)
    {
        foreach (var task in _tasks)
            if (task.Id == id)
            {
                task.Complete();
                return true;
            }
        return false;
    }
}

/*
4. Implementer fullføring i modellen
Åpne MissionBoard.cs igjen.

Nå skal du implementere Complete(int id).

Metoden skal:

Finne oppdraget som har den oppgitte ID-en.
Bruke oppdragets eksisterende Complete()-metode til å fullføre det.
Returnere true hvis oppdraget finnes.
Returnere false hvis ingen oppdrag har denne ID-en.
Husk at en ID ikke er det samme som en listeindeks.

Ikke lag en ny fullføringsregel i MissionBoard. Bruk funksjonaliteten som allerede finnes i MissionTask.

Ikke endre forventningene i testene.
*/