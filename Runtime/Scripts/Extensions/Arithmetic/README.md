# Arithmetic

## Exp [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.exp) `F`
Returns `e` raised to a power.
```csharp
(5f).Exp();       // returns '148.4132f'
(5f).Exp().Log(); // returns '5f'
```

## Log [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.log) `F`
Returns the logarithm of the number.
```csharp
(5f).Log();       // returns '1.609438f'
(5f).Log().Exp(); // returns '5f'
```

## Pow [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.pow) `F,I`
Returns the number raised to a power.
```csharp
 (10).Pow(3);   // returns '1000'
(10f).Pow(-3f); // returns '0.001f'
```

## Sqrt [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.sqrt) `F,I`
Returns the square root of the number.
```csharp
(4f).Sqrt();  // returns '2d'
```

## Root `+` `F,I`
Returns the specified root of the number.
```csharp
(4f).Root(2d);  // returns '2d'
```

## BigMul [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.bigmul) `I`
Returns the full product of two numbers as the next-bigger value-type to avoid overflows.
```csharp
(1234567890).BigMul(1000000000); // returns '1234567890000000000L'
```

## DivRem [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.divrem) `I`
Returns the quotient of two numbers and also returns the remainder in an output parameter.
```csharp
int remainder;
 (5).DivRem(3, out remainder);   // returns '1', remainder == '2'
 (5).DivRem(-3, out remainder);  // returns '-1', remainder == '2'
(-5).DivRem(3, out remainder);   // returns '-1', remainder == '-2'
(-5).DivRem(-3, out remainder);  // returns '1', remainder == '-2'
```