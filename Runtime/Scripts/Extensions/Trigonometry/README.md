# Trigonometry

**Note:** 
Methods for trigonometric functions use `degrees` by default.

## Sin/Asin / Sinh
**Sin[/h]** [`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.sin) [`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.sinh) `F`  
Returns the (hyperbolic) sine of the angle.  
**Asin** [`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.asin) `F`  
Returns the angle whose sine is the number.
```csharp
 (0f).Sin();  // returns '0f'
(90f).Sin();  // returns '1f'
 (0f).Asin(); // returns '0f'
 (1f).Asin(); // returns '90f'

(90f).Sinh(); // returns '2.301299f'
```

## Cos/Acos / Cosh
**Cos[/h]** [`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.cos) [`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.cosh) `F`  
Returns the (hyperbolic) cosine of the angle.  
**Acos** [`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.acos) `F`  
Returns the angle whose cosine is the number.
```csharp
 (0f).Cos();  // returns '1f'
(90f).Cos();  // returns '0f'
 (0f).Acos(); // returns '90f'
 (1f).Acos(); // returns '0f'

(90f).Cosh(); // returns '2.509179f'
```

## Tan/Atan[/2] / Tanh
**Tan[/h]** [`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.tan) [`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.tanh) `F`  
Returns the (hyperbolic) tangent of the angle.  
**Atan[/2]** [`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.atan) [`►`](https://docs.microsoft.com/en-us/dotnet/api/system.math.atan2) `F`  
Returns the angle whose tangent is the number / `y/x`.
```csharp
(45f).Tan();     // returns '1f'
 (1f).Atan();    // returns '45f'
 (1f).Atan2(1f); // returns '45f'

(90f).Tanh();    // returns '0.9171523f'
```