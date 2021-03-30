echo OFF
echo Windows venv creator will create a Python virtual environment (venv) and install a list of Python packages in that venv. After each package is installed, the installer will pause awaiting a keypress. This will enable you to check the install details as it progresses.

First, install Python (suggested location is C:\)
Second, make sure you are in the root of the folder you want to work from. 

pause

echo creating Python venv
python -m venv venv

pause

echo Activating venv
venv\Scripts\activate.bat

pause