# Week 2 - Lesson Practice

## Concepts
Chapter 1 continuation: label output, PictureBox visibility, sequential execution and closing a form.

## Chapter summary
This continues Week1, which already introduces objects, controls, the IDE, forms and a button message.

- An event handler runs when an event such as a button click occurs.
- Assigning a string to `Label.Text` changes displayed output. An empty string clears it.
- A PictureBox displays images. `Visible` controls its visibility and `SizeMode` controls image fitting. This exercise uses a coloured placeholder; set Image in the Designer to try a real picture.
- A namespace groups classes, a class describes an object, and methods contain executable statements. This small example uses the global namespace.
- Statements execute in sequence. Comments, blank lines and indentation make code easier to read.
- `Close()` closes the form. IntelliSense suggests members, while compiler errors point out invalid syntax.


## Examples from the lesson
The comments in [Form1.cs](practice/Form1.cs) identify the source chapter and slide for each example. Some short examples follow the supplied Gaddis Visual C# sixth edition slides directly; others adapt them with input controls, event handlers or error handling. Added practice code is marked. Slide numbers refer to positions in your supplied PowerPoint, whose section numbers sometimes differ from the chapter number.

## Visual Studio files
- Form1.cs contains the constructor and button Click handlers, in the style used in class.
- Form1.Designer.cs contains control creation and InitializeComponent.
- Program.cs starts the application.

Open practice/Week2.csproj in Visual Studio on Windows with the .NET desktop development workload and .NET Framework 4.8 targeting pack. Press F5. Use View Designer on Form1.cs to see the form; edit exercise logic in Form1.cs.

## Practice checks
Show back hides the face placeholder. Show face restores it and updates the label. Clear label empties the label. Exit closes the form. The two coloured PictureBoxes are placeholders; set their Image properties in the Designer to use real pictures.

## Code images
These are generated illustrations of the included Form1.cs lesson examples, not personal Visual Studio screenshots. Repository preparation and supporting code used AI assistance.

![Lesson example 1](screenshot/code-01.png)

![Lesson example 2](screenshot/code-02.png)

Source: supplied Chapter 1 PowerPoint, Gaddis, Starting Out with Visual C#, sixth edition. The original slides are not redistributed here.
This continues Week1, which already covers objects, controls, the IDE and the first button message.
