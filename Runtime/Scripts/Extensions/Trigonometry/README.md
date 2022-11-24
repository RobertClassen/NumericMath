# Trigonometry

Note:  
`°` = Methods for non-hyperbolic trigonometric functions use `degrees` by default.

## Sin/Asin `°` [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.sin) [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.asin) / Sinh [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.sinh) `F`
Sin[/h]: Returns the (hyperbolic) sine of the angle.  
Asin: Returns the angle whose sine is the number.
```csharp
 (0f).Sin();  // returns '0f'
(90f).Sin();  // returns '1f'
 (0f).Asin(); // returns '0f'
 (1f).Asin(); // returns '90f'

 (5f).Sinh(); // returns '74.20321f'
```

## Cos/Acos `°` [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.cos) [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.acos) / Cosh [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.cosh) `F`
Cos[/h]: Returns the (hyperbolic) cosine of the angle.  
Acos: Returns the angle whose cosine is the number.
```csharp
 (0f).Cos();  // returns '1f'
(90f).Cos();  // returns '0f'
 (0f).Acos(); // returns '90f'
 (1f).Acos(); // returns '0f'

 (5f).Cosh(); // returns '74.20995f'
```

## Tan/Atan[/2] `°` [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.tan) [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.atan) [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.atan2) / Tanh [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.tanh) `F`
Tan[/h]: Returns the (hyperbolic) tangent of the angle.  
Atan: Returns the angle whose tangent is the number.
```csharp
(45f).Tan();  // returns '1f'
 (1f).Atan(); // returns '45f'

 (5f).Tanh(); // returns '0.9999092f'
```