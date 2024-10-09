# Birds-Flying-OOP-CSharp

## Description

This project demonstrates basic object-oriented programming (OOP) concepts in C#, focusing on inheritance and interfaces. The example models birds, with a specific example of a falcon that can fly. The code features:

*	An abstract Bird class.
*	A Falcon class that inherits from Bird and implements the IFly interface.
*	The ability for the falcon to ascend and descend in height.

This simple project is an excellent starting point for learning OOP principles such as inheritance, abstraction, and interface implementation in C#.

## Structure

The project contains the following files:

*	Bird.cs: Defines an abstract base class Bird with a protected property SpeciesName and an abstract method MakeNoise().
*	Falcon.cs: Implements the Falcon class, inheriting from Bird and implementing the IFly interface. The class provides methods for flying (ascending and descending) and overriding the MakeNoise() method.
*	IFly.cs: Declares the IFly interface with properties MaxHeightFlying, CurrentHeight, and methods FlyAscending() and FlyDescending().

## Classes Overview

Bird (Abstract Class)

The Bird class represents a general bird. It is an abstract class, meaning that it cannot be instantiated directly. The class contains:

*	SpeciesName: A protected string that stores the species name of the bird.
*	MakeNoise(): An abstract method that must be implemented by any derived class.

## Falcon (Class)

The Falcon class inherits from Bird and implements the IFly interface. It adds the following properties and methods:

*	MaxHeightFlying: Maximum flying height in meters.
*	CurrentHeight: Current height of the falcon.
*	FlyAscending(): Increases the current height by 10 meters unless the falcon is already at the maximum height.
*	FlyDescending(): Decreases the current height by 10 meters unless the falcon is already at ground level.
*	MakeNoise(): Overrides the abstract method from Bird to display the falcon’s species and current height.

## IFly (Interface)

The IFly interface ensures that classes implementing it will have the necessary flying properties and methods:

* MaxHeightFlying and CurrentHeight properties.
* FlyAscending() and FlyDescending() methods.

## How to Run

1.	Clone the repository:
```
git clone https://github.com/YourUsername/Birds-Flying-OOP-CSharp.git
```
2.	Open the project in your preferred C# IDE (e.g., Visual Studio or JetBrains Rider).
3.	Build and run the project to see the falcon’s behavior as it flies and makes noise.

## Example Output

```
I'm a Falcon, my current height is 0[m]
I'm a Falcon, my current height is 10[m]
I'm a Falcon, my current height is 20[m]
```
