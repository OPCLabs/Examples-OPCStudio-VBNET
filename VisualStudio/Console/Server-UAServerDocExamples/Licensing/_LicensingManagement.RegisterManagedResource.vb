﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable ArrangeModifiersOrder
' ReSharper disable InconsistentNaming
' ReSharper disable LocalizableElement
' ReSharper disable PossibleNullReferenceException
#Region "Example"
' Shows how to register a license located in an embedded managed resource.
' You can use any OPC UA client, including our Connectivity Explorer and OpcCmd utility, to connect to the server. 
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports System.Reflection
Imports OpcLabs.EasyOpc.UA

Namespace Licensing
    Partial Friend Class _LicensingManagement
        Shared Sub RegisterManagedResource()
            ' Register a license that is we embed as a managed resource in this program.

            ' The first two arguments should always be "OPCWizard" and "Multipurpose".
            ' The third argument determines the assembly where the license resides.
            ' The fourth argument is the namespace-qualified name of the managed resource, or a pattern identifying it.
            ' We could use precise "Key-DemoOrTrial-WebForm-1995003302-20240717.txt" instead.
            OpcLabs.BaseLib.ComponentModel.LicensingManagement.Instance.RegisterManagedResource("OPCWizard", "Multipurpose",
                Assembly.GetExecutingAssembly(), "*.Key-*.*")

            ' Instantiate the server object, obtain the serial number from the license info, and display the serial number.
            Dim server = New EasyUAServer()
            Dim serialNumber As Long = CUInt(server.LicenseInfo("Multipurpose.SerialNumber"))
            Console.WriteLine("SerialNumber: {0}", serialNumber)

            ' The license we ship for this purpose is a trial license with low runtime limit, so it won't be of much use.
            ' But you get the point...
        End Sub
    End Class
End Namespace
#End Region

