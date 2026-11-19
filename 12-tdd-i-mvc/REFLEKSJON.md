# Arbeidslogg – Nytt behov: vis bare ufullførte oppdrag

## Før koding

Min forventning og begrunnelse:
GetPending_MixedBoard_ReturnsOnlyIncompleteTask() failer testen fordi den forventer et objekt i listen, men testen returnerer en tom liste. De andre testene består fordi de ikke tester den uimplementerte metoden


## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
kjørt tester | 5/6 succeed | 5/6 succeed | dette er å forvente iflg readme, programmet fungerer som det skal i starten av oppgaven
skrevet GetPending_ReturnsEmptyCopy() | succeed | succeed | GetPending returner en tom liste
skrevet GetPending_ReturnsOnlyIncompleteTasks | failed | failed | GetPending lager bare en tom liste
skrevet GetPending() | 7/7 succeed | 7/7 succeed | metoden returnerer bare incomplete tasks og putter de inn i en egen liste
skrevet AllMissionsComplete_GetPendingReturnsEmptyList | succeed | succeed | pending returnerer en tom liste når alle oppdrag er flagged som isComplete
Skrevet MissionOrder_IsPreservedInPendingList | succeed | failed | sammenlignet objekt id med id
fjernet id fra Assert.Same | succeed | succeed | gode tester blir med nødvendig ettersom kompleksiteten øker
skrevet GetPending_ReturnsFullCopyWhenAllMissionsArePending | succeed | failed | assert.same(board, pending fungerer ikke her)
endret til assert.same(first/second, pending[0/1]) | succeed | succeed | -
steg for steg testing | klarer hele tabellen | programmet returnerer forventet resultat og output | -
kjørt alle tester | 10/10 passed | 10/10 passed | -

## Etterpå

Hvilke filer endret jeg, og hvorfor?
Under refaktorering var det kun variabel navn som ga mening å gjøre tydligere foreach incomplete in _tasks er nå endret til foreach task in _tasks. Resten er tydelig og enkelt å lese.

Svar på refleksjonsspørsmålene:
Hvorfor skal filtreringen ligge i MissionBoard i stedet for i MissionView?
View er bare ansvarlig for hvordan data skal vises, filtreringen lager en liste og objekter blir puttet i den, dette er ikke view ansvar.
Hvorfor skal GetPending() returnere en ny liste i stedet for å fjerne fullførte oppdrag fra den eksisterende listen?
Getpending er bare filtrerer ut det som allerede er i den eksisterende listen, menyvalg 2 skal vise alle oppdrag, uansett status.
Hvorfor kan en test for tom tavle bestå selv om GetPending() ennå ikke er implementert riktig?
Den ufulstendige versjonen av GetPending returnerte bare en tom liste uansett. Testen sjekker om pending er en tom liste. Den mangler sanity checks.
Hvorfor trengte du ikke skrive en ny ShowTasks()-metode for menyvalg 4?
Showtasks godtar MissionTask lister som argumenter, pending listen er fremdeles en missiontask liste, her er DRY konseptet fulgt.
Hvordan hjalp de eksisterende testene deg med å kontrollere at den nye funksjonaliteten ikke ødela tidligere oppførsel?
Hvis en test som ikke feilet i starten begynner å feile vet jeg at jeg har tuklet med noe jeg ikke skulle. Ettersom ingen av de gamle testene feilet vet jeg at jeg bare kan fortsette, men dette krever gode tester.

