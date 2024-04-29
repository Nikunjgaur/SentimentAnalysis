@echo off


if exist myenv rmdir /s /q myenv

python -m venv myenv
call myenv\Scripts\activate
pip install -r requirements.txt
python training.py

pause
