// Name: C# HW 15
// Author: James Smelser
// Date: August 17, 2019

--------------------------------------------------------------
# Homework 15, ISTA-220
## Chapter 15, C# Step by Step
### July 28, 2018
#### 1 Homework
##### 1.1 Readings
###### Read chapter 15, pages 329 - 352 in the C# Step by Step book.
###### 1.2 Discussion Questions
###### Answer the discussion questions in writing.
1. What is the difference between a property and a field?
- a field is a variable of any type that is declared directly in the class while property
is a member that provides a flexible mechanism to read, write or compute the value of a private field.
2. What is the difference between a property and a method?
- Properties are a useful way of expressing a feature of an object, allowing get/set in a common way
that can be used by APIs like data-binding, reflection and serialization. Methods are better for
expressing things that either change the state, or which have an expectation of taking some time and
not necessarily being reproducible.
3. What is your understanding of encapsulation?
- Bundling of data with the methods that operate on that data. Encapsulation is used to hide the values
or state of a structured data object inside a class, preventing unauthorized parties' direct access to them.
4. Some languages are case insensitive, that is, an "a" and an "A" are considered to be the same letter.
C# is case sensitive. What implications does this have regarding the naming of variables, methods,
and other identifiers? Do you think that the difference in case in the initial character of two different
identifiers is sufficient to distinguish them?
- No, it would allow for a simple capitalization mistake to cause an error in the programming and would be
difficult to identify the error.
5. Give an example that is not in the book of an instance where you might want to use a read-only
property. Give an example not in the book of an instance where you might want to use a write-only
property.
- The value of a constant like PI. A password for an application.
6. Can you think of a reason why you might ever want to make getters and setters private? Give an
example. Also, make a case why getters and setters should never be private.
- private getter for a password, private setter for a constant value. A good case for keeping accessors
public would be to allow the ability to change private data members within a encapsulated program.
7. What are restrictions on the use of properties?
- You can’t use a property as a ref or out argument.
- You can’t declare multiple properties in a single declaration statement.
- You can’t declare constant or read only properties.
- You can declare only a get or set accessor, or both, inside a property.
- You can’t declare a property whose type is void.
8. What is an object initializer? What is the syntax for an object initializer?
- Object initializers let you assign values to any accessible fields or properties of an object at creation
time without having to invoke a constructor followed by lines of assignment statements.
