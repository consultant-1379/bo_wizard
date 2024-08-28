Imports TPIdeUniverseWizard

Friend Class CreateDocOfflineOp
    Inherits AbstractOperation

    Private docFunctions As DocumentFunctionsTPIde

    Public Sub New(operationName As String, bouser As String, bopass As String, borep As String, tpident As String, cmTechPack As String, baseident As String, outputFolder As String, eniqConn As String, boVersion As String, boAut As String, domain As String, universe As String)
        MyBase.New(operationName, bouser, bopass, borep, tpident, cmTechPack, baseident, outputFolder, eniqConn, boVersion, boAut, domain, universe)
        docFunctions = New DocumentFunctionsTPIde(New TPUtilitiesTPIde(), New UniverseDocumentWriter(tpident))
    End Sub

    Public Overrides Function cleanup() As Boolean
        docFunctions = Nothing
    End Function

    Public Overrides Function doOperation() As Boolean
        Dim success As Boolean = False
        success = docFunctions.GenerateTechPackProductReference(m_tpident, m_outputFolder, m_cmTechPack)
        Return success
    End Function

End Class
