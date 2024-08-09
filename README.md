# C# Code Execution through Python Mediator

## Overview

This project facilitates the execution of C# code by acting as a mediator between the Python environment and the .NET runtime. It uses a Flask-based Python application to compile and run C# code provided by users. The project demonstrates the seamless integration of different technologies to execute and manage .NET code within a Python-driven workflow.

## Features

- **C# Code Compilation**: Compiles C# code using the `dotnet` CLI.
- **Execution Management**: Runs the compiled C# code and captures the output.
- **Flexible Input Handling**: Allows users to provide various C# scripts for execution.
- **Web Interface**: (Optional) A simple web interface using Flask where users can input their C# code and see the results.

## Requirements

- **Python 3.9.7** (or compatible version)
- **.NET SDK** (to compile and run C# code)
- **Flask** (if using the web interface)

Make sure the .NET SDK is installed on your system. You can download it from the official .NET website:

- [Download .NET SDK](https://dotnet.microsoft.com/download)

