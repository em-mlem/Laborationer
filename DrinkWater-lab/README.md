# Vattenkalkylatorn 

## Beskrivning
Eva älskar att träna på löpbandet. Men det är viktigt att hålla koll på vätskebalansen.  
Därför dricker hon **0,5 liter vatten per timma** hon tränar.

Hon har däremot problem att hålla koll på matematiken.  
Din uppgift är att bygga en **vattenkalkylator** i WPF som hjälper henne.

## Uppgift
I textrutan ska Eva kunna fylla i **antalet timmar hon tränar** – även med **decimaltal**.  
När hon klickar på en knapp ska programmet visa **hur många liter vatten hon behöver dricka**.

Resultatet ska visas i en **MessageBox**, avrundat **nedåt till heltal**.

### Exempel
| Träningstid (timmar) | Beräkning          | Resultat (liter) |
|------------------------|--------------------|------------------|
| 1                      | 1 × 0,5 = 0,5      | 0                |
| 2,5                    | 2,5 × 0,5 = 1,25   | 1                |
| 5                      | 5 × 0,5 = 2,5      | 2                |
| 7,9                    | 7,9 × 0,5 = 3,95   | 3                |


## Självtest
- [ ] Programmet startar utan fel.  
- [ ] TextBox accepterar decimaltal.  
- [ ] Knappen visar rätt vattenmängd.  
- [ ] Resultatet avrundas nedåt.  

## Del 2 – Hela flaskor
Eva vill inte hälla ut vatten i onödan så hon dricker alltid ur hela flaskan.
Hon vill samtidigt inte riskera att dricka för lite vatten. Se därför till att du 
alltid fyller så många flaskor hon behöver.

Undersök 'Math.Ceiling' och se om du kan få ett bättre resultat.
Fundera, vad blir skillanden mot att avrunda?

### Exempel
| Träningstid (timmar) | Beräkning          | Resultat (liter) |
|------------------------|--------------------|------------------|
| 1                      | 1 × 0,5 = 0,5      | 1                |
| 2,5                    | 2,5 × 0,5 = 1,25   | 2                |
| 5                      | 5 × 0,5 = 2,5      | 3                |
| 7,9                    | 7,9 × 0,5 = 3,95   | 4                |


## Del 3 – Sportdryck
Eva har börjat fundera på sportdryck.  
Vad innehåller den egentligen?

Ingredienslistan visar till exempel:  
**C<sub>6</sub>H<sub>12</sub>O<sub>6</sub>H<sub>2</sub>O** = Glukos (dextros) och vatten

Vi ska som tur är inte bli kemister. Därför ska vi bara räkna väte-atomer: H

Ta reda på hur många H det är i molekylen (formeln) ovanför. Du behöver i den här delen enbart 
fokusera på bokstäver, inte siffror.
- Inga LINQ-metoder tillåtna — använd **loopar och if-satser**.

## Del 4 – Valfri bonus
Nu ska du också ta hänsyn till antalet atomer i en molekyl. Så H2O är två väteatomer och en syreatom.

Du behöver fortfarande enbart räkna väteatomer (H).
### Exempel
| Molekyl                | Antal  |
|------------------------|--------|
| H2O                    | 2      |
| HH2                    | 3      |
| H2OHO2H7               | 10     |
| C6H12O6H2OC6H12O6      | 26     |



