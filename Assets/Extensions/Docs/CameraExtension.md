# CameraExtension Class

## Index
- [WorldToScreenPoint (Vector2)](#WorldToScreenPoint-Vector2)
- [WorldToScreenPoint (Vector3)](#WorldToScreenPoint-Vector3)
- [WorldToViewportPoint (Vector2)](#WorldToViewportPoint-Vector2)
- [WorldToViewportPoint (Vector3)](#WorldToViewportPoint-Vector3)
- [ScreenToWorldPoint (Vector3)](#ScreenToWorldPoint-Vector3)
- [ScreenToWorldPoint (Vector2)](#ScreenToWorldPoint-Vector2)
- [ScreenToViewportPoint (Vector3)](#ScreenToViewportPoint-Vector3)
- [ScreenToViewportPoint (Vector2)](#ScreenToViewportPoint-Vector2)
- [ScreenToRay (Vector3)](#ScreenToRay-Vector3)
- [ViewportToScreenPoint (Vector3)](#ViewportToScreenPoint-Vector3)
- [ViewportToScreenPoint (Vector2)](#ViewportToScreenPoint-Vector2)
- [ViewportToWorldPoint (Vector3)](#ViewportToWorldPoint-Vector3)
- [ViewportToWorldPoint (Vector2)](#ViewportToWorldPoint-Vector2)

## WorldToScreenPoint (Vector2)

Converts a 2D world point to a screen point based on the specified camera's perspective.

### Usage

```csharp
// Example: Convert a 2D world point to a screen point
Vector2 worldPoint = new Vector2(2.0f, 3.0f);
Camera mainCamera = Camera.main;
Vector2 screenPoint = worldPoint.WorldToScreenPoint(mainCamera);
```

### General Syntax

```csharp
Vector2 result = worldPoint.WorldToScreenPoint(cam);
```

### Parameters

| Parameter | Data Type | Description                                       |
|-----------|-----------|---------------------------------------------------|
| point     | Vector2   | The 2D world point to convert.                   |
| cam       | Camera    | The Camera used for the conversion.              |

### Method Description

This extension method converts a 2D world point to a screen point in pixels based on the specified camera's perspective.

## WorldToScreenPoint (Vector3)

Converts a 3D world point to a screen point based on the specified camera's perspective.

### Usage

```csharp
// Example: Convert a 3D world point to a screen point
Vector3 worldPoint = new Vector3(2.0f, 3.0f, 5.0f);
Camera mainCamera = Camera.main;
Vector3 screenPoint = worldPoint.WorldToScreenPoint(mainCamera);
```

### General Syntax

```csharp
Vector3 result = worldPoint.WorldToScreenPoint(cam);
```

### Parameters

| Parameter | Data Type | Description                                       |
|-----------|-----------|---------------------------------------------------|
| point     | Vector3   | The 3D world point to convert.                   |
| cam       | Camera    | The Camera used for the conversion.              |

### Method Description

This extension method converts a 3D world point to a screen point in pixels based on the specified camera's perspective.

## WorldToViewportPoint (Vector2)

Converts a 2D world point to a viewport point based on the specified camera's perspective.

### Usage

```csharp
// Example: Convert a 2D world point to a viewport point
Vector2 worldPoint = new Vector2(2.0f, 3.0f);
Camera mainCamera = Camera.main;
Vector2 viewportPoint = worldPoint.WorldToViewportPoint(mainCamera);
```

### General Syntax

```csharp
Vector2 result = worldPoint.WorldToViewportPoint(cam);
```

### Parameters

| Parameter | Data Type | Description                                       |
|-----------|-----------|---------------------------------------------------|
| point     | Vector2   | The 2D world point to convert.                   |
| cam       | Camera    | The Camera used for the conversion.              |

### Method Description

This extension method converts a 2D world point to a viewport point in normalized coordinates based on the specified camera's perspective.

## WorldToViewportPoint (Vector3)

Converts a 3D world point to a viewport point based on the specified camera's perspective.

### Usage

```csharp
// Example: Convert a 3D world point to a viewport point
Vector3 worldPoint = new Vector3(2.0f, 3.0f, 5.0f);
Camera mainCamera = Camera.main;
Vector3 viewportPoint = worldPoint.WorldToViewportPoint(mainCamera);
```

### General Syntax

```csharp
Vector3 result = worldPoint.WorldToViewportPoint(cam);
```

### Parameters

| Parameter | Data Type | Description                                       |
|-----------|-----------|---------------------------------------------------|
| point     | Vector3   | The 3D world point to convert.                   |
| cam       | Camera    | The Camera used for the conversion.              |

### Method Description

This extension method converts a 3D world point to a viewport point in normalized coordinates based on the specified camera's perspective.

## ScreenToWorldPoint (Vector3)

Converts a 3D screen point to a world point in the 3D scene based on the specified camera's perspective.

### Usage

```csharp
// Example: Convert a 3D screen point to a world point
Vector3 screenPoint = new Vector3(100.0f, 200.0f, 0.5f);
Camera mainCamera = Camera.main;
Vector3 worldPoint = screenPoint.ScreenToWorldPoint(mainCamera);
```

### General Syntax

```csharp
Vector3 result = screenPoint.ScreenToWorldPoint(cam);
```

### Parameters

| Parameter | Data Type | Description                                       |
|-----------|-----------|---------------------------------------------------|
| point     | Vector3   | The 3D screen point to convert.                   |
| cam       | Camera    | The Camera used for the conversion.              |

### Method Description

This extension method converts a 3D screen point in pixels to a world point in 3D space based on the specified camera's perspective.

## ScreenToWorldPoint (Vector2)

Converts a 2D screen point to a world point in the 2D scene based on the specified camera's perspective.

### Usage

```csharp
// Example: Convert a 2D screen point to a world point
Vector2 screenPoint = new Vector2(100.0f, 200.0f);
Camera mainCamera = Camera.main;
Vector2 worldPoint = screenPoint.ScreenToWorldPoint(mainCamera);
```

### General Syntax

```csharp
Vector2 result = screenPoint.ScreenToWorldPoint(cam);
```

### Parameters

| Parameter | Data Type | Description                                       |
|-----------|-----------|---------------------------------------------------|
| point     | Vector2   | The 2D screen point to convert.                   |
| cam       | Camera    | The Camera used for the conversion.              |

### Method Description

This extension method converts a 2D screen point in pixels to a world point in 2D space based on the specified camera's perspective.

## ScreenToViewportPoint (Vector3)

Converts a 3D screen point to a viewport point in normalized coordinates based on the specified camera's perspective.

### Usage

```csharp
// Example: Convert a 3D screen point to a viewport point
Vector3 screenPoint = new Vector3(100.0f, 200.0f, 0.5f);
Camera mainCamera = Camera.main;
Vector3 viewportPoint = screenPoint.ScreenToViewportPoint(mainCamera);
```

### General Syntax

```csharp
Vector3 result = screenPoint.ScreenToViewportPoint(cam);
```

### Parameters

| Parameter | Data Type | Description                                       |
|-----------|-----------|---------------------------------------------------|
| point     | Vector3   | The 3D screen point to convert.                   |
| cam       | Camera    | The Camera used for the conversion.              |

### Method Description

This extension method converts a 3D screen point in pixels to a viewport point in normalized coordinates based on the specified camera's perspective.

## ScreenToViewportPoint (Vector2)

Converts a 2D screen point to a viewport point in normalized coordinates based on the specified camera's perspective.

### Usage

```csharp
// Example: Convert a 2D screen point to a viewport point
Vector2 screenPoint = new Vector2(100.0f, 200.0f);
Camera mainCamera = Camera.main;
Vector2 viewportPoint = screenPoint.Screen

ToViewportPoint(mainCamera);
```

### General Syntax

```csharp
Vector2 result = screenPoint.ScreenToViewportPoint(cam);
```

### Parameters

| Parameter | Data Type | Description                                       |
|-----------|-----------|---------------------------------------------------|
| point     | Vector2   | The 2D screen point to convert.                   |
| cam       | Camera    | The Camera used for the conversion.              |

### Method Description

This extension method converts a 2D screen point in pixels to a viewport point in normalized coordinates based on the specified camera's perspective.

## ScreenToRay (Vector3)

Creates a Ray originating from the specified screen point based on the specified camera's perspective.

### Usage

```csharp
// Example: Create a Ray from a 3D screen point
Vector3 screenPoint = new Vector3(100.0f, 200.0f, 0.5f);
Camera mainCamera = Camera.main;
Ray ray = screenPoint.ScreenToRay(mainCamera);
```

### General Syntax

```csharp
Ray result = screenPoint.ScreenToRay(cam);
```

### Parameters

| Parameter | Data Type | Description                                       |
|-----------|-----------|---------------------------------------------------|
| point     | Vector3   | The 3D screen point to create the Ray from.       |
| cam       | Camera    | The Camera used for the Ray creation.             |

### Method Description

This extension method creates a Ray originating from a 3D screen point in pixels based on the specified camera's perspective.

## ViewportToScreenPoint (Vector3)

Converts a 3D viewport point in normalized coordinates to a screen point in pixels based on the specified camera's perspective.

### Usage

```csharp
// Example: Convert a 3D viewport point to a screen point
Vector3 viewportPoint = new Vector3(0.5f, 0.8f, 0.5f);
Camera mainCamera = Camera.main;
Vector3 screenPoint = viewportPoint.ViewportToScreenPoint(mainCamera);
```

### General Syntax

```csharp
Vector3 result = viewportPoint.ViewportToScreenPoint(cam);
```

### Parameters

| Parameter | Data Type | Description                                       |
|-----------|-----------|---------------------------------------------------|
| point     | Vector3   | The 3D viewport point to convert.                |
| cam       | Camera    | The Camera used for the conversion.              |

### Method Description

This extension method converts a 3D viewport point in normalized coordinates to a screen point in pixels based on the specified camera's perspective.

## ViewportToScreenPoint (Vector2)

Converts a 2D viewport point in normalized coordinates to a screen point in pixels based on the specified camera's perspective.

### Usage

```csharp
// Example: Convert a 2D viewport point to a screen point
Vector2 viewportPoint = new Vector2(0.5f, 0.8f);
Camera mainCamera = Camera.main;
Vector2 screenPoint = viewportPoint.ViewportToScreenPoint(mainCamera);
```

### General Syntax

```csharp
Vector2 result = viewportPoint.ViewportToScreenPoint(cam);
```

### Parameters

| Parameter | Data Type | Description                                       |
|-----------|-----------|---------------------------------------------------|
| point     | Vector2   | The 2D viewport point to convert.                |
| cam       | Camera    | The Camera used for the conversion.              |

### Method Description

This extension method converts a 2D viewport point in normalized coordinates to a screen point in pixels based on the specified camera's perspective.

## ViewportToWorldPoint (Vector3)

Converts a 3D viewport point in normalized coordinates to a world point in the 3D scene based on the specified camera's perspective.

### Usage

```csharp
// Example: Convert a 3D viewport point to a world point
Vector3 viewportPoint = new Vector3(0.5f, 0.8f, 0.5f);
Camera mainCamera = Camera.main;
Vector3 worldPoint = viewportPoint.ViewportToWorldPoint(mainCamera);
```

### General Syntax

```csharp
Vector3 result = viewportPoint.ViewportToWorldPoint(cam);
```

### Parameters

| Parameter | Data Type | Description                                       |
|-----------|-----------|---------------------------------------------------|
| point     | Vector3   | The 3D viewport point to convert.                |
| cam       | Camera    | The Camera used for the conversion.              |

### Method Description

This extension method converts a 3D viewport point in normalized coordinates to a world point in 3D space based on the specified camera's perspective.

## ViewportToWorldPoint (Vector2)

Converts a 2D viewport point in normalized coordinates to a world point in the 2D scene based on the specified camera's perspective.

### Usage

```csharp
// Example: Convert a 2D viewport point to a world point
Vector2 viewportPoint = new Vector2(0.5f, 0.8f);
Camera mainCamera = Camera.main;
Vector2 worldPoint = viewportPoint.ViewportToWorldPoint(mainCamera);
```

### General Syntax

```csharp
Vector2 result = viewportPoint.ViewportToWorldPoint(cam);
```

### Parameters

| Parameter | Data Type | Description                                       |
|-----------|-----------|---------------------------------------------------|
| point     | Vector2   | The 2D viewport point to convert.                |
| cam       | Camera    | The Camera used for the conversion.              |

### Method Description

This extension method converts a 2D viewport point in normalized coordinates to a world point in 2D space based on the specified camera's perspective.

## ViewportToRay (Vector3)

Creates a Ray originating from the specified viewport point in normalized coordinates based on the specified camera's perspective.

### Usage

```csharp
// Example: Create a Ray from a 3D viewport point
Vector3 viewportPoint = new Vector3(0.5f, 0.8f, 0.5f);
Camera mainCamera = Camera.main;
Ray ray = viewportPoint.ViewportToRay(mainCamera);
```

### General Syntax

```csharp
Ray result = viewportPoint.ViewportToRay(cam);
```

### Parameters

| Parameter | Data Type | Description                                       |
|-----------|-----------|---------------------------------------------------|
| point     | Vector3   | The 3D viewport point to create the Ray from.    |
| cam       | Camera    | The Camera used for the Ray creation.             |

### Method Description

This extension method creates a Ray originating from a 3D viewport point in normalized coordinates based on the specified camera's perspective.
