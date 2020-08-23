@echo off
setlocal
set REPORTGEN="%USERPROFILE%\.nuget\packages\reportgenerator\4.4.5\tools\netcoreapp3.0\ReportGenerator.exe"
set OUTPUT="coverage.xml"
set OUTPUT_DIR="Coverage"

@echo on
%REPORTGEN% -reports:%OUTPUT% -targetdir:%OUTPUT_DIR%

@echo off
endlocal