' ReSharper disable RedundantQualifier
#If _MyType <> "Empty" Then

Namespace My
    ''' <summary>
    ''' Module used to define the properties that are available in the My Namespace for Web projects.
    ''' </summary>
    ''' <remarks></remarks>
    <Global.Microsoft.VisualBasic.HideModuleName()> _
    Module MyWebExtension
        Private ReadOnly SComputer As New ThreadSafeObjectProvider(Of Global.Microsoft.VisualBasic.Devices.ServerComputer)
        Private ReadOnly SUser As New ThreadSafeObjectProvider(Of Global.Microsoft.VisualBasic.ApplicationServices.WebUser)
        Private ReadOnly SLog As New ThreadSafeObjectProvider(Of Global.Microsoft.VisualBasic.Logging.AspLog)
        ''' <summary>
        ''' Returns information about the host computer.
        ''' </summary>
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
        Friend ReadOnly Property Computer() As Global.Microsoft.VisualBasic.Devices.ServerComputer
            Get
                Return SComputer.GetInstance()
            End Get
        End Property
        ''' <summary>
        ''' Returns information for the current Web user.
        ''' </summary>
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
        Friend ReadOnly Property User() As Global.Microsoft.VisualBasic.ApplicationServices.WebUser
            Get
                Return SUser.GetInstance()
            End Get
        End Property
        ''' <summary>
        ''' Returns Request object.
        ''' </summary>
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
        <Global.System.ComponentModel.Design.HelpKeyword("My.Request")> _
        Friend ReadOnly Property Request() As Global.System.Web.HttpRequest
            <Global.System.Diagnostics.DebuggerHidden()> _
            Get
                Dim currentContext As Global.System.Web.HttpContext = Global.System.Web.HttpContext.Current
                If currentContext IsNot Nothing Then
                    Return currentContext.Request
                End If
                Return Nothing
            End Get
        End Property
        ''' <summary>
        ''' Returns Response object.
        ''' </summary>
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
         <Global.System.ComponentModel.Design.HelpKeyword("My.Response")> _
         Friend ReadOnly Property Response() As Global.System.Web.HttpResponse
            <Global.System.Diagnostics.DebuggerHidden()> _
            Get
                Dim currentContext As Global.System.Web.HttpContext = Global.System.Web.HttpContext.Current
                If currentContext IsNot Nothing Then
                    Return currentContext.Response
                End If
                Return Nothing
            End Get
        End Property
        ''' <summary>
        ''' Returns the Asp log object.
        ''' </summary>
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
        Friend ReadOnly Property Log() As Global.Microsoft.VisualBasic.Logging.AspLog
            Get
                Return SLog.GetInstance()
            End Get
        End Property
    End Module
End Namespace

#End If
' ReSharper restore RedundantQualifier
