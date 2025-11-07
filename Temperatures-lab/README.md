# Temperaturhistorik

## Beskrivning
Du ska skapa ett program som lagrar och analyserar temperaturer under en vecka.  
Programmet ska använda en **array** med 7 värden – ett för varje dag.

Användaren ska kunna:
1. Mata in temperaturer (t.ex. måndag till söndag).  
2. Se alla värden i en lista.  
3. Visa veckans **medeltemperatur**, **högsta** och **lägsta** temperatur.

---

## Mål
- Förstå hur man lagrar värden i en array.  
- Träna på loopar och grundläggande beräkningar.  
- Visa data i WPF med `ListBox` och `TextBlock`.

---

## Uppgift
1. Följande finns i gränssnittet:
   - En `TextBox` där användaren matar in temperaturen för en dag.  
   - En `Button` med texten **"Lägg till"** som sparar värdet i arrayen.  
   - En `ListBox` som visar alla inmatade temperaturer.  
   - En `Button` med texten **"Beräkna statistik"**.  
   - En `TextBlock` där resultatet visas.
3. När användaren klickar på **"Lägg till"**:
   - Läs in värdet från `TextBox`.  
   - Spara värdet i arrayen (om plats finns).  
   - Visa värdet i `ListBox`.
4. När användaren klickar på **"Beräkna statistik"**:
   - Beräkna och visa:
     - Medeltemperaturen.  
     - Högsta och lägsta temperatur.

---

## Exempel
| Inmatade värden | Resultat |
|------------------|-----------|
| 4.5, 5.2, 3.8, 6.0, 5.4, 7.1, 6.3 | Medel: 5.47 °C  Högsta: 7.1 °C  Lägsta: 3.8 °C |
| 1.2, 2.0, -0.3, -1.1, 0.0, 1.8, 3.3 | Medel: 1.27 °C  Högsta: 3.3 °C  Lägsta: -1.1 °C |

---

## Meddelanden

| Situation | Meddelande |
|------------|-------------|
| Inmatning lyckad | `"Temperaturen har lagts till."` |
| Alla temperaturer redan inmatade | `"Alla temperaturer är redan inmatade."` |
| För få värden vid beräkning | `"Fyll i alla temperaturer först."` |
| Alla värden inmatade (precis fyllt arrayen) | `"Alla temperaturer är nu inmatade. Klicka på 'Beräkna statistik'."` |
| Statistik färdig | `"Medel: X °C   Högsta: Y °C   Lägsta: Z °C"` |
| Programstart (valfritt startmeddelande) | `"Ange veckans temperaturer och klicka på 'Lägg till'."` |


## Viktigt krav
`ListBox` får **inte** användas för att läsa tillbaka temperaturerna.  
Alla beräkningar ska göras med **arrayen**, inte med `ListBox.Items`.  
ListBox är endast till för **presentation**.

## Tips
- Såhär lägger du till ett värde i en listbox.
```csharp
    lstTemps.Items.Add($"{temp} °C");
```

## Regler

- Du får **inte** använda LINQ-metoder (`Average()`, `Min()`, `Max()`).  
- Du får **inte** använda `ListBox` för att hämta temperaturer.  
- Alla beräkningar ska göras med **loopar och arrayen**.  
- Du får gärna utgå från att användaren matar in korrekta värden. Ingen felkoll för detta behövs

---

## Självtest

- [ ] Programmet startar utan fel.  
- [ ] Inmatning sker i en `TextBox`.  
- [ ] Temperaturen lagras i arrayen.  
- [ ] `ListBox` visar värden men används inte i beräkningen.  
- [ ] Efter sju inmatningar visas ett meddelande att listan är full.  
- [ ] “Beräkna statistik”-knappen visar medel, högsta och lägsta temperatur.  
- [ ] Inga LINQ-funktioner används.   


## Del 2 – Veckodagar och extrema temperaturer

I den här delen ska programmet visa **vilken dag** som hade den högsta respektive lägsta temperaturen.

---

### Uppgift
1. Skapa en ny array med veckodagar:
```csharp
    string[] days = { "måndag", "tisdag", "onsdag", "torsdag", "fredag", "lördag", "söndag" };
```
2. Fortsätt på samma projekt, det är ok om del 1 "försvinner"

När användaren klickar på **"Beräkna statistik"** ska programmet:

- Beräkna **medel-, högsta- och lägsta temperatur** som tidigare.  
- Visa **vilken veckodag** som hade den högsta respektive lägsta temperaturen.  
- Skriva ut **alla dagar med sina temperaturer** i `ListBox`.

---

### Exempel på presentation i ListBox
|  |
|--------------------------|
| Måndag: 12 °C           |
| Tisdag: 3 °C            |
| Onsdag: 5 °C            |
| Torsdag: 7 °C           |
| Fredag: 6 °C            |
| Lördag: 9 °C            |
| Söndag: 8 °C            |



## Självtest

- [ ] Programmet använder två arrayer: en för temperaturer och en för veckodagar.  
- [ ] ListBox visar veckodagar och deras temperaturer.  
- [ ] Resultatet visar rätt veckodag för både högsta och lägsta temperatur.   
- [ ] Inga LINQ-funktioner används.   
