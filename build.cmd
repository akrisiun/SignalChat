@REM nuget restore LetsChat.sln

msbuild /v:m LetsChat.sln
del src\bin\*.xml

@PAUSE