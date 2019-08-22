// Name: C# HW 16
// Author: James Smelser
// Date: August 19, 2019

------------------------------------------------------
# Homework 16, ISTA-220
## Chapter 16, C# Step by Step
### July 28, 2018
#### 1 Homework
##### 1.1 Readings
###### Read chapter 16, pages 329 { 352 in the C# Step by Step book.
###### 1.2 Discussion Questions
###### Answer the discussion questions in writing.
1. Give five examples (using valid C# code) of the five bitwise operators listed in the text.
- <<, >>, |, &, ^.
2. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valid
C# code.
- Yes, uint x = 0b_1001; uint y = x >> 2; before (1001) after (10).
3. Explain in detail this code: bits & (1 << index);.
- Shifts one left and returns value where 1's match both.
4. Explain in detail this code: bits |= (1 << index);.
- Shifts one left and returns all 1 values in both.
5. Explain in detail this code: bits &= (1 << index);.
- Shifts one left and returns value where 1's match both
6. How does C# interpret this? bool peek = bits[n];
- Assigns true or false to peek of binary value index n.
7. How does C# interpret this? bits[n] = true;
- Assigns the binary value 1 to index n.
8. How does C# interpret this? bits[n] ^= true;
- Inverts.
9. Assume that users were assigned read, write, and execute permissions according to this scheme: read
= 1, write = 2, execute = 4. How would you interpret the following user permissions:
(a) permission = 0 - 0000 - None
(b) permission = 1 - 0001 - Read
(c) permission = 2 - 0010 - Write
(d) permission = 3 - 0011 - Read/Write
(e) permission = 4 - 0100 - Execute
(f) permission = 5 - 0101 - Read/Execute
(g) permission = 6 - 0110 - Write/Execute
(h) permission = 7 - 0111 - Read/Write/Execute
10. Answer the previous question by converting the decimal permissions into binary permissions. What
does this tell you about using this scheme of permissions?
- 1 position allows permissions.
