# Limits

## Clamp[/01]
`+` `F,I`
Returns the number which is clamped to the inclusive range of `min` and `max`.
```csharp
  (10).Clamp(-5, 5); // returns  '5'
 (-10).Clamp(-5, 5); // returns '-5'
(1.1f).Clamp01();    // returns '1f'
```
## IsClamped[/01]
`+` `F,I`
Checks whether the number is clamped to the range of `min` and `max`, inclusively by default.
```csharp
  (10).IsClamped(-5, 5);        // returns 'false'
   (5).IsClamped(-5, 5);        // returns 'true'
   (5).IsClamped(-5, 5, false); // returns 'false'
(0.5f).IsClamped01();           // returns 'true'
```

## Modulo
`+` `F,I`
Repeats the sequence from `zero` to `divisor` (exclusively), with the direction and `sign` based on the `sign` of the `divisor`.
```csharp
var range = (-3).Range(7);      // returns '-3, -2, -1,  0,  1,  2,  3'
range.Select(i => i.Modulo(3);  // returns ' 0,  1,  2,  0,  1,  2,  0'
range.Select(i => i.Modulo(-3); // returns ' 0, -2, -1,  0, -2, -1,  0'
```

## Remainder
[`►`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#remainder-operator-) `F,I`
Repeats the sequence from `zero` to `divisor` (exclusively), with the direction and `sign` based on the `sign` of the `dividend`.
```csharp
var range = (-3).Range(7);         // returns '-3, -2, -1,  0,  1,  2,  3'
range.Select(i => i.Remainder(3);  // returns ' 0, -2, -1,  0,  1,  2,  0'
range.Select(i => i.Remainder(-3); // returns ' 0, -2, -1,  0,  1,  2,  0'
```