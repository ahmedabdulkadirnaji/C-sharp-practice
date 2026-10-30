# EXPLAIN FILE
Explain the Functions and Classes

## 1. Files and File Processing

### File
- Stores data for use on later days.
- A text file stores readable text; a binary file requires a suitable program.

### File Object
- Connects a program to a particular file.
- Allows the program to read or write its contents.

### Open Process and Close
- Open creates the connection; process reads or writes data.
- Close ends the connection between the file and the program.

## 2. Functions Used to Create Write and Append

### StreamWriter
- A class used to write text into a file.
- It is also used when appending text.

### File.CreateText()
- Creates a text file and returns a StreamWriter.
- It erases existing contents if the file already exists.

### Write() and WriteLine()
- Write() writes text without adding a new line.
- WriteLine() writes text and adds a new line.

### File.AppendText()
- Opens a file to add text at its end.
- Keeps existing contents and creates the file if it is missing.

## 3. Functions Used to Read a File

### StreamReader and File.OpenText()
- StreamReader is a class used to read text.
- File.OpenText() opens an existing file and returns a StreamReader.

### Read() and ReadLine()
- Read() reads the next character code, or returns -1 at the end.
- ReadLine() reads one line at a time.

### ReadToEnd() and File.ReadAllText()
- ReadToEnd() reads all remaining text from a StreamReader.
- File.ReadAllText() reads the whole file into a string and closes it automatically.

### EndOfStream
- A property that checks whether the end of the file is reached.
- Returns true at the end; use a loop while it is false.

## 4. Closing and Deleting

### Close() and using
- Close() closes a reader or writer and releases the connection.
- A using block closes it automatically when the block ends.

### File.Delete()
- Deletes the entire file.
- It does not throw an error simply because the file is missing.

### Deleting an Item
- Read with StreamReader, skip the unwanted item and write the rest with StreamWriter.
- Save to a temporary file, close both streams, then replace the original.

### File.Move()
- Moves a file or changes its name.
- After deleting the original, it can rename the updated temporary file.

## 5. File Dialogs

### OpenFileDialog and SaveFileDialog
- OpenFileDialog lets the user select an existing file.
- SaveFileDialog lets the user choose a save location and filename.

### ShowDialog() and DialogResult
- ShowDialog() displays the dialog.
- DialogResult.OK confirms the selection; Cancel cancels it.

### FileName and InitialDirectory
- FileName contains the selected file path.
- InitialDirectory sets the folder first displayed.

## 6. Other Topics from the Final Slides

### Random Next() and NextDouble()
- Random generates pseudorandom values; Next(1, 7) returns an integer from 1 to 6.
- NextDouble() returns a value from 0.0 up to, but excluding, 1.0.

### Form Load Event
- Runs before a Windows Form first appears.
- Used to set initial values or load saved data.
