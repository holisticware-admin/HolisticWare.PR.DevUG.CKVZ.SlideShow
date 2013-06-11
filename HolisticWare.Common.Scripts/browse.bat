@echo off


@echo off

set BROWSER="%PROGRAMFILES%\Google\Chrome\Application\chrome.exe"

%BROWSER% ^
	-new-window ^
	http://holisticware.net/HolisticWare/Know-How/development/multitargeting-portability-interoperability/Presentations.aspx ^
	http://mono-aspnet-mvc4-aws.holisticware.org/ ^
	http://mono-aspnet-mvc4-aws.holisticware.org/WebServiceFileUploader.asmx ^
	http://holisticware-ft-compositec1.ironfoundry.me/holisticware/layout/presentations/reveal-js/ ^
	http://127.0.0.1:8080/ ^
	http://127.0.0.1:8080/WebServiceFileUploader.asmx ^



echo ===========================================================================================

@IF %ERRORLEVEL% NEQ 0 PAUSE	

:: "%PROGRAMFILES%\Mono-3.0.10\bin\xsp4.bat"

