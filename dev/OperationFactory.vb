Public Class OperationFactory
    Implements IOperationFactory

    Public Function createOperation(ByVal operation As String, ByVal bouser As String, ByVal bopass As String, ByVal borep As String, ByVal tpident As String,
                                    ByVal cmTechPack As Boolean, ByVal baseident As String, ByVal outputFolder As String,
                                    ByVal eniqConn As String, ByVal boVersion As String, ByVal boAut As String,
                                    ByVal domain As String, ByVal universe As String, ByVal inputFolder As String) As AbstractOperation Implements IOperationFactory.createOperation
        Dim newOperation As AbstractOperation = Nothing
        If (operation = "createUnv") Then
            newOperation = New CreateUnvOp("Create Universe", bouser, bopass, borep, tpident, False, baseident, outputFolder, eniqConn,
                                           boVersion, boAut, domain, universe)
        ElseIf (operation = "updateUnv") Then
            newOperation = New UpdateUnvOp("Update Universe", bouser, bopass, borep, tpident, False, baseident, outputFolder, eniqConn,
                                           boVersion, boAut, domain, universe, False)
        ElseIf (operation = "updateEbsUnv") Then
            newOperation = New UpdateUnvOp("Update EBS Universe", bouser, bopass, borep, tpident, False, baseident, outputFolder, eniqConn,
                                           boVersion, boAut, domain, universe, True)
        ElseIf (operation = "createDoc") Then
            newOperation = New CreateDocOp("Create Universe Reference Document", bouser, bopass, borep, tpident, False, baseident, outputFolder,
                                           eniqConn, boVersion, boAut, domain, universe)
        ElseIf (operation = "listDomain") Then
            newOperation = New GetDomainListOp("Get Repository Domain List", bouser, bopass, borep, tpident, False, baseident, outputFolder,
                                                 eniqConn, boVersion, boAut, domain, universe)
        ElseIf (operation = "listUniverses") Then
            newOperation = New GetDomainUnvListOp("Get Domain Universe List", bouser, bopass, borep, tpident, False, baseident, outputFolder,
                                                 eniqConn, boVersion, boAut, domain, universe)
        ElseIf (operation = "listContext") Then
            newOperation = New ListUniversesOp("List contexts", bouser, bopass, borep, tpident, False, baseident, outputFolder,
                                                 eniqConn, boVersion, boAut, domain, universe)
        ElseIf (operation = "createUnvOffline") Then
            newOperation = New CreateUnvOfflineOp("Create Universe Offline", bouser, bopass, borep, tpident, False, baseident, outputFolder,
                                                 eniqConn, boVersion, boAut, domain, universe, inputFolder)
        ElseIf (operation = "updateUnvOffline") Then
            newOperation = New UpdateUnvOfflineOp("Update Universe Offline", bouser, bopass, borep, tpident, False, baseident, outputFolder,
                                                 eniqConn, boVersion, boAut, domain, universe, inputFolder)
        ElseIf (operation = "createDocOffline") Then
            newOperation = New CreateDocOfflineOp("Create Universe Reference Document Offline", bouser, bopass, borep, tpident, False, baseident, outputFolder,
                                           eniqConn, boVersion, boAut, domain, universe)
        Else
            Throw New Exception("Unknown command: " & operation)
        End If
        Return newOperation
    End Function

End Class

