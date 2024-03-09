# Command-Line Calculator

This project contains a command-line calculator.  The calculator has one register and five memory cells.  It supports about eighty different operators, including add, subtract, multiply and divide.  Each operation is printed to the screen.  Enter the numbers directly into the Number fields. Use Copy and Paste (Ctrl-C and Shift-Insert) to insert numbers into the Number fields as needed.  Use memory cells (M1 - M5) in the Number fields as needed.

## Install and Build

The is a C# Console-Mode Project.  Open with Visual Studio 2022 and above to compile. 

## Description:

  Command-Line Calculator. Supports one register and five memory cells.

## Usage:
	CalcOne [options]

## Options:
	-h  Show help and usage information.
	-ha  Show operator list.
	-ho [operator]  Show operator help.
	-hq  Show quick help.
	-hx  Show help examples.

## Exit Application

  Enter an empty line in the operator field.


## Operators

| Operator | Description |
| --- | --- |
| + | add|
| - | subtract |
| * | multiply |
| / | divide |
| % | modulus |
| ! | factorial |
| = | show register |
| A |  absolute value |
| ACOS | anti-cosine |
| ASIN | anti-sine |
| ATAN | anti-tangent |
| B | Binary |
| BIT | Show Bits |
| C | clear |
| CB | cube, a ^ 3 |
| CL | Ceiling |
| COS | Cosine in radians |
| CDF | Cumulative Density Function, z-score |
| CM | Commas |
| CR | Cube root, EXP(a, 1 / 3) |
| CSR | Cosine Rule |
| DEG | radians to degrees |
| E | exponent, power, a ^ b |
| EN | Euler's Number 2.71 |
| F | fraction |
| FL | Floor |
| G | General, No exponent |
| GAU | Gaussian, z - score |
| GCF | Greatest Common Factor |
| H | Hex |
| HT | Height of Triangle |
| HYP | Hypotenuse |
| I | Integer |
| LCM | Least Common Multiple |
| LG | Base 10 Logarithm, 10 ^ a |
| LN | Natural Logarithm, e ^ a |
| M1 | get from memory cell one |
| MC | Memory Clear |
| MEM | Show Memory Cells |
| N | Number |
| ND | Normal Distribution, x, mean, std |
| P2 | power of two, 2 ^ a |
| PD | Prime Divisor |
| PI | half rotation in radians 3.14 |
| PM | Prime? |
| QF | Quadratic Formula |
| R | reciprocal, 1 / x |
| RAD | degrees to radians |
| RAN | Random Integer |
| RC | Range Clear, Set Range to 0 to 100 |
| RD | Round |
| RH | Random High |
| RL | Random Low |
| RN | Random Number Between High and Low |
| RND | Random Double Between One and Zero |
| RT | Nth Root, EXP(a, 1 / b) |
| S | Change Sign |
| SIN | sine in radians |
| SM1 | save to memory cell one |
| SN | Simple Normal Distribution, mean = 0, std = 1 |
| SR | square root, SQRT(a) |
| STU | Student's T-Distribution, t-score and degrees of freedom|
| TAN | tangent in radians |
| TAU | full rotation in radians 6.28 |
| X2 | square, a * a |
| X3 | cube, a ^ 3 |

## Fields

There are two types of fields: Operator and Number.
To see a list of all operators use -ha.

## Operator Basics

Type n to save a new number into the base register.  Type c to clear the screen and register.

Type mem to view all memory cells.  Type sm1 to save the base register into the first memory cell.  Type sm2 to save the base register into the second memory cell.

Type m1 to copy the first memory cell into the base register.  Type m2 to copy the second memory cell into the base register.

Memory cells can be used in number fields and operator fields. Type m1 to use memory cell one in a calcuation.

## EXAMPLES

### Change the Sign of a Number:  12.62

```
Operator? n
Number ? 12.62
12.62
Operator? S
-(12.62) = -12.62
```

### 123 Squared

```
Operator? n
Number? 123
123
Operator? x2
123 ^ 2 = 15129
```

### Add Three Numbers: 121, 336 and 712

```
Operator? n
Number ? 121
121
Operator ? +
Number ? 336
121 + 336 = 457
Operator ? +
Number ? 712
457 + 712 = 1169
```

### Square Root of 658

```
Operator? n
Number ? 658
658
Operator? sr
SQRT(658) = 25.65151067676132
```

### Raise 127 to the 4th Power

```
Operator? n
Number ? 127
127
Operator? e
Number ? 4
127 ^ 4 = 260144641
```

### Convert 33 degrees to Radians

```
Operator? n
Number? 33
33
Operator? rad
RAD(33) = 0.5759586531581288
```

### Cosine of 42 degrees

```
Operator? n
Number? 42
42
Operator? rad
RAD(42) = 0.7330382858376184
Operator? cos
COS(0.7330382858376184) = 0.7431448254773942
```

### Factorial of 9

```
Operator? n
Number ? 9
9
Operator ? !
9! = 362880
```

### Greatest Common Factor of 121 and 335

```
Operator? n
Number ? 121
121
Operator? gcf
Number ? 335
GCF(121, 335) = 1
```

### Log Base 10 of 55

```
Operator? n
Number ? 55
55
Operator? lg
LG(55) = 1.7403626894942439
```

### 5th Root of 321

```
Operator? n
Number ? 321
321
Operator? rt
Number ? 5
RT(321, 5) = 3.1717650296502993
```

### Hypotenuse of a Right Triangle with Sides 7.2 and 11.5

```
Operator? n
Number ? 7.2
7.2
Operator? x2
7.2 ^ 2 = 51.84
Operator? n
Number ? 11.5
11.5
Operator? x2
11.5 ^ 2 = 132.25
Operator? n
Number ? 51.84
51.84
Operator ? +
Number ? 132.25
51.84 + 132.25 = 184.09
Operator ? sr
SQRT(184.09) = 13.567977004697495
```

### Save 3.5 to Memory Cell Three

```
Operator? n
Number ? 3.5
3.5
Operator? sm3
M3 = 3.5
Operator? mem
M1 = 0
M2 = 0
M3 = 3.5
M4 = 0
M5 = 0
```

## Credits

```
1. James McCaffrey, "The Normal Cumulative Density Function in C#", http://jamesmccaffrey.wordpress.com, 2014.
```
   
