# Arbeidslogg – Oppdragstavlen: test modellen før menyen

## Før koding

Min forventning og begrunnelse:
1. Mission Board holder listen med oppdrag, men selve oppdragene hører til missionstasks.
2. Når MissionBoard.add blir kalt blir det laget et nytt objekt av klassen MissionTask
3. Objektet får tildelt ID fra _nextID som blir oppdatert med ++ hver gang Add blir påkalt
4. MissionTask.Complete() oppdaterer isComplete til true, 
5. MissionBoard.Complete() tar inn ID og returnerer pr. nå false.


- SpaceAcademy.Tests.ExerciseTests.Complete_KnownId_CompletesOnlySelectedTask [FAIL] - Assert.True(Result), får false
- UnknownID testen består fordi den antar at den ikke klarer å fullføre oppgave 99, og at isComplete = false, og at det er ett objekt i listen, alle disse punktene stemmer over ens med hva testen asserter.

## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
test GetAll_ReturnsEmptyCopy | Succeed | Succeed | alle bitene involvert fungerer som de skal
test CanCompleteSameIDTwice | failed | failed | complete returnerer false
test TwoIndependentMissionBoards | succeed | succeed | listene kopierer ikke hverandre automatisk, ID blir utdelt
test CopiesListWithObjects | succeed | succeed | Listen blir kopiert og objektene begge listene peker på er de samme
kjørt alle testene | 6/8 succeed | 6/8 succeed | ingenting har blitt endret mens jeg har implementert testene
implementert Complete(int id) | 8/8 succeed | 8/8 succeed | complete er implementert korrekt
## Etterpå

Hvilke filer endret jeg, og hvorfor?
endret pr readme instrukser 
Svar på refleksjonsspørsmålene:

Hvilken test feilet i starten, og hvorfor?
Testen forventet at verdien skulle være true, uten complete implementert vil den alltid returnere false
Hvilke fire nye tester skrev du?
Jeg skrev GetAll_ReturnsEmptyCopy, CanCompleteSameIDTwice, TwoIndependentMissionBoards, CopiesListWithObjects
Hva endret du i MissionBoard.Complete()?
jeg la til en foreach loop som sjekker om ID i argumentet matcher IDen til et objekt i listen, dersom den matcher så vil IsCompleted bli oppdatert til true.
Hvor mange tester besto etter implementasjonen?
8/8
Hva viste testen med Assert.Same()?
Assert same antar at to ting er/peker på det samme objektet, ikke en kopi, eller et annet objekt med like verdier.