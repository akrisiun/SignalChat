@ECHO http://localhost:8080
set dir=%~dp0chat

"%ProgramFiles%\IIS Express\IISExpress.exe" /port:8080 /path:%dir% /clr:4.0 /systray:true

@PAUSE