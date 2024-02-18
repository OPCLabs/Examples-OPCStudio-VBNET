
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

' ReSharper disable CheckNamespace
Namespace SymbolFactoryDemo
    ' ReSharper restore CheckNamespace

    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        ' ReSharper disable InconsistentNaming
        Private Sub richTextBox1_LinkClicked(ByVal sender As Object, ByVal e As LinkClickedEventArgs) Handles richTextBox1.LinkClicked
            ' ReSharper restore InconsistentNaming
            Process.Start(e.LinkText)
        End Sub
    End Class
End Namespace
