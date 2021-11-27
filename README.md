# NumericMath for Unity
Extension methods for built-in numeric value-types.

## Contents
Note:  
`Method[A/B/C]` = Methods with the names `MethodA`, `MethodB`, and `MethodC` exist.  
`Method[/A/B/C]` = Methods with the names `Method`, `MethodA`, `MethodB`, and `MethodC` exist.


`→` = One or more extension methods have been added for existing `static` methods in order to simplify the way they can be called. The `→` leads to the official documentation.  
`+` = One or more extension methods with custom implementations have been added in order to provide additional functionality.


---


### Common

#### Abs [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.abs)
Returns the absolute value of the number.

```csharp
   5.Abs(); // returns '5'
(-5).Abs(); // returns '5'
```

#### Add `+`
Returns a sequence of numbers (without the initial value), adding the specified `addend` a specified number of times.

```csharp
   0.Add(2, 5);  // returns '[ 2,  4,  6,  8, 10]'
   5.Add(5, 4);  // returns '[10, 15, 20, 25]'
(-5).Add(-1, 3); // returns '[-6, -7, -8]'
```

#### Clamp `+`
Returns the number which is clamped to the inclusive range of `min` and `max`.
```csharp
   10.Clamp(-5, 5); // returns  '5'
(-10).Clamp(-5, 5); // returns '-5'

```
#### Divide `+`
Returns a sequence of numbers (without the initial value), dividing by the specified `divisor` a specified number of times.

```csharp
1000f.Divide(10f, 5);  // returns '[100f,   10,    1, 0.1f, 0.01f]'
  100.Divide(-2, 4);   // returns '[ -50,   25,  -12,    6]'
   5f.Divide(0.5f, 3); // returns '[ 10f,  20f,  40f]'
```

#### IsClamped[/01] `+`
Checks whether the number is clamped to the inclusive range of `min` and `max`, inclusively by default.
```csharp
  10.IsClamped(-5, 5);        // returns 'false'
   5.IsClamped(-5, 5);        // returns 'true'
   5.IsClamped(-5, 5, false); // returns 'false'
0.5f.IsClamped01();           // returns 'true'
```

#### Max [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.max)
Returns the larger of two numbers.
```csharp
5.Max(10); // returns '10'
```

#### Min [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.min)
Returns the smaller of two numbers.
```csharp
5.Min(10); // returns '5'
```

#### Modulo `+`
Repeats the sequence from `zero` to `divisor` (exclusively), with the direction and `sign` based on the `sign` of the `divisor`.
```csharp
var range = (-3).Range(7);      // returns '[-3, -2, -1,  0,  1,  2,  3]'
range.Select(i => i.Modulo(3);  // returns '[ 0,  1,  2,  0,  1,  2,  0]'
range.Select(i => i.Modulo(-3); // returns '[ 0, -2, -1,  0, -2, -1,  0]'
```

#### Multiply `+`
Returns a sequence of numbers (without the initial value), multiplying by the specified `factor` a specified number of times.

```csharp
   1.Multiply(2, 5);  // returns '[ 2,  4,  8, 16, 32]'
   1.Multiply(-2, 4); // returns '[-2,  4, -8, 16]'
(-5).Multiply(-1, 3); // returns '[ 5, -5,  5]'
```

#### Pow [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.pow)
Returns the number raised to a power.
```csharp
 10.Pow(3);   // returns '1000'
10f.Pow(-3f); // returns '0.001'
```

#### Range [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.range) / `+`
Returns a sequence of numbers with a specified length, incrementing by `one` by default.
```csharp
   0.Range(3);      // returns '[ 0,   1,   2]'
   0.Range(3, 5);   // returns '[ 0,   5,  10]'
  10.Range(3, 5);   // returns '[10,  15,  20]'
(-5).Range(3);      // returns '[-5,  -4,  -3]'
(-5).Range(3, -10); // returns '[-5, -15, -25]'
```

#### Remainder [`→`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#remainder-operator-)
Repeats the sequence from `zero` to `divisor` (exclusively), with the direction and `sign` based on the `sign` of the `dividend`.
```csharp
var range = (-3).Range(7);         // returns '[-3, -2, -1,  0,  1,  2,  3]'
range.Select(i => i.Remainder(3);  // returns '[ 0, -2, -1,  0,  1,  2,  0]'
range.Select(i => i.Remainder(-3); // returns '[ 0, -2, -1,  0,  1,  2,  0]'
```

#### Sign [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.sign)
Returns an integer which indicates the sign of a number.
```csharp
   5.Sign(); // returns  '1'
   0.Sign(); // returns  '0'
(-5).Sign(); // returns '-1'
```

#### Subtract `+`
Returns a sequence of numbers (without the initial value), subtracting the specified `subtrahend` a specified number of times.

```csharp
  10.Subtract(2, 5);  // returns '[ 8,  6,  4,  2,  0]'
   1.Subtract(-2, 4); // returns '[ 3,  5,  7,  9]'
(-5).Subtract(1, 3);  // returns '[-6, -7, -8]'
```

#### ToBool `+`
Returns `true` if the number is not `zero`.
```csharp
   5.ToBool(); // returns 'false'
   0.ToBool(); // returns 'true'
(-5).ToBool(); // returns 'false'
```

#### ToInvariantString `+`
Returns a string representation of the number, using the [invariant Culture](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo.invariantculture?view=net-5.0).
```csharp
      5.5f.ToInvariantString();    // returns "5.5"
123456.78f.ToInvariantString("N2") // returns "123,456.80" (rounded due to floating-point precision)
```


---


### Floating-point numerics

Note:  
`°` = Methods for non-hyperbolic trigonometric functions use `degrees` by default.

#### Ceil[/ToInt] [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.ceiling) / `+`
Returns the smallest integral value greater than or equal to the number.
```csharp
   5.5f.Ceil(); // returns  '6f'
(-5.5f).Ceil(); // returns '-5f'
```

#### Cos/Acos `°` [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.cos) [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.acos) / Cosh [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.cosh)
Cos[/h]: Returns the (hyperbolic) cosine of the angle.  
Acos: Returns the angle whose cosine is the number.
```csharp
 0f.Cos();  // returns '1f'
90f.Cos();  // returns '0f'
 0f.Acos(); // returns '90f'
 1f.Acos(); // returns '0f'

 5f.Cosh(); // returns '74.20995f'
```

#### Exp [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.exp)
Returns `e` raised to a power.
```csharp
5f.Exp();       // returns '148.4132f'
5f.Exp().Log(); // returns '5f'
```

#### Floor[/ToInt] [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.floor) / `+`
Returns the largest integral value less than or equal to the number.
```csharp
   5.5f.Floor(); // returns  '5f'
(-5.5f).Floor(); // returns '-6f'
```

#### InverseLerp `+`
Calculates the percentage of the number between two numbers.
```csharp
 0f.InverseLerp(0f, 10f);       // returns '0f'
 5f.InverseLerp(0f, 10f);       // returns '0.5f'
10f.InverseLerp(0f, 10f);       // returns '1f'

11f.InverseLerp(0f, 10f);       // returns '1.1f'
11f.InverseLerp(0f, 10f, true); // returns '1f'
```

#### Is[[Negative/Positive/]Infinity / NaN] `+`
Checks if the value is (negative/positive) infinity / `Not a Number`
```csharp
 (5f / 0f).IsPositiveInfinity(); // returns 'true'
(-5f / 0f).IsNegativeInfinity(); // returns 'true'
 (0f / 0f).IsNaN();              // returns 'true'
```

#### Lerp `+`
Linearly interpolates between two numbers by a percent value.
```csharp
0f.Lerp(10f, 0f);         // returns '0f'
0f.Lerp(10f, 0.5f);       // returns '5f'
0f.Lerp(10f, 1f);         // returns '10f'

0f.Lerp(10f, 1.1f);       // returns '11f'
0f.Lerp(10f, 1.1f, true); // returns '10f'
```

#### Log [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.log)
Returns the logarithm of the number.
```csharp
5f.Log();       // returns '1.609438f'
5f.Log().Exp(); // returns '5f'
```

#### Remap `+`
Calculates the percentage of the number between two starting numbers via `InverseLerp` and applies it to two target numbers via `Lerp`.
```csharp
5f.Remap(0f, 10f, 50f, 100f);   // returns '75f'
5f.Remap(-20f, 10f, 10f, -20f); // returns '-15f'
```

#### Round[/ToInt] [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.round) / `+`
Rounds a value to the nearest integer.
```csharp
   5.4f.Round(); // returns  '5f'
   5.5f.Round(); // returns  '6f'
(-5.4f).Round(); // returns '-5f'
(-5.5f).Round(); // returns '-6f'
```

#### Sin/Asin `°` [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.sin) [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.asin) / Sinh [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.sinh)
Sin[/h]: Returns the (hyperbolic) sine of the angle.  
Asin: Returns the angle whose sine is the number.
```csharp
 0f.Sin();  // returns '0f'
90f.Sin();  // returns '1f'
 0f.Asin(); // returns '0f'
 1f.Asin(); // returns '90f'

 5f.Sinh(); // returns '74.20321f'
```

#### Sqrt [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.sqrt)
Returns the square root of the number.
```csharp
 4f.Sqrt(); // returns '2f'
16f.Sqrt(); // returns '4f'
```

#### Tan/Atan[/2] `°` [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.tan) [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.atan) [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.atan2) / Tanh [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.tanh)
Tan[/h]: Returns the (hyperbolic) tangent of the angle.  
Atan: Returns the angle whose tangent is the number.
```csharp
45f.Tan();  // returns '1f'
 1f.Atan(); // returns '45f'

 5f.Tanh(); // returns '0.9999092f'
```


#### To[Degrees/Radians] `+`
Converts an angle between `degrees` and `radians`.
```csharp
Math.PI.ToDegrees(); // returns '180d'
   180d.ToRadians(); // returns '3.14159265358979d'
```

#### ToPercentString `+`
Returns a string representation of the number, formatted as percent.
```csharp
0.5f.ToInvariantString();  // returns "50.00 %"
0.5f.ToInvariantString(0); // returns "50 %"
```

#### Truncate [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.truncate)
Calculates the integral part of a number.
```csharp
   5.5f.Truncate(); // returns  '5'
(-5.5f).Truncate(); // returns '-5'
```



---


### Integral numerics


#### BigMul [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.bigmul)
Returns the full product of two numbers as the next-bigger value-type to avoid overflows.
```csharp
1234567890.BigMul(1000000000); // returns '1234567890000000000L'
```

#### DivRem [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.divrem)
Returns the quotient of two numbers and also returns the remainder in an output parameter.
```csharp
int remainder;
   5.DivRem(3, out remainder);   // returns '1', remainder == '2'
   5.DivRem(-3, out remainder);  // returns '-1', remainder == '2'
(-5).DivRem(3, out remainder);   // returns '-1', remainder == '-2'
(-5).DivRem(-3, out remainder);  // returns '1', remainder == '-2'
```

#### Is[Even/Odd] `+`
Checks whether a number is even or odd.
```csharp
5.IsEven(); // returns 'false'
5.IsOdd();  // returns 'true'
```

#### To[Binary/Hex]String `+`
Returns a string representation of the number, formatted as binary/hexadecimal.
```csharp
5.ToBinaryString(); // returns "00000101"
5.ToHexString();    // returns "05"
```


---


## Installation

### Compatibility

Should work with Unity 2018.3+, except when using Scripting Runtime Version ".NET 3.5 Equivalent (Deprecated)".

### Installation via Git URL (recommended)
See [here](https://docs.unity3d.com/Manual/upm-ui-giturl.html) for how to install packages via Git URL by using the Unity Package Manager.  
See [here](https://docs.unity3d.com/Manual/upm-git.html) for how to do so manually by editing the "manifest.json" file in `[your project folder]/Packages/`.

### Installation from a local package (alternative)
See [here](https://docs.unity3d.com/Manual/upm-ui-local.html) for how to install packages from a local folder using the Unity Package Manager.  
See [here](https://docs.unity3d.com/Manual/upm-localpath.html) for how to do so manually by editing the "manifest.json" file in `[your project folder]/Packages/`.


## Usage

Include the namespace at the top of script files which should contain calls to the extension methods: 

```csharp
using NumericMath;
```