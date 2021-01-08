# dotNetTips.Utility.Standard.Tester

![dotNetTips.com](https://dotnettips.files.wordpress.com/2018/03/cropped-rtw-dotnettips-com-logo05x1.png)
This repository is for the dotNetTips.Utility.Standard.Tester code for .NET Standard.

Much of this code is documented on <a href="https://dotnettips.wordpress.com/tag/dotnettips-utility/" target="_blank">dotNetTips.com</a>.

## Overview
The main goal is to make it simple to create real-world objects along with lots of other methods to create random data. Some of the methods include the use of fixed-length strings that I needed for the benchmark tests.  
## Person Types
For the benchmark tests for my performance book, I created three Person types that reflect different ways that I see developers create data model classes. All of them implement from the `IPerson` interface that defines these properties: `Address`, `Address2`, `BornOn`, `CellPhone`, `City`, `Country`, `Email`, `FirstName`, `HomePhone`, `Id`, `LastName`, `PostalCode`.

The three different types that implement IPerson are:

`Person`: This type represents how I see most model classes created for use in web API service calls or Entity Framework by implementing the properties in `IPerson` as auto-implemented properties.

`PersonFixed`: This type is implemented the same as `Person`, adds a property for Age and implements methods for the `ICoparable<T>` and `IEquatable<T>` interfaces. It also overrides `GetHashCode()`, `ToString()` and `Equals()` and implements operators. It also uses the `DebuggerDisplay` attribute.

`PersonProper`: This type is implemented the same as PersonFixed and adds validation to all appropriate properties. It also uses the `Serializable`, `XmlRoot` and `DataContract` attributes. The type represents how most data objects should be implemented and should usually be the one that you should use in your tests. 

Along with those types, there is a `PersonCollection<>` that is used to return a collection of any types that implement `IPerson`.

## Coordinate Types

Also, for my benchmark tests, I created two structure types that implement the ICoordinate interface. The interface has only two properties, `X` and `Y`. The two different types that implement ICoordinate are:

`Coordinate`: This structure implements `X` and `Y` as auto-implemented properties. It implements the `IEquatable<>` interface. It also overrides `ToString()`, `Equals()` and `GetHashCode()`. It implements operators (since structures do not by default have them) and uses the `Serializable` attribute.

`CoordinateProper`: This structure is implemented the same as Coordinate and implements the `IComparable` and `IComparable<>` interfaces. This structure should be used most often in your tests.

## Random Data Methods
Using random data is very important if you are testing processing in your assemblies. I created the `RandomData` static type that helps with generating random data. There are many methods in this class, and I add new ones often, especially when working on a new edition of my books. The methods are listed below along with sample output (most from using `?` in the Immediate Window in Visual Studio).


## Usage Examples
To install the NuGet package, run the following from the Package Manager Console in Visual Studio:

`Install-Package dotNetTips.Utility.Standard.Tester`

## Your Support Is Needed
Do you have code you would like to submit to these repositories? Submit a pull request or submit an issue. I promise to take a look and include it if I like it!
