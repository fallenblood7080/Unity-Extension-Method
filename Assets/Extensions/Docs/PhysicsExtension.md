# PhysicsExtension Class

## Index
-[IncludesLayer](#IncludesLayer)

## IncludesLayer

Checks if a LayerMask includes a specific layer.

### Usage

```csharp
// Example: Check if a LayerMask includes the layer with index 5
LayerMask mask = LayerMask.GetMask("LayerName"); // Or specify the layers to be included
int layerIndex = 5;
bool includesLayer = mask.IncludesLayer(layerIndex);
```

### General Syntax

```csharp
bool includesLayer = mask.IncludesLayer(layer);
```

### Parameters

| Parameter  | Data Type | Description                              |
| ---------- | --------- | ---------------------------------------- |
| mask       | LayerMask | The LayerMask to check for layer inclusion. |
| layer      | int       | The layer index to check for inclusion.  |
| **Return Value** | bool | True if the LayerMask includes the specified layer; otherwise, false. |

### Method Description

This extension method checks if a LayerMask includes a specific layer. It takes a LayerMask and a layer index as input parameters and returns true if the LayerMask includes the specified layer; otherwise, it returns false.