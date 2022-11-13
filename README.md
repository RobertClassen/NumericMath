# NumericMath for Unity
Extension methods for built-in numeric value-types.


## Installation
<details><summary>Expand</summary>

### Compatibility

Should work with Unity 2018.3 or newer.

### Installation via Git URL (recommended)
See [here](https://docs.unity3d.com/Manual/upm-ui-giturl.html) for how to install packages via Git URL by using the Unity Package Manager.  
See [here](https://docs.unity3d.com/Manual/upm-git.html) for how to do so manually by editing the "manifest.json" file in `[your project folder]/Packages/`.

### Installation from a local package (alternative)
See [here](https://docs.unity3d.com/Manual/upm-ui-local.html) for how to install packages from a local folder using the Unity Package Manager.  
See [here](https://docs.unity3d.com/Manual/upm-localpath.html) for how to do so manually by editing the "manifest.json" file in `[your project folder]/Packages/`.

</details>

## Usage

Include the namespace at the top of script files which should contain calls to the extension methods: 

```csharp
using NumericMath;
```


---


## Contents

Note:  

`Method[A/B/C]` = Methods with the names `MethodA`, `MethodB`, and `MethodC` exist.  
`Method[/A/B/C]` = Methods with the names `Method`, `MethodA`, `MethodB`, and `MethodC` exist.

`→` = Methods for existing `static` methods have been added in order to simplify the way they can be called. The `→` leads to the official documentation.  
`+` = Methods with custom implementations have been added in order to provide additional functionality.

`F` = Methods for floating-point value-types exist.  
`I` = Methods for integral value-types exist.  
`B` = Methods for boolean values exist.


---


### Arithmetic


---


#### Basic
<details><summary>Expand</summary>

##### Add `+` `F,I`
Returns a sequence of numbers (**excluding** the initial value), adding the specified `addend` a specified number of times.

```csharp
 (0).Add(2, 5);  // returns '[ 2,  4,  6,  8, 10]'
 (5).Add(5, 4);  // returns '[10, 15, 20, 25]'
(-5).Add(-1, 3); // returns '[-6, -7, -8]'
```

##### Subtract `+` `F,I`
Returns a sequence of numbers (**excluding** the initial value), subtracting the specified `subtrahend` a specified number of times.

```csharp
(10).Subtract(2, 5);  // returns '[ 8,  6,  4,  2,  0]'
 (1).Subtract(-2, 4); // returns '[ 3,  5,  7,  9]'
(-5).Subtract(1, 3);  // returns '[-6, -7, -8]'
```

##### Multiply `+` `F,I`
Returns a sequence of numbers (**excluding** the initial value), multiplying by the specified `factor` a specified number of times.

```csharp
 (1).Multiply(2, 5);  // returns '[ 2,  4,  8, 16, 32]'
 (1).Multiply(-2, 4); // returns '[-2,  4, -8, 16]'
(-5).Multiply(-1, 3); // returns '[ 5, -5,  5]'
```

##### Divide `+` `F,I`
Returns a sequence of numbers (**excluding** the initial value), dividing by the specified `divisor` a specified number of times.

```csharp
(1000f).Divide(10f, 5);  // returns '[100f,   10,    1, 0.1f, 0.01f]'
  (100).Divide(-2, 4);   // returns '[ -50,   25,  -12,    6]'
   (5f).Divide(0.5f, 3); // returns '[ 10f,  20f,  40f]'
```

##### Range [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.range) / `+` `F,I`
Returns a sequence of numbers (**including** the initial value) with a specified length, incrementing by `one` by default.
```csharp
 (0).Range(3);      // returns '[ 0,   1,   2]'
 (0).Range(3, 5);   // returns '[ 0,   5,  10]'
(10).Range(3, 5);   // returns '[10,  15,  20]'
(-5).Range(3);      // returns '[-5,  -4,  -3]'
(-5).Range(3, -10); // returns '[-5, -15, -25]'
```

##### BigMul [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.bigmul) `I`
Returns the full product of two numbers as the next-bigger value-type to avoid overflows.
```csharp
(1234567890).BigMul(1000000000); // returns '1234567890000000000L'
```

##### DivRem [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.divrem) `I`
Returns the quotient of two numbers and also returns the remainder in an output parameter.
```csharp
int remainder;
 (5).DivRem(3, out remainder);   // returns '1', remainder == '2'
 (5).DivRem(-3, out remainder);  // returns '-1', remainder == '2'
(-5).DivRem(3, out remainder);   // returns '-1', remainder == '-2'
(-5).DivRem(-3, out remainder);  // returns '1', remainder == '-2'
```

</details>


---


#### Modular
<details><summary>Expand</summary>

##### Modulo `+` `F,I`
Repeats the sequence from `zero` to `divisor` (exclusively), with the direction and `sign` based on the `sign` of the `divisor`.
```csharp
var range = (-3).Range(7);      // returns '[-3, -2, -1,  0,  1,  2,  3]'
range.Select(i => i.Modulo(3);  // returns '[ 0,  1,  2,  0,  1,  2,  0]'
range.Select(i => i.Modulo(-3); // returns '[ 0, -2, -1,  0, -2, -1,  0]'
```

##### Remainder [`→`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#remainder-operator-) `F,I`
Repeats the sequence from `zero` to `divisor` (exclusively), with the direction and `sign` based on the `sign` of the `dividend`.
```csharp
var range = (-3).Range(7);         // returns '[-3, -2, -1,  0,  1,  2,  3]'
range.Select(i => i.Remainder(3);  // returns '[ 0, -2, -1,  0,  1,  2,  0]'
range.Select(i => i.Remainder(-3); // returns '[ 0, -2, -1,  0,  1,  2,  0]'
```

</details>


---

#### Trigonometry
<details><summary>Expand</summary>

Note:  
`°` = Methods for non-hyperbolic trigonometric functions use `degrees` by default.

##### Sin/Asin `°` [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.sin) [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.asin) / Sinh [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.sinh) `F`
Sin[/h]: Returns the (hyperbolic) sine of the angle.  
Asin: Returns the angle whose sine is the number.
```csharp
 (0f).Sin();  // returns '0f'
(90f).Sin();  // returns '1f'
 (0f).Asin(); // returns '0f'
 (1f).Asin(); // returns '90f'

 (5f).Sinh(); // returns '74.20321f'
```

##### Cos/Acos `°` [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.cos) [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.acos) / Cosh [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.cosh) `F`
Cos[/h]: Returns the (hyperbolic) cosine of the angle.  
Acos: Returns the angle whose cosine is the number.
```csharp
 (0f).Cos();  // returns '1f'
(90f).Cos();  // returns '0f'
 (0f).Acos(); // returns '90f'
 (1f).Acos(); // returns '0f'

 (5f).Cosh(); // returns '74.20995f'
```

##### Tan/Atan[/2] `°` [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.tan) [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.atan) [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.atan2) / Tanh [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.tanh) `F`
Tan[/h]: Returns the (hyperbolic) tangent of the angle.  
Atan: Returns the angle whose tangent is the number.
```csharp
(45f).Tan();  // returns '1f'
 (1f).Atan(); // returns '45f'

 (5f).Tanh(); // returns '0.9999092f'
```

</details>


---


#### Advanced
<details><summary>Expand</summary>


##### Exp [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.exp) `F`
Returns `e` raised to a power.
```csharp
(5f).Exp();       // returns '148.4132f'
(5f).Exp().Log(); // returns '5f'
```

##### Log [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.log) `F`
Returns the logarithm of the number.
```csharp
(5f).Log();       // returns '1.609438f'
(5f).Log().Exp(); // returns '5f'
```

##### Pow [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.pow) `F,I`
Returns the number raised to a power.
```csharp
 (10).Pow(3);   // returns '1000'
(10f).Pow(-3f); // returns '0.001'
```

##### Sqrt[/F] [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.sqrt) `F,I`
Returns the square root of the number.
```csharp
(4f).Sqrt();  // returns '2d'
(16).SqrtF(); // returns '4f'
```

##### Root[/F] `+` `F,I`
Returns the specified root of the number.
```csharp
(4f).Root(2d);  // returns '2d'
(27).RootF(3d); // returns '3f'
```

</details>


---


### Interpolation
<details><summary>Expand</summary>

#### Lerp `+` `F`
Linearly interpolates between two numbers by a percent value.
```csharp
  (0f).Lerp(0f, 10f);       // returns '0f'
(0.5f).Lerp(0f, 10f);       // returns '5f'
  (1f).Lerp(0f, 10f);       // returns '10f'

(1.1f).Lerp(0f, 10f);       // returns '11f'
(1.1f).Lerp(0f, 10f, true); // returns '10f'
```

#### InverseLerp `+` `F`
Calculates the percentage of the number between two numbers.
```csharp
 (0f).InverseLerp(0f, 10f);       // returns '0f'
 (5f).InverseLerp(0f, 10f);       // returns '0.5f'
(10f).InverseLerp(0f, 10f);       // returns '1f'

(11f).InverseLerp(0f, 10f);       // returns '1.1f'
(11f).InverseLerp(0f, 10f, true); // returns '1f'
```

#### Remap `+` `F`
Calculates the percentage of the number between two starting numbers via `InverseLerp` and applies it to two target numbers via `Lerp`.
```csharp
(5f).Remap(0f, 10f, 50f, 100f);   // returns '75f'
(5f).Remap(-20f, 10f, 10f, -20f); // returns '-15f'
```

</details>


---


### Conversion
<details><summary>Expand</summary>


#### ToBool `+` `F,I`
Returns `true` if the number is not `zero`.
```csharp
 (5).ToBool(); // returns 'true'
 (0).ToBool(); // returns 'False'
(-5).ToBool(); // returns 'true'
```

#### To[Degrees/Radians] `+` `F`
Converts an angle between `degrees` and `radians`.
```csharp
Math.PI.ToDegrees(); // returns '180d'
 (180d).ToRadians(); // returns '3.14159265358979d'
```

#### ToInvariantString `+` `F,I,B`
Returns a string representation of the number, using the [invariant Culture](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo.invariantculture?view=net-5.0).
```csharp
      (5.5f).ToInvariantString();    // returns "5.5"
(123456.78f).ToInvariantString("N2") // returns "123,456.80" (rounded due to floating-point precision)
```

#### ToPercentString `+` `F`
Returns a string representation of the number, formatted as percent.
```csharp
(0.5f).ToPercentString();  // returns "50.00 %"
(0.5f).ToPercentString(0); // returns "50 %"
```

#### To[Binary/Hex]String `+` `I`
Returns a string representation of the number, formatted as binary/hexadecimal.
```csharp
(5).ToBinaryString(); // returns "00000101"
(5).ToHexString();    // returns "05"
```

#### To[Byte/Short/Int/Long/Float/Double] `+` `B`
Returns a value representing the bool as `zero` or `one`.
```csharp
false.ToInt();   // returns '0'
 true.ToFloat(); // returns '1f'
```

</details>


---


### Rounding
<details><summary>Expand</summary>

#### Ceil[/ToInt] [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.ceiling) / `+` `F`
Returns the smallest integral value greater than or equal to the number.
```csharp
 (5.5f).Ceil(); // returns  '6f'
(-5.5f).Ceil(); // returns '-5f'
```

#### Floor[/ToInt] [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.floor) / `+` `F`
Returns the largest integral value less than or equal to the number.
```csharp
 (5.5f).Floor(); // returns  '5f'
(-5.5f).Floor(); // returns '-6f'
```

#### Round[/ToInt] [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.round) / `+` `F`
Rounds a value to the nearest integer.
```csharp
 (5.4f).Round(); // returns  '5f'
 (5.5f).Round(); // returns  '6f'
(-5.4f).Round(); // returns '-5f'
(-5.5f).Round(); // returns '-6f'
```

#### Truncate [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.truncate) `F`
Calculates the integral part of a number.
```csharp
 (5.5f).Truncate(); // returns  '5'
(-5.5f).Truncate(); // returns '-5'
```

</details>


---


### Extremes
<details><summary>Expand</summary>

#### Min [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.min) `F,I`
Returns the smaller of two numbers.
```csharp
(5).Min(10); // returns '5'
```

#### Max [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.max) `F,I`
Returns the larger of two numbers.
```csharp
(5).Max(10); // returns '10'
```

#### Is[[Negative/Positive/]Infinity / NaN] `+` `F`
Checks if the value is (negative/positive) infinity / `Not a Number`
```csharp
 (5f / 0f).IsPositiveInfinity(); // returns 'true'
(-5f / 0f).IsNegativeInfinity(); // returns 'true'
 (0f / 0f).IsNaN();              // returns 'true'
```

</details>


---


### Limits
<details><summary>Expand</summary>

#### Clamp[/01] `+` `F,I`
Returns the number which is clamped to the inclusive range of `min` and `max`.
```csharp
  (10).Clamp(-5, 5); // returns  '5'
 (-10).Clamp(-5, 5); // returns '-5'
(1.1f).Clamp01();    // returns '1f'
```
#### IsClamped[/01] `+` `F,I`
Checks whether the number is clamped to the range of `min` and `max`, inclusively by default.
```csharp
  (10).IsClamped(-5, 5);        // returns 'false'
   (5).IsClamped(-5, 5);        // returns 'true'
   (5).IsClamped(-5, 5, false); // returns 'false'
(0.5f).IsClamped01();           // returns 'true'
```

</details>


---


### Signum
<details><summary>Expand</summary>

#### Abs [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.abs) `F,I`
Returns the absolute value of the number.

```csharp
 (5).Abs(); // returns '5'
(-5).Abs(); // returns '5'
```

#### Sign [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.sign) `F,I`
Returns an integer which indicates the sign of a number.
```csharp
 (5).Sign(); // returns  '1'
 (0).Sign(); // returns  '0'
(-5).Sign(); // returns '-1'
```

</details>


---


### Parity
<details><summary>Expand</summary>

#### Is[Even/Odd] `+` `I`
Checks whether a number is even or odd.
```csharp
(5).IsEven(); // returns 'false'
(5).IsOdd();  // returns 'true'
```

</details>