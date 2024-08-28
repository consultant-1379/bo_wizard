''
' Interface for OperationFactory. 
' Concrete implementation is OperationFactory but it can also be mocked for testing.
''
Public Interface IOperationFactory

    Function createOperation(ByVal operation As String, ByVal bouser As String, ByVal bopass As String, ByVal borep As String, ByVal tpident As String,
                                    ByVal cmTechPack As Boolean, ByVal baseident As String, ByVal outputFolder As String,
                                    ByVal eniqConn As String, ByVal boVersion As String, ByVal boAut As String,
                                    ByVal domain As String, ByVal universe As String, ByVal InputFolder As String) As AbstractOperation

End Interface
