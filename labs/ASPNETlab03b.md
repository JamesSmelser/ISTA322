// Name: ASPNET lab03b
// Author: James Smelser
// Date: August 21, 2019

-------------------------------------------------------------
```
<!DOCTYPE html>
<html>
  <head>
    <style>
      div
      {
        border: 1px solid black;
        font-size: 24pt;
        text-align: center;
      }
      #master
      {
        padding: 6px;
        background-color: #000000;
        border: 3px #000000 offset;

        display: grid;
        grid-template-columns: 10% 45% 45%;
        grid-template-rows: 200px 100px 600px 100px;
      }
      #c01
      {
        background-color: #ffaaaa;
        grid-column-start: 1;
        grid-column-end: 4;
        grid-row-start: 0;
        grid-row-start: 1;
      }
      #c02
      {
        background-color: #aaffaa;
        grid-column-start: 1;
        grid-column-end: 4;
        grid-row-start: 1;
        grid-row-start: 2;
      }
      #c03
      {
        background-color: #aaaaff;
        grid-column-start: 1;
        grid-column-end: 2;
        grid-row-start: 2;
        grid-row-start: 3;
      }
      #c04
      {
        background-color: #ffffaa;
        grid-column-start: 2;
        grid-column-end: 3;
        grid-row-start: 2;
        grid-row-start: 3;
      }
      #c05
      {
        background-color: #ffaaff;
        grid-column-start: 3;
        grid-column-end: 4;
        grid-row-start: 2;
        grid-row-start: 3;
      }
      #c06
      {
        background-color: #aaffff;
        grid-column-start: 1;
        grid-column-end: 4;
        grid-row-start: 3;
        grid-row-start: 4;
      }
    </style>
  </head>
    <body>
      <div id="master">
          <div id="c01"> 1 </div>
          <div id="c02"> 2 </div>
          <div id="c03"> 3 </div>
          <div id="c04"> 4 </div>
          <div id="c05"> 5 </div>
          <div id="c06"> 6 </div>
      </div>
    </body>
</html>
```
