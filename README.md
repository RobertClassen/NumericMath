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

`►` = Methods for existing `static` methods have been added in order to simplify the way they can be called. The `►` leads to the official documentation.  
`+` = Methods with custom implementations have been added in order to provide additional functionality.

`F` = Methods for floating-point value-types exist.  
`I` = Methods for integral value-types exist.  
`B` = Methods for boolean values exist.


---


| Category | Methods |
| - | - |
| [Interpolation] | [`Lerp`][Interpolation.Lerp] [`InverseLerp`][Interpolation.InverseLerp] [`Remap`][Interpolation.Remap] |
| [Limits] | [`Clamp[/01]`][Limits.Clamp01] [`Clamp[Min/Max]`][Limits.ClampMinMax] [`IsClamped[/01]`][Limits.IsClamped01] [`Modulo`][Limits.Modulo] [`Remainder`][Limits.Remainder] |
| [Comparison] | [`Min/Max`][Comparison.MinMax] [`Nearest/Furthest`][Comparison.NearestFurthest] |
| [Rounding] | [`Ceil[/ToInt]`][Rounding.Ceil] [`Floor[/ToInt]`][Rounding.Floor] [`Round[/ToInt]`][Rounding.Round] [`RoundTo[Nearest/Furthest/Mid]`][Rounding.RoundTo] [`Truncate`][Rounding.Truncate] |
| [Statistics] | [`[Arithmetic/Geometric/Harmonic]Mean`][Statistics.Mean] [`MidRange`][Statistics.MidRange] [`RangeMagnitude`][Statistics.RangeMagnitude] |
| [Trigonometry] | [`Sin/Asin / Sinh`][Trigonometry.Sin] [`Cos/Acos / Cosh`][Trigonometry.Cos] [`Tan/Atan[/2] / Tanh`][Trigonometry.Tan] |
| [Conversion] | [`To[Degrees/Radians]`][Conversion.ToDegreesRadians] [`ToInvariantString`][Conversion.ToInvariantString] [`ToPercentString`][Conversion.ToPercentString] [`To[Binary/Hex]String`][Conversion.ToBinaryHexString] [`ToBool`][Conversion.ToBool] [`To[Byte/Short/Int/Long/Float/Double]`][Conversion.To01] |
| [Sequences] | [`Range`][Sequences.Range] [`Add`][Sequences.Add] [`Subtract`][Sequences.Subtract] [`Multiply`][Sequences.Multiply] [`Divide`][Sequences.Divide] |
| [Arithmetic] | [`Exp`][Arithmetic.Exp] [`Log`][Arithmetic.Log] [`Pow`][Arithmetic.Pow] [`Sqrt`][Arithmetic.Sqrt] [`Root`][Arithmetic.Root] [`BigMul`][Arithmetic.BigMul] [`DivRem`][Arithmetic.DivRem] |
| [Signum] | [`Abs`][Signum.Abs] [`Sign`][Signum.Sign] [`Extreme`][Signum.Extreme] |
| [Validation] | [`Is[Negative/Positive/]Infinity`][Validation.IsInfinity] [`IsNaN`][Validation.IsNaN] |
| [Parity] | [`Is[Even/Odd]`][Parity.IsEvenOdd] |



[Interpolation]: Runtime/Scripts/Extensions/Interpolation/README.md
[Interpolation.Lerp]: Runtime/Scripts/Extensions/Interpolation/README.md#Lerp
[Interpolation.InverseLerp]: Runtime/Scripts/Extensions/Interpolation/README.md#InverseLerp
[Interpolation.Remap]: Runtime/Scripts/Extensions/Interpolation/README.md#Remap

[Limits]: Runtime/Scripts/Extensions/Limits/README.md
[Limits.Clamp01]: Runtime/Scripts/Extensions/Limits/README.md#Clamp01
[Limits.ClampMinMax]: Runtime/Scripts/Extensions/Limits/README.md#ClampMinMax
[Limits.IsClamped01]: Runtime/Scripts/Extensions/Limits/README.md#IsClamped01
[Limits.Modulo]: Runtime/Scripts/Extensions/Limits/README.md#Modulo
[Limits.Remainder]: Runtime/Scripts/Extensions/Limits/README.md#Remainder

[Comparison]: Runtime/Scripts/Extensions/Comparison/README.md
[Comparison.MinMax]: Runtime/Scripts/Extensions/Comparison/README.md#MinMax
[Comparison.NearestFurthest]: Runtime/Scripts/Extensions/Comparison/README.md#NearestFurthest

[Rounding]: Runtime/Scripts/Extensions/Rounding/README.md
[Rounding.Ceil]: Runtime/Scripts/Extensions/Rounding/README.md#CeilToInt
[Rounding.Floor]: Runtime/Scripts/Extensions/Rounding/README.md#FloorToInt
[Rounding.Round]: Runtime/Scripts/Extensions/Rounding/README.md#RoundToInt
[Rounding.RoundTo]: Runtime/Scripts/Extensions/Rounding/README.md#RoundToNearestFurthestMid
[Rounding.Truncate]: Runtime/Scripts/Extensions/Rounding/README.md#Truncate

[Statistics]: Runtime/Scripts/Extensions/Statistics/README.md
[Statistics.Mean]: Runtime/Scripts/Extensions/Statistics/README.md#ArithmeticGeometricHarmonicMean
[Statistics.MidRange]: Runtime/Scripts/Extensions/Statistics/README.md#MidRange
[Statistics.RangeMagnitude]: Runtime/Scripts/Extensions/Statistics/README.md#RangeMagnitude

[Trigonometry]: Runtime/Scripts/Extensions/Trigonometry/README.md
[Trigonometry.Sin]: Runtime/Scripts/Extensions/Trigonometry/README.md#SinAsinSinh
[Trigonometry.Cos]: Runtime/Scripts/Extensions/Trigonometry/README.md#CosAcosCosh
[Trigonometry.Tan]: Runtime/Scripts/Extensions/Trigonometry/README.md#TanAtan2Tanh

[Conversion]: Runtime/Scripts/Extensions/Conversion/README.md
[Conversion.ToDegreesRadians]: Runtime/Scripts/Extensions/Conversion/README.md#ToDegreesRadians
[Conversion.ToInvariantString]: Runtime/Scripts/Extensions/Conversion/README.md#ToInvariantString
[Conversion.ToPercentString]: Runtime/Scripts/Extensions/Conversion/README.md#ToPercentString
[Conversion.ToBinaryHexString]: Runtime/Scripts/Extensions/Conversion/README.md#ToBinaryHexString
[Conversion.ToBool]: Runtime/Scripts/Extensions/Conversion/README.md#ToBool
[Conversion.To01]: Runtime/Scripts/Extensions/Conversion/README.md#ToByteShortIntLongFloatDouble

[Sequences]: Runtime/Scripts/Extensions/Sequences/README.md
[Sequences.Range]: Runtime/Scripts/Extensions/Sequences/README.md#Range
[Sequences.Add]: Runtime/Scripts/Extensions/Sequences/README.md#Add
[Sequences.Subtract]: Runtime/Scripts/Extensions/Sequences/README.md#Subtract
[Sequences.Multiply]: Runtime/Scripts/Extensions/Sequences/README.md#Multiply
[Sequences.Divide]: Runtime/Scripts/Extensions/Sequences/README.md#Divide

[Arithmetic]: Runtime/Scripts/Extensions/Arithmetic/README.md
[Arithmetic.Exp]: Runtime/Scripts/Extensions/Arithmetic/README.md#Exp
[Arithmetic.Log]: Runtime/Scripts/Extensions/Arithmetic/README.md#Log
[Arithmetic.Pow]: Runtime/Scripts/Extensions/Arithmetic/README.md#Pow
[Arithmetic.Sqrt]: Runtime/Scripts/Extensions/Arithmetic/README.md#Sqrt
[Arithmetic.Root]: Runtime/Scripts/Extensions/Arithmetic/README.md#Root
[Arithmetic.BigMul]: Runtime/Scripts/Extensions/Arithmetic/README.md#BigMul
[Arithmetic.DivRem]: Runtime/Scripts/Extensions/Arithmetic/README.md#DivRem

[Signum]: Runtime/Scripts/Extensions/Signum/README.md
[Signum.Abs]: Runtime/Scripts/Extensions/Signum/README.md#Abs
[Signum.Sign]: Runtime/Scripts/Extensions/Signum/README.md#Sign
[Signum.Extreme]: Runtime/Scripts/Extensions/Signum/README.md#Extreme

[Validation]: Runtime/Scripts/Extensions/Validation/README.md
[Validation.IsInfinity]: Runtime/Scripts/Extensions/Validation/README.md#IsNegativePositiveInfinity
[Validation.IsNaN]: Runtime/Scripts/Extensions/Validation/README.md#IsNaN

[Parity]: Runtime/Scripts/Extensions/Parity/README.md
[Parity.IsEvenOdd]: Runtime/Scripts/Extensions/Parity/README.md#IsEvenOdd