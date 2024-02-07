# Physics2DExtension Class

## Index
- [Add2DExplosiveForce](#Add2DExplosiveForce)

## Add2DExplosiveForce

Applies a 2D explosive force originating from the specified point, affecting nearby Rigidbody2D objects within the given range and based on the provided parameters.

### Usage

```csharp
// Example: Apply a 2D explosive force at position (0, 0) with a range of 5 units and force amount of 10
Rigidbody2D body = GetComponent<Rigidbody2D>();
LayerMask explosionImpactLayer = LayerMask.GetMask("Default"); // Or specify the layers to be affected
List<Rigidbody2D> affectedBodies = body.Add2DExplosiveForce(range: 5f, forceAmt: 10f, explosionImpactLayer);
```

### General Syntax

```csharp
Rigidbody2D body = GetComponent<Rigidbody2D>();
List<Rigidbody2D> affectedBodies = body.Add2DExplosiveForce(range, forceAmt, explosionImpactLayer);
```

### Parameters

| Parameter              | Data Type   | Description                                              |
| ---------------------- | ----------- | -------------------------------------------------------- |
| body                   | Rigidbody2D | The Rigidbody2D object representing the point where the explosion originates. |
| range                  | float       | The range within which Rigidbody2D objects are affected by the explosion. |
| forceAmt               | float       | The magnitude of the explosive force applied to Rigidbody2D objects. |
| explosionImpactLayer   | LayerMask   | A LayerMask specifying which layers the explosion can impact. |
| **Return Value**       | List<Rigidbody2D> | A list of Rigidbody2D objects that were affected by the explosive force. |

### Method Description

This extension method applies a 2D explosive force originating from the specified Rigidbody2D object, affecting nearby Rigidbody2D objects within the given range and based on the provided parameters. It returns a list of Rigidbody2D objects that were affected by the explosive force.