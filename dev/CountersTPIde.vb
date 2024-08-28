Option Strict Off
Imports System.IO

''
'  Counters class is a collection of Counter classes
'
Public NotInheritable Class CountersTPIde
    Private _counters As System.Collections.ArrayList = New System.Collections.ArrayList

    ''
    '  Gets count of Counter classes in Counters class
    '
    ' @param Index Specifies the index in the Counters class
    ' @return Count of Counter classes
    Public ReadOnly Property Count() As Integer
        Get
            If (Not _counters Is Nothing) Then
                Return _counters.Count
            End If
            Return 0
        End Get
    End Property

    ''
    '  Gets Counter class from Counters class based on given index.
    '
    ' @param Index Specifies the index in the Counters class 
    ' @return Reference to Counter
    Public ReadOnly Property Item(ByVal Index As Integer) As Counter
        Get
            If (Index > 0) AndAlso (Index <= Me.Count) Then
                Return DirectCast(_counters.Item(Index - 1), Counter)
            End If
            Return Nothing
        End Get
    End Property

    ''
    '  Adds Counter class to Counters class
    '
    ' @param ValueIn Specifies reference to Counter
    Public Sub AddItem(ByVal ValueIn As Counter)

        If (Not _counters Is Nothing) Then
            _counters.Add(ValueIn)
        End If

    End Sub

    ''
    '  Counter class defines counters for measurement types.
    '
    Public NotInheritable Class Counter
        Private m_MeasurementTypeID As String
        Private m_TypeName As String
        Private m_CounterName As String
        Private m_Description As String
        Private m_Datatype As String
        Private m_Datasize As String
        Private m_Datascale As String
        Private m_TimeAggr As String
        Private m_GroupAggr As String
        Private m_TimeAggrList() As String
        Private m_GroupAggrList() As String
        Private m_Aggregations() As String
        Private m_oneAggrValue As String
        Private m_oneAggrFormula As Boolean
        Private m_CountAggr As String
        Private m_CounterType As String
        Private m_CounterProcess As String
        Private m_UnivObject As String
        Private m_UnivClass As String
        Private m_SpecialIndex As String
        Private m_IndexValue As String
        Private m_ColNumber As Integer
        Private m_MaxAmount As Integer
        Private m_IncludeInSQLInterface As Integer
        Private m_Row As Integer
        Private m_givenDatatype As String

        Public Property TypeName() As String
            Get
                TypeName = m_TypeName
            End Get

            Set(ByVal Value As String)
                m_TypeName = Value
            End Set

        End Property

        ''
        ' Gets and sets value for SpecialIndex parameter. SpecialIndex defines special database indexes set to counter.
        '
        ' @param Value Specifies value of SpecialIndex parameter
        ' @return Value of SpecialIndex parameter
        Public Property SpecialIndex() As String
            Get
                SpecialIndex = m_SpecialIndex
            End Get

            Set(ByVal Value As String)
                m_SpecialIndex = Value
            End Set

        End Property

        ''
        ' Gets and sets value for MeasurementTypeID parameter. 
        ' MeasurementTypeID defines measurement type for counter.
        '
        ' @param Value Specifies value of MeasurementTypeID parameter
        ' @return Value of MeasurementTypeID parameter
        Public Property MeasurementTypeID() As String
            Get
                MeasurementTypeID = m_MeasurementTypeID
            End Get

            Set(ByVal Value As String)
                m_MeasurementTypeID = Value
            End Set

        End Property

        ''
        ' Gets and sets value for CounterName parameter. 
        ' CounterName defines name for counter.
        '
        ' @param Value Specifies value of CounterName parameter
        ' @return Value of CounterName parameter
        Public Property CounterName() As String
            Get
                CounterName = m_CounterName
            End Get

            Set(ByVal Value As String)
                m_CounterName = Value
            End Set

        End Property

        ''
        ' Gets and sets value for Description parameter. 
        ' Description defines description for counter.
        '
        ' @param Value Specifies value of Description parameter
        ' @return Value of Description parameter
        Public Property Description() As String
            Get
                Description = m_Description
            End Get

            Set(ByVal Value As String)
                m_Description = Value
            End Set

        End Property


        Public Property givenDatatype() As String
            Get
                givenDatatype = m_givenDatatype
            End Get

            Set(ByVal Value As String)
                m_givenDatatype = Value
            End Set

        End Property

        ''
        ' Gets and sets value for Datatype parameter. 
        ' Datatype defines data type for counter.
        '
        ' @param Value Specifies value of Datatype parameter
        ' @return Value of Datatype parameter
        Public Property Datatype() As String
            Get
                Datatype = m_Datatype
            End Get

            Set(ByVal Value As String)
                m_Datatype = Value
            End Set

        End Property

        ''
        ' Gets and sets value for Datasize parameter. 
        ' Datasize defines data size for counter.
        '
        ' @param Value Specifies value of Datasize parameter
        ' @return Value of Datasize parameter
        Public Property Datasize() As String
            Get
                Datasize = m_Datasize
            End Get

            Set(ByVal Value As String)
                m_Datasize = Value
            End Set

        End Property

        ''
        ' Gets and sets value for Datascale parameter. 
        ' Datascale defines data scale for counter.
        '
        ' @param Value Specifies value of Datascale parameter
        ' @return Value of Datascale parameter
        Public Property Datascale() As String
            Get
                Datascale = m_Datascale
            End Get

            Set(ByVal Value As String)
                m_Datascale = Value
            End Set

        End Property

        ''
        ' Gets and sets value for TimeAggr parameter. 
        ' TimeAggr defines time aggregation for counter.
        '
        ' @param Value Specifies value of TimeAggr parameter
        ' @return Value of TimeAggr parameter
        Public Property TimeAggr() As String
            Get
                TimeAggr = m_TimeAggr
            End Get

            Set(ByVal Value As String)
                m_TimeAggr = UCase(Value)
            End Set

        End Property

        Public Property TimeAggrList() As String()
            Get
                TimeAggrList = m_TimeAggrList
            End Get

            Set(ByVal Value As String())
                m_TimeAggrList = Value
            End Set

        End Property

        Public Property oneAggrFormula() As Boolean
            Get
                oneAggrFormula = m_oneAggrFormula
            End Get

            Set(ByVal Value As Boolean)
                m_oneAggrFormula = Value
            End Set

        End Property

        Public Property oneAggrValue() As String
            Get
                oneAggrValue = m_oneAggrValue
            End Get

            Set(ByVal Value As String)
                m_oneAggrValue = Value
            End Set

        End Property

        ''
        ' Gets and sets value for GroupAggr parameter. 
        ' GroupAggr defines group aggregation for counter.
        '
        ' @param Value Specifies value of GroupAggr parameter
        ' @return Value of GroupAggr parameter
        Public Property GroupAggr() As String
            Get
                GroupAggr = m_GroupAggr
            End Get

            Set(ByVal Value As String)
                m_GroupAggr = UCase(Value)
            End Set

        End Property

        Public Property GroupAggrList() As String()
            Get
                GroupAggrList = m_GroupAggrList
            End Get

            Set(ByVal Value As String())
                m_GroupAggrList = Value
            End Set

        End Property

        Public Property Aggregations() As String()
            Get
                Aggregations = m_Aggregations
            End Get

            Set(ByVal Value As String())
                m_Aggregations = Value
            End Set

        End Property


        ''
        ' Gets and sets value for CountAggr parameter. 
        ' CountAggr defines count aggregation for counter.
        '
        ' @param Value Specifies value of CountAggr parameter
        ' @return Value of CountAggr parameter
        Public Property CountAggr() As String
            Get
                CountAggr = m_CountAggr
            End Get

            Set(ByVal Value As String)
                m_CountAggr = UCase(Value)
            End Set

        End Property

        ''
        ' Gets and sets value for CounterType parameter. 
        ' CounterType defines type for counter.
        '
        ' @param Value Specifies value of CounterType parameter
        ' @return Value of CounterType parameter
        Public Property CounterType() As String
            Get
                CounterType = m_CounterType
            End Get

            Set(ByVal Value As String)
                m_CounterType = UCase(Value)
            End Set

        End Property

        ''
        ' Gets and sets value for CounterProcess parameter. 
        ' CounterProcess defines type for counter.
        '
        ' @param Value Specifies value of CounterProcess parameter
        ' @return Value of CounterProcess parameter
        Public Property CounterProcess() As String
            Get
                CounterProcess = m_CounterProcess
            End Get

            Set(ByVal Value As String)
                m_CounterProcess = UCase(Value)
            End Set

        End Property
        ''
        ' Gets and sets value for UnivObject parameter. 
        ' UnivObject defines universe object name for counter.
        '
        ' @param Value Specifies value of UnivObject parameter
        ' @return Value of UnivObject parameter
        Public Property UnivObject() As String
            Get
                UnivObject = m_UnivObject
            End Get

            Set(ByVal Value As String)
                m_UnivObject = Value
            End Set

        End Property

        ''
        ' Gets and sets value for UnivClass parameter. 
        ' UnivClass defines universe class name for counter.
        '
        ' @param Value Specifies value of UnivClass parameter
        ' @return Value of UnivClass parameter
        Public Property UnivClass() As String
            Get
                UnivClass = m_UnivClass
            End Get

            Set(ByVal Value As String)
                m_UnivClass = Value
            End Set

        End Property

        ''
        ' Gets and sets value for ColNumber parameter. 
        ' ColNumber defines column order number counter.
        '
        ' @param Value Specifies value of ColNumber parameter
        ' @return Value of ColNumber parameter
        Public Property ColNumber() As Integer
            Get
                ColNumber = m_ColNumber
            End Get

            Set(ByVal Value As Integer)
                m_ColNumber = Value
            End Set

        End Property

        ''
        ' Gets and sets value for IndexValue parameter. 
        ' IndexValue defines unique index value for counter.
        '
        ' @param Value Specifies value of IndexValue parameter
        ' @return Value of IndexValue parameter
        Public Property IndexValue() As String
            Get
                IndexValue = m_IndexValue
            End Get

            Set(ByVal Value As String)
                m_IndexValue = Value
            End Set

        End Property

        ''
        ' Gets and sets value for MaxAmount parameter. 
        ' MaxAmount defines estimated maximum amount of different values.
        '
        ' @param Value Specifies value of MaxAmount parameter
        ' @return Value of MaxAmount parameter
        Public Property MaxAmount() As Integer
            Get
                MaxAmount = m_MaxAmount
            End Get

            Set(ByVal Value As Integer)
                If Value <> 0 Then
                    m_MaxAmount = 255
                Else
                    m_MaxAmount = Value
                End If
            End Set

        End Property

        ''
        ' Gets and sets value for IncludeInSQLInterface parameter. 
        ' IncludeInSQLInterface defines whether public key is visible in SQL interface.
        '
        ' @param Value Specifies value of IncludeInSQLInterface parameter
        ' @return Value of IncludeInSQLInterface parameter
        Public Property IncludeInSQLInterface()
            Get
                IncludeInSQLInterface = m_IncludeInSQLInterface
            End Get

            Set(ByVal Value)
                If Value = "" Then
                    m_IncludeInSQLInterface = 1
                Else
                    m_IncludeInSQLInterface = 0
                End If
            End Set

        End Property

        Public Property Row()
            Get
                Row = m_Row
            End Get

            Set(ByVal Value)
                m_Row = Value
            End Set

        End Property

    End Class

    ''
    ' Gets counters defined in TP definition. 
    '
    ' @param conn Specifies reference to OLE DbConnection
    ' @param dbCommand Specifies reference to OLE DbCommand
    ' @param dbReader Specifies reference to OLE DbDataReader
    Public Sub getCounters(ByRef DefaultCounterMaxAmount As Integer, ByRef conn As System.Data.Odbc.OdbcConnection, _
                           ByRef dbCommand As System.Data.Odbc.OdbcCommand, ByRef dbReader As System.Data.Odbc.OdbcDataReader, _
                           ByRef TechPackTPIde As String)

        Dim tputils = New TPUtilitiesTPIde
        Dim counter As Counter
        Dim ClassTree() As String
        Dim TreeCount As Integer
        Dim Row As Integer
        Dim tempVendorReleases As String
        Dim VendorReleases() As String
        Dim Aggregations() As String
        Dim counterDescription As String

        Dim SUMCount As String
        Dim AVGCount As String
        Dim MAXCount As String
        Dim MINCount As String
        Dim COUNTCount As String
        Dim NONECount As String
        Dim AggregationFormula As String
        Dim count As Integer
        Dim tempAggregations As String
        Dim first As Boolean
        Dim oneAggrFormula As Boolean
        Dim oneAggrValue As String
        Dim loopVar As Integer
        Dim exceptionNull As String

        Dim SupportedFormulas As String
        Dim SupportedTypes As String
        SupportedFormulas = "SUM,AVG,MAX,MIN,COUNT,NONE"
        SupportedTypes = "PEG,GAUGE,VECTOR,UNIQUEVECTOR,CMVECTOR,PMRESVECTOR,COMPRESSEDVECTOR"

        Row = 1

        Dim tp_utils = New TPUtilitiesTPIde
        tempVendorReleases = tp_utils.readSingleValue("SELECT VENDORRELEASE FROM SUPPORTEDVENDORRELEASE WHERE VERSIONID = ", conn, dbCommand, dbReader, TechPackTPIde)
        VendorReleases = Split(tempVendorReleases, ",")
        tp_utils = Nothing

        Dim tmpmeascnt As String
        tmpmeascnt = "SELECT TYPEID,DATANAME," & _
        "SUBSTR(DESCRIPTION,1,8000),SUBSTR(DESCRIPTION,8001,8000),SUBSTR(DESCRIPTION,16001,8000),SUBSTR(DESCRIPTION,24001,8000)" & _
        ",TIMEAGGREGATION, GROUPAGGREGATION,DATATYPE,DATASIZE,DATASCALE,INCLUDESQL,UNIVOBJECT,UNIVCLASS,COUNTERPROCESS FROM MeasurementCounter WHERE TYPEID LIKE '" & TechPackTPIde & "%'"

        dbCommand = New System.Data.Odbc.OdbcCommand(tmpmeascnt, conn)
        'Modification for HK80515
        Console.WriteLine("Gets counters defined in TP definition from the Database")
        Trace.WriteLine("Gets counters defined in TP definition from the Database")

        Try
            If dbReader.IsClosed = False Then
                dbReader.Close()
            End If
            dbReader = dbCommand.ExecuteReader()
        Catch ex As Exception
            Trace.WriteLine("Database Exception during execution of SQL : " & tmpmeascnt)
            Trace.WriteLine("Exception  : " & ex.ToString)
            Exit Sub
        End Try


        Try
            While (dbReader.Read())

                exceptionNull = ""

                If dbReader.GetValue(0).ToString() = "" Then
                    Exit While
                Else
                    Row += 1
                    counter = New Counter

                    counter.MeasurementTypeID = Trim(dbReader.GetValue(0).ToString())
                    exceptionNull = "MeasurementTypeID"

                    counter.CounterName = Trim(dbReader.GetValue(1).ToString())
                    exceptionNull = "CounterName"

                    counterDescription = ""

                    Try
                        counterDescription = counterDescription & Trim(dbReader.GetValue(2).ToString & dbReader.GetValue(3).ToString & dbReader.GetValue(4).ToString & dbReader.GetValue(5).ToString)
                    Catch ex As Exception
                        counterDescription = counterDescription
                        Trace.WriteLine("Info : Counter description for counter : " & counter.CounterName & " is null.")
                    End Try

                    exceptionNull = "Description"
                    counter.Description = Trim(counterDescription)

                    exceptionNull = "TimeAggr"
                    counter.TimeAggr = Trim(dbReader.GetValue(6).ToString())

                    exceptionNull = "TimeAggrList"
                    counter.TimeAggrList = Split(counter.TimeAggr, ",")

                    exceptionNull = "GroupAggr"
                    counter.GroupAggr = Trim(dbReader.GetValue(7).ToString())

                    exceptionNull = "GroupAggrList"
                    counter.GroupAggrList = Split(counter.GroupAggr, ",")

                    exceptionNull = "Datatype"
                    counter.Datatype = Trim(dbReader.GetValue(8).ToString())

                    exceptionNull = "Datasize"
                    counter.Datasize = Trim(dbReader.GetValue(9).ToString())

                    exceptionNull = "Datascale"
                    counter.Datascale = Trim(dbReader.GetValue(10).ToString())

                    exceptionNull = "IncludeInSQLInterface"
                    counter.IncludeInSQLInterface = Trim(dbReader.GetValue(11).ToString())

                    exceptionNull = "UnivObject"
                    counter.UnivObject = Trim(dbReader.GetValue(12).ToString())

                    exceptionNull = "UnivClass"
                    counter.UnivClass = Trim(dbReader.GetValue(13).ToString())

                    exceptionNull = "CounterProcess"
                    counter.CounterProcess = Trim(dbReader.GetValue(14).ToString())

                    Trace.WriteLine("Processing Counter :: " & counter.CounterName & " , of measurement type :: " & counter.MeasurementTypeID)

                    'time aggregation formula change check
                    If tempVendorReleases <> "" Then
                        Aggregations = Split(counter.TimeAggr, ",")
                        If counter.TimeAggr <> "SUM" AndAlso counter.TimeAggr <> "AVG" AndAlso _
                        counter.TimeAggr <> "MAX" AndAlso counter.TimeAggr <> "MIN" AndAlso _
                        counter.TimeAggr <> "COUNT" AndAlso counter.TimeAggr <> "NONE" AndAlso counter.TimeAggr <> "" Then
                            If UBound(Aggregations) <> UBound(VendorReleases) Then
                                Trace.WriteLine("Counter '" & counter.CounterName & "' time aggregation formula in table '" & counter.MeasurementTypeID & "' does not match number of vendor releases.")
                            Else
                                AggregationFormula = ""
                                SUMCount = ""
                                AVGCount = ""
                                MAXCount = ""
                                MINCount = ""
                                COUNTCount = ""
                                NONECount = ""
                                For count = 0 To UBound(VendorReleases)
                                    If UCase(Aggregations(count)) = "SUM" Then
                                        If SUMCount = "" Then
                                            SUMCount &= VendorReleases(count)
                                        Else
                                            SUMCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "AVG" Then
                                        If AVGCount = "" Then
                                            AVGCount &= VendorReleases(count)
                                        Else
                                            AVGCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "MAX" Then
                                        If MAXCount = "" Then
                                            MAXCount &= VendorReleases(count)
                                        Else
                                            MAXCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "MIN" Then
                                        If MINCount = "" Then
                                            MINCount &= VendorReleases(count)
                                        Else
                                            MINCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "COUNT" Then
                                        If COUNTCount = "" Then
                                            COUNTCount &= VendorReleases(count)
                                        Else
                                            COUNTCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "NONE" Then
                                        If NONECount = "" Then
                                            NONECount &= VendorReleases(count)
                                        Else
                                            NONECount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                Next count
                                If SUMCount <> "" Then
                                    AggregationFormula &= SUMCount & ";SUM"
                                End If
                                If AVGCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= AVGCount & ";AVG"
                                End If
                                If MAXCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= MAXCount & ";MAX"
                                End If
                                If MINCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= MINCount & ";MIN"
                                End If
                                If COUNTCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= COUNTCount & ";COUNT"
                                End If
                                If NONECount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= NONECount & ";NONE"
                                End If
                                counter.TimeAggr = AggregationFormula
                            End If
                        End If
                    End If


                    'group aggregation formula change check
                    If tempVendorReleases <> "" Then
                        Aggregations = Split(counter.GroupAggr, ",")
                        If counter.GroupAggr <> "SUM" AndAlso counter.GroupAggr <> "AVG" AndAlso _
                        counter.GroupAggr <> "MAX" AndAlso counter.GroupAggr <> "MIN" AndAlso _
                        counter.GroupAggr <> "COUNT" AndAlso counter.GroupAggr <> "NONE" AndAlso counter.GroupAggr <> "" Then
                            If UBound(Aggregations) <> UBound(VendorReleases) Then
                                Trace.WriteLine("Counter '" & counter.CounterName & "' group aggregation formula in table '" & counter.MeasurementTypeID & "' does not match number of vendor releases.")
                            Else
                                AggregationFormula = ""
                                SUMCount = ""
                                AVGCount = ""
                                MAXCount = ""
                                MINCount = ""
                                COUNTCount = ""
                                NONECount = ""
                                For count = 0 To UBound(VendorReleases)
                                    If UCase(Aggregations(count)) = "SUM" Then
                                        If SUMCount = "" Then
                                            SUMCount &= VendorReleases(count)
                                        Else
                                            SUMCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "AVG" Then
                                        If AVGCount = "" Then
                                            AVGCount &= VendorReleases(count)
                                        Else
                                            AVGCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "MAX" Then
                                        If MAXCount = "" Then
                                            MAXCount &= VendorReleases(count)
                                        Else
                                            MAXCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "MIN" Then
                                        If MINCount = "" Then
                                            MINCount &= VendorReleases(count)
                                        Else
                                            MINCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "COUNT" Then
                                        If COUNTCount = "" Then
                                            COUNTCount &= VendorReleases(count)
                                        Else
                                            COUNTCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "NONE" Then
                                        If NONECount = "" Then
                                            NONECount &= VendorReleases(count)
                                        Else
                                            NONECount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                Next count
                                If SUMCount <> "" Then
                                    AggregationFormula &= SUMCount & ";SUM"
                                End If
                                If AVGCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= AVGCount & ";AVG"
                                End If
                                If MAXCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= MAXCount & ";MAX"
                                End If
                                If MINCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= MINCount & ";MIN"
                                End If
                                If COUNTCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= COUNTCount & ";COUNT"
                                End If
                                If NONECount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= NONECount & ";NONE"
                                End If
                                counter.GroupAggr = AggregationFormula
                            End If
                        End If
                    End If

                    'get different aggregation formulas
                    first = True
                    tempAggregations = ""
                    counter.oneAggrFormula = False
                    counter.oneAggrValue = ""
                    For count = 0 To UBound(counter.TimeAggrList)
                        If InStrRev(tempAggregations, counter.TimeAggrList(count)) = 0 Then
                            If first = False Then
                                tempAggregations &= ","
                            End If
                            If first = True Then
                                first = False
                            End If
                            tempAggregations &= counter.TimeAggrList(count)
                        End If
                    Next count
                    For count = 0 To UBound(counter.GroupAggrList)
                        If InStrRev(tempAggregations, counter.GroupAggrList(count)) = 0 Then
                            If first = False Then
                                tempAggregations &= ","
                            End If
                            If first = True Then
                                first = False
                            End If
                            tempAggregations &= counter.GroupAggrList(count)
                        End If
                    Next count
                    Aggregations = Split(tempAggregations, ",")
                    counter.Aggregations = Aggregations
                    If UBound(Aggregations) = 0 Then
                        counter.oneAggrFormula = True
                        counter.oneAggrValue = Aggregations(0)
                    End If

                    If counter.CounterProcess = "VECTOR" Then
                        counter.CounterType = "VECTOR"
                    ElseIf counter.CounterProcess = "UNIQUEVECTOR" Then
                        counter.CounterType = "VECTOR"
                    ElseIf counter.CounterProcess = "CMVECTOR" Then
                        counter.CounterType = "VECTOR"
                    ElseIf counter.CounterProcess = "PMRESVECTOR" Then
                        counter.CounterType = "VECTOR"
					ElseIf counter.CounterProcess = "COMPRESSEDVECTOR" Then
                        counter.CounterType = "VECTOR"
                    Else
                        counter.CounterType = counter.CounterProcess
                    End If

                    If counter.CounterType = "VECTOR" Then
                        counter.CountAggr = "GAUGE"
                    Else
                        counter.CountAggr = counter.CounterType
                    End If
                    counter.SpecialIndex = ""
                    'APO
                    If counter.Datasize <> "Err" AndAlso counter.Datasize <> "" Then
                        If counter.Datasize > 255 Then
                            counter.IndexValue = ""
                        Else
                            If counter.SpecialIndex <> "" Then
                                counter.IndexValue = counter.SpecialIndex
                            Else
                                counter.IndexValue = ""
                            End If
                        End If
                    Else
                        counter.IndexValue = ""
                    End If

                    counter.MaxAmount = DefaultCounterMaxAmount
                    counter.Row = Row
                    AddItem(counter)
                End If
            End While
        Catch ex As Exception
            Trace.WriteLine("Error !! Database Exception during Counter Processing.")
            Trace.WriteLine("Error !! Possible column : " & exceptionNull & " have " & ex.ToString)
        End Try
        dbReader.Close()
        dbCommand.Dispose()

        'test counters
        Dim testCounters As CountersTPIde
        Dim testCounter As CountersTPIde.Counter
        Dim test_count As Integer
        Dim amount As Integer
        testCounters = Me
        For count = 1 To Me.Count
            counter = Item(count)
            amount = 0
            'description check
            'If InStrRev(counter.Description, "'") > 0 OrElse InStrRev(counter.Description, ControlChars.Quote) > 0 Then
            'Trace.Writeline("Description in Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' contains invalid characters.")
            'End If
            'data type check
            If counter.Datatype = "NOT FOUND" OrElse counter.Datasize = "Err" Then
                Trace.WriteLine("Data Type in Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' is not defined correctly.")
            End If

            'time formula check
            For test_count = 0 To UBound(counter.TimeAggrList)
                If InStrRev(SupportedFormulas, counter.TimeAggrList(test_count)) = 0 Then
                    Trace.WriteLine("Time aggregation formula for Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' is not one of the supported: " & SupportedFormulas)
                End If
            Next test_count

            'group formula check
            For test_count = 0 To UBound(counter.GroupAggrList)
                If InStrRev(SupportedFormulas, counter.GroupAggrList(test_count)) = 0 Then
                    Trace.WriteLine("Group aggregation formula for Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' is not one of the supported: " & SupportedFormulas)
                End If
            Next test_count

            'universe class check
            ClassTree = Split(counter.UnivClass, "//")
            For TreeCount = 0 To UBound(ClassTree)
                If ClassTree(TreeCount).Length > 128 Then
                    Trace.WriteLine("Universe Class '" & counter.UnivClass & "' for Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' exceeds maximum of 128 characters")
                End If
            Next TreeCount
            'universe object check
            If counter.UnivObject <> "" Then
                If counter.UnivObject.Length > 128 Then
                    Trace.WriteLine("Universe Object '" & counter.UnivObject & "' for Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' exceeds maximum of 128 characters")
                End If
            End If
            'type check
            If InStrRev(SupportedTypes, counter.CounterType) = 0 AndAlso counter.CounterType <> "NONE" Then
                Trace.WriteLine("Counter Type for Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' is not one of the supported: " & SupportedTypes)
            End If
            'duplicate check
            For test_count = 1 To testCounters.Count
                testCounter = testCounters.Item(test_count)
                If counter.MeasurementTypeID = testCounter.MeasurementTypeID AndAlso counter.CounterName = testCounter.CounterName Then
                    amount += 1
                End If
            Next test_count
            If amount > 1 Then
                Trace.WriteLine("Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' has been defined " & amount & " times.")
            End If
            amount = 0
            'duplicate object check
            For test_count = 1 To testCounters.Count
                testCounter = testCounters.Item(test_count)
                If counter.MeasurementTypeID = testCounter.MeasurementTypeID AndAlso counter.UnivObject = testCounter.UnivObject AndAlso testCounter.UnivObject <> "" AndAlso (counter.UnivClass = testCounter.UnivClass OrElse testCounter.UnivClass = "") Then
                    amount += 1
                End If
            Next test_count
            If amount > 1 Then
                Trace.WriteLine("Object '" & counter.UnivObject & "' for class '" & counter.UnivClass & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' has been defined " & amount & " times.")
            End If

        Next count


    End Sub

    Public Sub getCounters(defaultCounterMaxAmount As String, InputDir As String)
        Dim tputils = New TPUtilitiesTPIde
        Dim counter As Counter
        Dim ClassTree() As String
        Dim TreeCount As Integer
        Dim Row As Integer
        Dim tempVendorReleases As String
        Dim VendorReleases() As String
        Dim Aggregations() As String
        Dim counterDescription As String

        Dim SUMCount As String
        Dim AVGCount As String
        Dim MAXCount As String
        Dim MINCount As String
        Dim COUNTCount As String
        Dim NONECount As String
        Dim AggregationFormula As String
        Dim count As Integer
        Dim tempAggregations As String
        Dim first As Boolean
        Dim oneAggrFormula As Boolean
        Dim oneAggrValue As String
        Dim loopVar As Integer
        Dim exceptionNull As String

        Dim SupportedFormulas As String
        Dim SupportedTypes As String
        Dim singleVal As String
        Dim counters As String
        SupportedFormulas = "SUM,AVG,MAX,MIN,COUNT,NONE"
        SupportedTypes = "PEG,GAUGE,VECTOR,UNIQUEVECTOR,CMVECTOR,PMRESVECTOR,COMPRESSEDVECTOR"
        singleVal = InputDir & "\generalDetails"
        counters = InputDir & "\counters"

        Row = 1

        Dim tp_utils = New TPUtilitiesTPIde
        tempVendorReleases = tp_utils.getValueFromFile("VENDORRELEASE", singleVal)
        VendorReleases = Split(tempVendorReleases, ",")
        Try
            Dim line As String
            Dim value() As String
            Dim dbReader = File.OpenText(counters)
            While (dbReader.Peek() <> -1)
                line = dbReader.ReadLine()
                value = Split(line, ",")
                exceptionNull = ""

                If value(0) = "" Then
                    Exit While
                Else
                    Row += 1
                    counter = New Counter

                    counter.MeasurementTypeID = tp_utils.unFormatData(Trim(value(0)))
                    exceptionNull = "MeasurementTypeID"

                    counter.CounterName = tp_utils.unFormatData(Trim(value(1)))
                    exceptionNull = "CounterName"

                    counterDescription = ""

                    Try
                        counterDescription = tp_utils.unFormatData(Trim(value(2)))
                    Catch ex As Exception
                        counterDescription = counterDescription
                        Trace.WriteLine("Info : Counter description for counter : " & counter.CounterName & " is null.")
                    End Try

                    exceptionNull = "Description"
                    counter.Description = Trim(counterDescription)

                    exceptionNull = "TimeAggr"
                    counter.TimeAggr = tp_utils.unFormatData(Trim(value(3)))

                    exceptionNull = "TimeAggrList"
                    counter.TimeAggrList = Split(counter.TimeAggr, ",")

                    exceptionNull = "GroupAggr"
                    counter.GroupAggr = tp_utils.unFormatData(Trim(value(4)))

                    exceptionNull = "GroupAggrList"
                    counter.GroupAggrList = Split(counter.GroupAggr, ",")

                    exceptionNull = "Datatype"
                    counter.Datatype = tp_utils.unFormatData(Trim(value(5)))

                    exceptionNull = "Datasize"
                    counter.Datasize = tp_utils.unFormatData(Trim(value(6)))

                    exceptionNull = "Datascale"
                    counter.Datascale = tp_utils.unFormatData(Trim(value(7)))

                    exceptionNull = "IncludeInSQLInterface"
                    counter.IncludeInSQLInterface = tp_utils.unFormatData(Trim(value(8)))

                    exceptionNull = "UnivObject"
                    counter.UnivObject = tp_utils.unFormatData(Trim(value(9)))

                    exceptionNull = "UnivClass"
                    counter.UnivClass = tp_utils.unFormatData(Trim(value(10)))

                    exceptionNull = "CounterProcess"
                    counter.CounterProcess = tp_utils.unFormatData(Trim(value(11)))

                    Trace.WriteLine("Processing Counter :: " & counter.CounterName & " , of measurement type :: " & counter.MeasurementTypeID)

                    'time aggregation formula change check
                    If tempVendorReleases <> "" Then
                        Aggregations = Split(counter.TimeAggr, ",")
                        If counter.TimeAggr <> "SUM" AndAlso counter.TimeAggr <> "AVG" AndAlso
                        counter.TimeAggr <> "MAX" AndAlso counter.TimeAggr <> "MIN" AndAlso
                        counter.TimeAggr <> "COUNT" AndAlso counter.TimeAggr <> "NONE" AndAlso counter.TimeAggr <> "" Then
                            If UBound(Aggregations) <> UBound(VendorReleases) Then
                                Trace.WriteLine("Counter '" & counter.CounterName & "' time aggregation formula in table '" & counter.MeasurementTypeID & "' does not match number of vendor releases.")
                            Else
                                AggregationFormula = ""
                                SUMCount = ""
                                AVGCount = ""
                                MAXCount = ""
                                MINCount = ""
                                COUNTCount = ""
                                NONECount = ""
                                For count = 0 To UBound(VendorReleases)
                                    If UCase(Aggregations(count)) = "SUM" Then
                                        If SUMCount = "" Then
                                            SUMCount &= VendorReleases(count)
                                        Else
                                            SUMCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "AVG" Then
                                        If AVGCount = "" Then
                                            AVGCount &= VendorReleases(count)
                                        Else
                                            AVGCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "MAX" Then
                                        If MAXCount = "" Then
                                            MAXCount &= VendorReleases(count)
                                        Else
                                            MAXCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "MIN" Then
                                        If MINCount = "" Then
                                            MINCount &= VendorReleases(count)
                                        Else
                                            MINCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "COUNT" Then
                                        If COUNTCount = "" Then
                                            COUNTCount &= VendorReleases(count)
                                        Else
                                            COUNTCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "NONE" Then
                                        If NONECount = "" Then
                                            NONECount &= VendorReleases(count)
                                        Else
                                            NONECount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                Next count
                                If SUMCount <> "" Then
                                    AggregationFormula &= SUMCount & ";SUM"
                                End If
                                If AVGCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= AVGCount & ";AVG"
                                End If
                                If MAXCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= MAXCount & ";MAX"
                                End If
                                If MINCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= MINCount & ";MIN"
                                End If
                                If COUNTCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= COUNTCount & ";COUNT"
                                End If
                                If NONECount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= NONECount & ";NONE"
                                End If
                                counter.TimeAggr = AggregationFormula
                            End If
                        End If
                    End If


                    'group aggregation formula change check
                    If tempVendorReleases <> "" Then
                        Aggregations = Split(counter.GroupAggr, ",")
                        If counter.GroupAggr <> "SUM" AndAlso counter.GroupAggr <> "AVG" AndAlso
                        counter.GroupAggr <> "MAX" AndAlso counter.GroupAggr <> "MIN" AndAlso
                        counter.GroupAggr <> "COUNT" AndAlso counter.GroupAggr <> "NONE" AndAlso counter.GroupAggr <> "" Then
                            If UBound(Aggregations) <> UBound(VendorReleases) Then
                                Trace.WriteLine("Counter '" & counter.CounterName & "' group aggregation formula in table '" & counter.MeasurementTypeID & "' does not match number of vendor releases.")
                            Else
                                AggregationFormula = ""
                                SUMCount = ""
                                AVGCount = ""
                                MAXCount = ""
                                MINCount = ""
                                COUNTCount = ""
                                NONECount = ""
                                For count = 0 To UBound(VendorReleases)
                                    If UCase(Aggregations(count)) = "SUM" Then
                                        If SUMCount = "" Then
                                            SUMCount &= VendorReleases(count)
                                        Else
                                            SUMCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "AVG" Then
                                        If AVGCount = "" Then
                                            AVGCount &= VendorReleases(count)
                                        Else
                                            AVGCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "MAX" Then
                                        If MAXCount = "" Then
                                            MAXCount &= VendorReleases(count)
                                        Else
                                            MAXCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "MIN" Then
                                        If MINCount = "" Then
                                            MINCount &= VendorReleases(count)
                                        Else
                                            MINCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "COUNT" Then
                                        If COUNTCount = "" Then
                                            COUNTCount &= VendorReleases(count)
                                        Else
                                            COUNTCount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                    If UCase(Aggregations(count)) = "NONE" Then
                                        If NONECount = "" Then
                                            NONECount &= VendorReleases(count)
                                        Else
                                            NONECount &= "," & VendorReleases(count)
                                        End If
                                    End If
                                Next count
                                If SUMCount <> "" Then
                                    AggregationFormula &= SUMCount & ";SUM"
                                End If
                                If AVGCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= AVGCount & ";AVG"
                                End If
                                If MAXCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= MAXCount & ";MAX"
                                End If
                                If MINCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= MINCount & ";MIN"
                                End If
                                If COUNTCount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= COUNTCount & ";COUNT"
                                End If
                                If NONECount <> "" Then
                                    If AggregationFormula <> "" Then
                                        AggregationFormula &= "/"
                                    End If
                                    AggregationFormula &= NONECount & ";NONE"
                                End If
                                counter.GroupAggr = AggregationFormula
                            End If
                        End If
                    End If

                    'get different aggregation formulas
                    first = True
                    tempAggregations = ""
                    counter.oneAggrFormula = False
                    counter.oneAggrValue = ""
                    For count = 0 To UBound(counter.TimeAggrList)
                        If InStrRev(tempAggregations, counter.TimeAggrList(count)) = 0 Then
                            If first = False Then
                                tempAggregations &= ","
                            End If
                            If first = True Then
                                first = False
                            End If
                            tempAggregations &= counter.TimeAggrList(count)
                        End If
                    Next count
                    For count = 0 To UBound(counter.GroupAggrList)
                        If InStrRev(tempAggregations, counter.GroupAggrList(count)) = 0 Then
                            If first = False Then
                                tempAggregations &= ","
                            End If
                            If first = True Then
                                first = False
                            End If
                            tempAggregations &= counter.GroupAggrList(count)
                        End If
                    Next count
                    Aggregations = Split(tempAggregations, ",")
                    counter.Aggregations = Aggregations
                    If UBound(Aggregations) = 0 Then
                        counter.oneAggrFormula = True
                        counter.oneAggrValue = Aggregations(0)
                    End If

                    If counter.CounterProcess = "VECTOR" Then
                        counter.CounterType = "VECTOR"
                    ElseIf counter.CounterProcess = "UNIQUEVECTOR" Then
                        counter.CounterType = "VECTOR"
                    ElseIf counter.CounterProcess = "CMVECTOR" Then
                        counter.CounterType = "VECTOR"
                    ElseIf counter.CounterProcess = "PMRESVECTOR" Then
                        counter.CounterType = "VECTOR"
					ElseIf counter.CounterProcess = "COMPRESSEDVECTOR" Then
                        counter.CounterType = "VECTOR"						
                    Else
                        counter.CounterType = counter.CounterProcess
                    End If

                    If counter.CounterType = "VECTOR" Then
                        counter.CountAggr = "GAUGE"
                    Else
                        counter.CountAggr = counter.CounterType
                    End If
                    counter.SpecialIndex = ""
                    'APO
                    If counter.Datasize <> "Err" AndAlso counter.Datasize <> "" Then
                        If counter.Datasize > 255 Then
                            counter.IndexValue = ""
                        Else
                            If counter.SpecialIndex <> "" Then
                                counter.IndexValue = counter.SpecialIndex
                            Else
                                counter.IndexValue = ""
                            End If
                        End If
                    Else
                        counter.IndexValue = ""
                    End If

                    counter.MaxAmount = defaultCounterMaxAmount
                    counter.Row = Row
                    AddItem(counter)
                End If
            End While
            dbReader.Close()
            tp_utils = Nothing
        Catch ex As Exception
            Trace.WriteLine("Error !! Database Exception during Counter Processing.")
            Trace.WriteLine("Error !! Possible column : " & exceptionNull & " have " & ex.ToString)
        End Try

        'test counters
        Dim testCounters As CountersTPIde
        Dim testCounter As CountersTPIde.Counter
        Dim test_count As Integer
        Dim amount As Integer
        testCounters = Me
        For count = 1 To Me.Count
            counter = Item(count)
            amount = 0
            'description check
            'If InStrRev(counter.Description, "'") > 0 OrElse InStrRev(counter.Description, ControlChars.Quote) > 0 Then
            'Trace.Writeline("Description in Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' contains invalid characters.")
            'End If
            'data type check
            If counter.Datatype = "NOT FOUND" OrElse counter.Datasize = "Err" Then
                Trace.WriteLine("Data Type in Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' is not defined correctly.")
            End If

            'time formula check
            For test_count = 0 To UBound(counter.TimeAggrList)
                If InStrRev(SupportedFormulas, counter.TimeAggrList(test_count)) = 0 Then
                    Trace.WriteLine("Time aggregation formula for Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' is not one of the supported: " & SupportedFormulas)
                End If
            Next test_count

            'group formula check
            For test_count = 0 To UBound(counter.GroupAggrList)
                If InStrRev(SupportedFormulas, counter.GroupAggrList(test_count)) = 0 Then
                    Trace.WriteLine("Group aggregation formula for Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' is not one of the supported: " & SupportedFormulas)
                End If
            Next test_count

            'universe class check
            ClassTree = Split(counter.UnivClass, "//")
            For TreeCount = 0 To UBound(ClassTree)
                If ClassTree(TreeCount).Length > 128 Then
                    Trace.WriteLine("Universe Class '" & counter.UnivClass & "' for Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' exceeds maximum of 128 characters")
                End If
            Next TreeCount
            'universe object check
            If counter.UnivObject <> "" Then
                If counter.UnivObject.Length > 128 Then
                    Trace.WriteLine("Universe Object '" & counter.UnivObject & "' for Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' exceeds maximum of 128 characters")
                End If
            End If
            'type check
            If InStrRev(SupportedTypes, counter.CounterType) = 0 AndAlso counter.CounterType <> "NONE" Then
                Trace.WriteLine("Counter Type for Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' is not one of the supported: " & SupportedTypes)
            End If
            'duplicate check
            For test_count = 1 To testCounters.Count
                testCounter = testCounters.Item(test_count)
                If counter.MeasurementTypeID = testCounter.MeasurementTypeID AndAlso counter.CounterName = testCounter.CounterName Then
                    amount += 1
                End If
            Next test_count
            If amount > 1 Then
                Trace.WriteLine("Counter '" & counter.CounterName & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' has been defined " & amount & " times.")
            End If
            amount = 0
            'duplicate object check
            For test_count = 1 To testCounters.Count
                testCounter = testCounters.Item(test_count)
                If counter.MeasurementTypeID = testCounter.MeasurementTypeID AndAlso counter.UnivObject = testCounter.UnivObject AndAlso testCounter.UnivObject <> "" AndAlso (counter.UnivClass = testCounter.UnivClass OrElse testCounter.UnivClass = "") Then
                    amount += 1
                End If
            Next test_count
            If amount > 1 Then
                Trace.WriteLine("Object '" & counter.UnivObject & "' for class '" & counter.UnivClass & "' at Row " & counter.Row & " in Fact Table '" & counter.MeasurementTypeID & "' has been defined " & amount & " times.")
            End If

        Next count
    End Sub

End Class
