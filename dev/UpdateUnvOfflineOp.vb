''
'Updates a universe.
'
Public Class UpdateUnvOfflineOp
    Inherits AbstractOperation

    Dim InputDir As String = ""
    Public Sub New(ByVal operationName As String, ByVal bouser As String, ByVal bopass As String, ByVal borep As String,
                   ByVal tpident As String, ByVal cmTechPack As Boolean, ByVal baseident As String, ByVal outputFolder As String,
                   ByVal eniqConn As String, ByVal boVersion As String, ByVal boAut As String, ByVal domain As String,
                   ByVal universe As String, ByVal inputDir As String)
        MyBase.New(operationName, bouser, bopass, borep, tpident, cmTechPack, baseident, outputFolder, eniqConn, boVersion, boAut, universe, domain)
        Me.InputDir = inputDir
    End Sub

    Public Overrides Function cleanup() As Boolean
        MyBase.universeFunctions.cleanup()
        MyBase.universeFunctions = Nothing
    End Function

    Public Overrides Function doOperation() As Boolean
        Dim success As Boolean = False
        Trace.WriteLine("Starting universe update")
        success = MyBase.universeFunctions.UpdateUniverse(m_tpident, m_baseident, m_outputFolder, InputDir, m_eniqConn)
        Return success
    End Function
End Class
