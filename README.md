# Sacha Riku

**Unity 3D gameplay prototype built in C#**

Sacha Riku is a small Unity 3D exploration and collection prototype featuring player movement and trigger-based collectible interactions.

## Technical Details

* **Engine:** Unity 2022.3.47f1
* **Language:** C#
* **Project Type:** 3D exploration / collection prototype
* **Input:** Unity `Horizontal` and `Vertical` axes

## Features

### Player Movement

`PlayerController.cs` reads Unity's horizontal and vertical input axes and converts them into 3D movement on the X/Z plane.

```csharp
Vector3 moveDirection = new Vector3(moveX, 0, moveZ);
transform.Translate(moveDirection * Time.deltaTime * 5f);
```

### Collectible System

`Ingredient.cs` uses `OnTriggerEnter` to detect when the player enters a collectible's trigger.

The system:

* Detects the player through the `Player` tag.
* Removes the collected object from the scene.
* Uses the object's tag to determine its type.
* Adds the collected object to the corresponding player collection.

The project currently supports two collectible categories:

* **Planta**
* **Piedra**

The player maintains separate `List<GameObject>` collections for each category.

## Code Structure

| Script                | Responsibility                                   |
| --------------------- | ------------------------------------------------ |
| `PlayerController.cs` | Player movement and collected-item lists         |
| `Ingredient.cs`       | Collectible trigger detection and categorization |

## Project Structure

```text
Sacha-Riku-main/
├── Assets/
│   ├── Models/
│   │   └── bosque y laberinto..blend
│   ├── Prefabs/
│   │   ├── Planta.prefab
│   │   └── Piedra.prefab
│   ├── Scenes/
│   │   └── SampleScene.unity
│   └── Scripts/
│       ├── Ingredient.cs
│       └── PlayerController.cs
├── Packages/
├── ProjectSettings/
└── README.md
```

## Running the Project

1. Open the project in **Unity 2022.3.47f1**.
2. Open `Assets/Scenes/SampleScene.unity`.
3. Enter Play Mode.
4. Use the configured horizontal/vertical controls to move through the environment.
5. Enter the collectible trigger areas to collect plants and stones.

## What This Project Demonstrates

* Unity scene and prefab workflow
* C# MonoBehaviour scripting
* Input-driven 3D movement
* Trigger-based interaction
* Tag-based object categorization
* Basic collection/inventory data structures
* Blender asset integration

## Contact

**Adrian Abad**

* Portfolio: https://portfolio-ashen-one-23.vercel.app
* LinkedIn: https://www.linkedin.com/in/adrian-abad-80b4a4358/
* GitHub: https://github.com/AdrianNAT00

 
