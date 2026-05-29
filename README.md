# 🍽️ Zufalls Essens Generator

<div align="center">
  <img src="https://img.shields.io/badge/C%23-.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white">
  <img src="https://img.shields.io/badge/Status-In%20Progress-yellow?style=for-the-badge">
</div>

---

Eine Konsolen-App, die dir per Zufall ein komplettes Menü zusammenstellt — nach Länderküche oder völlig zufällig.

---

## Features

- 🎲 **Völliger Zufall** — zufällige Vorspeise, Hauptspeise, Beilage & Dip aus allen Küchen
- 🌍 **Zufall nach Land** — wähle Italien, Japan, Mexiko oder Griechenland und erhalte ein Zufallsmenü dieser Küche
- 🛒 **Warenkorb** — Gerichte hinzufügen, Gesamtpreis einsehen und bestellen
- 📦 **Animierter Bestellvorgang** — simulierter Ladebildschirm bei Lieferung & Abholung

---

## Technologie

- C# / .NET Konsolen-App
- ASCII-Art UI mit Tastaturnavigation (↑ ↓ Enter)

---

## Starten

```bash
git clone https://github.com/TranceMeli/ZufallsEssensGenerator.git
cd ZufallsEssensGenerator
dotnet run
```

---

## Neue Länderküche hinzufügen

`SpeisekartenDaten.cs` öffnen und einen neuen Eintrag ins Dictionary einfügen — er erscheint automatisch im Menü.

```csharp
["Thailand"] = new LandSpeisekarte
{
    Vorspeisen   = new() { ... },
    Hauptspeisen = new() { ... },
    Beilagen     = new() { ... },
    Dips         = new() { ... }
}
```
