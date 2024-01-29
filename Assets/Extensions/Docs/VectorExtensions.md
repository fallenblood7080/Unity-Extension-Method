# VectorsExtension Class

## Index
- [NearestPointOnAxis (Vector3)](#NearestPointOnAxis-Vector3)
- [NearestPointOnAxis (Vector2)](#NearestPointOnAxis-Vector2)
- [NearestPointOnLine (Vector3)](#NearestPointOnLine-Vector3)
- [NearestPointOnLine (Vector2)](#NearestPointOnLine-Vector2)
- [GetClosestVectorFrom (Vector2)](#GetClosestVectorFrom-Vector2)
- [GetClosestVectorFrom (Vector3)](#GetClosestVectorFrom-Vector3)

## NearestPointOnAxis (Vector3)

Finds the nearest point on a specified axis to a given point in 3D space.

### Usage

```csharp
// Example: Find the nearest point on the X-axis to the point (2, 1, 3)
Vector3 axisDirection = Vector3.right;
Vector3 point = new Vector3(2, 1, 3);
Vector3 nearestPoint = axisDirection.NearestPointOnAxis(point);
```

### General Syntax

```csharp
Vector3 result = axisDirection.NearestPointOnAxis(point, isNormalized);
```

### Parameters

| Parameter      | Data Type | Description                                               |
| -------------- | --------- | --------------------------------------------------------- |
| axisDirection  | Vector3   | The direction vector of the axis.                         |
| point          | Vector3   | The 3D point for which you want to find the nearest point on the axis. |
| isNormalized   | bool      | Indicates whether the `axisDirection` vector is already normalized. Default is `false`. |

### Method Description

This extension method finds the nearest point on the specified axis to the input `point` in 3D space. If the `axisDirection` vector is not normalized, it normalizes it before performing the calculations. The result is calculated as the projection of the `point` onto the axis defined by `axisDirection`.

### Example

```csharp
// Find the nearest point on the X-axis to the point (2, 1, 3)
Vector3 axisDirection = Vector3.right;
Vector3 point = new Vector3(2, 1, 3);
Vector3 nearestPoint = axisDirection.NearestPointOnAxis(point);
// Result: nearestPoint = (2, 0, 0)
```

In this example, the `NearestPointOnAxis` method is used to find the nearest point on the X-axis to the point (2, 1, 3).

## NearestPointOnAxis (Vector2)

Finds the nearest point on a specified axis to a given point in 2D space.

### Usage

```csharp
// Example: Find the nearest point on the X-axis to the point (2, 1)
Vector2 axisDirection = Vector2.right;
Vector2 point = new Vector2(2, 1);
Vector2 nearestPoint = axisDirection.NearestPointOnAxis(point);
```

### General Syntax

```csharp
Vector2 result = axisDirection.NearestPointOnAxis(point, isNormalized);
```

### Parameters

| Parameter      | Data Type | Description                                               |
| -------------- | --------- | --------------------------------------------------------- |
| axisDirection  | Vector2   | The direction vector of the axis.                         |
| point          | Vector2   | The 2D point for which you want to find the nearest point on the axis. |
| isNormalized   | bool      | Indicates whether the `axisDirection` vector is already normalized. Default is `false`. |

### Method Description

This extension method finds the nearest point on the specified axis to the input `point` in 2D space. If the `axisDirection` vector is not normalized, it normalizes it before performing the calculations. The result is calculated as the projection of the `point` onto the axis defined by `axisDirection`.

### Example

```csharp
// Find the nearest point on the X-axis to the point (2, 1)
Vector2 axisDirection = Vector2.right;
Vector2 point = new Vector2(2, 1);
Vector2 nearestPoint = axisDirection.NearestPointOnAxis(point);
// Result: nearestPoint = (2, 0)
```

In this example, the `NearestPointOnAxis` method is used to find the nearest point on the X-axis to the point (2, 1).

## NearestPointOnLine (Vector3)

Finds the nearest point on a specified line to a given point in 3D space.

### Usage

```csharp
// Example: Find the nearest point on the line passing through (1, 1, 1) in the direction of (1, 0, 0) to the point (2, 2, 2)
Vector3 lineDirection = Vector3.right;
Vector3 pointOnLine = new Vector3(1, 1, 1);
Vector3 point = new Vector3(2, 2, 2);
Vector3 nearestPoint = lineDirection.NearestPointOnLine(point, pointOnLine);
```

### General Syntax

```csharp
Vector3 result = lineDirection.NearestPointOnLine(point, pointOnLine, isNormalized);
```

### Parameters

| Parameter      | Data Type | Description                                               |
| -------------- | --------- | --------------------------------------------------------- |
| lineDirection  | Vector3   | The direction vector of the line.                         |
| point          | Vector3   | The 3D point for which you want to find the nearest point on the line. |
| pointOnLine    | Vector3   | A point on the line used as a reference for calculations.  |
| isNormalized   | bool      | Indicates whether the `lineDirection` vector is already normalized. Default is `false`. |

### Method Description

This extension method finds the nearest point on the specified line to the input `point` in 3D space. If the `lineDirection` vector is not normalized, it normalizes it before performing the calculations. The result is calculated as the projection of the vector from `pointOnLine` to `point` onto the line defined by `lineDirection`.

### Example

```csharp
// Find the nearest point on the line passing through (1, 1, 1) in the direction of (1, 0, 0) to the point (2, 2, 2)
Vector3 lineDirection = Vector3.right;
Vector3 pointOnLine = new Vector3(1, 1, 1);
Vector3 point = new Vector3(2, 2, 2);
Vector3 nearestPoint = lineDirection.NearestPointOnLine(point, pointOnLine);
// Result: nearestPoint = (2, 1, 1)
```

In this example, the `NearestPointOnLine` method is used to find the nearest point on the line to the point (2, 2, 2).

## NearestPointOnLine (Vector2)

Finds the nearest point on a specified line to a given point in 2D space.

### Usage

```csharp
// Example: Find the nearest point on the line passing through (1, 1) in the direction of (1, 0) to the point (2, 2)
Vector2 lineDirection = Vector2.right;
Vector2 pointOnLine = new Vector2(1, 1);
Vector2 point = new Vector2(2, 2);
Vector2 nearestPoint = lineDirection.NearestPointOnLine(point, pointOnLine);
```

### General Syntax

```csharp
Vector2 result = lineDirection.NearestPointOnLine(point, pointOnLine, isNormalized);
```

### Parameters

| Parameter      | Data Type | Description                                               |
| -------------- | --------- | --------------------------------------------------------- |
| lineDirection  | Vector2  

 | The direction vector of the line.                         |
| point          | Vector2   | The 2D point for which you want to find the nearest point on the line. |
| pointOnLine    | Vector2   | A point on the line used as a reference for calculations.  |
| isNormalized   | bool      | Indicates whether the `lineDirection` vector is already normalized. Default is `false`. |

### Method Description

This extension method finds the nearest point on the specified line to the input `point` in 2D space. If the `lineDirection` vector is not normalized, it normalizes it before performing the calculations. The result is calculated as the projection of the vector from `pointOnLine` to `point` onto the line defined by `lineDirection`.

### Example

```csharp
// Find the nearest point on the line passing through (1, 1) in the direction of (1, 0) to the point (2, 2)
Vector2 lineDirection = Vector2.right;
Vector2 pointOnLine = new Vector2(1, 1);
Vector2 point = new Vector2(2, 2);
Vector2 nearestPoint = lineDirection.NearestPointOnLine(point, pointOnLine);
// Result: nearestPoint = (2, 1)
```

In this example, the `NearestPointOnLine` method is used to find the nearest point on the line to the point (2, 2).

## GetClosestVectorFrom (Vector2)

Finds the vector in an array that is closest to a specified reference vector in 2D space.

### Usage

```csharp
// Example: Find the Vector2 vector from an array closest to the reference vector (2, 1)
Vector2 referenceVector = new Vector2(2, 1);
Vector2[] otherVectors = { new Vector2(3, 1), new Vector2(1, 2), new Vector2(4, 1) };
Vector2 closestVector = referenceVector.GetClosestVectorFrom(otherVectors);
```

### General Syntax

```csharp
Vector2 result = referenceVector.GetClosestVectorFrom(otherVectors);
```

### Parameters

| Parameter      | Data Type   | Description                                               |
| -------------- | ----------- | --------------------------------------------------------- |
| referenceVector| Vector2     | The reference vector for which you want to find the closest vector. |
| otherVectors   | Vector2[]   | An array of Vector2 vectors from which to find the closest vector. |

### Method Description

This extension method finds the Vector2 vector from the array `otherVectors` that is closest to the reference vector `referenceVector`. It iterates through the array and calculates the squared distance between the reference vector and each vector in the array, returning the vector with the minimum squared distance.

### Example

```csharp
// Find the Vector2 vector from an array closest to the reference vector (2, 1)
Vector2 referenceVector = new Vector2(2, 1);
Vector2[] otherVectors = { new Vector2(3, 1), new Vector2(1, 2), new Vector2(4, 1) };
Vector2 closestVector = referenceVector.GetClosestVectorFrom(otherVectors);
// Result: closestVector = (3, 1)
```

In this example, the `GetClosestVectorFrom` method is used to find the Vector2 vector from the array that is closest to the reference vector (2, 1).

## GetClosestVectorFrom (Vector3)

Finds the vector in an array that is closest to a specified reference vector in 3D space.

### Usage

```csharp
// Example: Find the Vector3 vector from an array closest to the reference vector (2, 1, 3)
Vector3 referenceVector = new Vector3(2, 1, 3);
Vector3[] otherVectors = { new Vector3(3, 1, 2), new Vector3(1, 2, 4), new Vector3(4, 1, 3) };
Vector3 closestVector = referenceVector.GetClosestVectorFrom(otherVectors);
```

### General Syntax

```csharp
Vector3 result = referenceVector.GetClosestVectorFrom(otherVectors);
```

### Parameters

| Parameter      | Data Type   | Description                                               |
| -------------- | ----------- | --------------------------------------------------------- |
| referenceVector| Vector3     | The reference vector for which you want to find the closest vector. |
| otherVectors   | Vector3[]   | An array of Vector3 vectors from which to find the closest vector. |

### Method Description

This extension method finds the Vector3 vector from the array `otherVectors` that is closest to the reference vector `referenceVector`. It iterates through the array and calculates the squared distance between the reference vector and each vector in the array, returning the vector with the minimum squared distance.

### Example

```csharp
// Find the Vector3 vector from an array closest to the reference vector (2, 1, 3)
Vector3 referenceVector = new Vector3(2, 1, 3);
Vector3[] otherVectors = { new Vector3(3, 1, 2), new Vector3(1, 2, 4), new Vector3(4, 1, 3) };
Vector3 closestVector = referenceVector.GetClosestVectorFrom(otherVectors);
// Result: closestVector = (3, 1, 2)
```

In this example, the `GetClosestVectorFrom` method is used to find the Vector3 vector from the array that is closest to the reference vector (2, 1, 3).
