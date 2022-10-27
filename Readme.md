
# Hash Assistant Tool

The tool is used for 
- calculating the hash value for the specified file based on SHA512 algorithm 
- checking if the hash value for specified file matches with the expected hash value

It can be ran both in command line style by providing argument(s) for the .exe, or in the Windows form application style without passing any argument.

## Command Line Usage
```
The command line is used to calculate the hash value for the specified file based on SHA512 algorithm.

Usage: HashAssistant.exe [File full path] [Hash file name]

[File full path]: Required. The full file path of the file to calculate the hash value.
[Hash file name]: Optional. The file name which store the calculated hash value. The file will be saved in the same directory with the file that checks hash value if the argument only includes hash file name. The default hash file name is 'name of file to calculate hash.sha512' is this argument is not provided. 
```

## Windows Form App
Launch the .exe without passing any argument. It can checke if the hash value for specified file matches with the expected hash value.

## Reference
Tools for calculating the hash from Windows  
```certutil.exe -hashfile C:\file.text SHA512```