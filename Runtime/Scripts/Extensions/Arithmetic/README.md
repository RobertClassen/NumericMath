# Arithmetic

## Add
[`►`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#addition-operator-) `F,I`
Returns the sum of both numbers.
```csharp
(5).Add(10);  // returns '15'
(5).Add(-10); // returns '-5'
```

## Subtract
[`►`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#subtraction-operator--) `F,I`
Returns the difference of both numbers.
```csharp
(5).Subtract(10);  // returns '-5'
(5).Subtract(-10); // returns '15'
```

## Multiply
[`►`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#multiplication-operator-) `F,I`
Returns the product of both numbers.
```csharp
(5).Multiply(10);  // returns  '50'
(5).Multiply(-10); // returns '-50'
```

## Divide
[`►`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#division-operator-) `F,I`
Returns the quotient of both numbers.
```csharp
 (5).Divide(10);  // returns '0'
(5f).Divide(10f); // returns '0.5f'
```

## Pow
[`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.pow) `F,I`
Returns the number raised to a power.
```csharp
 (10).Pow(3);   // returns '1000'
(10f).Pow(-3f); // returns '0.001f'
```

## Sqrt
[`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.sqrt) `F,I`
Returns the square root of the number.
```csharp
(4f).Sqrt(); // returns '2d'
```

## Root
`+` `F,I`
Returns the specified root of the number.
```csharp
(4f).Root(2d); // returns '2d'
```

## Exp
[`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.exp) `F`
Returns `e` raised to a power.
```csharp
(5f).Exp();       // returns '148.4132f'
(5f).Exp().Log(); // returns '5f'
```

## Log
[`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.log) `F`
Returns the logarithm of the number.
```csharp
(5f).Log();       // returns '1.609438f'
(5f).Log().Exp(); // returns '5f'
```

## BigMul
[`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.bigmul) `I`
Returns the full product of two numbers as the next-bigger value-type to avoid overflows.
```csharp
(1234567890).BigMul(1000000000); // returns '1234567890000000000L'
```

## DivRem
[`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.divrem) `I`
Returns the quotient of two numbers and also returns the remainder in an output parameter.
```csharp
int remainder;
 (5).DivRem(3, out remainder);  // returns '1', remainder == '2'
 (5).DivRem(-3, out remainder); // returns '-1', remainder == '2'
(-5).DivRem(3, out remainder);  // returns '-1', remainder == '-2'
(-5).DivRem(-3, out remainder); // returns '1', remainder == '-2'
```