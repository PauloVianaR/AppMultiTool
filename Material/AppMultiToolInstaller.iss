[Setup]
AppName=AppMultiTool
AppVersion=1.0
AppPublisher=Paulo Viana
DefaultDirName={pf}\AppMultiTool
DefaultGroupName=AppMultiTool
DisableDirPage=no
OutputDir=D:\PROJETOS PROG HD\AppMultiTool\Instalador
OutputBaseFilename=AppMultiToolSetup
SetupIconFile=D:\PROJETOS PROG HD\AppMultiTool\AppMultiTool\Material\toolbox_repair_box_tool_box_toolboxes_toolkit_icon_189326.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern
PrivilegesRequired=admin
ArchitecturesInstallIn64BitMode=x64

[Languages]
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"

[Tasks]
Name: "desktopicon"; Description: "Criar atalho na área de trabalho"; GroupDescription: "Opções adicionais:"

[Files]
Source: "D:\PROJETOS PROG HD\AppMultiTool\AppMultiTool\bin\Release\net8.0-windows\win-x64\publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{group}\AppMultiTool"; Filename: "{app}\AppMultiTool.exe"; IconFilename: "D:\PROJETOS PROG HD\AppMultiTool\AppMultiTool\Material\toolbox_repair_box_tool_box_toolboxes_toolkit_icon_189326.ico"
Name: "{commondesktop}\AppMultiTool"; Filename: "{app}\AppMultiTool.exe"; Tasks: desktopicon; IconFilename: "D:\PROJETOS PROG HD\AppMultiTool\AppMultiTool\Material\toolbox_repair_box_tool_box_toolboxes_toolkit_icon_189326.ico"

[Run]
Filename: "{app}\AppMultiTool.exe"; Description: "Executar AppMultiTool agora"; Flags: nowait postinstall skipifsilent