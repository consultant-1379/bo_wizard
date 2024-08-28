Option Strict Off

''
'  ReportObjects class is a collection of ReportObject classes
'
Public Class ReportObjectsTPIde
    Private _reportobjects As System.Collections.ArrayList = New System.Collections.ArrayList

    ''
    '  Gets count of ReportObject classes in ReportObjects class
    '
    ' @param Index Specifies the index in the ReportObjects class
    ' @return Count of ReportObject classes
    Public ReadOnly Property Count() As Integer
        Get
            If (Not _reportobjects Is Nothing) Then
                Return _reportobjects.Count
            End If
            Return 0
        End Get
    End Property

    ''
    '  Gets ReportObject class from ReportObjects class based on given index.
    '
    ' @param Index Specifies the index in the ReportObjects class
    ' @return Reference to ReportObject
    Public ReadOnly Property Item(ByVal Index As Integer) As ReportObject
        Get
            If (Index > 0) And (Index <= Me.Count) Then
                Return CType(_reportobjects.Item(Index - 1), ReportObject)
            End If
            Return Nothing
        End Get
    End Property

    ''
    '  Adds ReportObject class to ReportObjects class
    '
    ' @param ValueIn Specifies reference to ReportObject
    Public Sub AddItem(ByVal ValueIn As ReportObject)

        If (Not _reportobjects Is Nothing) Then
            _reportobjects.Add(ValueIn)
        End If

    End Sub

    ''
    '  ReportObject defines report objects.
    '
    Public Class ReportObject
        Private m_MeasurementTypeID As String
        Private m_Level As String
        Private m_ObjectClass As String
        Private m_Name As String

        ''
        ' Gets and sets value for MeasurementTypeID parameter. 
        ' MeasurementTypeID defines measurement type.
        '
        ' @param Value Specifies value of MeasurementTypeID parameter
        ' @return Value of MeasurementTypeID parameter
        Public Property MeasurementTypeID()
            Get
                MeasurementTypeID = m_MeasurementTypeID
            End Get

            Set(ByVal Value)
                m_MeasurementTypeID = Value
            End Set

        End Property

        ''
        ' Gets and sets value for Level parameter. 
        ' Level defines measurement level.
        '
        ' @param Value Specifies value of Level parameter
        ' @return Value of Level parameter
        Public Property Level()
            Get
                Level = m_Level
            End Get

            Set(ByVal Value)
                m_Level = Value
            End Set

        End Property

        ''
        ' Gets and sets value for ObjectClass parameter. 
        ' ObjectClass defines object's class name.
        '
        ' @param Value Specifies value of ObjectClass parameter
        ' @return Value of ObjectClass parameter
        Public Property ObjectClass()
            Get
                ObjectClass = m_ObjectClass
            End Get

            Set(ByVal Value)
                m_ObjectClass = Value
            End Set

        End Property

        ''
        ' Gets and sets value for Name parameter. 
        ' Name defines object's name.
        '
        ' @param Value Specifies value of Name parameter
        ' @return Value of Name parameter
        Public Property Name()
            Get
                Name = m_Name
            End Get

            Set(ByVal Value)
                m_Name = Value
            End Set

        End Property
    End Class

    Public Sub getReportObjects(ByRef conn As System.Data.Odbc.OdbcConnection, ByRef dbCommand As System.Data.Odbc.OdbcCommand, _
                                ByRef dbReader As System.Data.Odbc.OdbcDataReader, ByRef TechPackTPIde As String)

        Dim indexes() As String
        Dim count As Integer
        Dim repobj As ReportObjectsTPIde.ReportObject
        Dim Row As Integer

        Row = 1

        Dim verobj As String
        'verobj = "SELECT SUBSTR(TARGETTABLE,1,8000),SUBSTR(TARGETTABLE,8001,8000),SUBSTR(TARGETTABLE,16001,8000),SUBSTR(TARGETTABLE,24001,8000)" & _
        '",LEVEL,CLASSNAME,OBJNAME FROM Verificationobject where VERSIONID ='" & TechPackTPIde & "'"

        verobj = "SELECT MEASTYPE,MEASLEVEL,OBJECTCLASS, OBJECTNAME FROM VerificationObject where VERSIONID ='" & TechPackTPIde & "'"


        dbCommand = New System.Data.Odbc.OdbcCommand(verobj, conn)

        Try
            If dbReader.IsClosed = False Then
                dbReader.Close()
            End If
            dbReader = dbCommand.ExecuteReader()
        Catch ex As Exception
            Trace.WriteLine("Database Exception: " & ex.ToString)
            Exit Sub
        End Try

        While (dbReader.Read())
            If dbReader.GetValue(0).ToString() = "" Then
                Exit While
            Else
                Row += 1
                repobj = New ReportObjectsTPIde.ReportObject
                If dbReader.IsDBNull(0) = False Then
                    'repobj.MeasurementTypeID = Trim(dbReader.GetString(0) + dbReader.GetString(1) + dbReader.GetString(2) + dbReader.GetString(3))
                    repobj.MeasurementTypeID = dbReader.GetValue(0).ToString()
                Else
                    repobj.MeasurementTypeID = ""
                End If
                'repobj.Level = dbReader.GetValue(4).ToString()
                repobj.Level = dbReader.GetValue(1).ToString()
                'repobj.ObjectClass = dbReader.GetValue(5).ToString()
                repobj.ObjectClass = dbReader.GetValue(2).ToString()
                'repobj.Name = dbReader.GetValue(6).ToString()
                repobj.Name = dbReader.GetValue(3).ToString()
                AddItem(repobj)
            End If
        End While
        dbReader.Close()
        dbCommand.Dispose()

    End Sub
End Class
