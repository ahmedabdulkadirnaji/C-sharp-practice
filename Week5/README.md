# Week 5 - Chapter 4: Loops, Files, and Random Numbers

- while is a pretest loop and may run zero times. for groups initialization, condition and update in one statement.
- do-while checks after the body and therefore runs at least once.
- ++ increments and -- decrements. Updating the loop state prevents infinite loops.
- An accumulator stores a running total. Check loop boundaries to avoid an extra or missing iteration.
- StreamWriter writes text; StreamReader reads it. EndOfStream helps a while loop stop reading.
- File.CreateText creates or overwrites a file. File.AppendText preserves existing content and adds to the end. using closes and disposes streams even if an exception occurs.
- OpenFileDialog and SaveFileDialog choose file paths. Continue only when ShowDialog returns DialogResult.OK; FileName holds the selected path.
- Random.Next(min, max) includes min and excludes max. Next(1, 7) produces dice values 1 through 6. NextDouble produces a value from 0 inclusive to 1 exclusive.
- The form Load event runs as the form loads and can initialize displayed information.

## Practice
Roll generates five dice values with a for loop and displays their total. A small do-while countdown demonstrates decrementing. Save writes each value to a text file. Open uses a while loop to read lines into the list.

Check that five values appear, each from 1 to 6, and that the total is from 5 to 30. Save to a new file, roll again, then open the saved file and compare the original values. Cancelling either dialog should leave the current data alone.

Save overwrites the selected file after the standard confirmation. Use a new practice file. Open displays text lines without assuming that every line is numeric.

Try replacing CreateText with AppendText and explain how the saved file changes.

## Run in Visual Studio
Open the .csproj in practice/ with Visual Studio on Windows. Install the .NET desktop development workload and .NET Framework 4.8 targeting pack if requested. Press F5. Controls are created in code, so this exercise does not use a Designer file.

## Code images
The screenshot/ folder contains generated code illustrations from the included source, labelled as such. They are study examples, not screenshots of a student's Visual Studio session. The examples and summaries were prepared with AI assistance for review and practice.

![Code example 1](screenshot/code-01.png)

![Code example 2](screenshot/code-02.png)

Source topics: the supplied Gaddis, Starting Out with Visual C#, sixth edition chapter slides. These notes and exercises use original wording and code.