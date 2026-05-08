# CalcOne: Command-Line Power Calculator

**CalcOne** is a high-precision CLI calculator featuring a single base register and five dedicated memory cells (M1–M5). With support for over 80 operators, it handles everything from basic arithmetic to advanced statistics and trigonometry.

---

## 🚀 Quick Start
1. **Launch:** Run `CalcOne.exe` from the command line.
2. **Set Base:** Type `n` then enter your first number.
3. **Operate:** Enter an operator (e.g., `+`, `sr`, `cos`).
4. **Exit:** Press **Enter** on an empty operator line.

### Help Options:
* `-ha`: Show full operator list.
* `-hx`: Show usage examples.
* `-ho [op]`: Help for a specific operator.

---

## 🧠 Memory & Register Logic
The calculator operates on a **Base Register**. You can store and recall values using five cells.

| Command | Action |
| :--- | :--- |
| **N** | Set a new number into the Register. |
| **C** | Clear screen and Register. |
| **MEM** | View all memory cells (M1–M5). |
| **SM[1-5]** | **Save** Register to cell (e.g., `sm1`). |
| **M[1-5]** | **Recall** cell to Register (e.g., `m1`). |

> [!TIP]
> You can type `m1` through `m5` directly in any **Number?** field to use a stored value in a calculation.

---

## 🔢 Operator Quick Reference

### Basic & Advanced Math
* **Arithmetic:** `+`, `-`, `*`, `/`, `%` (Modulus), `R` (Reciprocal)
* **Power/Roots:** `X2` (Square), `X3` (Cube), `E` (Power), `SR` (Sq. Root), `RT` (Nth Root)
* **Rounding:** `FL` (Floor), `CL` (Ceiling), `RD` (Round), `I` (Integer)
* **Theory:** `GCF`, `LCM`, `PM` (Prime Test), `!` (Factorial)

### Science & Stats
* **Trig (Radians):** `SIN`, `COS`, `TAN`, `ASIN`, `ACOS`, `ATAN`
* **Logarithms:** `LN` (Natural), `LG` (Base 10)
* **Distributions:** `GAU` (Gaussian), `ND` (Normal), `STU` (Student's T)
* **Constants:** `PI` (3.14...), `TAU` (6.28...), `EN` (Euler's 2.71...)

### Conversion & Logic
* **Bases:** `B` (Binary), `H` (Hex), `BIT` (Show Bits)
* **Angles:** `DEG` (Rad to Deg), `RAD` (Deg to Rad)

---

## 📖 Examples

### Calculating Hypotenuse (Sides 7.2, 11.5)
1. `Operator? n` -> `Number? 7.2`
2. `Operator? x2` (Result: 51.84)
3. `Operator? sm1` (Save to M1)
4. `Operator? n` -> `Number? 11.5`
5. `Operator? x2` (Result: 132.25)
6. `Operator? +` -> `Number? m1` (Add stored 51.84)
7. `Operator? sr` (Result: 13.56...)

---

## 🏗 Build Instructions
* **Platform:** .NET / C# Console Application.
* **IDE:** Visual Studio 2022+.
* **Build:** Open solution and compile in **Release** mode.
