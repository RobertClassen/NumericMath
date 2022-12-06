@echo off
( type Doxyfile.doxygen & type Settings.txt ) | doxygen.exe -
::PAUSE