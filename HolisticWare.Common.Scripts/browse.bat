@echo off


@echo off

set BROWSER="%PROGRAMFILES%\Google\Chrome\Application\chrome.exe"

%BROWSER% ^
	-new-window ^
	http://holisticware.net/HolisticWare/Know-How/development/multitargeting-portability-interoperability/Presentations.aspx ^
	http://mono-aspnet-mvc4-aws.holisticware.org/ ^
	http://mono-aspnet-mvc4-aws.holisticware.org/WebServiceFileUploader.asmx ^
	http://holisticware-ft-compositec1.ironfoundry.me/holisticware/layout/presentations/reveal-js/ ^





echo ===========================================================================================

@IF %ERRORLEVEL% NEQ 0 PAUSE	


