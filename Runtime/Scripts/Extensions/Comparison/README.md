# Comparison

## Min [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.min) `F,I`
Returns the smaller of two numbers.
```csharp
(5).Min(10); // returns '5'
```

## Max [`→`](https://docs.microsoft.com/en-us/dotnet/api/system.math.max) `F,I`
Returns the larger of two numbers.
```csharp
(5).Max(10); // returns '10'
```

## Nearest `+` `F,I`
Returns the number with the closest value.  
If there are multiple candidates which are the same distance away but in opposite directions, the one which was found first is returned.
```csharp
(0).Nearest(new []{ 10, 5, 20, -5 }); // returns '5'
(0).Nearest(new []{ 10, -5, 20, 5 }); // returns '-5'
```

## Furthest `+` `F,I`
Returns the number with the farthest value.  
If there are multiple candidates which are the same distance away but in opposite directions, the one which was found first is returned.
```csharp
(0).Furthest(new []{ 10, 20, 5, -20 }); // returns '20'
(0).Furthest(new []{ 10, -20, 5, 20 }); // returns '-20'
```