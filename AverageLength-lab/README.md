# Medellängd av ord

## Beskrivning
EU har bestämt att alla personer måste föra statistik över **medelvärdet 
av längden på alla ord** hen säger i en mening.  

Din uppgift är att skriva en **metod** som beräknar detta.

## Uppgift
Skriv en metod med namnet `CalculateAverageWordLength` som tar emot en mening (`string`) och returnerar 
ett **decimaltal** (`double`) som visar medellängden av orden i meningen.

Alla skiljetecken (t.ex. `, . ! ?`) ska ignoreras när du räknar ordlängd.  
Tomma strängar eller flera mellanslag ska inte påverka resultatet.

Sätt egenskapen `AverageWordLength` i klassen `SentenceAnalyzer` till medelvärdet du just räknade ut.

### Metodsignatur
```csharp
CalculateAverageWordLength("A B C.") → 1
CalculateAverageWordLength("Jag gillar glass.") → 4.67
CalculateAverageWordLength("Det här är roligt.") → 3.5
CalculateAverageWordLength("Oj, vad snabbt du sprang!") → 3.8

→ Valfritt stretchgoal:
CalculateAverageWordLength(" ! ") → 0
CalculateAverageWordLength("två  mellanslag") → 6.5
```

## Tips
- Gå igenom meningen tecken för tecken.  
- Räkna bokstäver tills du hittar ett mellanslag eller skiljetecken.  
- När ett ord tar slut, öka antalet ord och lägg till ordets längd till en totalsumma.  
- Beräkna medelvärdet: `totalLängd / antalOrd`.  
- Använd `Math.Round(värde, 2)` för att visa max två decimaler.
- https://learn.microsoft.com/en-us/dotnet/api/system.char.isletter?view=net-9.0 (IsLetter)
- https://learn.microsoft.com/en-us/dotnet/api/system.char.iswhitespace?view=net-9.0 (IsWhiteSpace)

## Regler

**Du får inte använda:**
- `Contains()`
- `Split()`
- LINQ (t.ex. `Where`, `Select`, `Sum`, `Average`)
- `Regex`
- Andra avancerade eller färdiga textfunktioner

**Du ska använda:**
- Loopar (`for`, `while`, `foreach`)
- Villkor (`if`, `else`)

> Syftet är att öva grundläggande programmeringslogik i C#.
> Reglerna gäller alla delar i uppgiften
---

## Del 2 – Bli en medelmåtta

EU har nu skärpt reglerna.  
En person anses vara en **medelmåtta** om medellängden av orden ligger **mellan 3,5 och 4,4**.

Utöka programmet så att det:

1. Räknar ut medellängden (som tidigare).  
2. Kontrollerar om värdet ligger inom intervallet 3,5–4,4.  
3. Skriver ut ett meddelande i en `MessageBox`:

   - Om värdet ligger inom intervallet:  
     **"Du är en sann medelmåtta!"**
   - Om värdet är för lågt:  
     **"Dina ord är för korta."**
   - Om värdet är för högt:  
     **"Dina ord är för långa."**

>Du ska lägga din `MessageBox` i knappen (gränssnittet) och inte i klassen `SentenceAnalyzer` 



## Del 3 – Tala lagom mycket (valfri extra)

EU kräver nu att du **korrigerar meningen** så att medellängden hamnar inom intervallet **3,5–4,4 bokstäver per ord**.

### Uppgift
Utöka programmet så att det:
1. Räknar ut medellängden (Del 1).
2. Avgör om meningen ligger inom intervallet (Del 2).
3. Beräknar hur många **bokstäver** som måste **läggas till** eller **tas bort** för att hamna inom intervallet.
4. Visar meddelanden liknande tidigare, men nu med tillägget hur användaren måste korrigera sina meningar
  - För kort: **"Du pratar alltför kortfattat. Lägg till mellan `x` och `y` bokstäver för att bli godkänd."**
  - För långt: **"Du pratar alldeles för mycket. Ta bort mellan `x` och `y` bokstäver för att bli godkänd."**
  - Lagom: **"Du är en sann medelmåtta!"**

### Exempel
`Vi är på väg nu men det tar nog en stund till.'
   → Lägg till **8–18** bokstäver.


> Samma regler gäller som tidigare uppgift: inga LINQ/Regex; lös med loopar och if-satser.


