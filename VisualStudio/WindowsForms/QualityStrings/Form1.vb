﻿
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess

Public Class Form1

    ' ReSharper disable InconsistentNaming
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        ' ReSharper restore InconsistentNaming

        'define the quality codes that we want to run thru our function as a test
        Dim qualityTests() As Integer = New Integer() {0, 10, 50, 64, 100, 128, 150, 192, 210}

        'now test each of the quality codes defined above
        For Each qualityTest As Integer In qualityTests
            ListBox1.Items.Add(New DAQuality(qualityTest))
        Next
    End Sub
End Class
