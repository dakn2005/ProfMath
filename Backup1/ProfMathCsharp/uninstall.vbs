'Another way 
'from
'http://forums.devarticles.com/net-development-43/create-an-uninstall-7599.html
Dim shell, systempath

set shell = WScript.CreateObject( "WScript.Shell" )

systempath = shell.ExpandEnvironmentStrings("%SystemRoot%")

shell.Run Chr(34) & systempath & "\system32\msiexec.exe" & Chr(34) & "  /x{E5000FDC-1548-4107-B332-2D3459436038}"

''x{PRODUCT CODE HERE} 

WScript.Quit