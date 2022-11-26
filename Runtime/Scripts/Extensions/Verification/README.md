# Verification

## Is[Negative/Positive/]Infinity
[`►`](https://docs.microsoft.com/en-us/dotnet/api/system.single.isnegativeinfinity) [`►`](https://docs.microsoft.com/en-us/dotnet/api/system.single.ispositiveinfinity) [`►`](https://docs.microsoft.com/en-us/dotnet/api/system.single.isinfinity) `F`
Checks if the value is (negative/positive) infinity.
```csharp
 (5f / 0f).IsInfinity(); // returns 'true'
(-5f / 0f).IsInfinity(); // returns 'true'
 (5f / 0f).IsNegativeInfinity(); // returns 'false'
(-5f / 0f).IsNegativeInfinity(); // returns 'true'
 (5f / 0f).IsPositiveInfinity(); // returns 'true'
(-5f / 0f).IsPositiveInfinity(); // returns 'false'
```

## IsNaN
[`►`](https://docs.microsoft.com/en-us/dotnet/api/system.single.isnan) `F`
Checks if the value is `Not a Number`.
```csharp
(0f / 0f).IsNaN(); // returns 'true'
```