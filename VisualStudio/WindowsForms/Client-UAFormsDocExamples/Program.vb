' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
Namespace UAFormsDocExamples
    ' ReSharper restore CheckNamespace

    Friend NotInheritable Class Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        Private Sub New()
        End Sub
        <MTAThread> ' needed for COM security initialization to succeed
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
            'System.Threading.Thread.Sleep(10 * 60 * 1000);
        End Sub
    End Class
End Namespace
