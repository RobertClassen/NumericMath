# Sequences

## Range
[`►`](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.range) / `+` `F,I`
Returns a sequence of numbers (**including** the initial value) with a specified length, incrementing by `one` by default.
```csharp
 (0).Range(3);      // returns ' 0,   1,   2'
 (0).Range(3, 5);   // returns ' 0,   5,  10'
(10).Range(3, 5);   // returns '10,  15,  20'
(-5).Range(3);      // returns '-5,  -4,  -3'
(-5).Range(3, 10);  // returns '-5,   5,  15'
(-5).Range(3, -10); // returns '-5, -15, -25'
```

## Repeat
`+` `F,I`
Returns a sequence of repeated numbers or sequence values.
```csharp
(0).Repeat(5);            // returns '0, 0, 0, 0, 0'

var range = (0).Range(5); // returns '0, 1, 2, 3, 4'
range.Repeat(3);          // returns '0, 1, 2, 3, 4, 0, 1, 2, 3, 4, 0, 1, 2, 3, 4'
range.Repeat(3, true);    // returns '0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4'
```

## Add
`+` `F,I`
Returns a sequence of numbers (**excluding** the initial value), adding the specified `addend` a specified number of times.

```csharp
(-5).Add(1, 2, -3);            // returns '-4, -3, -8'
 (0).Add((2).Range(5, 2));     // returns ' 2,  4,  6,  8, 10'
 (5).Add((5).Repeat(4), true); // returns '10, 15, 20, 25'
```

## Subtract
`+` `F,I`
Returns a sequence of numbers (**excluding** the initial value), subtracting the specified `subtrahend` a specified number of times.

```csharp
(-5).Subtract(1, 2, -3);             // returns '-6, -7, -2'
(10).Subtract((2).Range(5, 2));      // returns ' 8,  6,  4,  2,  0'
 (1).Subtract((-2).Repeat(4), true); // returns ' 3,  5,  7,  9'
```

## Multiply
`+` `F,I`
Returns a sequence of numbers (**excluding** the initial value), multiplying by the specified `factor` a specified number of times.

```csharp
(-5).Multiply(-2, -3, 1));           // returns '10, 15, -5'
 (2).Multiply((2).Range(5, 2));        // returns ' 4,  8, 12, 16, 20'
 (1).Multiply((-2).Repeat(4), true); // returns '-2,  4, -8, 16'
```

## Divide
`+` `F,I`
Returns a sequence of numbers (**excluding** the initial value), dividing by the specified `divisor` a specified number of times.

```csharp
 (5f).Divide(0.5f, 0.5f, 5f));      // returns ' 10f,  20f,   4f'
(12f).Divide((12f).Range(5, -2f));  // returns '1.0f, 1.2f, 1.5f, 2.0f, 3.0f'
(100).Divide((-2).Repeat(4), true); // returns ' -50,   25,  -12,    6'
```