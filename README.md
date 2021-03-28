# Code Snippets (Python)

Last updated: Mar 2021



### Python Naming Convention
The style guide for Python is based on [Guido’s ](https://www.python.org/doc/essays/styleguide/)naming convention recommendations. List of covered sections:

* [Class Naming](../python/class-naming.md)
* [Constant Naming](../python/constant-naming.md)
* [Method Naming](../python/method-naming.md)
* [Module Naming](../python/module-naming.md)
* [Variable Naming](../python/variable-naming.md)
* [Package Naming](../python/package-naming.md "Python Package Naming")
* [Exception Naming](../python/exception-naming.md)
* [Underscore](../python/underscore.md)

#### TL;DR

| Type | Public | Internal |
| :--- | :--- | :--- |
| Packages | `lower_with_under` |  |
| Modules | `lower_with_under` | `_lower_with_under` |
| Classes | `CapWords` | `_CapWords` |
| Exceptions | `CapWords` |  |
| Functions | `lower_with_under()` | `_lower_with_under()` |
| Global/Class Constants | `CAPS_WITH_UNDER` | `_CAPS_WITH_UNDER` |
| Global/Class Variables | `lower_with_under` | `_lower_with_under` |
| Instance Variables | `lower_with_under` | `_lower_with_under` |
| Method Names | `lower_with_under()` | `_lower_with_under()` |
| Function/Method Parameters | `lower_with_under` |  |
| Local Variables | `lower_with_under` |  |

### Glob
    import glob
    for g in glob.glob("/dev/tty.usbmodem*"):
        print(g)

### SubStrings
    if 'some_text' in some_string:
        do_something

    if ('some_text' and 'some_more_text') in some_string:
        do_something

### Timeit
This code calls a function named getpumps() 1000 times and displays the time taken in seconds

    import timeit
    print( timeit.timeit(stmt=findpumps.getpumps, number=1000) )

### Time and sleep
    import time
    while True:
        print("This prints once a minute.")
        time.sleep(60) # Delay for 1 minute (60 seconds).

### Watchdog
A cross-platform Python API library and shell utilities to monitor file system events.
https://python-watchdog.readthedocs.io/en/v0.10.3/

### Pyserial
The following command should get a list of ports (https://pyserial.readthedocs.io/en/stable/tools.html)

    python -m serial.tools.list_ports

### Listing available serial ports

    https://stackoverflow.com/questions/12090503/listing-available-com-ports-with-python

### Returning values from functions
If Return is missing, None will be returned by default.

    def return_none_explicitly():
        return None
        
Can Return multiple values.

    def return_multiple():
        return sample1, sample2, sample3

### Exit-ing from a script with a message
https://stackoverflow.com/questions/22633544/how-to-throw-error-and-exit-with-a-custom-message-in-python

    import sys
    sys.exit('Exited because your operating system is not supported.')

### Useful pip commands

    * pip search package
    * pip install package
    * pip install package requests==2.6.0 (install specific package version)
    * pip uninstall package
    * pip freeze package
    * pip upgrade package
    * pip show package
    * pip list package

### Setting up a Python PyQt development environment
* install Python into C:\PythonX.X (not the hideous long path suggested by the installer)
    * Make sure the installer adds the folder above to the path

* Create environments to work in. Use the following to create an environment inside folder_name:

    python -m venv folder_name 

To activate the environment, use the following:

    folder_name\scripts\activate.bat  (Windows)
    source folder_name/bin/activate   (Mac and Linux)     <<< need to test this >>>

Now that we are working within an environment, install environment specific tools:

    pip install PyQt5
    pip install PyQt5Designer          GUI designer for Qt
    pip install pyinstaller            makes platform specific executables fom .py files

To convert PyQt Designer .ui files into .py files, use:

    pyuic5 -x filename.ui -o filename.py

To convert .py files into an executable file (destination = dist folder), use:

    pyinstaller --onefile filename.py
