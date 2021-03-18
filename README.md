# Code Snippets (all languages)

## Python

### Glob
    import glob
    for g in glob.glob("/dev/tty.usbmodem*"):
        print(g)
        
### Timeit
This code calls a function named getpumps() 1000 times and displays the time taken in seconds

    import timeit
    print( timeit.timeit(stmt=findpumps.getpumps, number=1000) )

### Watchdog
Python API library and shell utilities to monitor file system events.
https://python-watchdog.readthedocs.io/en/v0.10.3/

