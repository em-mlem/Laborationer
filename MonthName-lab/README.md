# Månadskalkylator

## Beskrivning
Användaren ska kunna skriva in ett **tal mellan 1 och 12** i en textruta.  
Programmet ska sedan visa **vilken månad** talet motsvarar.

Exempel:  
- 1 → Januari  
- 2 → Februari  
- 12 → December  

Om användaren matar in ett tal utanför intervallet 1–12 ska programmet visa ett felmeddelande.

## Uppgift
1.  När knappen klickas:
   - Läs in talet från textrutan.
   - Kontrollera att det är mellan 1 och 12.
   - Visa rätt månad i en `MessageBox`.  
   - Visa ett felmeddelande om talet är ogiltigt.

### Exempel
| Inmatning | Utdata (MessageBox) |
|------------|--------------------|
| 3          | Mars               |
| 7          | Juli               |
| 12         | December           |
| 0          | Fel: Ogiltig månad |
| 15         | Fel: Ogiltig månad |

## Tips 
- Visa resultat med `MessageBox.Show()`.  

## Självtest
- [ ] Programmet startar utan fel.  
- [ ] Inmatning 1–12 ger rätt månad.  
- [ ] Felaktiga värden hanteras korrekt.  
- [ ] Resultatet visas i en MessageBox.  
