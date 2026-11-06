# Arbeidslogg – Forsyninger: fra krav til testeksempler

## 1. Forventet og faktisk resultat

Fyll inn **Forventet** før du kjører programmet. Etter at du har kjørt alle fem tilfellene, fyller du inn **Faktisk** og om resultatene stemte.

| Inndata | Forventet | Faktisk | Stemte det? |
|---|---|---|---|
| 3 personer, 4 dager | 24 | 24 | ja |
| 0 personer, 4 dager | 0 | 0 | ja |
| 3 personer, 0 dager | 0 | 0 | ja |
| 1 person, 1 dag | 2 | 2 | ja |
| 20 personer, 30 dager | 1200 | 1200 | ja |

Hvordan fant du frem til de forventede resultatene?

## 2. Prøv å innføre en feil

Endre multiplikatoren fra 2 til 3, og kjør programmet på nytt.

**Hvilke tilfeller avslørte feilen?**
Alle tilfeller der resultatet ikke ble null ovenfor, resultatet ble økt med 50% fordi multiplikatoren ble økt med 50%

**Hvilke tilfeller ga fortsatt riktig resultat?**
Alle tilfeller der resultatet ble null ovenfor.

**Hvorfor kan nulltilfellene gi riktig resultat selv om multiplikatoren er feil?**

Å gange med null gir alltid null

## 3. Refleksjon

Hvorfor er det ikke nok at programmet skriver ut et resultat for å avgjøre om en test består?
Vi må passe på at resultatet stemmer.

## 4. Endringer

Hvilke filer endret du, og hvorfor?
FuelCalculators: eneste stedet jeg fant en multiplikator
Argumentene til FuelCalculator.Calculate for å teste resultatene.
