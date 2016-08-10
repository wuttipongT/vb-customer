Imports WMS_STD_Formula
Imports WMS_STD_Formula.W_Module
Public Class CustomerType : Inherits DBType_SQLServer
    Private _dataTable As DataTable = New DataTable
    Public ReadOnly Property DataTable() As DataTable
        Get
            Return _dataTable
        End Get
    End Property
    Public Sub getCustomerType()
        Dim strSQL As String = ""

        Try
            strSQL = "SELECT * FROM ms_Customer_Type"
            SetSQLString = strSQL
            connectDB()
            EXEC_DataAdapter()
            _dataTable = GetDataTable
        Catch ex As Exception
            Throw ex
        Finally
            disconnectDB()
        End Try
    End Sub

    Public Sub getCustomerStatus()
        Dim strSQL As String = ""
        Try
            strSQL = "SELECT * FROM ms_Status"
            SetSQLString = strSQL
            connectDB()
            EXEC_DataAdapter()
            _dataTable = GetDataTable
        Catch ex As Exception
            Throw ex
        Finally
            disconnectDB()
        End Try
    End Sub
End Class
