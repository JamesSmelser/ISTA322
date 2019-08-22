// Name: ASP.NET HW 02
// Author: James Smelser
// Date: August 14, 2019

-------------------------------------------------------
# Homework Chapter 02, ISTA-322
## ISTA-322, ASP.NET MVC
### Readings
#### Read chapter 2, pages 11 - 50 in the Pro ASP.NET MVC 5 book.
##### Discussion Questions
###### Answer the discussion questions in writing for chapter 2.
1. Describe what a controller does in the MVC design pattern.
- MVC controllers are responsible for responding to requests made against an ASP.NET MVC website. Each browser request is mapped to a particular controller.
2. What is the ASP.NET MVC convention in naming controllers? What does HomeController.cs do?
- Default names that identify routing, main method.
3. What is the name of the routing configurationfile? Where is it located?
- ASP.NET Routing, Web.config file, Global.asax file.
4. What is Razor? How does Razor treat an expression beginning with the at symbol (@)?
- Razor is an ASP.NET programming syntax used to create dynamic web pages with the C# or Visual Basic.NET programming languages. You add code to a page using the @ character when using razor.
5. How do View methods work?
- For ASP.NET or Active Server Pages, ASP.NET MVC does not include anything that directly corresponds to a page. In an ASP.NET MVC application, there is not a page on disk that corresponds to the path in the URL that you type into the address bar of your browser. The closest thing to a page in an ASP.NET MVC application is something called a view.
6. What is the purpose of MVC models?
- Model represents domain specific data and business logic in MVC architecture. It maintains the data of the application. Model objects retrieve and store model state in the persistance store like a database.
7. What is a strongly typed view and why do we use strongly typed views?
- A strongly typed View is one that is generated or is associated to a Model.
8. What is the purpose of setting a start page URL?
- Start URL has to be a fully qualified URL and is not really used that often. It's meant for testing web services by opening a page that will call into the service, but isn't part of the application itself.
9. Describe the differences between HTTP GET and HTTP POST.
- Browsers can cache GET requests, generally on static data, like images or scripts. But you can also allow browsers to cache GET requests to controller actions as well, POSTs won't be cached by the browser, so any POST is guaranteed to make it to the server.
10. Describe the two approaches to validation in web applications.
- Server side Validations, Client Side Validations
11. What is the role of Cascading Style Sheets (CSS) in web development?
- Is a language used for describing the look and formatting of a document written in a markup language. Describes how HTML elements are to be displayed on screen, paper, or in other media.
