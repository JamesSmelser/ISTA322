// Name: ASPNET HW05
// Author: James Smelser
// Date: August 28, 2019

----------------------------------------------------------
# Homework Chapter 05, ISTA-322
## ISTA-322, ASP.NET MVC
### Readings
#### Read chapter 5, pages 95 - 118 in the Pro ASP.NET MVC 5 book.
##### Discussion Questions
###### Answer the discussion questions in writing for chapter 5.
1. What is a view engine?
- View Engine renders the view into html form to the browser.
2. What is Razor?
- Razor Pages is a page-focused framework for building dynamic, data-driven web sites with clean separation of concerns.
3. What do views do? List two specific things in your answer to this question.
- A view is a standard (X)HTML document that can contain scripts. Handles the app's data presentation and user interaction.
4. How does Razor respond when it encounters statements that begin with the at character (@)? Be
specific.
- Razor supports C# and uses the @ symbol to transition from HTML to C#. Razor evaluates C# expressions and renders them in the HTML output.
5. How does Razor respond when it encounters statements that begin with the at character followed by
the colon (@:)? Be specific.
- The @: outputs a single line of content containing plain text or unmatched HTML tags.
6. Describe how you implement a standard formatting for all pages in an ASP.NET application.
- RenderPage method.
7. What is the difference in using Razor to interpolate data values as stand-alone HTML elements and
as attributes to HTML elements. What is the similarity?
- Data attributes, which are attributes whose names are prefixed by data.
8. What is a view startfile and where is it located?
- It execute the code inside this file before executing the code inside an individual view.,_ViewStart.cshtml.
9. What is a Razor code block? What is the syntax of a Razor code block?
- Razor code blocks start with @ and are enclosed by {}. Unlike expressions, C# code inside code blocks isn't rendered. Code
blocks and expressions in a view share the same scope and are defined in order.
10. Describe the different roles of action methods and views.
- Views display HTML and action methods output data to the view.
11. Describe the use of the @using statement. Give an example of how you would use it.
- @model, applies scope to the view.
