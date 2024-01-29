# RandomExtension Class

## Index
- [GetRandomItems (List)](#GetRandomItems-List)
- [GetRandomItems (Array)](#GetRandomItems-Array)
- [GetRandomPointInCircle (Vector2)](#GetRandomPointInCircle-Vector2)
- [GetRandomPointInSphere (Vector3)](#GetRandomPointInSphere-Vector3)

## GetRandomItems (List)

Retrieves a random selection of items from a List.

### Usage

```csharp
// Example: Get 3 random items from a List<int>
List<int> itemList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
List<int> randomItems = itemList.GetRandomItems(3);
```

### General Syntax

```csharp
List<T> result = itemList.GetRandomItems(count);
```

### Parameters

| Parameter | Data Type | Description                                               |
|-----------|-----------|-----------------------------------------------------------|
| items     | List\<T>  | The List of items from which to select randomly.          |
| count     | int       | The number of random items to retrieve from the List.      |

### Method Description

This extension method retrieves a random selection of items, containing 'count' elements, randomly selected from the input List using the Fisher-Yates shuffle algorithm.

### Example

```csharp
// Get 3 random items from a List<int>
List<int> itemList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
List<int> randomItems = itemList.GetRandomItems(3);
// Result: randomItems = [6, 2, 8] (Note: This result may vary as it is random)
```

In this example, the `GetRandomItems` method is used to get 3 random items from a List<int>.

## GetRandomItems (Array)

Retrieves a random selection of items from an array.

### Usage

```csharp
// Example: Get 2 random items from an array of strings
string[] stringArray = { "apple", "banana", "cherry", "date", "elderberry" };
string[] randomItems = stringArray.GetRandomItems(2);
```

### General Syntax

```csharp
T[] result = items.GetRandomItems(count);
```

### Parameters

| Parameter | Data Type | Description                                               |
|-----------|-----------|-----------------------------------------------------------|
| items     | T[]       | The array of items from which to select randomly.         |
| count     | int       | The number of random items to retrieve from the array.     |

### Method Description

This extension method retrieves a random selection of items, containing 'count' elements, randomly selected from the input array using the Fisher-Yates shuffle algorithm.

### Example

```csharp
// Get 2 random items from an array of strings
string[] stringArray = { "apple", "banana", "cherry", "date", "elderberry" };
string[] randomItems = stringArray.GetRandomItems(2);
// Result: randomItems = ["date", "banana"] (Note: This result may vary as it is random)
```

In this example, the `GetRandomItems` method is used to get 2 random items from an array of strings.

## GetRandomPointInCircle (Vector2)

Generates a random 2D point within a circular area defined by a center and radius.

### Usage

```csharp
// Example: Get a random point in a circle with center (0, 0) and radius 5
Vector2 center = new Vector2(0, 0);
float radius = 5f;
Vector2 randomPoint = center.GetRandomPointInCircle(radius);
```

### General Syntax

```csharp
Vector2 result = center.GetRandomPointInCircle(radius);
```

### Parameters

| Parameter | Data Type | Description                                               |
|-----------|-----------|-----------------------------------------------------------|
| center    | Vector2   | The center of the circle in 2D space.                     |
| radius    | float     | The radius of the circle, determining the distance from the center to the generated point. |

### Method Description

This extension method generates a random Vector2 point within the specified circle using polar coordinates.

### Example

```csharp
// Get a random point in a circle with center (0, 0) and radius 5
Vector2 center = new Vector2(0, 0);
float radius = 5f;
Vector2 randomPoint = center.GetRandomPointInCircle(radius);
// Result: randomPoint = (2.1, 3.8) (Note: This result may vary as it is random)
```

In this example, the `GetRandomPointInCircle` method is used to get a random point in a circle with center (0, 0) and radius 5.

## GetRandomPointInSphere (Vector3)

Generates a random 3D point within a spherical volume defined by a center and radius.

### Usage

```csharp
// Example: Get a random point in a sphere with center (0, 0, 0) and radius 10
Vector3 center = new Vector3(0, 0, 0);
float radius = 10f;
Vector3 randomPoint = center.GetRandomPointInSphere(radius);
```

### General Syntax

```csharp
Vector3 result = center.GetRandomPointInSphere(radius);
```

### Parameters

| Parameter | Data Type | Description                                               |
|-----------|-----------|-----------------------------------------------------------|
| center    | Vector3   | The center of the sphere in 3D space.                     |
| radius    | float     | The radius of the sphere, determining the distance from the center to the generated point. |

### Method Description

This extension method generates a random Vector3 point within the specified sphere using spherical coordinates.

### Example

```csharp
// Get a random point in a sphere with center (0, 0, 0) and radius 10
Vector3 center = new Vector3(0, 0, 0);
float radius = 10f;
Vector3 randomPoint = center.GetRandomPointInSphere(radius);
// Result: randomPoint = (-5.2, 3.6, 8.9) (Note: This result may vary as it is random)
```

In this example, the `GetRandomPointInSphere` method is used to get a random point in a sphere with center (0, 0, 0) and radius 10.
