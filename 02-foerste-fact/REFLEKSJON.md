# Arbeidslogg – Første xUnit-test og Arrange–Act–Assert

## Før koding

Min forventning og begrunnelse:
Jeg regner med at testen blir bestått, testen sjekker om resultatet er lik 24, 3*4*2 = 24

## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
Kjør uten koding | passed | passed | |
implementert 0,4 test = 0 | passed | passed | |
implementert 1,1 test = 2 | passed | passed | |
endret multiplikator til 3 | 2 failed | 2 failed | |


## Etterpå

Hvilke filer endret jeg, og hvorfor?
FuelCalculators for å endre multiplikator
ExerciseTests for å implementere nye tester
Svar på refleksjonsspørsmålene:
Kun en test består når man endrer multiplikatoren fordi det er fremdeles tull å gange med null.
Bruke null i eksempler er en like dårlig ide som å bruke tallet 2 gjentatte ganger, man kan komme frem til riktig resultat men man har ingen garanti for at riktig utregning ble gjort.
