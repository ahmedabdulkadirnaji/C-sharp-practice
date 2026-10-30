# C Sharp Files Summary

Slides 21 to the end

## Files and file objects
A file stores data for later use. A text file contains readable text; a binary file requires a suitable program to interpret it. These examples use .txt files.
A file object connects a program to a file. StreamWriter writes or appends text. StreamReader reads text. Add using System.IO; to access these classes.

## Three steps
1. Open the file to establish a connection.
2. Process the file by writing or reading data.
3. Close the file with Close() to release the connection.

## Create and write
File.CreateText() creates a text file or erases an existing file. Write() adds text without a line ending; WriteLine() adds a line ending.
```csharp
StreamWriter writer = File.CreateText("names.txt");
writer.WriteLine("Ahmed");
writer.Close();
```

## Append
File.AppendText() adds text at the end without erasing existing contents. It creates the file if it is missing.
```csharp
StreamWriter writer = File.AppendText("names.txt");
writer.WriteLine("Amina");
writer.Close();
```

## Read
File.OpenText() opens an existing file and returns a StreamReader. EndOfStream is true when no more data remains.
```csharp
StreamReader reader = File.OpenText("names.txt");
while (!reader.EndOfStream)
    Console.WriteLine(reader.ReadLine());
reader.Close();
```
Read() reads a character code, returning -1 at the end. ReadLine() reads one line. ReadToEnd() reads all remaining text into a string.
File.ReadAllText("names.txt") reads the whole file and closes it automatically. No loop is needed, and line breaks are preserved. This method belongs to File, not String.

## Delete and close safely
File.Delete("names.txt") deletes the entire file. To delete one item, read the lines, remove the matching item and rewrite the remaining lines.
A using block closes a StreamWriter or StreamReader automatically, even if an error occurs. An absolute path such as @"C:\Data\names.txt" specifies the file location.

## Remaining slide topics
OpenFileDialog selects an existing file; SaveFileDialog selects a save location. ShowDialog() displays the dialog, DialogResult.OK confirms the choice, and FileName contains the selected path. The program must still read or write the file.
Random generates pseudorandom values. rand.Next(1, 7) produces integers from 1 to 6; NextDouble() produces a value from 0.0 up to, but excluding, 1.0.
The Form Load event runs before a Windows Form first appears. Use it to set initial values or load saved data.
