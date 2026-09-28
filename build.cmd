@echo off
setlocal enabledelayedexpansion

set ROOT=%~dp0

if "%CI%"=="true" (
    set BUILD_CONFIG=Release
) else (
    set BUILD_CONFIG=Debug
)

echo === Building Zaya.UI (%BUILD_CONFIG%) ===

dotnet build "%ROOT%Zaya.UI.sln" -c %BUILD_CONFIG%
if %ERRORLEVEL% neq 0 exit /b %ERRORLEVEL%

echo === Detecting versions ===

for /f "usebackq delims=" %%a in (`dotnet msbuild "%ROOT%src\Zaya.UI.Impl\Zaya.UI.Impl.csproj" -getProperty:Version -nologo -v:q`) do set VER=%%a
set VER=!VER: =!

echo   Impl=!VER!

echo === Preparing output directory ===

rmdir /s /q "%ROOT%out" 2>nul
mkdir "%ROOT%out" 2>nul

echo !VER!>"%ROOT%out\version.txt"

echo === Packing NuGet packages ===

dotnet pack "%ROOT%src\Zaya.UI.Impl\Zaya.UI.Impl.csproj" -c %BUILD_CONFIG% -o "%ROOT%out" --no-build
if %ERRORLEVEL% neq 0 exit /b %ERRORLEVEL%

echo === Done: !VER! ===
