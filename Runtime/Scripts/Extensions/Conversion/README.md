# Conversion

## ToBool `+` `F,I`
Returns `true` if the number is not `zero`.
```csharp
 (5).ToBool(); // returns 'true'
 (0).ToBool(); // returns 'False'
(-5).ToBool(); // returns 'true'
```

## To[Degrees/Radians] `+` `F`
Converts an angle between `degrees` and `radians`.
```csharp
Math.PI.ToDegrees(); // returns '180d'
 (180d).ToRadians(); // returns '3.14159265358979d'
```

## ToInvariantString `+` `F,I,B`
Returns a string representation of the number, using the [invariant Culture](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo.invariantculture?view=net-5.0).
```csharp
      (5.5f).ToInvariantString();    // returns "5.5"
(123456.78f).ToInvariantString("N2") // returns "123,456.80" (rounded due to floating-point precision)
```

## ToPercentString `+` `F`
Returns a string representation of the number, formatted as percent.
```csharp
(0.5f).ToPercentString();  // returns "50.00 %"
(0.5f).ToPercentString(0); // returns "50 %"
```

## To[Binary/Hex]String `+` `I`
Returns a string representation of the number, formatted as binary/hexadecimal.
```csharp
(5).ToBinaryString(); // returns "00000101"
(5).ToHexString();    // returns "05"
```

## To[Byte/Short/Int/Long/Float/Double] `+` `B`
Returns a value representing the bool as `zero` or `one`.
```csharp
false.ToInt();   // returns '0'
 true.ToFloat(); // returns '1f'
```