# Rounding

## Ceil[/ToInt] [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.ceiling) / `+` `F`
Returns the smallest integral value greater than or equal to the number.
```csharp
 (5.5f).Ceil(); // returns  '6f'
(-5.5f).Ceil(); // returns '-5f'
```

## Floor[/ToInt] [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.floor) / `+` `F`
Returns the largest integral value less than or equal to the number.
```csharp
 (5.5f).Floor(); // returns  '5f'
(-5.5f).Floor(); // returns '-6f'
```

## Round[/ToInt] [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.round) / `+` `F`
Rounds a value to the nearest integer.
```csharp
 (5.4f).Round(); // returns  '5f'
 (5.5f).Round(); // returns  '6f'
(-5.4f).Round(); // returns '-5f'
(-5.5f).Round(); // returns '-6f'
```

## Truncate [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.truncate) `F`
Calculates the integral part of a number.
```csharp
 (5.5f).Truncate(); // returns  '5'
(-5.5f).Truncate(); // returns '-5'
```