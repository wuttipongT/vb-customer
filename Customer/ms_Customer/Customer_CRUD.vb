Imports WMS_STD_Formula
Imports WMS_STD_Formula.W_Module
Public Class Customer_CRUD : Inherits DBType_SQLServer
    ' ###
    Private _dataTable As DataTable = New DataTable
    Private _Customer_Id As String
    Private _Customer_Type_Id As String
    Private _Customer_Name As String
    Private _Customer_Addr As String
    Private _Start_Date As Date
    Private _End_Date As Date
    Private _Status As Integer
    Private _TimeStamp As Date

    Public ReadOnly Property DataTable() As DataTable
        Get
            Return _dataTable
        End Get
    End Property

    Public Property Customer_Id() As String
        Get
            Return _Customer_Id
        End Get
        Set(ByVal value As String)
            _Customer_Id = value
        End Set
    End Property
    Public Property Customer_Type_Id() As String
        Get
            Return _Customer_Type_Id
        End Get
        Set(ByVal value As String)
            _Customer_Type_Id = value
        End Set
    End Property
    Public Property Customer_Name() As String
        Get
            Return _Customer_Name
        End Get
        Set(ByVal value As String)
            _Customer_Name = value
        End Set
    End Property
    Public Property Custoner_Addr() As String
        Get
            Return _Customer_Addr
        End Get
        Set(ByVal value As String)
            _Customer_Addr = value
        End Set
    End Property
    Public Property Start_Date() As Date
        Get
            Return _Start_Date
        End Get
        Set(ByVal value As Date)
            _Start_Date = value
        End Set
    End Property
    Public Property End_Date() As Date
        Get
            Return _End_Date
        End Get
        Set(ByVal value As Date)
            _End_Date = value
        End Set
    End Property
    Public Property Status() As Integer
        Get
            Return _Status
        End Get
        Set(ByVal value As Integer)
            _Status = value
        End Set
    End Property
    Public Property TimeStamp() As Date
        Get
            Return _TimeStamp
        End Get
        Set(ByVal value As Date)
            _TimeStamp = value
        End Set
    End Property
    

    Private Function Insert_Master() As Boolean
        Dim strSQL As String = ""
        Try
            strSQL = "INSERT INTO ms_Customer VALUES(@Customer_Id, @Customer_Type_Id, @Customer_Name, @Customer_Addr, @Start_Date, @End_Date, @Status, @TimeStamp)"

            strSQL = strSQL
            With SQLServerCommand
                .Parameters.Clear()
                .Parameters.Add("@Customer_Id", SqlDbType.VarChar, 20).Value = Me._Customer_Id
                .Parameters.Add("@Customer_Type_Id", SqlDbType.VarChar, 20).Value = Me._Customer_Type_Id
                .Parameters.Add("@Customer_Name", SqlDbType.VarChar, 50).Value = Me._Customer_Name
                .Parameters.Add("@Customer_Addr", SqlDbType.VarChar, 50).Value = Me._Customer_Addr
                .Parameters.Add("@Start_Date", SqlDbType.DateTime).Value = Me._Start_Date
                .Parameters.Add("@End_Date", SqlDbType.DateTime).Value = Me._End_Date
                .Parameters.Add("@Status", SqlDbType.Int, 20).Value = Me._Status
                .Parameters.Add("@TimeStamp", SqlDbType.DateTime).Value = Me._TimeStamp
            End With

            SetSQLString = strSQL
            SetCommandType = DBType_SQLServer.enuCommandType.Text
            SetEXEC_TYPE = DBType_SQLServer.EXEC.NonQuery
            connectDB()
            EXEC_Command()
            Return True

        Catch ex As Exception
            Throw ex
        Finally
            disconnectDB()
            strSQL = Nothing
        End Try
    End Function
    Private Function Update_Master() As Boolean
        Dim strSQL As String = ""
        Try
            strSQL = "UPDATE ms_Customer SET Customer_Type_Id = @Customer_Type_Id, Customer_Name = @Customer_Name, Customer_Addr = @Customer_Addr, Start_Date = @Start_Date, End_Date = @End_Date, Status = @Status, TimeStamp = @TimeStamp WHERE Customer_Id = @Customer_Id "
            strSQL = strSQL
            With SQLServerCommand
                .Parameters.Clear()
                .Parameters.Add("@Customer_Id", SqlDbType.VarChar, 20).Value = Me._Customer_Id
                .Parameters.Add("@Customer_Type_Id", SqlDbType.VarChar, 20).Value = Me._Customer_Type_Id
                .Parameters.Add("@Customer_Name", SqlDbType.VarChar, 50).Value = Me._Customer_Name
                .Parameters.Add("@Customer_Addr", SqlDbType.VarChar, 50).Value = Me._Customer_Addr
                .Parameters.Add("@Start_Date", SqlDbType.DateTime).Value = Me._Start_Date
                .Parameters.Add("@End_Date", SqlDbType.DateTime).Value = Me._End_Date
                .Parameters.Add("@Status", SqlDbType.Int, 20).Value = Me._Status
                .Parameters.Add("@TimeStamp", SqlDbType.DateTime).Value = Me._TimeStamp
            End With

            SetSQLString = strSQL
            SetCommandType = DBType_SQLServer.enuCommandType.Text
            SetEXEC_TYPE = DBType_SQLServer.EXEC.NonQuery
            connectDB()
            EXEC_Command()
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            disconnectDB()
            strSQL = Nothing
        End Try

    End Function
    Public Function SaveData(ByVal CustomerId As String, ByVal CustomerType As String, ByVal CustomerName As String, ByVal CustomerAddr As String, ByVal StartDate As Date, ByVal EndDate As Date, ByVal Status As Integer, ByVal TimeStamp As Date) As Boolean
        Me._Customer_Id = CustomerId
        Me._Customer_Type_Id = CustomerType
        Me._Customer_Name = CustomerName
        Me._Customer_Addr = CustomerAddr
        Me._Start_Date = StartDate
        Me._End_Date = EndDate
        Me._Status = Status
        Me._TimeStamp = TimeStamp

        Dim checked As Boolean = Insert_Master()
        Return checked
    End Function

    Public Function UpdateData(ByVal CustomerId As String, ByVal CustomerType As String, ByVal CustomerName As String, ByVal CustomerAddr As String, ByVal StartDate As Date, ByVal EndDate As Date, ByVal Status As Integer, ByVal TimeStamp As Date) As Boolean
        Me._Customer_Id = CustomerId
        Me._Customer_Type_Id = CustomerType
        Me._Customer_Name = CustomerName
        Me._Customer_Addr = CustomerAddr
        Me._Start_Date = StartDate
        Me._End_Date = EndDate
        Me._Status = Status
        Me._TimeStamp = TimeStamp

        Dim checked As Boolean = Update_Master()
        Return checked

    End Function
End Class
