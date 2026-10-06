# Kalkulator statystyk liczb

Aplikacja okienkowa napisana w języku C# z wykorzystaniem technologii Windows Forms (.NET). Umożliwia dodawanie liczb do listy oraz obliczanie podstawowych statystyk na podstawie wprowadzonych wartości.

Projekt został wykonany w celu praktycznego zastosowania podstaw języka C#, programowania obiektowego oraz obsługi danych w aplikacji desktopowej.

## Funkcjonalności

* Dodawanie liczb do listy.
* Walidacja danych wejściowych przed dodaniem liczby.
* Wyświetlanie komunikatów o błędnych danych za pomocą `MessageBox`.
* Obliczanie największej liczby.
* Obliczanie najmniejszej liczby.
* Obliczanie sumy wszystkich liczb.
* Obliczanie średniej arytmetycznej.
* Obsługa nieprawidłowych danych bez nieoczekiwanego zamykania aplikacji.

## Wykorzystane technologie

* **C#** — język programowania.
* **.NET** — platforma uruchomieniowa.
* **Windows Forms (WinForms)** — tworzenie interfejsu graficznego.
* **Visual Studio** — środowisko programistyczne.
* **Git i GitHub** — kontrola wersji i przechowywanie kodu źródłowego.

## Zrzut ekranu

<!-- Po dodaniu zrzutu ekranu zapisz go jako docs/screenshot.png -->

![Widok aplikacji](docs/screenshot.png)

## Uruchomienie aplikacji

### Wymagania

* System Windows.
* Visual Studio z zainstalowanym obciążeniem „Programowanie aplikacji klasycznych .NET”.
* Wersja .NET SDK zgodna z projektem.

### Instrukcja

1. Sklonuj repozytorium na swój komputer:

   ```bash
   git clone ADRES_REPOZYTORIUM
   ```

2. Otwórz plik rozwiązania `.sln` w Visual Studio.

3. W razie potrzeby przywróć wymagane pakiety NuGet.

4. Skompiluj projekt.

5. Uruchom aplikację za pomocą Visual Studio.

## Struktura projektu

Aplikacja rozdziela obsługę interfejsu graficznego od logiki obliczeniowej.

* **Formularz** — odpowiada za interakcję z użytkownikiem i prezentację wyników.
* **Klasa logiki obliczeniowej** — odpowiada za przetwarzanie listy liczb i wykonywanie obliczeń.

## Walidacja danych

Przed dodaniem liczby aplikacja sprawdza poprawność wprowadzonych danych. Nieprawidłowe wartości są odrzucane, a użytkownik otrzymuje komunikat o błędzie.

## Umiejętności wykorzystane w projekcie

* Podstawy programowania w C#.
* Programowanie obiektowe (OOP).
* Tworzenie aplikacji okienkowych z wykorzystaniem Windows Forms.
* Obsługa zdarzeń i interakcji z użytkownikiem.
* Walidacja danych wejściowych.
* Obsługa błędów i wyjątków.
* Praca z kolekcjami oraz wykonywanie operacji matematycznych.
* Oddzielanie logiki obliczeniowej od interfejsu użytkownika.

## Możliwe kierunki rozwoju

* Dodanie testów jednostkowych dla logiki obliczeniowej.
* Możliwość usuwania wybranych liczb z listy.
* Dodanie przycisku czyszczącego listę i resetującego wyniki.
* Udoskonalenie interfejsu użytkownika.

## Licencja

Projekt edukacyjny przygotowany w celu rozwijania umiejętności programowania w C# i budowania portfolio programistycznego.
