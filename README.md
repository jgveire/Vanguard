# Vanguard
A simple guard library for validation method parameters without being a complete validation library. This library makes it easy to validate method arguments in a uniform way.

## Getting Started
You can use NuGet to include Vanguard into your project.

```
PM> Install-Package Vanguard
```

## Howto use Vanguard
Vanguard supports the three most commonly used argument checks there are:

* Argument not null
* Argument not empty
* Argument not out of range

For more complex checks a validation library is recommended and not a guard library. 

The following code show how to check whether the argument is not null. When the argument is null an ArgumentNullException will be thrown.

```
// Basic argument not null check.
Guard.ArgumentNotNull(value, nameof(value));

// Argument not null check with custom exception message.
Guard.ArgumentNotNull(value, nameof(value), "Custom exception message.");
``` 

The following code show how to check whether the argument is not empty. When the argument is empty an ArgumentException will be thrown.

```
// Basic argument not empty check.
Guard.ArgumentNotNullOrEmpty(value, nameof(value));

// Argument not empty check with custom exception message.
Guard.ArgumentNotNullOrEmpty(value, nameof(value), "Custom exception message.");
```

The following code show how to check whether the argument is out of range. When the argument is out of range an ArgumentOutOfRangeException will be thrown.

```
// Basic argument in range check.
Guard.ArgumentInRange(value, 0, 10, nameof(value));

// Argument in range check with custom exception message.
Guard.ArgumentInRange(value, 0, 10, nameof(value), "Custom exception message.");
```

Vanguard supports the three most commonly used value checks there are:

* Value not null
* Value not empty
* Value not out of range

The following code show how to check whether a value is not null. When the value is null an ValueNullException will be thrown.

```
// Basic value not null check.
Guard.ValueNotNull(value);

// Value not null check with custom exception message.
Guard.ValueNotNull(value, "Custom exception message.");
``` 

The following code show how to check whether a value is not null or empty. When the argument is empty an ValueEmptyException will be thrown.

```
// Basic value not null or empty check.
Guard.ValueNotNullOrEmpty(value);

// Value not null or emtpy check with custom exception message.
Guard.ValueNotNullOrEmpty(value, "Custom exception message.");
```

The following code show how to check whether the value is not out of range. When the value is out of range an ValueOutOfRangeException will be thrown.

```
// Basic value in range check.
Guard.ValueInRange(value, 0, 10);

// Value in range check with custom exception message.
Guard.ValueInRange(value, 0, 10, "Custom exception message.");
```
