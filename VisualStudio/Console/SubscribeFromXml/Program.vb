
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports System.Threading
Imports System.Xml
Imports System.Xml.Serialization
Imports OpcLabs.BaseLib.Runtime.InteropServices
Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.DataAccess.OperationModel


Friend Class Program
    Shared WithEvents _client As New EasyDAClient

    <MTAThread> ' needed for COM security initialization to succeed
    Shared Sub Main()
        ComManagement.Instance.AssureSecurityInitialization()

        Console.WriteLine("Loading items from XML file...")
        Dim xmlSerializer = New XmlSerializer(GetType(DAItemGroupArguments()))
        Dim xmlReader = Xml.XmlReader.Create("OpcItems.xml", New XmlReaderSettings With {.IgnoreWhitespace = True})
        Dim argArray = CType(xmlSerializer.Deserialize(xmlReader), DAItemGroupArguments())

        If argArray IsNot Nothing Then
            Console.WriteLine("Subscribing for 30 seconds...")
            _client.SubscribeMultipleItems(argArray)
            Thread.Sleep(30 * 1000)

            Console.WriteLine("Unsubscribing...")
            _client.UnsubscribeAllItems()
        End If

        Console.WriteLine("Finished.")
    End Sub

    Private Shared Sub ItemChanged(ByVal sender As Object, ByVal eventArgs As EasyDAItemChangedEventArgs) Handles _client.ItemChanged
        Console.WriteLine("{0}: {1}", eventArgs.Arguments.ItemDescriptor.ItemId, eventArgs.Vtq)
    End Sub
End Class