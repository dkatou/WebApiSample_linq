@echo off
setlocal
set OPENCOVER="%USERPROFILE%\.nuget\packages\opencover\4.7.922\tools\OpenCover.Console.exe"
set TARGET="dotnet.exe"
set TARGET_TEST="test --logger:\"console;verbosity=detailed\""
set OUTPUT="coverage.xml"
set FILTERS="+[*]*"

@echo on
%OPENCOVER% -register:user -target:%TARGET% -targetargs:%TARGET_TEST% -filter:%FILTERS% -oldstyle -output:%OUTPUT% > TestResult.txt

@echo off
endlocal