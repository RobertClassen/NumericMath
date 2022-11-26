# Interpolation

## Lerp
`+` `F`
Linearly interpolates between two numbers by a percent value.
```csharp
  (0f).Lerp(0f, 10f);       // returns '0f'
(0.5f).Lerp(0f, 10f);       // returns '5f'
  (1f).Lerp(0f, 10f);       // returns '10f'

(1.1f).Lerp(0f, 10f);       // returns '11f'
(1.1f).Lerp(0f, 10f, true); // returns '10f'
```

## InverseLerp
`+` `F`
Calculates the percentage of the number between two numbers.
```csharp
 (0f).InverseLerp(0f, 10f);       // returns '0f'
 (5f).InverseLerp(0f, 10f);       // returns '0.5f'
(10f).InverseLerp(0f, 10f);       // returns '1f'

(11f).InverseLerp(0f, 10f);       // returns '1.1f'
(11f).InverseLerp(0f, 10f, true); // returns '1f'
```

## Remap
`+` `F`
Calculates the percentage of the number between two starting numbers via `InverseLerp` and applies it to two target numbers via `Lerp`.
```csharp
(5f).Remap(0f, 10f, 50f, 100f);   // returns '75f'
(5f).Remap(-20f, 10f, 10f, -20f); // returns '-15f'
```