# Week 3 - Chapter 2: Processing Data

- TextBox.Text contains a string, even when the user types digits.
- Variables have types: `string` for text, `int` for whole numbers, `decimal` for money and `double` for general floating-point calculations.
- Parse converts text to a number. FormatException and OverflowException handle invalid or excessively large input.
- Arithmetic operators include +, -, *, / and %. Parentheses control evaluation order. Integer division discards the fractional part.
- A named constant stores a value that cannot change. Local variables belong to a method; fields belong to the object and retain values between events.
- ToString("F2") displays two decimal places. Math.Round rounds a value; formatting changes its displayed representation.
- Breakpoints and stepping help inspect values and locate logic errors. TabIndex sets keyboard navigation order and Focus() selects a control for input.

## Practice
The order calculator reads unit price and quantity, adds 5% tax, rounds the total and counts successful calculations. Enter the price with a decimal point.

| Input | Expected result |
| --- | --- |
| Price 10, quantity 2 | Total 21.00 (decimal separator follows system settings) |
| Price 12.50, quantity 3 | Total 39.38 |
| Price abc | Numeric input message |
| Quantity 0 | Positive quantity message |

Try a different tax rate. Place a breakpoint before the total calculation and inspect subtotal and tax.

## Run in Visual Studio
Open the .csproj in practice/ with Visual Studio on Windows. Install the .NET desktop development workload and .NET Framework 4.8 targeting pack if requested. Press F5. Controls are created in code, so this exercise does not use a Designer file.

## Code images
The screenshot/ folder contains generated code illustrations from the included source, labelled as such. They are study examples, not screenshots of a student's Visual Studio session. The examples and summaries were prepared with AI assistance for review and practice.

![Code example 1](screenshot/code-01.png)

![Code example 2](screenshot/code-02.png)

Source topics: the supplied Gaddis, Starting Out with Visual C#, sixth edition chapter slides. These notes and exercises use original wording and code.