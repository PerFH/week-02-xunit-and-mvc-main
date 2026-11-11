# Arbeidslogg – Lasterom: test tilstand uten testrekkefølge

## Før koding

Min forventning og begrunnelse:
CargoBay objektet blir opprettet i ExerciseTests
Assert.Equal antar at null og lengen på listen er det samme. Count øker i verdi for hvert objekt som blir lagt til, 0 = tom liste.

## Forsøk

Handling / testnavn | Forventet | Faktisk |
---|---|---|---
Constructor_StartsEmpty | Assert.Count 0 | Test Success |
Constructor_HasOne | Assert.Count 1, TryAdd = True | Test Success |
Constructor_HasTWo | Assert.Count 2, TryAdd = True | Test Success |
Constructor_CantAddMore | Assert.Count 2, TryAdd = false | Test Success |
Kjør alle testene | 4 passed | 4 passed |
Constructor_TwoBays | Assert.Equal(1, bay1.Count), Assert.Equal(0, bay2.Count)| Test Success
## Etterpå

Hva lærte jeg? 
På starten av oppgaven var jeg usikker på om en assertation telte som en test, iløpet av oppgaven lærte jeg at alt som står innenfor en Fact blokk teller som en test, uansett hvor mange assertations man har.

Hvilke filer endret jeg, og hvorfor?
La til tester i Excersise test, flyttet "hva lærte jeg?" fra tabellen til en egen bit i refleksjonsnotatet så man har bedre plass til å ordlegge seg selv uten at det ser rotetet ut.

Svar på refleksjonsspørsmålene:
1. Den tredje testen sjekker om programmet nekter å legge til mer dersom kapasiteten er nådd, så først må vi nå kapasiteten.
2. Det er viktig å teste begge av mange grunner, man kan få falsk positiv/negativ. Selv om metodene henger sammen så returnerer de false av forskjellige grunner. Hvis man hopper over kan det resultere i merkelige edge cases man ikke har tenkt over eller kommet borti fordi testen manglet viktige biter
3. hvis testene deler static objekt så kan testene gi et uforventet resultat, eller nekte å kompilere







