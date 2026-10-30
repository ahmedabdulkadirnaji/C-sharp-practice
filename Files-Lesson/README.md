# C# Files — Lesson Summary

Based on slides 21–43 of Chapter_04_Gaddis_CSharp_6e_final-1.pptx, starting at section 5.6. The main topic is files; the final sections summarize the remaining slides. Examples and explanations are rewritten for study. File deletion and item deletion are additional practice topics requested in the notes.

## 1. Files and Data Storage (slide 21)

**Definition:** A file is a named collection of data saved on a storage device.

**Theory:** Variables hold data while a program runs. Files allow a program to save information and use it again on later days, even after the program closes.

- **Text file:** Stores text using an encoding such as UTF-8. Example: students.txt.
- **Binary file:** Stores data in a format that requires a suitable program to interpret. Example: an image or a Word document.

These examples work with plain text. Giving a text file a .doc extension does not create a real Word document. Use .txt for plain text.

## 2. The Three File-Processing Steps (slide 21)

1. **Open:** Establish a connection between the program and the file.
2. **Process:** Write data to the file or read data from it.
3. **Close:** Release the connection and its resources. Closing a writer also flushes buffered output.

Example: Open students.txt → write student names → close the file.

## 3. File Objects and Classes (slides 22–23)

**File object:** An object connected to a particular file that provides methods for working with it.

- **StreamWriter:** Writes text to a file, including when appending.
- **StreamReader:** Reads text from a file.
- **File:** A static class that provides methods for creating, opening, reading and deleting files.

Add this namespace at the top of the C# source file:

```csharp
using System.IO;
```

This makes the class names available; it does not open a file. Console examples also use `using System;`.

## 4. Create a New File: File.CreateText() (slides 23–25)

**Definition:** File.CreateText(path) opens a text file for writing and returns a StreamWriter.

**Theory:** If the file does not exist, it is created. If it already exists, its previous contents are erased.

```csharp
StreamWriter outputFile = File.CreateText("students.txt"); // Open
outputFile.WriteLine("Ahmed");                            // Process
outputFile.WriteLine("Amina");
outputFile.Close();                                      // Close
```

The file contains Ahmed and Amina on separate lines.

## 5. Write() and WriteLine() (slide 24)

**Write():** Writes text without adding a line ending.

**WriteLine():** Writes text and then adds a line ending.

```csharp
StreamWriter outputFile = File.CreateText("message.txt");
outputFile.Write("Hello ");
outputFile.WriteLine("class!");
outputFile.WriteLine("Welcome to C#.");
outputFile.Close();
```

Result:

```text
Hello class!
Welcome to C#.
```

## 6. Append to a File: File.AppendText() (slide 25)

**Definition:** Appending adds new text at the end of a file while keeping its existing contents.

**Theory:** File.AppendText(path) returns a StreamWriter. It creates the file if it does not exist. Use Write() or WriteLine() to add text. If the existing text has no final line ending, the new text starts immediately after it.

```csharp
StreamWriter outputFile = File.AppendText("students.txt");
outputFile.WriteLine("Hassan");
outputFile.Close();
```

After section 4, the file contains Ahmed, Amina and Hassan, each on a separate line.

## 7. File Paths (slide 26)

**Definition:** A path identifies the location of a file.

**Theory:** A relative path such as students.txt uses the program's current working directory. An absolute path specifies the full location. The @ prefix allows backslashes to be written directly in a C# string.

```csharp
Directory.CreateDirectory(@"C:\Data");
StreamWriter outputFile = File.CreateText(@"C:\Data\students.txt");
outputFile.WriteLine("Ahmed");
outputFile.Close();
```

Equivalent path strings: `@"C:\Data\students.txt"` and `"C:\\Data\\students.txt"`. The program must have permission to access the folder.

## 8. Read a File: File.OpenText() (slides 27–28)

**Definition:** File.OpenText(path) opens an existing text file for reading and returns a StreamReader.

**Theory:** Reading retrieves stored information. OpenText() does not create a missing file; it throws an exception if the file cannot be opened.

```csharp
StreamReader inputFile = File.OpenText("students.txt");
string firstName = inputFile.ReadLine();
Console.WriteLine(firstName);
inputFile.Close();
```

ReadLine() returns the next line without its line ending, or null when no more lines remain.

## 9. Reading Methods (slides 27–30)

### Read()

**Definition:** The parameterless Read() reads the next character and returns its character code as an int. It returns -1 at the end of the stream.

**Theory:** A loop lets you process a file character by character. Other overloads can read several characters into a buffer.

```csharp
StreamReader inputFile = File.OpenText("students.txt");
int character;
while ((character = inputFile.Read()) != -1)
{
    Console.Write((char)character);
}
inputFile.Close();
```

### ReadLine() with EndOfStream

**Definition:** EndOfStream is a Boolean property that is true when no more data remains to read and false when data remains.

**Theory:** Use a loop to read every line when the number of lines is unknown. The ! symbol means NOT.

```csharp
StreamReader inputFile = File.OpenText("students.txt");
while (!inputFile.EndOfStream)
{
    string line = inputFile.ReadLine();
    Console.WriteLine(line);
}
inputFile.Close();
```

`while (!inputFile.EndOfStream)` means the same as `while (inputFile.EndOfStream == false)`.

### ReadToEnd()

**Definition:** A StreamReader method that reads all remaining text from its current position and returns one string.

```csharp
StreamReader inputFile = File.OpenText("students.txt");
string contents = inputFile.ReadToEnd();
inputFile.Close();
Console.Write(contents);
```

### File.ReadAllText()

**Definition:** A static method of the File class that opens a file, reads all its text into a string and closes the file automatically.

```csharp
string contents = File.ReadAllText("students.txt");
Console.Write(contents);
```

**Theory:** ReadToEnd() and File.ReadAllText() do not require a loop in your code. They preserve line breaks: one string can contain many displayed lines. ReadAllText() belongs to File, not String. For very large files, reading one line at a time avoids loading the whole file into memory.

## 10. Closing Files Safely

**Definition:** Close() ends a reader's or writer's connection to the file.

**Theory:** The examples above show the three steps explicitly. A using block is safer because it disposes of the object automatically, even when an exception occurs inside the block.

```csharp
using (StreamWriter outputFile = File.AppendText("students.txt"))
{
    outputFile.WriteLine("Maryam");
} // Automatically closes and disposes of the writer.
```

Use the same pattern with StreamReader. An error during file processing may still need a try/catch block to display a helpful message.

## 11. Delete a Whole File — Additional Practice

**Definition:** File.Delete(path) removes a file from storage.

**Theory:** Close any readers or writers before deletion. File.Exists() can check whether the file exists. File.Delete() does not throw merely because the file is missing, but permission or file-access problems can cause an exception.

```csharp
if (File.Exists("practice-delete.txt"))
{
    File.Delete("practice-delete.txt");
}
```

## 12. Delete an Item from a Text File — Additional Practice

**Definition:** Deleting an item removes a selected record or line while keeping the other data.

**Theory:** A plain-text file has no built-in DeleteItem() method. A simple approach is to read the lines, remove the matching entries and rewrite the file. The following example removes every line exactly equal to Hassan; matching is case-sensitive.

```csharp
// Additional namespaces: using System.Collections.Generic;
List<string> names = new List<string>(File.ReadAllLines("students.txt"));
names.RemoveAll(name => name == "Hassan");
File.WriteAllLines("students.txt", names);
```

File.Delete() removes the entire file. This example only removes matching lines. For important data, keep a backup before rewriting the original file.

## 13. OpenFileDialog and SaveFileDialog (slides 31–38)

**OpenFileDialog:** A Windows Forms component that lets the user select an existing file.

**SaveFileDialog:** A Windows Forms component that lets the user choose a save location and filename.

**Theory:** These components appear in the Designer's component tray. ShowDialog() displays the dialog. DialogResult.OK means the user confirmed; DialogResult.Cancel means the user cancelled. Selecting a path does not itself read or write the file.

- **FileName:** The selected path and filename. Capitalization matters.
- **InitialDirectory:** The folder initially shown by the dialog.
- **Filter:** Limits which file types are displayed.

The following snippets belong inside Windows Forms event handlers and use `System.Windows.Forms` and `System.IO`.

Open and read:

```csharp
using (OpenFileDialog dialog = new OpenFileDialog())
{
    dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
    dialog.InitialDirectory = Environment.GetFolderPath(
        Environment.SpecialFolder.MyDocuments);

    if (dialog.ShowDialog() == DialogResult.OK)
    {
        string contents = File.ReadAllText(dialog.FileName);
        MessageBox.Show(contents);
    }
}
```

Save text:

```csharp
using (SaveFileDialog dialog = new SaveFileDialog())
{
    dialog.Filter = "Text files (*.txt)|*.txt";
    dialog.DefaultExt = "txt";
    dialog.AddExtension = true;

    if (dialog.ShowDialog() == DialogResult.OK)
    {
        using (StreamWriter outputFile = File.CreateText(dialog.FileName))
        {
            outputFile.WriteLine("My saved lesson notes.");
        }
    }
}
```

Use the save dialog's FileName when saving. Call ShowDialog() once per action and check its result.

## 14. Random Numbers (slides 39–40)

**Definition:** Random is a class that generates pseudorandom values.

**Theory:** Next() returns an integer; NextDouble() returns a double greater than or equal to 0.0 and less than 1.0. The upper limit of Next(max) and Next(min, max) is excluded. Keep and reuse a Random object when generating several values.

```csharp
Random rand = new Random();
int value = rand.Next();           // 0 through 2,147,483,646
int percentage = rand.Next(100);   // 0 through 99
int dice = rand.Next(1, 7);        // 1 through 6
double fraction = rand.NextDouble(); // 0.0 <= value < 1.0
```

## 15. The Form Load Event (slides 41–42)

**Definition:** Load is a Windows Forms event raised before a form is displayed for the first time.

**Theory:** Use its event handler to prepare the form, set initial values or load saved data. In the Designer, double-click the form background to create the default Load handler and connect it to the event.

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Welcome! Your form is loading.");
}
```

Slide 43 is the copyright slide and introduces no new programming topic.

## 16. Quick Revision

- Create or overwrite: File.CreateText() → StreamWriter.
- Append: File.AppendText() → StreamWriter.
- Open for reading: File.OpenText() → StreamReader.
- Write text: Write() or WriteLine().
- Read a character: Read(); read a line: ReadLine().
- Read remaining text: reader.ReadToEnd().
- Read an entire file and close automatically: File.ReadAllText().
- Check the end: reader.EndOfStream.
- Close explicitly: Close(); close automatically: a using block.
- Delete a file: File.Delete().
- Main pattern: Open → Process → Close.

## 17. Practice Assignment

1. Create courses.txt and write three course names on separate lines.
2. Append a fourth course without erasing the first three.
3. Read every course using ReadLine() and EndOfStream.
4. Display the whole file using File.ReadAllText().
5. Remove one course by reading, filtering and rewriting the lines.
6. Delete the practice file after closing all connections.
7. Optional: Add Windows Forms buttons to open and save text with dialogs.

Expected result before deletion: the file has three course names after one of the four names is removed.