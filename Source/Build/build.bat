del .\Output\Vanguard.zip
del .\Output\Vanguard /Q
mkdir .\Output
mkdir .\Output\Vanguard
mkdir .\Output\Vanguard\lib
mkdir .\Output\Vanguard\lib\net20
mkdir .\Output\Vanguard\lib\net35
mkdir .\Output\Vanguard\lib\net40
mkdir .\Output\Vanguard\lib\net45
mkdir ".\Output\Vanguard\lib\portable-net4+sl5+wp8+win8"

copy ..\Vanguard.Net20\bin\Release\Vanguard.dll .\Output\Vanguard\lib\net20
copy ..\Vanguard.Net20\bin\Release\Vanguard.pdb .\Output\Vanguard\lib\net20
copy ..\Vanguard.Net20\bin\Release\Vanguard.xml .\Output\Vanguard\lib\net20

copy ..\Vanguard.Net35\bin\Release\Vanguard.dll .\Output\Vanguard\lib\net35
copy ..\Vanguard.Net35\bin\Release\Vanguard.pdb .\Output\Vanguard\lib\net35
copy ..\Vanguard.Net35\bin\Release\Vanguard.xml .\Output\Vanguard\lib\net35

copy ..\Vanguard.Net40\bin\Release\Vanguard.dll .\Output\Vanguard\lib\net40
copy ..\Vanguard.Net40\bin\Release\Vanguard.pdb .\Output\Vanguard\lib\net40
copy ..\Vanguard.Net40\bin\Release\Vanguard.xml .\Output\Vanguard\lib\net40

copy ..\Vanguard.Net45\bin\Release\Vanguard.dll .\Output\Vanguard\lib\net45
copy ..\Vanguard.Net45\bin\Release\Vanguard.pdb .\Output\Vanguard\lib\net45
copy ..\Vanguard.Net45\bin\Release\Vanguard.xml .\Output\Vanguard\lib\net45

copy ..\Vanguard.Portable\bin\Release\Vanguard.dll ".\Output\Vanguard\lib\portable-net4+sl5+wp8+win8"
copy ..\Vanguard.Portable\bin\Release\Vanguard.pdb ".\Output\Vanguard\lib\portable-net4+sl5+wp8+win8"
copy ..\Vanguard.Portable\bin\Release\Vanguard.xml ".\Output\Vanguard\lib\portable-net4+sl5+wp8+win8"


"c:\Program Files\7-Zip\7z.exe" a -tzip -r .\Output\Vanguard.zip .\Output\Vanguard\*.*