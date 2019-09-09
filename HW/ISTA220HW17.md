// Name: C# HW 17
// Author: James Smelser
// Date: August 25, 2019

-----------------------------------------------------
# Homework 17, ISTA-220
## Chapter 17, C# Step by Step
### July 28, 2018
#### 1 Homework
##### 1.1 Readings
###### Read chapter 17, pages 369 - 398 in the C# Step by Step book.
###### 1.2 Discussion Questions
###### Answer the discussion questions in writing.
1. What is a type parameter?
-  <T>.
2. What does a type parameter do?
- Type parameter acts as a placeholder for a real type at compile time. Creates a new instance
of the type class.
3. How many type parameters can a generic class have?
- A generic class can have multiple type parameters.
4. What is the difference between a generic class and a generalized class?
- generic classes use type parameters and a generalized class takes parameters that can be cast to different types.
5. What is a constraint? How do you specify a constraint?
- By using a constraint, you can limit the type parameters of a generic class to those that implement a particular set of interfaces and therefore provide the methods defined by those interfaces.
6. What is a generic method? How do you define a generic method?
- With a generic method, you can specify the types of the parameters and the return type by using a type parameter like that used when you define a generic class. You define generic methods by using the same type parameter syntax you use when you create generic classes.
7. What do we mean when we say that a generic type interface is invariant?
- The IWrapper<T> interface is said to be invariant. You cannot assign an IWrapper<A> object to a reference of type IWrapper<B>, even if type A is derived from type B. By default, C# implements this restriction to ensure the type safety of your code.
8. What do we mean when we say that a generic type interface is covariant?
- You can assign an IRetrieveWrapper<A> object to an IRetrieve-Wrapper<B> reference as long as there is a valid conversion from type A to type B, or type A derives from type B.
9. Does covariance work with value types? Does it work with reference types?
- Covariance works only with reference types. This is because value types cannot form inheritance hierarchies.
10. What do we mean when we say that a generic type interface is contravariant?
- Contravariance follows a similar principle to covariance except that it works in the opposite direction; it enables you to use a generic interface to reference an object of type B through a reference to type A as long as type B derives from type A.
