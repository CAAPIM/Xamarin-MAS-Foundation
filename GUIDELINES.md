# CA Technologies C# Style Guide

This document describes the C# coding style of Mobile SDK for Xamarin team. This guideline is recommended to comply with all C# implementations of our products.

## Review Microsoft Official Coding Guideline

Beyond the guidelines defined in this document, we also recommend reviewing the [Microsoft C# Guide](https://docs.microsoft.com/en-us/dotnet/csharp/index). 

### Mobile SDK

For more information, see [developer website](http://mas.ca.com).

The Mobile SDK for Xamarin consists of multiple functional products separated into individual frameworks.

All of frameworks are recommended to comply with the coding guideline.

## Table of Contents

* [Documentation](#documentation)
* [Brace Style](#brace-style)
* [New Line](#new-line)
* [Wrapping Lines](#wrapping-lines)
  * [Long Argument Lists](#long-argument-lists) 
  * [Strings](#strings)
* [Lambdas](#lambdas)
* [Spacing](#spacing)
  * [Vertical Spacing](#vertical-spacing)
  * [Blocks](#blocks)
  * [Properties](#properties)
  * [Other Cases](#other-cases)
* [Enums](#enums)
* [#region directive](#region-directive)
* [using directive](#using-directive)
* [Nomenclature](#nomenclature)
* [Comments](#comments)
  * [In-line comment](#in-line-comment)
  * [Multiline comment](#multiline-comment)
* [File Structure](#file-structure)
* [Copyright Statement](#copyright-statements)
* [Error Handling](#error-handling)


## Documentation

All code **should be properly documented** in `.cs` files. Code documentation should adhere to Microsoft Doc's format.

Microsoft provides a documentation generation system based on XML comments. These comments are formally single line C♯ comments (indicated by triple slashes) containing XML tags. All comments must be placed directly before the code block to which the comments refer, for example:

```c#
/// <summary>  
///  This is the class definition of CustomClass.  
/// </summary>  
public class CustomClass{} 
```
A list of recommended tags for documentation comments can be found in [Microsoft C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/recommended-tags-for-documentation-comments).

Visual Studio produces compiler-generated XML documents by taking the XML comments from the code and building them into an XML file. This XML file can then be used to generate human-readable documentation in a variety of forms including HTML, MSDN style documentation and IntelliSense within the code window.

Our team uses [Monodoc](http://http://www.mono-project.com/docs/tools+libraries/tools/monodoc/) as a tool to build HTML and IntelliSense documentation based on the compiler-generated XML files.

Recommended elements to document:

* Class description
* Property
* Enum type
* Constant
* Method


## Brace Style

All braces get their own line (a C# convention):

**For example:**

```c#
class CustomClass
{
    void DoSomething()
    {
        if (someTest)
        {
            // ...
        }
        else
        {
            // ...
        }
    }
    
    void DoSomethingElse(int n)
    {
    	for (int i = 0; i < n; ++i) 
    	{
		    // ...
		}
    }
}
```

**Not:**

```c#
class CustomClass {
    void DoSomething() {
        if (someTest) {
          // ...
        } else {
          // ...
        }
    }
    void DoSomethingElse(int n)
    {
    	for (int i = 0; i < n; ++i) {
		    // ...
		}
    }
}
```


## New Line

Blank lines improve readability. They set off blocks of code which are logically related.

Two lines should always be used between:

* Logical sections of a source file
* Class and interface definitions

One line should always be used between:

*  Methods
*  Properties
*  Local variables in a method and its first statement
*  Logical sections inside a method to improve readability

Indent blank lines to make it easier to insert a statement.

## Wrapping Lines

When an expression will not fit on a single line, break it up according to these general principles:

* Break after a comma
* Break after an operator
* Prefer higher-level breaks to lower-level breaks
* Indentation for line wraps should use 4 spaces

### Long Argument Lists

When your argument list grows too long, split your method invocation across multiple lines. With the first argument on a new line after the opening parenthesis of the method invocation, and the closing parenthesis of the invocation on its own line at the same indentation level as the line with the opening parenthesis.

**For example:**

```c#
Console.WriteLine(
    "Values of someObject: {0}, {1} and of anotherObject: {2} {3}",
    someObject.FirstProperty,
    someObject.SecondProperty,
    anotherObject.FirstPart,
    anotherObject.SecondPart
);
```

**Not:**

```c#
Console.WriteLine("Values of someObject: {0}, {1} and of anotherObject: {2} {3}", someObject.FirstProperty, someObject.SecondProperty, anotherObject.FirstPart, anotherObject.SecondPart);
```

### Strings

Use the `+` operator and break the string up into human-readable lines. The compiler will pick up that the strings are constant and concatenate them at compile time.

**For example:**

```c#
const string myVeryLongString = 
    "This is the opening paragraph of my long string. " +
    "Which is split over multiple lines to improve code readability.";
```

**Not:**

```c#
const string myVeryLongString = "This is the opening paragraph of my long string. Which is split over multiple lines to improve code readability.";
```

## Lambdas

In C#, a lambda expression is an anonymous function that allow you to write local functions that can be passed as arguments or returned as the value of function calls.

If your lambda takes a single argument, omit the parentheses around the argument list:

**For example:**

```c#
var admins = Users.Select (user => user.IsAdministrator);
```

**Not:**

```c#
var admins = Users.Select ((user) => user.IsAdministrator);
```

Whenever possible, omit types from lambda argument lists, and use simple names:

**For example:**

```c#
list.OnScroll += (sender, e) => {
	// ...
};
```

**Not:**

```c#
list.OnScroll += (object sender, EventArgs e) => {
	// ...
};
```

When the body of the lambda is a block, put the opening brace on the same line as the =>, indent the body of the block, and close the block at the same level of indentation as the line containing the opening brace:

**For example:**

```c#
people.ForEach (person => {
	person.BrushTeeth ();
	person.CallMom ();
	person.RegisterToVote ();
});

button1.Click += async (sender, e) => {  
    await ExampleMethodAsync();   
};
```

**Not:**

```c#
people.ForEach (person => {
	person.BrushTeeth ();
	person.CallMom ();
	person.RegisterToVote ();
	}
);

button1.Click += async (sender, e) => {  
    await ExampleMethodAsync();   
};
```

## Spacing

Spacing is especially important in the code, as code needs to be easily readable by contributors.

* Use consistent spacing format across all places in the code
* Indentation should be done using spaces — never tabs

### Vertical Spacing

There should be exactly one blank line between methods to aid in visual clarity and organization. Whitespace within methods should separate functionality, but having too many sections in a method often means you should refactor into several methods.


### Blocks

Indent blocks with 4 spaces for optimal readability.

**For example:**

```c#
for (int i = 0; i < 10; i++) 
{
    Debug.Log("index=" + i);
}
```

**Not:**

```c#
for (int i = 0; i < 10; i++) 
{
  Debug.Log("index=" + i);
}
```

### Properties

Declare automatic properties on a single line with a single spaces before and after `{`, and the space before `}`.

**For example:**

```c#
string SomeProperty { get; set; }
```

**Not:**

```c#
string SomeProperty{get;set;}
```

Complex properties go like this:

**For example:**

```c#
string SomeProperty 
{
    get 
    {
        return someProperty;
    }
    set 
    {
        someProperty = value;
    }
}
```

**Not:**

```c#
string SomeProperty {
  get {
    return someProperty;
  }
  set {
    someProperty = value;
  }
}
```


### Other cases


Do not put a space before the left angle bracket in a generic type:

**For example:**

```c#
var someList = new List<int>();
```

**Not:**

```c#
var someList = new List <int>();
```

Do not put spaces inside parentheses, square brackets, or angle brackets:

**For example:**

```c#
Initialize(someObject);	
object[i];
new List<int>();
```

**Not:**

```c#
Initialize( someObject );	
object[ i ];
new List< int >();
```

Do use space to separate type parameters to generic types:

**For example:**

```c#
var someDictionary = new Dictionary<ObjectId, Object>();
```

**Not:**

```c#
var someDictionary = new Dictionary<ObjectId,Object>();
```

Do use single spaces in expressions liberally:

**For example:**

```c#
if (a + b > someMethod())
{
    // ...
}
```

**Not:**

```c#
if (a+b>someMethod())
{
    // ...
}
```

## Enums

* Use singular names for enums.
* Do not explicitly specify a type of an enum or values of enums.

**For example:**

```c#
public enum Direction
{
    North,
    East,
    South,
    West
}
```

**Not:**

```c#
public enum Direction : long
{
    North = 1,
    East = 2,
    South = 3,
    West = 4
}
```

## *#region* directive

`#region` is a preprocessor directive that lets you specify a block of code that you can expand or collapse when using the outlining feature of the Visual Studio Code Editor. It makes the code easier to organize and navigate by other developers.

### Syntax of *#region*

Follow the Microsoft [standard format](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-region) of region directive.

**For example:**

```c#
#region Lifecycle methods 

	public async void SomeMethodAsync()
	{
	    
	}
     
	public async void AnotherMethodAsync()
	{
	    
	}
	         
#endregion 
```

### Organization of *#region*

- Order of the `#region` should be identical in both interface and class files.
- **All of the methods** under `#region` should be in **alphabetical order**.

## *using* directive

* `using` directives may or may not be in alphabetical order
* Always group using directives by common prefix, with shorter namespaces coming before longer ones
* Prefered, namespaces should be ordered in increasing order of platform specificity, with .NET namespaces first, followed by library or component namespaces, then Xamarin namespaces, finally application namespaces

**For example:**

```c#
using System;
using System.Xml;
using System.Collections.Generic;

using SomeLib;
using SomeLib.Extensions;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MyApp;
```

**Not:**

```c#
using MyApp;
using SomeLib.Extensions;
using MonoTouch.Foundation;
using System.Collections.Generic;
using System;
using System.Xml;
using MonoTouch.UIKit;
using SomeLib;
```

## Nomenclature

For naming, you should follow [Microsoft Naming Guidelines](http://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines).

### Special cases

Beyond the Microsoft naming conventions for general code development, there are special rules you should follow to ensure consistency and usability of the framework.

#### Class

* All classes should start with the prefix, `MAS`, except for classes from other vendors.
* Prefix interface names with the letter `I`, to indicate that the type is an interface.
* Exactly one class per source file, although inner classes are encouraged where scoping appropriate.

#### Namespace

Namespaces are all PascalCase, multiple words concatenated together, without hypens ( - ) or underscores ( _ ). We use the name of the framework as Namespace:

```c#
namespace MASFoundation
{

}
```

#### Constants

Write constants in `PascalCase`, not `UPPERCASE`.

**For example:**

```c#
public static const string VersionNumber = "1.1";
```

**Not:**

```c#
public static const string VERSION_NUMBER = "1.1";
```

## Comments

### In-line Comment

Comments begin with `//` followed by a single space, use sentence casing, and exhibit proper spelling and grammar. Use leading and trailing empty in-line comment.

**For example:**

```c#
//
// Place an in-line comment like this
//
```

**Not:**

```c#
//Don't do in-line comment like this
```

#### Multi-line comments

Long comments tend to grow from smaller ones, so it's simpler to always use `//` than to switch to `/* ... */` when a comment becomes "long".

**For example:**

```c#
//
// Programming style is a set of rules or guidelines used when writing the source code for a 
// computer program. It is often claimed that following a particular programming style will
// help programmers read and understand source code conforming to the style, and help to
// avoid introducing errors.
//
// A classic work on the subject was The Elements of Programming Style, written in the 
// 1970s, and illustrated with examples from the Fortran and PL/I languages prevalent at
// the time.
//
```

**Not:**

```c#
/*
 * Programming style is a set of rules or guidelines used when writing the source code for a 
 * computer program. It is often claimed that following a particular programming style will
 * help programmers read and understand source code conforming to the style, and help to
 * avoid introducing errors.
 *
 * A classic work on the subject was The Elements of Programming Style, written in the 
 * 1970s, and illustrated with examples from the Fortran and PL/I languages prevalent at
 * the time.
 */
```

## File Structure

Because we are maintaining multiple frameworks, ensure that all frameworks use the same style, format, and file structure.

```c#
File Header

Using Directives

Namespace Declaration

    Type Declaration

        Constants
        Static Fields
        Static Auto-Properties
        Static Delegates
        Static Events
        Static Enums
        Static Constructors
        Static Complex Properties
        Static Methods
        Static Structs
        Static Interfaces
        Static Classes
        Fields
        Auto-Properties
        Delegates
        Events
        Enums
        Constructors
        Finalizers (Destructors)
        Complex Properties
        Methods
        Structs
        Interfaces
        Classes
```


## Copyright Statement

The following copyright statement should be included at the top of every source file:

```c#
//
//  Copyright (c) 2018 CA. All rights reserved.
//
//  This software may be modified and distributed under the terms
//  of the MIT license. See the LICENSE file for details.
//
```

## Error Handling

All frameworks handle errors with proper framework error domains.

In Constants, or any framework constant class, properly define the error domain constants.  The error domain format should be **com.ca.FRAMEWORKNAME:SUB_DOMAIN**.

### Handling exceptions

* Do not write try-catch in all your methods. Use it only if there is a possibility that a specific exception may occur and it cannot be prevented by any other means
* Always catch only the specific exception, not generic exception
* In case of exceptions, give a friendly message to the user, but log the actual error with all possible details about the error
* Never do a 'catch exception and do nothing'. If you hide an exception, you will never know if the exception happened or not


**For example:**

```c#
try
{
    // read from file.
}
catch (FileIOException ex)
{
    // log error.
    // re-throw exception depending on your case.
    throw;
}
```

**Not:**

```c#
try
{
    // read from file.
}
catch (Exception ex)
{
    // Catching general exception is bad... we will never know whether
    // it was a file error or some other error.
    // Here you are hiding an exception.
    // In this case no one will ever know that an exception happened.
    return "";
}
```
