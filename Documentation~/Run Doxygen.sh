#!/bin/bash
( cat Doxyfile.doxygen; cat Settings.txt ) | doxygen -
#$SHELL