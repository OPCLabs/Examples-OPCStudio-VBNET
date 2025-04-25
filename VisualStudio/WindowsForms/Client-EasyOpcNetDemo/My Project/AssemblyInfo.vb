' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
Imports System.Reflection
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("EasyOPC-DA.NET Demo")>
<Assembly: AssemblyDescription("This demo is written in .NET, and it shows how to use the component to work with OPC DA servers. It allows reading and writing items, subscriptions to items, and getting item properties. It also shows the user interface for browsing machines, OPC servers, OPC items and OPC properties.")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("CODE Consulting and Development, s.r.o.")>
<Assembly: AssemblyProduct("QuickOPC.NET")>
<Assembly: AssemblyCopyright("© 2006-2022 CODE Consulting and Development, s.r.o., Plzen. All rights reserved.")>
<Assembly: AssemblyTrademark("OPC Labs")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("bfcf780a-48ed-4ec5-bd44-0d153a17d7d6")>

<Assembly: Resources.NeutralResourcesLanguageAttribute("en-US")>

#If Not NETFRAMEWORK Then
<Assembly: System.Runtime.Versioning.SupportedOSPlatform("windows")>
#End If
