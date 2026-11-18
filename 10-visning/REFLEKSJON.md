# Arbeidslogg – Visningen: vis data uten å endre dem

## Før koding

Min forventning og begrunnelse:
Programmet skal endres til å vise faktisk data på en lesbar måte, pr nå sier det bare hva den ønsker å vise. Hvis det var 3 oppdrag ville det fremdeles stått "to oppdrag" på demo 2 f.eks.

## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
kjørt tester | 4 succeeded | 4 succeeded | programmet fungerer som readme beskriver det
Implementert visning for 0 oppdrag | ingen oppdrag | som forventet | -
Implementert visning av oppdrag | 1: Sjekk antenne [Venter],2: Lad rover [Fullført] | 1: Sjekk antenne[Venter], 2: Lad rover[Fullført] | for å vise Fullført og Venter må man skrive en ny string variabel som endrer seg etter boolean, hvis ikke vil den bare returnere true/false
kjørt tester etter implementasjon | 4 succeeded | 4 succeed | min kode påvirker ikke dataen, kun hvordan den vises


## Etterpå

Hvilke filer endret jeg, og hvorfor?
ShowTasks har en egen melding for hvis det ikke er noen oppdrag å vise, uten den ville den ikke vist noen ting dersom det ikke var noen oppdrag å vise.

Svar på refleksjonsspørsmålene:

Hvorfor kan alle modelltestene bestå selv om konsollvisningen er feil?
Testene sjekker dataen, ikke hvordan brukeren ser den. Selv om det er dårlig visning så er dataen korrekt.

Hvorfor skal ShowTasks() bare lese oppdragenes tilstand og ikke endre den?
Dette blir ansvarsfordeling, showtasks er ansvarlig for å show... the tasks, andre deler av programmet er ansvarlig for å manipulere dataen.

Hvorfor får ShowTasks() en liste som argument, i stedet for å opprette sin egen MissionBoard?
Igjen ansvarsfordeling, den får listen via GetAll() som lager en ny liste - view.ShowTasks(board.GetAll());

Hvorfor hører valget mellom tekstene Venter og Fullført hjemme i View, mens selve fullføringen hører hjemme i modellen?
View er ansvarlig for presentasjonen av dataen som er tilgjengelig, selv om jeg har laget en ny variabel, statusText, så sjekker den bare status på boolean og viser status deretter, den endrer ikke på dataen.

