// Name: ASPNET HW 06
// Author: James Smelser
// Date: August 29, 2019

-----------------------------------------------------------
# Homework Chapter 06, ISTA-322
## ISTA-322, ASP.NET MVC
### Readings
#### Read chapter 5, pages 119 - 154 in the Pro ASP.NET MVC 5 book.
##### Discussion Questions
###### Answer the discussion questions in writing for chapter 6.
1. What is the primary idea that underlies Dependency Injection?
- Which is a technique for achieving Inversion of Control (IoC) between classes and their dependencies.  inversion of control (IoC)
is a design principle in which custom-written portions of a computer program receive the flow of control from a generic, reusable library.
2. Describe the role of interfaces in implementing a dependency injection container.
- allows the constructor to access the application’s repository through the interface without having any need to
know which implementation class has been configured.
3. List the three stages of building basic Ninject functionality, and briefly define each stage.
- You must initialize to use it, you can't easy control lifetime, you can't make unit tests on it.
4. What is the purpose of a custom dependency resolver?
- This can be done by implementing the IDependencyResolver interface and registering an instance of the interface on application startup.
5. What is the purpose of conditional binding? Describe how it works.
- Data-binding expressions are contained within <%# and %> delimiters and use the Eval and Bind functions.
you can call any publicly scoped code within the <%# and %> delimiters to execute that code and return a value during page processing.
6. Why is setting the object scope important when using dependency injection?
- To ensure decoupling is accomplished.
7. Briefly describe the Test Driven Development approach in developing an application.
- Test-driven development is a methodology for creating more robust code. Among other benefits, test-driven development (or TDD)
allows you to catch bugs early and decouple code, making it more modular and scalable.
8. Consider the Assert class. How do you access the methods of that class?
- Within the method body, methods defined by the Assert class are used to compare the expected result of a test with what actually happened.
9. Why is it useful to mock objects when developing software?
- A mocking framework makes it easier to create fake components to isolate parts of the application for unit testing.
10. Briefly describe the two main issues that arise when attempting to do Unit Tests without the aid of
some sort of mocking library.
- It leads to creating implementation classes for every kind of test you want to run.
