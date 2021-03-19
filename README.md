# Code Snippets (Python)

### Glob
    import glob
    for g in glob.glob("/dev/tty.usbmodem*"):
        print(g)
        
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
