# Week 4 - Chapter 3: Making Decisions

- `if`, `if-else` and nested decisions choose which statements execute.
- Relational operators compare values: ==, !=, <, >, <= and >=.
- Logical operators &&, || and ! combine or negate Boolean conditions. A bool variable can act as a flag.
- TryParse returns false when conversion fails. Validate both conversion and the allowed range.
- String equality compares text; use an explicit comparison such as StringComparison.OrdinalIgnoreCase when case should not matter.
- Radio buttons in the same container allow one selection. Check boxes allow independent choices. CheckedChanged responds to selection changes.
- A switch selects a case for a matching value. break ends the case, and default handles other values.
- A ListBox stores Items. SelectedIndex is -1 when nothing is selected; check it before using SelectedItem. Add, Remove, RemoveAt and Clear change the list.

## Practice
Enter a score, select a course and choose a study mode. The form assigns a grade and checks scholarship eligibility using a check box and a score of at least 80. These are example exercise rules.

| Input | Expected result |
| --- | --- |
| 90, C#, scholarship checked | A; eligible True |
| 79, C#, scholarship checked | C; eligible False |
| -1, 101 or abc | Validation message |
| Valid score, no course | Select a course message |

Try boundary scores 59, 60, 79, 80, 89 and 90. Add another course and a switch case for it.

## Run in Visual Studio
Open the .csproj in practice/ with Visual Studio on Windows. Install the .NET desktop development workload and .NET Framework 4.8 targeting pack if requested. Press F5. Controls are created in code, so this exercise does not use a Designer file.

## Code images
The screenshot/ folder contains generated code illustrations from the included source, labelled as such. They are study examples, not screenshots of a student's Visual Studio session. The examples and summaries were prepared with AI assistance for review and practice.

![Code example 1](screenshot/code-01.png)

![Code example 2](screenshot/code-02.png)

Source topics: the supplied Gaddis, Starting Out with Visual C#, sixth edition chapter slides. These notes and exercises use original wording and code.