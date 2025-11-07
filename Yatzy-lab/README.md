# Yatzy

## Del 1 – Summera poäng och bonus (CHECK)
När användaren klickar på **OK** ska totalpoängen visas.  
Bonusregeln gäller de sex översta fälten: *Ettor–Sexor*.

### Krav (CHECK)
- Summera alla värden i fälten Ettor–Sexor.  
- Om summan är **63 eller mer** → lägg till **50 poäng i bonus**.  
- Visa bonus och total i respektive ruta.  

### Självtest (CHECK)
- Tomma fält ska räknas som 0.   
- Bonus ska ges exakt vid 63 poäng.  
---


## Del 2 – Få tärningarna att fungera (DU ÄR HÄR)
När användaren klickar på **Kasta tärningar** ska fem tärningar få nya värden mellan 1 och 6.  

### Krav
- Använd en array med 5 element för att spara tärningsvärden.  
- Uppdatera gränssnittet utifrån arrayens innehåll.  
- Inga “spara”-funktioner ännu.  

### Självtest
- Varje kast visar nya värden.  
- Tärningarna visar endast värden mellan 1 och 6.  
-
---

## Del 3 – Poängknappar (Ettor–Sexor)
Klick på exempelvis **Ettor** ska räkna poängen utifrån de fem tärningarna.  

### Krav
- Poäng ska räknas från tärnings-arrayen.  
- Skriv resultatet i rätt ruta.  
- **Ingen LINQ får användas.** Endast loopar och if-satser.  

### Självtest
- Ettor: summera alla tärningar som visar 1.  
- Tvåor: summera alla som visar 2, osv.  
- UI-textrutan uppdateras med korrekt poäng.  

---

## Del 4 – Spara tärningar och räkna kast
Användaren ska kunna välja att **spara tärningar** och ha högst **3 kast** per runda.  

### Krav
- Varje tärning har en “Spara”-checkbox.  
- Sparade tärningar behåller sitt värde vid nytt kast.  
- Antal kast räknas ned: *Kast kvar: 3 → 2 → 1 → 0*.  
- När 0 kast återstår, ska kastknappen inaktiveras tills nästa runda.  

### Självtest
- Sparade tärningar ändras inte.  
- Kastknapp fungerar tills inga kast återstår.  
- Återställning nollställer alla tärningar och “Spara”-val.  

---

## Regler
- Använd **arrayer, loopar och if-satser**.  
- **Ingen LINQ, ingen Regex.**  
- Validera all inmatning.
