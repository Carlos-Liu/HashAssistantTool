# Purpose
The tool is used for 
- calculating the hash value for the specified file based on SHA512 algorithm 
- checking if the hash value for specified file matches with the expected hash value

The tool can be running both in **command line mode** by providing argument(s) for the HashAssistant.exe, and in the **Windows form application mode** without passing any argument.

# Command Line Mode
The command line is used to calculate the hash value for the specified file based on SHA512 algorithm.

 ```
 Usage: HashAssistant.exe [File full path] [Hash file name]

[File full path]: Required. The full file path of the file to calculate the hash value.
[Hash file name]: Optional. The file name which stores the calculated hash value. The file will be saved in the same directory with the file that checks hash value if the argument only includes hash file name. The default hash file name is '{name of file to calculate hash}.sha512' if this argument is not provided.
```
 
# Windows Form Application Mode
Launch the HashAssistant.exe without passing any argument. It can check if the hash value for specified file matches with the expected hash value.
 
**File to compute hash**: Select the file which needs to verify the hash value. The user can select the file by
- Browsing the file using the browse button on the right, or
- Drag the file from Windows explorer and drop to the text box

**Expected Hash Value**: Input the expected hash value for the file to compute hash. The user can input the hash value by
- Inputting the hash value manually in the text box, or
- Browsing the file using the browse button on the right, then the file content will be loaded and shown in the text box, or
- Drag the file contains hash value from Windows explorer and drop to the text box

**Check Hash**: Click this button to start to compute hash for the selected file and show the verify result to the user.
If the hash value check is passed, the result is shown on the right of the 'Check Hash' button.

# Reference
```certutil.exe -hashfile C:\Trunk\Trunk.zip SHA512```
