# Arbeidslogg – Kontrolleren: koble sammen en hel konsollapp

## Før koding

Min forventning og begrunnelse:
Hvor opprettes MissionBoard og MissionView?
 - I program.cs
Hvordan får MissionController tilgang til disse objektene?
 - Controller blir laget med board og view som args.
Hva skjer når controller.Run() kalles?
 - Når vi bruker det kallet får vi opp noen valgalternativer, programmet vil også vente på input fra bruker og deretter kjøre en    metode basert på brukerens input.
    

## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
kjørt tester | 4 succeed | 4 succeed | programmet fungerer som det skal i følge readme
implementert CompleteTask() | programmet legger til, og fullfører oppdrag når den får ID | som forventet feilmeldinger og looping fungerer som forventet også | - 
menyvalg: qdw | Ukjent menyvalg | ukjent menyvalg | -
menyvalg 3, afad | ID må være ett heltall | ID må være ett heltall, return to Run() | -
menyvalg 3, 999 | Fant ikke oppdrag med ID: 999 | Fant ikke oppdrag med ID: 999, return to Complete() | de returner til forskjellige steder for å unngå å bli fanget i Fullfør menyvalget.
test hele applikasjonen | besto alle tester etter å ha fulgt instrukser til punkt og prikke | programmet hadde nesten lik funksjonalitet | jeg kaller Complete() istedenfor Run() når feil int blir inputtet i menyvalg 3, løser seg med å input asd
kjørt tester | 4 succeed | 4 succeed | min implementasjon har ikke påvirket programmet på en måte det ikke skulle

## Etterpå

Hvilke filer endret jeg, og hvorfor?
Jeg tenkte det var greit med en metode som loopet seg selv frem til den fikk riktig ID, men før jeg kjørte programmet innså jeg at det ville gjøre at man kunne bli fanget i CompleteTask, derfor lot jeg int inputs out of range gjøre at metoden loopet seg selv, mens andre feilinputs vil returnere bruker til start menyen.

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

Svar på refleksjonsspørsmålene:

Hvorfor er det viktig at Program.cs oppretter MissionBoard bare én gang før menyløkken starter?
Hele programmet starter via controller.Run(), så program må opprette controller, controller krever et missionboard og et missionview - For å kunne bli opprettet. Uten MissionBoard vil ikke programmet kompilere.
Hvorfor bruker vi TryParse før vi kaller MissionBoard.Complete()?
- For å passe på at Complete(int id) får riktig type inn.
Hvorfor skal kontrolleren ikke selv lete gjennom listen med oppdrag og endre IsCompleted?
- hver del av programmet skal ha ett konkret ansvar, her er kontrolleren mellomleddet mellom brukeren og resten av programmet
Hvorfor kan modelltestene fortsatt være grønne selv om menyvalg 3 ikke fungerer?
- modelltestene gir selv eksempler på inndata og metodekall, selv om testen demonstrerer programflyten vi ønsker så betyr ikke det at den er implementert på en brukervennelig måte
Hva er ansvaret til Model, View og Controller når brukeren fullfører et oppdrag?
View viser controller brukerinput, controller sjekker om det kan være en int type, hvis teksten kan konverteres til en int så forteller den MissionBoard at ID x kan fullføres, MissionBoard sier bare tommel opp eller tommel ned til controller, controller vet nå at den kan be view om at den kan vise at oppdraget er fullført.



