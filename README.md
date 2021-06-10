## GetHeightByCoordinates
---
Komenda ZwCAD odczytująca pionową rzędną terenu na podstawie współrzędnych wskazanego punktu.

### UŻYTE TECHNOLOGIE
- - -
* C#
* .NET FRAMEWORK 4.5

### FUNKCJONALNOŚĆ
- - -
W środowisku CAD dostarcza komendę C:CK_GetHbyXY zwracającą komunikat z rzędną wysokościową terenu o wskazanych współrzędnych w układzie PUWG92
Rzędne wysokosciowe dostarcza serwis https://services.gugik.gov.pl/nmt/

### UŻYCIE
---
Ładowanie biblioteki .dll w środowisku CAD: 

(vl-load-com)
(vl-cmdf "netload" ".\\GetHeightByCoordinates\\bin\\debug\\GetHeightByCoordinates.dll")

Użycie komendy:

(command "CK_GetHbyXY")

### STATUS
---
Projekt w trakcie budowy.

### TO DO
---
Stworzenie interfejsu do osadzania w rysunku .dwg informacji o pozyskanej rzędnej
