## Program Structure

- **Programs** consist of one or more source files which declare **types** that contain **members** that are organized into **namespaces**.

  - Types - Classes and interfaces.
  - Memebers - Fields, methods, properties, and events.
  - Assemblies - Compiled files that are packages as either an `.exe` (application) or `.dll` (library).

- Assemblies contain executable code in the form of Intermediate Language (IL) instructions. Before it is executed, the IL code in an assembly (`.exe` or `.dll`) is automatically converted to code by the Just-In-Time (JIT) compiler.

- A namespace is a code block which contains other (nested) namespaces, types, and members.

## Types and Variables

### Value types

- Simple types:
  - Signed/ Unsigned Intergral
  - Unicode characters
  - Boolean
  - Floating point
  - Decimal
- Enums - a type that consists of a set of named constants.

```C#
enum Day {Sat, Sun, Mon, Tue, Wed, Thu, Fri};
```

- Structs - is typically used to encapsulate small groups of related variables, such as the coordinates of a rectangle or the characteristics of an item in an inventory.

```C#
public struct Book
{
  public decimal price;
  public string title;
  public string author;
}
```

- Nullable values

### Reference types

- Classes
  - Objects
  - String
  - Class - defines a data structure that contains data members (fields) and function members (methods, properties, and others). Class types support single inheritance and polymorphism, mechanisms whereby derived classes can extend and specialize base classes.
- Interfaces - defines a contract as a named set of public function members. A class or struct that implements an interface must provide implementations of the interface’s function members. An interface may inherit from multiple base interfaces, and a class or struct may implement multiple interfaces.
- Arrays
- Delegates - represents references to methods with a particular parameter list and return type.
  - Delegates make it possible to treat methods as entities that can be assigned to variables and passed as parameters. Delegates are analogous to function types provided by functional languages. They are also similar to the concept of function pointers found in some other languages, but unlike function pointers, delegates are object-oriented and type-safe.
