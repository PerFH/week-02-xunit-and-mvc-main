# Arbeidslogg – Oppdragskort: første Red–Green–Refactor

## Før koding

Min forventning og begrunnelse:
har ikke så store forventninger her annet enn å utvikle en bedre forståelse for fremgangsmetoden, først skrive en test som konsekvent feiler virker litt bakvendt for meg
## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
kontrolltest | 1 succeeded | som forventet
Calling_EmptyCompleteMethod(uten argumenter) | vil den i det hele tatt compile? | nei
Calling_EmptyCompleteMethod(med argumenter) | compiler, men failer testen | som forventet
Calling_CompleteMethod | 2 passed tests | som forventet
Calling_CompleteMethodTwice | 3 passed tests | som forventet

| Fase | Hva endret jeg? | Hva var resultatet?
|---|---|
| ERROR | var task = new MissionTask(); task.Complete(); | Compiler ikke |
| Red | var task = new MissionTask(7, "Sjekk antenne"); task.Complete(); | compiler men feiler
| Green |   public void Complete() {IsCompleted = true;} | compiler og passer
| Refactor | Nei, oppgaven var å refaktorere, ikke å endre funksjonalitet | uendret

## Etterpå

Hva lærte jeg?
Jeg lærte at tester må i det minste oppfylle kravene til compiling.

Hvilke filer endret jeg, og hvorfor?
endret pr instruks i readme.md

Svar på refleksjonsspørsmålene:
1. Hvorfor skrev du fullføringstesten før du implementerte `Complete()`?
Fordi det er fremgangsmåten som blir brukt i TDD.
2. Hvorfor var det positivt at testen først feilet?
Dette virker fremdeles helt bakvendt for meg, bortkastet tid å skrive en test du vet kommer til å feile, men kanskje det er enda en ting som gir mer mening når man jobber med større programkode.
3. Hvorfor er det å implementere `Complete()` en funksjonsendring og ikke refaktorering?
Fordi man endrer funksjonalitet på metoden. Blir det fremdeles funksjonsendring dersom man hadde kommentert "//makes complete true" i pseudokode?
4. Hvorfor trenger du ikke nødvendigvis endre koden i Refactor-fasen?
Koden kan forbedres, men det kommer helt ann på hva for funksjonalitet man ønsker, slik som det er nå så vil funksjonaliteten endres dersom man endrer på complete, og slik som jeg forstår det blir det da ikke en refaktorering.
