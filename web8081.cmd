@ECHO http://localhost:8081
set dir=%~dp0src

"%ProgramFiles%\IIS Express\IISExpress.exe" /port:8081 /path:%dir% /clr:4.0 /systray:true

@PAUSE