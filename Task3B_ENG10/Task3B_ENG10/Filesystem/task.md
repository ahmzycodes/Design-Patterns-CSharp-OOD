# Filesystems

Your task is to prepare filesystem interface for multiple Operating Systems. Your solution should support a possibility of creating additional platforms with filesystems if needed. The general interface should be platform independent, however their implementation may differ.

The solution consists of:
- Common interface `IFile` with `Name` for TextFile and Folder (same as in Unix everything is a file)
- TextFile - with Name and GetContent() method
- Folder - with Name, Files and AddFile() method
- Filesystem - with Name, GetRootDir() and GetContent() methods
- Main and BuildFilesystem methods

## Platforms

- ### Windows
  1. TextFile - GetContent() prints out the content, but with indent (insert `\t` before every line)
  2. Folder - AddFile() adds a file if a file with same name does not already exist. If it does it only prints out "File {file.name} already exists".
  3. Filesystem - Name is `NTFS`. GetContent() searches the filesystem according to forward-slash separated path (e.g. `C:/Users/user1`). If the file does not exist it prints out `Invalid path`. If file is TextFile GetContent() is called on the file. If file is Folder it lists all contents of the folder (non-recursively) in the order they have been added. It does not list hidden files with names starting with a dot "."

- ### MacOS
  1. TextFile - GetContent() prints out the content, but with prompt ">" inserted before every line.
  2. Folder - AddFile() adds a file and if file with same name already exists it is overwritten.
  3. Filesystem - Name is `APFS`. GetContent() behavior is similar to Windows, however Folder content is listed alphabetically, and hidden files (starting with a dot ".") are listed.
## Task
1. Implement missing classes.
2. Complete the BuildFilesystem method, that prepares the filesystem according to provided configuration, according to description within it.

## Notes
- Solution should support unlimited varieties of filesystem types and objects.
- Adding those should be easy and it should be performed without modifying previously defined 
code, especially BuildFilesystem function.
- You can’t modify IFile, Filesystem, TextFile and Folder classes.
- You can’t use switch or any other conditional operations on object types or object categories (with an exception to Filesystem's GetContent() method).