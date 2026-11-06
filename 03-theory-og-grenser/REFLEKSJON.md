# Arbeidslogg – Setereservasjon: Theory og grensetilfeller

## Før koding

Min forventning og begrunnelse:
Inline Data 4,4 kommer til å feile, fordi seat policy vil at requests skal være større en null, og at requested er mindre enn available

## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---
kjøre koden før endring | 4,4 failed | 4,4 failed | lese koden før man starter er alltid viktig |
| 1,4 `true` | passed | som forventet | |
| 3,4 `true` | passed | som forventet | |
| 4,4 `true` | failed | som forventet | |
| 5,4 `false` | passed | som forventet | |
| 0,4 `false` | passed | som forventet | |
| -1,4 `false` | passed | som forventet | |
| 1,0 `false` | passed | som forventet | |
Endret < til <= | 7 passed | 7 passed


## Etterpå

Hvilke filer endret jeg, og hvorfor?
Jeg endret SeatPolicy, gjorde < om til <=, slik at den nå sjekker om antall ledige seter er lik eller mer enn reserveringer.
        return requested > 0 && requested <= available;

Svar på refleksjonsspørsmålene:
Theory indikerer hvor noe skal testes, blanding av metode og scope setter, inline data forteller hvilken data vi skal bruke i testen
Assert.Equal sammenligner to verdier og sjekker om de er like, returner true hvis det stemmer. 
