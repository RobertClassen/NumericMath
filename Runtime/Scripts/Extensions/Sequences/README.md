# Sequences

## Range
[`►`](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.range) / `+` `F,I`
Returns a sequence of numbers (**including** the initial value) with a specified length, incrementing by `one` by default.
```csharp
 (0).Range(3);      // returns '[ 0,   1,   2]'
 (0).Range(3, 5);   // returns '[ 0,   5,  10]'
(10).Range(3, 5);   // returns '[10,  15,  20]'
(-5).Range(3);      // returns '[-5,  -4,  -3]'
(-5).Range(3, -10); // returns '[-5, -15, -25]'
```

## Repeat
`+` `F,I`
Returns a sequence of repeated numbers or sequence values.
```csharp
(0).Repeat(5);                      // returns '0, 0, 0, 0, 0'

var range = (0).Range(5).ToArray(); // returns '[0, 1, 2, 3, 4]'
range.Repeat(3);                    // returns '0, 1, 2, 3, 4, 0, 1, 2, 3, 4, 0, 1, 2, 3, 4'
range.Repeat(3, true);              // returns '0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4'
```

## AddRepeated
`+` `F,I`
Returns a sequence of numbers (**excluding** the initial value), adding the specified `addend` a specified number of times.

```csharp
 (0).AddRepeated(2, 5);  // returns '[ 2,  4,  6,  8, 10]'
 (5).AddRepeated(5, 4);  // returns '[10, 15, 20, 25]'
(-5).AddRepeated(-1, 3); // returns '[-6, -7, -8]'
```

## SubtractRepeated
`+` `F,I`
Returns a sequence of numbers (**excluding** the initial value), subtracting the specified `subtrahend` a specified number of times.

```csharp
(10).SubtractRepeated(2, 5);  // returns '[ 8,  6,  4,  2,  0]'
 (1).SubtractRepeated(-2, 4); // returns '[ 3,  5,  7,  9]'
(-5).SubtractRepeated(1, 3);  // returns '[-6, -7, -8]'
```

## MultiplyRepeated
`+` `F,I`
Returns a sequence of numbers (**excluding** the initial value), multiplying by the specified `factor` a specified number of times.

```csharp
 (1).MultiplyRepeated(2, 5);  // returns '[ 2,  4,  8, 16, 32]'
 (1).MultiplyRepeated(-2, 4); // returns '[-2,  4, -8, 16]'
(-5).MultiplyRepeated(-1, 3); // returns '[ 5, -5,  5]'
```

## DivideRepeated
`+` `F,I`
Returns a sequence of numbers (**excluding** the initial value), dividing by the specified `divisor` a specified number of times.

```csharp
(1000f).DivideRepeated(10f, 5);  // returns '[100f,   10,    1, 0.1f, 0.01f]'
  (100).DivideRepeated(-2, 4);   // returns '[ -50,   25,  -12,    6]'
   (5f).DivideRepeated(0.5f, 3); // returns '[ 10f,  20f,  40f]'
```