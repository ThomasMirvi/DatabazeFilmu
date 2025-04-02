# Databáze Filmů

Tento projekt je jednoduchá desktopová aplikace v **C# Windows Forms** s **SQLite**, která umožňuje správu filmů. Uživatel může filmy přidávat, upravovat a mazat. Filmy se ukládají do souboru **filmy.db**.

## Funkce
- **Přidávání filmů** s názvem, rokem vydání, žánrem, režisérem a hodnocením.
- **Upravování filmů** přímo v databázi.
- **Mazání filmů** 
- **Zobrazení seznamu filmů** v `DataGridView`.
- **SQLite databáze** pro uchování filmů.

## Technologie
- **C# Windows Forms**
- **SQLite** pro databázi

## Použití
1. Otevřete aplikaci.
2. Použijte tlačítko `Přidat` pro vložení nového filmu.
3. Pro editaci vyberte film a stiskněte `Upravit`.
4. Mazání filmu proveďte tlačítkem `Smazat`.

## Struktura Databáze (SQLite)
Tabulka `Filmy` obsahuje:
- `Id` (INTEGER, PRIMARY KEY)
- `Nazev` (TEXT)
- `Rok` (INTEGER)
- `Zanr` (TEXT)
- `Rezie` (TEXT)
- `Hodnoceni` (INTEGER, 0-100%)

## Požadavky

- .NET Framework (Windows Forms aplikace)
- SQLite package
- Visual Studio nebo jiný IDE pro práci s .NET aplikacemi

