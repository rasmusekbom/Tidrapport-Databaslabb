# Uppgiftsbeskrivning

## Scenario

I denna laboration ska vi öva på att använda ADO.NET och vanliga hederliga SQL-frågor. Ni ska skapa en databas för lagring av tidsrapporter för anställda på ett företag. Företaget har olika projekt, flera anställda personer och vill kunna spara rapporter på hur många timmar en anställd har jobbat med ett projekt en viss vecka.

## Kriterier för Godkänt

Del 1 - Databasen

Med hjälp av SSMS, skapa en databas. Följande information behöver lagras i databasen:

· Information om varje Anställd på företaget

o Förnamn

o Efternamn

· Information om Projekt på företaget

o Projektnamn

· Information om tidsrapporter

o Veckonummer

o Anställd som gör rapporteringen

o Vilket Projekt rapporteringen gäller

o Antal arbetade timmar

Lägg in några projekt, anställda och tidsrapporter via SSMS för att få lite testdata

Del 2 – Diagram och SQL

- Skapa ett tabell-diagram över tabellerna i databasen, SSMS kan skapa detta. Se Figur 1 för exempel

- Skriv SQL-fråga där alla anställda hämtas

- Skriv SQL-fråga där alla projekt hämtas

- Skriv SQL-fråga där rapporter sparas

- Skriv SQL-fråga som visar rapporter för en given anställd. Svaret ska visa vecka, arbetade timmar och projektnamn. Se figur 3 för exempel. I denna SQL-fråga måste en JOIN användas.

Del 3 – Application, G-nivå

Skapa en applikation i C# .NET som kan användas för att visa tidsrapporteringar. Se figur 3 för exempel

När användaren har valt en anställd ska en lista med rapporterade timmar visas för alla rapporterade veckor för den anställde. Rapporterna hämtas från en rapport-tabell. Använd SQL-frågan med join i del 2.

## Kriterier för Väl Godkänt (uppnått)
Del 4 – Extended application, VG-nivå

Skapa en applikation i C# .NET som kan användas för att visa och skapa tidsrapporteringar. I applikationen ska det vara möjligt att välja anställd, projekt, veckonummer och sedan fylla i antal arbetade timmar. Se figur 4 för exempel. Rapporterna ska lagras i en rapport-tabell.

När användaren har valt en anställd ska en lista med rapporterade timmar visas för alla rapporterade veckor för den anställde. Rapporterna hämtas från en rapport-tabell. Använd SQL-frågan med join i del 2.
