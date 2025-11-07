# Gissa ett tal

## Beskrivning
Du ska skapa ett spel där datorn **slumpar fram ett tal mellan 1 och 100**.  
Användaren ska sedan försöka gissa vilket tal det är.

Efter varje gissning ska programmet ge **hjälp**:
- “Du är långt ifrån.”  
- “Du är nära.”  
- eller **“Rätt svar!”**  

När användaren gissar rätt ska programmet visa hur många försök som krävdes.

---

## Mål
- Förstå händelsestyrd programmering med flera gissningar i följd.  
- Träna på att använda `Random` och `if`-satser.  
- Hantera tillstånd i ett program (antal försök och rätt svar).  

---

## Uppgift
1. Detta finns i gränssnittet:
   - En `TextBox` där användaren skriver sitt gissade tal.  
   - En `Button` för att skicka in gissningen.  
   - En `TextBlock` som visar ledtrådar och resultat.  
   - En `Button` för att starta ett nytt spel.
3. När programmet startar:
   - Slumpa ett tal mellan 1 och 100.  
   - Nollställ räknaren för antal försök.
4. När användaren klickar på “Gissa”:
   - Läs in talet.  
   - Öka räknaren för antal försök.  
   - Jämför gissningen med det hemliga talet:
     - Om talet är **rätt** → visa:  
       **"Du gissade rätt efter X försök!"**
     - Om talet är **för lågt eller för högt**, ge ledtrådar:
       - Skillnad > 20 → “Du är långt ifrån.”
       - Skillnad ≤ 20 → “Du är nära.”
5. När användaren klickar på “Nytt spel”:
   - Slumpa ett nytt tal och återställ antalet försök.  
   - Töm fält och text.

---

## Exempel
| Gissning | Hemligt tal | Skillnad | Resultattext |
|-----------|--------------|-----------|---------------|
| 10 | 75 | 65 | Du är långt ifrån. |
| 60 | 75 | 15 | Du är nära. |
| 75 | 75 | 0 | Du gissade rätt efter 3 försök! |

---

## Tips
- Skapa `Random _random = new Random();` som fält (instansvariabel) i klassen så att samma objekt används under hela spelet.  
- Rensa fält och sätt fokus på `TextBox` efter varje gissning:  
```csharp
  txtGuess.Clear();
  txtGuess.Focus();
```
