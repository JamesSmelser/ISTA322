// Name: ASPNET HW 03
// Author: James Smelser
// Date: August 20, 2019

---------------------------------------------------------
# Homework Chapter 03, ISTA-322
## ISTA-322, ASP.NET MVC
### Readings
#### Read chapter 3, pages 51 - 66 in the Pro ASP.NET MVC 5 book.
##### Discussion Questions
###### Answer the discussion questions in writing for chapter 3.
1. The book states, Interactions with an MVC application follow a natural cycle of user actions and view
updates, where the view is assumed to be stateless." What does it mean for the view to be stateless?
- Stateless means there is no memory of the past. Every transaction is performed as if it
were being done for the very first time. The server-side controls are what makes them different in as
far as being stateful and stateless.
2. The book identifies two kinds of models. Briefly describe each of them.
- View, data from controller to view. Domain, data on the business side.
3. Give an example of separation of concerns from your own life experience. This should be a simple,
everyday example.
- Work life and home life.
4. What is a view engine?
- The view engine is responsible for creating HTML from your views.
5. The book notes that the three-tier structure, or n-tier model, is the most widely used pattern for
business applications." Why do you think that this is true? An answer like, Because it works well,"
is not a sufficient answer to this question.
- a. Entity data model to connect to the database, create classes to process all the requests from Business Service Layer(UI),
write necessary methods to process the requests in business service layer. All three of these elements provide a comprehensive
program that receives, stores and displays data.
6. This question requires some outside research. When we study UWP, you will see that the UWP design
pattern is the Model-View-ViewModel (MVVM). What is the difference between MVC and MVVM
what makes thefirst good for ASP.NET MVC and the second good for UWP?
- Model-View-ViewModel (MVVM) is a UI architectural design pattern for decoupling UI and non-UI code. With MVVM, you define
your UI declaratively in XAML and use data binding markup to link it to other layers containing data and commands.
MVC is an architectural pattern commonly used for developing user interfaces that divides an application into three
interconnected parts Model, View and Controller.
7. Describe the two parts of the dependency injection (DI) design pattern.
- Dependency injection is basically providing the objects that an object needs (its dependencies) instead of having it construct them itself.
Service and client.
8. Give an example of loose coupling from your own life experience. This should be a simple, everyday
example.
- Changing my shirt.
9. What are the two types of testing discussed in the book?
- Integration and functional testing
10. What are the seven steps of the test driven development (TDD) workflow, as stated in the book?
- Add a test, run all tests and see if the new test fails, write the code, run tests, refactor code, repeat.
