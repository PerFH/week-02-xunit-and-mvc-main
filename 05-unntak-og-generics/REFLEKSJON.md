# Arbeidslogg – Lastestabel: LIFO og forventede unntak

## Før koding

Min forventning og begrunnelse:
At det er snakk om outofrange exception her, i og med at det er ikke snakk om noen faktiske invalid operations, men uønskede operations, her ønsker man å holde seg innenfor array range.
## Forsøk



Handling / testnavn | Forventet | Faktisk
kjørte første test | out of range exception mangler | Expected: InvalidOp, Actual: OutOfRange
Pop_ReturnsItemsInLifoOrderString | 2 passed tests | 2 passed tests
Pop_ReturnsItemsInLifoOrderInt | 3 passed tests | 3 passed tests
Oppgradert Pop_EmptyStack testen | 3 passed test | 3 passed tests


## Etterpå

Hva lærte jeg?
Lærte litt mer om hvordan testene henger sammen, og at man kan bruke metoder i en Assert
Hvilke filer endret jeg, og hvorfor?
Endret kun det jeg fikk instrukser om å endre.
Svar på refleksjonsspørsmålene:

1. Hvorfor ville det vært feil å endre testen slik at den forventer det utilsiktede unntaket?
Fordi en outofrange exception vil ikke fyre av på index 0, men Pop vil fremdeles prøve å redusere _items.Count med 1 på index 0.
2. Hvorfor bruker vi `Assert.Throws` i stedet for `Assert.Equal` når vi tester et forventet unntak?
Assert.Equal sjekker at to verdier er like. Assert.Throws sjekker om metoden oppfører seg som forventet, ved å anta korrekt feilmelding.
3. Hva viser testene med `CargoStack<string>` og `CargoStack<int>` om generiske klasser?
At generiske klasser kan brukes til å håndtere forskjellige Typer (int, string, char osv.)


