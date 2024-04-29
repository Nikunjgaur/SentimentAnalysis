@echo off

set "PYTHON_VERSION=3.12.0"
set "PYTHON_INSTALLER=python-%PYTHON_VERSION%-amd64.exe"
set "PYTHON_URL=https://www.python.org/ftp/python/%PYTHON_VERSION%/%PYTHON_INSTALLER%"

echo Downloading Python %PYTHON_VERSION% installer...
curl -o "%PYTHON_INSTALLER%" "%PYTHON_URL%"

echo Installing Python %PYTHON_VERSION%...
start /wait "" "%PYTHON_INSTALLER%" /quiet InstallAllUsers=1 PrependPath=1

echo Python installation completed.

if exist myenv rmdir /s /q myenv
python -m venv myenv
call myenv\Scripts\activate
pip install -r requirements.txt
python app.py

pause
