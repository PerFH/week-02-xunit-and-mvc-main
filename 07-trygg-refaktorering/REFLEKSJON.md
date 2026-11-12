# Arbeidslogg – Oppskytingspris: forbedre grønn kode

## Før koding

Min forventning og begrunnelse:
alle testene kommer til å bli passed, matematikken stemmer, jeg ser en ting som bryter DRY konseptet, regner med at det blir endring på strukturen i if blokken og at testene kommer til å passere hele veien
## Forsøk

Handling / testnavn | Forventet | Faktisk
---|---|---|---
test før koding | 5 passed | 5 passed 
2 nye inline linjer | 7 passed | 7 passed
gitt variabler mer deskriptive navn | 7 passed | 7 passed
skrevet om metoden etter DRY konseptet | 7 passed | 7 passed
endret pris til 21 | tester der hasPriority er false vil passe, det er 4 av de | 4 succeeded, 3 failed
endret pris tilbake til 20 | 7 passed | 

## Etterpå

Hvilke filer endret jeg, og hvorfor?
Launchprice, x ble endret til calculatedPrice, p ble endret til hasPriority, n ble endret til headCount
senere refaktorert, gammel kode er kommentert ut

Svar på refleksjonsspørsmålene:

1. Hva ble lettere å forstå etter refaktoreringen?
det ble mye klarere med en gang hva som faktisk blir regnet sammen etter variablene fikk nye navn
2. Hvorfor kjørte du testene mellom endringene?
for å passe på at ting ble endret riktig, dette følger det vitenskapelige prinsippet ang endring og fremgangsmåte, endre en ting av gangen, så kontroller, hvis ikke kan det fort bli rot
3. Hva er forskjellen på å forbedre beregningen og å endre prisregelen?
det forbedre beregningen er refakturering, endre på pris reglen er funksjons endring
4. Kan en grønn testpakke garantere riktig oppførsel for tilfeller testene ikke undersøker? Hvorfor eller hvorfor ikke?
Det kan ikke garantere riktig oppførsel, 2+2 er 4 2*2 er også 4, hvis man tester om x,y=4 så sier det ingenting om at regnemetoden er korrekt, og der tror jeg også det ga litt mer mening hvorfor vi også konsekvent skriver tester som skal feile.