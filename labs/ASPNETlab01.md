// Name: ASPNET lab01
// Author: James Smelser
// Date: August 18, 2019

----------------------------------------------------------------
```
<!DOCTYPE html>
<html>
  <head>
    <title>My First Webpage</title>
    <meta name='author' content='James Smelser' />
    <meta name='description' content='This is my first webpage.' />
    <script>
      <!-- no script yet -->
    </script>
    <style>
      <!-- no style yet -->
    </style>
  </head>
    <body>
      <a name="Top" /><a href="#Bottom">Go to the Bottom of the page.</a>
      <hr />
      <h1>H1 Level Header</h1>
      <h2>H2 Level Header</h2>
      <h3>H3 Level Header</h3>
      <h4>H4 Level Header</h4>
      <h5>H5 Level Header</h5>
      <h6>H6 Level Header</h6>
      Hello world!
      <p>Paragraphs are block level elements. In-Line elements are displayed from left to right.</p>
      <h1>My first webpage</h1>
      <p>Hello world. How do you like it?</p>
      <p>In-Line tags display across the page.
        <tt>This displays monospace font.</tt>
        <em>This displays italic.</em>
        <strong>This diplays &lt;BOLD &gt;.</strong>
        <br />
        <br />
        <i>This is italic.</i>
        <b>This is bold.</b>
        <b><i>This is bold italic. Notice that the tags must be closed in the
          reverse order of opening.</i></b></p>
          <h1>Examples of HR and BR</h1>
          <hr />
          <div>This is the first division element.</div>
          <div>This is the second division element.</div>
          <div>This is the third division element.</div>
          <span style="background-color: red;">This is the first span element.</span>
          <br />
          <span>This is the second span element.</span>
          <br />
          <span>This is the third span element.</span>
          <hr />
          <h1>Lists</h1>
          <h3>This is an unordered list</h3>
          <ul>
            <li>Green</li>
            <li>Eggs</li>
            <li>And</li>
            <li>Ham</li>
          </ul>
          <h3>This is an ordered list</h3>
          <ol>
          <li>The</li>
          <li>Cat</li>
          <li>In</li>
          <li>The</li>
          <li>Hat</li>
          </ol>
          <h3>This is a dictionary list<h3>
            <dl>
              <dt>M9</dt><dd>9mm</dd>
              <dt>M14</dt><dd>7.62mm</dd>
              <dt>M16</dt><dd>5.56mm</dd>
              <dt>M2</dt><dd>.50 cal</dd>
            </dl>
            <h1>Hyper Links</h1>
            <a href="http://weather.com" target="new">Get the Weather</a> <br />
            <a href="http://cnn.com" target="new">Get the News</a> <br />
            <a href="http://foxnews.com" target="new">Get the Real News</a> <br />
            <h1>HTML Tables</h1>
            <table rules="all" style="border: 6px #66ff55 groove;">
              <tr>
                <th>Name</th>
                <th>Place of Birth</th>
                <th>Favorite Color</th>
              </tr>
              <tr>
                <td>James</td>
                <td>Texas</td>
                <td>Green</td>
              </tr>
              <tr>
                <td>Milton</td>
                <td>Mississippi</td>
                <td>Red</td>
              </tr>
              <tr>
                <td>Lorenzo</td>
                <td>Florida</td>
                <td>Blue</td>
              </tr>
            </table>
            <h1>Images</h1>
            <img src="C:\Users\smels\OneDrive\Desktop\Microsoft.jpg" alt="My Photo" width="300px" />
            <h1> HTML Forms</h1>
              <form method="post" action="">
                <input type="hidden" name="my car" id="my car" value="I drive a Porsche" />
              Name: <input type="text" name="name" id="name" /><br /><br />
              Password: <input type="password" name="password" id="password" /><br /><br />
              Color: <input type="color" name="color" id="color" value="50" min="0" max="100" step="2" /><br /><br />
              Range: <input type="range" name="range" id="range" value="range" oninput="rangedisplay.value = range.value" />
                <output id="rangedisplay"></output><br /><br />
                <input type="submit" name="submit" id="submit" value="submit" /><br /><br />
                <input type="reset" name="reset" id="reset" value="reset" /><br /><br />
              <hr />
              <h3>Pizza</h3>
                <input type="checkbox" name="pizza" id="pizza" value="pepperoni" />Pepperoni |
                <input type="checkbox" name="pizza" id="pizza" value="meatballs" />Meatballs |
                <input type="checkbox" name="pizza" id="pizza" value="pineapple" />Pineapple |
                <input type="checkbox" name="pizza" id="pizza" value="jalapeno" />Jalapeno |
                <input type="checkbox" name="pizza" id="pizza" value="mushrooms" />Mushrooms |
                <input type="checkbox" name="pizza" id="pizza" value="black olives" />Black Olives |
                <input type="checkbox" name="pizza" id="pizza" value="green peppers" />Green Peppers |<br /><br />
              <h3>Gender</h3>
                <input type="radio" name="gender" id="gender" value="male" checked="male" />Male<br />
                <input type="radio" name="gender" id="gender" value="female" />Female<br />
                <input type="radio" name="gender" id="gender" value="no comment" />No Comment<br /><br />
              <h3>My Favorite Theater<h3>
                <select name="theater" id="theater" size="3" multiple="multiple">
                <option value="Iraq">Iraq</option>
                <option value="afghanistan">Afghanistan</option>
                <option value="africa">Africa</option>
                <option value="vietnam">Vietnam</option>
                </select><br />
              <h4>Comments</h4>
                <textarea name="freeform" id="freeform" rows="4" cols="24">
                </textarea><br />
                <button name="submit" id="submit">Submit</button><br /><br />
              </form>
            <hr />
            <a href="#Top">Go to the Top of the page.</a><a name="Bottom" />
    </body>
</html>
```
