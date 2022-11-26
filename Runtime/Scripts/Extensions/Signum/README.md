# Signum

## Abs
[`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.abs) `F,I`
Returns the absolute value of the number.
```csharp
 (5).Abs(); // returns '5'
(-5).Abs(); // returns '5'
```

## Sign
[`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.sign) `F,I`
Returns an integer which indicates the sign of a number.
```csharp
 (5).Sign(); // returns  '1'
 (0).Sign(); // returns  '0'
(-5).Sign(); // returns '-1'
```

## Extreme
`+` `F,I`
Returns the extreme value with the same sign.
```csharp
 (5).Sign(); // returns 'int.MaxValue'
(-5).Sign(); // returns 'int.MinValue'
```