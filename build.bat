@echo off

IF NOT EXIST build (
echo Creating build folder
mkdir build
)

cd build
del /Q *.msi
del /Q *.zip

IF NOT EXIST JavLuv (
echo Creating JavLuv folder
mkdir JavLuv
)

cd ../src/

MSBuild JavLuv.sln -t:build -restore -p:RestorePackagesConfig=true /p:Configuration=Release && (
  echo JavLuv Release build succeeded
) || (
  echo Release build failed
  EXIT /B 1
)

@REM cd ../setup/
@REM MSBuild Setup.sln /p:Configuration=Release && (
@REM   echo JavLuv Setup build succeeded
@REM ) || (
@REM   echo JavLuv Setup build failed
@REM   EXIT /B 1
@REM )

cd ..

@REM copy /y "setup\bin\Release\Setup-JavLuv.msi" "build\Setup-JavLuv.msi" && (
@REM   echo Copied setup file to build folder
@REM ) || (
@REM   echo JavLuv Setup copy failed
@REM   EXIT /B 1
@REM )

copy /y "src\JavLuv\bin\x64\Release\*.dll" "build\JavLuv\"
copy /y "src\JavLuv\bin\x64\Release\*.exe" "build\JavLuv\"
copy /y "src\JavLuv\bin\x64\Release\JavLuv.exe.config" "build\JavLuv\"
copy /y "src\JavLuv\bin\x64\Release\Core14.profile.xml" "build\JavLuv\"
copy /y "src\JavLuv\bin\x64\Release\runtimes\win-x64\native\WebView2Loader.dll" "build\JavLuv\WebView2Loader.dll"

@REM cd build

@REM @for /f "tokens=* usebackq" %%f in (`git tag --sort=committerdate`) do @set "tag=%%f"

@REM set JavLuv=JavLuv-%tag%

@REM rename JavLuv %JavLuv%
@REM rename "Setup-JavLuv.msi" "Setup-%JavLuv%.msi"

@REM tar -a -c -f %JavLuv%.zip %JavLuv%  && (
@REM   echo Copied setup file to build folder
@REM ) || (
@REM   echo JavLuv tar archive failed
@REM   EXIT /B 1
@REM )

@REM del /s /q %JavLuv%
@REM rmdir /s /q %JavLuv%

@REM cd ..

EXIT /B 0
