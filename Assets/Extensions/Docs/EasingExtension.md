# EasingExtensions Class 

1. [LerpLinear](#LerpLinear)
2. [LerpEaseInQuad](#LerpEaseInQuad)
3. [LerpEaseOutQuad](#LerpEaseOutQuad)
4. [LerpEaseInOutQuad](#LerpEaseInOutQuad)

---

## LerpLinear

Performs linear interpolation between 0 and a specified maximum value.

### Usage

```csharp
// Example: Use linear interpolation with a factor of 0.6 and a maximum value of 1.5
float interpolatedValue = 0.6f.LerpLinear(1.5f);
```

### General Syntax

```csharp
float result = t.LerpLinear(max);
```

### Parameters

| Parameter | Data Type | Description |
|-----------|-----------|-------------|
| t         | float     | The interpolation factor (usually between 0 and 1). |
| max       | float     | The maximum value to interpolate to (default is 1). |

### Method Description

This extension method performs linear interpolation between 0 and the specified maximum value. The interpolation factor `t` is typically between 0 and 1. The result is calculated as `t * max`, ensuring that it does not exceed the specified maximum value (`max`).

### Example

```csharp
// Example: Use linear interpolation with a factor of 0.6 and a maximum value of 1.5
float interpolatedValue = 0.6f.LerpLinear(1.5f);
// Result: interpolatedValue = 0.9f
```

In this example, the `LerpLinear` method is used to perform linear interpolation with a factor of 0.6 and a maximum value of 1.5. Adjust the values according to your specific requirements.

## LerpEaseInQuad

Performs ease-in quadratic interpolation between 0 and a specified maximum value.

### Usage

```csharp
// Example: Use ease-in quadratic interpolation with a factor of 0.3 and a maximum value of 2.0
float interpolatedValue = 0.3f.LerpEaseInQuad(2.0f);
```

### General Syntax

```csharp
float result = t.LerpEaseInQuad(max);
```

### Parameters

| Parameter | Data Type | Description |
|-----------|-----------|-------------|
| t         | float     | The interpolation factor (usually between 0 and 1). |
| max       | float     | The maximum value to interpolate to (default is 1). |

### Method Description

This extension method performs ease-in quadratic interpolation between 0 and the specified maximum value. The interpolation factor `t` is typically between 0 and 1. The result is calculated as `t * t * max`, ensuring that it does not exceed the specified maximum value (`max`).

### Example

```csharp
// Example: Use ease-in quadratic interpolation with a factor of 0.3 and a maximum value of 2.0
float interpolatedValue = 0.3f.LerpEaseInQuad(2.0f);
// Result: interpolatedValue = 0.18f
```

In this example, the `LerpEaseInQuad` method is used to perform ease-in quadratic interpolation with a factor of 0.3 and a maximum value of 2.0. Adjust the values according to your specific requirements.


## LerpEaseOutQuad

Performs ease-out quadratic interpolation between 0 and a specified maximum value.

### Usage

```csharp
// Example: Use ease-out quadratic interpolation with a factor of 0.6 and a maximum value of 2.5
float interpolatedValue = 0.6f.LerpEaseOutQuad(2.5f);
```

### General Syntax

```csharp
float result = t.LerpEaseOutQuad(max);
```

### Parameters

| Parameter | Data Type | Description |
|-----------|-----------|-------------|
| t         | float     | The interpolation factor (usually between 0 and 1). |
| max       | float     | The maximum value to interpolate to (default is 1). |

### Method Description

This extension method performs ease-out quadratic interpolation between 0 and the specified maximum value. The interpolation factor `t` is typically between 0 and 1. The result is calculated as `max - (max - t * t * max)`, ensuring that it does not exceed the specified maximum value (`max`).

### Example

```csharp
// Example: Use ease-out quadratic interpolation with a factor of 0.6 and a maximum value of 2.5
float interpolatedValue = 0.6f.LerpEaseOutQuad(2.5f);
// Result: interpolatedValue = 1.56f
```

In this example, the `LerpEaseOutQuad` method is used to perform ease-out quadratic interpolation with a factor of 0.6 and a maximum value of 2.5. Adjust the values according to your specific requirements.


## LerpEaseInOutQuad

Performs ease-in-out quadratic interpolation between 0 and a specified maximum value.

### Usage

```csharp
// Example: Use ease-in-out quadratic interpolation with a factor of 0.3 and a maximum value of 1.8
float interpolatedValue = 0.3f.LerpEaseInOutQuad(1.8f);
```

### General Syntax

```csharp
float result = t.LerpEaseInOutQuad(max);
```

### Parameters

| Parameter | Data Type | Description |
|-----------|-----------|-------------|
| t         | float     | The interpolation factor (usually between 0 and 1). |
| max       | float     | The maximum value to interpolate to (default is 1). |

### Method Description

This extension method performs ease-in-out quadratic interpolation between 0 and the specified maximum value. The interpolation factor `t` is typically between 0 and 1. The result is calculated based on a conditional expression: if `t` is less than 0.5, it uses `t * t * max * 2`, otherwise, it uses a quadratic easing-out formula. The result is capped to ensure it does not exceed the specified maximum value (`max`).

### Example

```csharp
// Example: Use ease-in-out quadratic interpolation with a factor of 0.3 and a maximum value of 1.8
float interpolatedValue = 0.3f.LerpEaseInOutQuad(1.8f);
// Result: interpolatedValue = 0.324f
```

In this example, the `LerpEaseInOutQuad` method is used to perform ease-in-out quadratic interpolation with a factor of 0.3 and a maximum value of 1.8. Adjust the values according to your specific requirements.
