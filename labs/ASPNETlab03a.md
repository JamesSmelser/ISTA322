// Name: ASPNET lab03b
// Author: James Smelser
// Date: August 21, 2019

-------------------------------------------------------------
```
<!DOCTYPE html>
<html>
<head>
<title>css01.html</title>
<style>
body
{
 background-color:#c0c0c0;
 color:#000000;
 font-family:sans-serif;
 border: #000000 solid 2px;
 padding: 24px;
 margin: 24px;
 border-width: 12px;
 border-color: #837e7c;
 border-style: outset;
}
h2
{
 background-color: #000099;
 color: #ddddff;
 padding: 4px;
 border: 1px red solid;
}
.important
{
  letter-spacing: .2em;
  font-size: 17pt;
  font-weight: 600;
}
.out
{
  display: block;
  color: #ffffff;
  background-color: #000000;
  padding: 6px;
  border: 4px outset #0000ff;
  width: 2in;
  text-decoration: none;
  cursor: crosshair;
}
.in
{
  display: block;
  color: #000000;
  background-color: #ffffff;
  padding: 6px;
  border: 4px inset #ff0000;
  width: 2in;
  text-decoration: none;
  cursor: crosshair;
}
.down
{
  display: block;
  color: #ff0000;
  background-color: #ffffff;
  padding: 6px;
  border: 4px inset #6666cc;
  width: 2in;
  text-decoration: none;
  cursor: crosshair;
}
</style>
<body>

<h1 style="font-size: 60pt; text-align: center">Quotes</h1>

<h2>Edgar Allan Poe</h2>
<p><span style="font-family:fantasy; font-size: 20pt;">The boundaries which divide <span style="font-weight:600; font-style: italic; color: #ff0000;">Life from Death</span> are at best shadowy and vague. <span class="important">Who shall say where the
one ends, and where the other begins?</span></p>
<a href="https://en.wikipedia.org/wiki/Edgar_Allan_Poe" class="out"
onMouseOver="this.className='in';"
onMouseOut="this.className='out';"
onMouseOver="this.className='down';"
>Edgar Allan Poe info</a>

<h2>Benjamin Franklin</h2>
<p><span style="font-family:monospace; font-size: 16pt;">Without continual <span style="font-weight:600; font-style: italic; color: #bc4321;">growth and progress</span>, such words as improvement, achievement, and <span class="important">success have no meaning.</span></p>
<a href="https://en.wikipedia.org/wiki/Benjamin_Franklin" class="out"
onMouseOver="this.className='in';"
onMouseOut="this.className='out';"
onMouseOut="this.className='down';"
>Benjamin Franklin info</a>

<h2>John F. Kennedy</h2>
<p><span style="font-family:sans-serif; font-size: 16pt;">Change is the law of life. And those who look only to the <span style="font-weight:600; font-style: italic; color: #ff00ff;">past or present</span> are certain to <span class="important">miss the future.</span></p>
<a href="https://en.wikipedia.org/wiki/John_F._Kennedy" class="out"
onMouseOver="this.className='in';"
onMouseOut="this.className='out';"
onMouseOut="this.className='down';"
>John F. Kennedy info</a>

<h2>Leonardo Di Vinci</h2>
<p><span style="font-family:cursive; font-size: 16pt;">I love those who can smile in trouble, who can gather <span style="font-weight:600; font-style: italic; color: #0000ff;">strength from distress</span>, and grow brave by reflection.
<span class="important">'Tis the business of little minds to shrink, but they whose heart is firm, and whose conscience approves their conduct, will pursue their principles unto death'.</span></p>
<a href="https://en.wikipedia.org/wiki/Leonardo_da_Vinci" class="out"
onMouseOver="this.className='in';"
onMouseOut="this.className='out';"
onMouseOut="this.className='down';"
>Leonardo Di Vinci info</a>

</body>
</head>
</html>
```
