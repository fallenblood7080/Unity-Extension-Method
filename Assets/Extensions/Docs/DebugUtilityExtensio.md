# DebugUtilityExtension Class
## Index
- [Log(string)](#Log-string)
- [Log (array)](#Log-T[])
- [Log (List)](#Log-List<T>)
- [DrawPolygon](#DrawPolygon)
- [VisualizeRay2D](#VisualizeRay2D)
- [VisualizeRay](#VisualizeRay)
- [DrawLineTo](#DrawLineTo)
- [DrawLineFromPoints](#DrawLineFromPoints)
- [DrawLineFromPoints (List)](#DrawLineFromPoints-List)
- [DrawSphere](#DrawSphere)

## Log (string)

Writes a log message to the Unity console with the specified color and font size.

### Usage

```csharp
// Example: Log a message with default settings
"Hello, Unity!".Log();

// Example: Log a message with red color and font size 18
"Error!".Log(logColorCode: "ff0000", fontSize: 18);
```

### General Syntax

```csharp
string message = "Hello, Unity!";
message.Log(logColorCode, fontSize);
```

### Parameters

| Parameter      | Data Type | Description                                              |
| -------------- | --------- | -------------------------------------------------------- |
| message        | string    | The message to be written in the Unity Console.          |
| logColorCode   | string    | Hex code of the color (default is white - "ffffff").     |
| fontSize       | int       | Font size of the message (default is 12).                |

### Method Description

This extension method logs a message to the Unity console with optional color and font size.

## Log (T[])

Writes the elements of an array to the Unity console with the specified color and font size.

### Usage

```csharp
// Example: Log an array of integers with default settings
int[] numbers = { 1, 2, 3, 4, 5 };
numbers.Log();

// Example: Log an array of strings with red color and font size 18
string[] words = { "apple", "banana", "cherry" };
words.Log(logColorCode: "ff0000", fontSize: 18);
```

### General Syntax

```csharp
T[] array = { ... };
array.Log(logColorCode, fontSize);
```

### Parameters

| Parameter      | Data Type | Description                                              |
| -------------- | --------- | -------------------------------------------------------- |
| array          | T[]       | The array whose elements will be logged.                |
| logColorCode   | string    | Hex code of the color (default is white - "ffffff").     |
| fontSize       | int       | Font size of the message (default is 12).                |

### Method Description

This extension method logs the elements of an array to the Unity console with optional color and font size.

## Log (List<T>)

Writes the elements of a List to the Unity console with the specified color and font size.

### Usage

```csharp
// Example: Log a List of floats with default settings
List<float> values = new List<float> { 1.0f, 2.5f, 3.7f };
values.Log();

// Example: Log a List of strings with red color and font size 18
List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
names.Log(logColorCode: "ff0000", fontSize: 18);
```

### General Syntax

```csharp
List<T> list = new List<T> { ... };
list.Log(logColorCode, fontSize);
```

### Parameters

| Parameter      | Data Type | Description                                              |
| -------------- | --------- | -------------------------------------------------------- |
| list           | List<T>   | The List whose elements will be logged.                 |
| logColorCode   | string    | Hex code of the color (default is white - "ffffff").     |
| fontSize       | int       | Font size of the message (default is 12).                |

### Method Description

This extension method logs the elements of a List to the Unity console with optional color and font size.

## DrawPolygon

Draws the outline of a polygon in the Unity Scene view.

### Usage

```csharp
// Example: Draw a hexagon with a radius of 5 units
Vector3 center = new Vector3(0, 0, 0);
center.DrawPolygon(radius: 5, orientation: Quaternion.identity, color: Color.white, vertices: 6);
```

### General Syntax

```csharp
Vector3 center = new Vector3(x, y, z);
center.DrawPolygon(radius, orientation, color, vertices, dur);
```

### Parameters

| Parameter      | Data Type  | Description                                              |
| -------------- | ---------- | -------------------------------------------------------- |
| center         | Vector3    | Center of the polygon in 3D space.                       |
| radius         | float      | Radius of the polygon, representing the distance from the center to a vertex. |
| orientation    | Quaternion | Orientation of the 2D shape in the world.                |
| color          | Color      | Color of the outline.                                    |
| vertices       | int        | Number of vertices to determine the shape's sides (e.g., 3 for a triangle, 4 for a square). |
| dur            | float      | Duration for which the polygon should appear in seconds. |

### Method Description

This extension method draws the outline of a polygon in the Unity Scene view.

## VisualizeRay2D

Visualizes a 2D ray by drawing a line from the specified origin to the point where it hits an object.

### Usage

```csharp


// Example: Visualize a 2D ray hit with red color
RaycastHit2D rayHit = Physics2D.Raycast(origin, direction);
rayHit.VisualizeRay2D(origin, color: Color.red);
```

### General Syntax

```csharp
RaycastHit2D rayHit = Physics2D.Raycast(origin, direction);
rayHit.VisualizeRay2D(origin, color, dur);
```

### Parameters

| Parameter      | Data Type  | Description                                              |
| -------------- | ---------- | -------------------------------------------------------- |
| rayHit         | RaycastHit2D | The RaycastHit2D result representing the intersection of the ray with an object. |
| origin         | Vector2    | The starting point of the ray in 2D space.               |
| color          | Color      | Color of the visualization line.                         |
| dur            | float      | Duration for which the visualization line should appear in seconds. |

### Method Description

This extension method visualizes a 2D ray hit by drawing a line in the Unity Scene view.

## VisualizeRay

Visualizes a 3D ray by drawing a line from the specified origin to the point where it hits an object.

### Usage

```csharp
// Example: Visualize a 3D ray hit with green color
RaycastHit rayHit = Physics.Raycast(origin, direction);
rayHit.VisualizeRay(origin, color: Color.green);
```

### General Syntax

```csharp
RaycastHit rayHit = Physics.Raycast(origin, direction);
rayHit.VisualizeRay(origin, color, dur);
```

### Parameters

| Parameter      | Data Type  | Description                                              |
| -------------- | ---------- | -------------------------------------------------------- |
| rayHit         | RaycastHit | The RaycastHit result representing the intersection of the ray with an object. |
| origin         | Vector3    | The starting point of the ray in 3D space.               |
| color          | Color      | Color of the visualization line.                         |
| dur            | float      | Duration for which the visualization line should appear in seconds. |

### Method Description

This extension method visualizes a 3D ray hit by drawing a line in the Unity Scene view.

## DrawLineTo

Draws a straight line from the specified origin point to the end point with the given color.

### Usage

```csharp
// Example: Draw a line from (0,0,0) to (1,1,1) with blue color
Vector3 origin = new Vector3(0, 0, 0);
Vector3 end = new Vector3(1, 1, 1);
origin.DrawLineTo(end, color: Color.blue);
```

### General Syntax

```csharp
Vector3 origin = new Vector3(x1, y1, z1);
Vector3 end = new Vector3(x2, y2, z2);
origin.DrawLineTo(end, color, dur);
```

### Parameters

| Parameter      | Data Type  | Description                                              |
| -------------- | ---------- | -------------------------------------------------------- |
| origin         | Vector3    | The starting point of the line in 3D space.              |
| end            | Vector3    | The ending point of the line in 3D space.                |
| color          | Color      | Color of the drawn line.                                 |
| dur            | float      | Duration for which the line should be visible in seconds.|

### Method Description

This extension method draws a straight line in the Unity Scene view.

## DrawLineFromPoints

Draws a series of lines connecting the points in the provided array, creating a continuous path.

### Usage

```csharp
// Example: Draw a path from an array of points with yellow color
Vector3[] points = { new Vector3(0, 0, 0), new Vector3(1, 1, 1), new Vector3(2, 0, 0) };
points.DrawLineFromPoints(color: Color.yellow);
```

### General Syntax

```csharp
Vector3[] points = { ... };
points.DrawLineFromPoints(color, dur);
```

### Parameters

| Parameter      | Data Type  | Description                                              |
| -------------- | ---------- | -------------------------------------------------------- |
| points         | Vector3[]  | An array of Vector3 points representing the path to be drawn. |
| color          | Color      | Color of the drawn lines.                                |
| dur            | float      | Duration for which the lines should be visible in seconds. |

### Method Description

This extension method draws a series of lines connecting points in the Unity Scene view.

## DrawLineFromPoints (List)

Draws a series of lines connecting the points in the provided List, creating a continuous path.

### Usage

```csharp
// Example: Draw a path from a List of points with magenta color
List<Vector3> pointsList = new List<Vector3> { new Vector3(0, 0, 0), new Vector3(1, 1, 1), new Vector3(2, 0, 0) };
pointsList.DrawLineFromPoints(color: Color.magenta);
```

### General Syntax

```csharp
List<Vector3> pointsList = new List<Vector3> { ... };
pointsList.DrawLineFromPoints(color, dur);
```

### Parameters

| Parameter      | Data Type  | Description                                              |
| -------------- | ---------- | -------------------------------------------------------- |
| pointsList     | List<Vector3> | A List of Vector3 points representing the path to be drawn. |
| color          | Color      | Color of the drawn lines.                                |
| dur            | float      | Duration for which the lines should be visible in seconds. |

### Method Description

This extension method draws a series of lines connecting points in the Unity Scene view.

## DrawSphere

Draws a 3D sphere with the specified center, radius, orientation, color, and level of detail (segments).

### Usage

```csharp
// Example: Draw a sphere at the origin with a radius of 2 units and red color
Vector3 center = new Vector3(0, 0, 0);
center.DrawSphere(radius: 2, orientation: Quaternion.identity, color: Color.red);
```

### General Syntax

```csharp
Vector3 center = new Vector3(x, y, z);
center.DrawSphere(radius, orientation, color, segments, dur);
```

### Parameters

| Parameter      | Data Type  | Description                                              |
| -------------- | ---------- | -------------------------------------------------------- |
| center         | Vector3    | The center of the sphere in 3D space.                   |
| radius         | float      | The radius of the sphere, determining its size.          |
| orientation    | Quaternion | The orientation of the sphere as a Quaternion.           |
| color          | Color      | The color of the sphere's outline.                       |
| segments       | int        | The number of segments used to approximate the sphere's surface (for smoother rendering). |
| dur            | float      | The duration for which the sphere should appear in seconds.|

### Method Description

This extension method draws a 3D sphere in the Unity Scene view.
