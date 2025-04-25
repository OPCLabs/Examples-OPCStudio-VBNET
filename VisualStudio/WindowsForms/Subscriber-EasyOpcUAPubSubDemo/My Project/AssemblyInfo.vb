' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.

' Review the values of the assembly attributes

<Assembly: AssemblyTitle("EasyOPC-UA PubSub Demo")>
<Assembly: AssemblyDescription("This demo is written in .NET, and it shows how to use the component to act as OPC UA PubSub subscriber. It allows subscribing to various predefined datasets. It also allows the user to specify custom settings for the PubSub subscription.")>
<Assembly: AssemblyCompany("CODE Consulting and Development, s.r.o.")>
<Assembly: AssemblyProduct("QuickOPC-UA")>
<Assembly: AssemblyCopyright("© 2020-2022 CODE Consulting and Development, s.r.o., Plzen. All rights reserved.")>
<Assembly: AssemblyTrademark("OPC Labs")>

<Assembly: ComVisible(False)>

'The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("9e2b400d-805a-4689-b731-5dd2d0c3612a")>

#If Not NETFRAMEWORK Then
<Assembly: System.Runtime.Versioning.SupportedOSPlatform("windows")>
#End If
