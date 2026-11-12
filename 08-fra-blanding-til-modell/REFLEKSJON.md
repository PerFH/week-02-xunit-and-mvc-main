# Arbeidslogg – Skill oppskytingsregelen fra konsollen

## Før koding

Min forventning og begrunnelse:
Her blir det å flytte bool canlaunch inn i metoden, oppgaven til metoden er å sjekke om både fuel er over minimumskravet, og sjekke om man har tillatelse. Oppgaven til konsollen er UI, der kan data bli punchet inn, og brukener får se hva programmet svarer. Den ene failer fordi den forventer at CanLaunch er true, uten en implementert metode så defaulter denne til false, som gjør at den andre testen får success, fordi den forventer at resultatet skal være false.
## Forsøk

Handling / testnavn | Forventet | Faktisk
---|---|---|---
test før koding | 1 passed, 1 failed | 1 passed, 1 failed
lagt til nye InlineData linjer | alle som forventer at resultatet skal være false består, av disse er det 3 | 3 passed, 2 failed
flytter canlaunch bool over i metoden | kompilerer ikke | som forventet
endre canlaunch variablen i if til et kall med korrekte argumenter | compiler | compiler
kjører tester etter den compiler| 5 passed | 2 failed
return false -> return canlaunch | overså at den returnerte false, 5 passed | 5 passed 
run 50, ja | klar for oppskyting | klar for oppskyting
run 49, ja | oppskyting avvist | oppskyting avvist
run 50, nei | oppskyting avvist | oppskyting avvist

## Etterpå

- Hvilken test feilet i starten, og hvorfor?
    alle tester som forventet true feilet i starten fordi metoden som ble testet returnerte alltid false

- Hvilke nye testtilfeller la du til?
    [InlineData(50, false, false)]
    [InlineData(100, true, true)]
    [InlineData(0, true, false)]

- Hva endret du i `LaunchPolicy.cs`?
bool canLaunch = fuel >= 50 && approved; hentet fra Program.cs og endret til bool canLaunch = fuel >= 50 && safetyApproved;

- Hva endret du i `Program.cs`?
fjernet bool canLaunch
if (canlaunch) -> if (LaunchPolicy.CanLaunch(fuel, approved))


Svar på refleksjonsspørsmålene:
1. Hvorfor er det enklere å teste `LaunchPolicy.CanLaunch()` når metoden ikke bruker `Console`?
    Fordi console readline ville ventet på en ny linje som aldri kom, evt måtte man testet dette ved å kjøre programmet ørten ganger.
2. Hvorfor bør oppskytingsregelen bare finnes ett sted?
    dont repeat yourself, og hvis man lager reglen flere steder, så må man også endre den på lik måte på alle stedene, hvis ikke kan det oppstå mange unødvendige og merkelige problemer, selv i dette lille programmet klarte jeg å overse at metoden alltid returnerte false
3. Hva er forskjellen på det enhetstestene kontrollerer, og det du kontrollerer når du kjører konsollapplikasjonen?
    enhetstestene sjekker metoden, når jeg kjører applikasjonen passer jeg på at brukersiden opplevelsen stemmer over ens med mekanikken
4. Hvorfor er det ikke nok å lage egne mapper for Model, View og Controller hvis forretningsreglene fortsatt er blandet med resten av koden?
    fordi du deler faktisk ikke opp ansvaret, det blir missvisende for evt. nestemann som skal jobbe på koden, og det kan gjøre at programmet får veldig merkelige, sjeldne edge cases



