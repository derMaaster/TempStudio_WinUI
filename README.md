# TempStudio_WinUI
An attempt to "port" a Windows Visual Studio created Template Studio WinUI app to a Debian based Uno-Platform WinUI app with as little as possible changes.

 TempStudio_WinUI
Attemp to "port" a Template Studio WinUI app from Windows PC and Visual Studio 22 to Debian VS Code with Uno Platform


I don't want to (don't know if I can) reinvent the wheel in terms of navigation. Therefore I am trying to port a Windows based, Visual Studio 22
Template Studio WinUI application example to a Debian based VSCode with the Uno Platform.

Steps:

On Windows PC - selection for new Template Studio WinUI app:
  MVVM
  Main Page plus List Details Page

On Debian PC - Create WinUI skia uno platform app:
  dotnet new unoapp -o TempStudio_WinUI -wasm=false -wpm=false -mobile=false -sw=false -slf=false -vs=true

Create GitHub repo and first commit.

Added <EnableWindowsTargeting>true</EnableWindowsTargeting>  to TempStudio_WinUI.Windows.csproj
Select TempStudio_WinUI.Skia.Gtk as the startup project.

In TempStudio_WinUI:
	Delete the "Debug (Chrome, WebAssembly)" configuration in launch.json
	Change net6.0 to net7.0 in launch.json for the "program" detail.
	Launch the app - the Hello World window loads correctly.  - commit.

 Copy folders from base project (Windows created template project, ignoring the .core project) to the Debian based application, into the TempStudio_WinUI project folder:
   	Views
    ViewModels
    Services
    Styles
    Helpers
    Contracts
    Behaviors
    Assets
    Activation

 Copied in folders from the TempStudio.WinUI.core project for references
 	Services
 	Models
 	Contracts


 Install Nuget Packages:
 	CommunityToolkit.Mvvm.ComponentModel
	CommunityToolkit.WinUI.UI.Controls --version 7.1.2
	Uno.CommunityToolkit.WinUI.UI.Behaviors  - the non Uno version is incompatible with all frameworks in the project.
		This is in order to use the namespace - Microsoft.Xaml.Interactivity;
	Uno.CommunityToolkit.WinUI.UI.Control
	Newtonsoft.Json


 Add missing using statements.
 Modified with App.cs file.
 Delete original MainPage.xaml and Mainpage.xaml.cs

 Problems remaining:

 Commented out in ShellPage.xaml.cs:
 	App.MainWindow.Activated += MainWindow_Activated;
	As well as the void MainWindow_Activated - Uno extension of and Microsoft.UI.Xaml.WindowActivatedEventArgs differs significantly it seems.
