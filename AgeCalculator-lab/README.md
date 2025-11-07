# Ålderskalkylator

## Del 1 – Räkna ut ålder
Skapa ett program där användaren matar in sitt **födelseår** och får sin **ålder** beräknad.

### Krav
- Användaren matar in födelseår i en **TextBox**.  
- När användaren klickar på **"Beräkna ålder"** ska programmet visa:  
  `Du är XX år gammal.`  
- Alla meddelanden ska visas i `lblResult`

### Självtest
- Programmet startar utan fel.  
- Rätt ålder visas.  
- Om åldern överstiger 120 år ska ett felmeddelande visas

---

## Del 2 – Två eller fyra siffror
Utöka programmet så att det hanterar både **tvåsiffriga** och **fyrsiffriga** inmatningar.

### Krav
- Om användaren matar in två siffror ska programmet tolka om det är 1900- eller 2000-tal.  
  - Om årtalet är mindre än eller lika med årets två sista siffror ⇒ **2000-tal**  
  - Annars ⇒ **1900-tal**  
- Exempel:  
  - `88` ⇒ 1988  
  - `02` ⇒ 2002  
- Visa vilket årtal programmet tolkar i TextBox. Alltså om användaren matar in 02 ska textrutan visa 2002

### Självtest
- `88` ger ålder baserad på 1988.  
- `02` ger ålder baserad på 2002.  
- Födelseår efter innevarande år ger felmeddelande.

---

## Del 3 – Validering med egen metod
Skapa en **egen metod** `IsValidNumber()` som kontrollerar att användaren bara matat in siffror.
- https://learn.microsoft.com/en-us/dotnet/api/system.char.isdigit?view=net-9.0

### Krav
- Metoden returnerar `true` om alla tecken är siffror.  
- Returnerar `false` annars.  
- Använd metoden i knappen **"Beräkna ålder"** innan beräkning sker.

### Självtest
- Textinmatning (t.ex. "7u") ger felmeddelande.  
- Tom inmatning hanteras korrekt.  
- Siffror fungerar som förväntat.
