# Bankomat (C# Console App)

En enkel bankomat byggd i C# med OOP struktur, inkapsling och källkodshantering med Git.


## Funktionalitet

- Startar med att användaren anger en fyrsiffrig PIN-kod. 
- Om PIN är korrekt visas en meny med följande alternativ: 
  1. Sätt in pengar 
  2. Ta ut pengar 
  3. Visa saldo 
  4. Avsluta 

- Validering:
  - Belopp måste vara numeriskt och större än 0. 
  - Uttag får inte överstiga aktuellt saldo. 

---

## OOP-struktur

### **BankAccount**
- Privat fält: `balance` 
- Read-only property: `Balance` 
- Metoder: 
  - `Deposit(decimal amount)` 
  - `Withdraw(decimal amount)` 

### **Person**
- Properties: `Name`, `PersonalNumber` (readonly) 

### **Customer**
- Innehåller en `Person`, ett `BankAccount` och en hårdkodad PIN. 
- Metod `Authenticate(pin)` för inloggning. 

---

## Kör app

dotnet run
