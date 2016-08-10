Imports System.Windows.Forms
Imports WMS_STD_Formula

Public Class FormResizeEvent
    Public Shared Sub Main()
        Application.Run(New ms_Customer)
    End Sub
End Class
Public Class ms_Customer

    Private Sub ms_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WMS_STD_Formula.W_Module.WV_ConnectionString = "Data Source=KASCO_B\MSSQL2014;Initial Catalog=ms_Customer;User ID=sa;PWD=kascodb;Connect Timeout=90000;max pool size=10000;"
        Me.showMainData()
        cboCustomerType()
        cboGetStatus()
    End Sub
    Private Sub Customer_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        'GroupBox1.Width = Me.Width
        'GroupBox1.Height = Me.Height
        'grdCustomer.Width = Me.Width
    End Sub
    Private Sub cboCustomerType()
        Dim objCustomerType As New CustomerType()
        Dim dt As New DataTable, dr As DataRow
        Try
            objCustomerType.getCustomerType()
            dt.Columns.Add(New DataColumn("Customer_Type_Id", GetType(String)))
            dt.Columns.Add(New DataColumn("Customer_Type_Name", GetType(String)))
            dr = dt.NewRow()
            dr("Customer_Type_Id") = "000"
            dr("Customer_Type_Name") = "ประเภทลูกค้า..."
            dt.Rows.Add(dr)
            dt.Merge(objCustomerType.DataTable)
            If dt.Rows.Count > 0 Then
                With typeFind
                    .ValueMember = "Customer_Type_Id"
                    .DisplayMember = "Customer_Type_Name"
                    .DataSource = dt
                    .SelectedIndex = 0
                End With
                
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function cboGetStatus()
        Dim objCustomerType As New CustomerType()
        Dim dt As New DataTable, dr As DataRow
        Try
            objCustomerType.getCustomerStatus()
            dt.Columns.Add(New DataColumn("Status", GetType(Integer)))
            dt.Columns.Add(New DataColumn("Status_Name", GetType(String)))
            dr = dt.NewRow
            dt.Rows.Add(dr)
            dr("Status") = 0
            dr("Status_Name") = "สถานะ..."
            dt.Merge(objCustomerType.DataTable)
            If dt.Rows.Count > 0 Then
                With cboStatusFind
                    .ValueMember = "Status"
                    .DisplayMember = "Status_Name"
                    .DataSource = dt
                    .SelectedIndex = 0
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub showMainData()
        Dim objClassDB As New customer()
        Dim objDT As DataTable = New DataTable
        Dim objDr As DataRow
        Try
            grdCustomer.Rows.Clear()
            objClassDB.ShowData("", getSQLSearch())
            objDT = objClassDB.DataTable

            If objDT.Rows.Count > 0 Then

                Dim i As Integer
                For Each objDr In objDT.Rows
                    grdCustomer.Rows.Add()
                    grdCustomer.Rows(i).Cells("Col_Index").Value = objDr("Customer_Id").ToString
                    grdCustomer.Rows(i).Cells("CustomerID").Value = objDr("Customer_Id").ToString
                    grdCustomer.Rows(i).Cells("CustomerType").Value = objDr("Customer_type_Name").ToString
                    grdCustomer.Rows(i).Cells("CustomerName").Value = objDr("Customer_Name").ToString
                    grdCustomer.Rows(i).Cells("CustomerAddr").Value = objDr("Customer_Addr").ToString
                    grdCustomer.Rows(i).Cells("StartDate").Value = objDr("Start_Date").ToString
                    grdCustomer.Rows(i).Cells("EndDate").Value = objDr("End_Date").ToString
                    grdCustomer.Rows(i).Cells("CusotmerStatus").Value = objDr("Status_Name").ToString
                    i = i + 1
                Next
            Else

                grdCustomer.Rows.Clear()
                grdCustomer.Refresh()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLinkCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLinkCreate.Click
        Try
            Dim frm As New frmAddCustomer
            frm.ShowDialog()
            showMainData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function getSQLSearch() As String
        Dim strWhere As String = " WHERE 1=1"
        If Me.searchCustomerId.Text.Trim <> "" Then
            strWhere &= " AND Customer_Id='" & searchCustomerId.Text & "'"
        End If
        If typeFind.SelectedIndex <> 0 And typeFind.SelectedIndex <> -1 Then
            strWhere &= " AND ms_Customer.Customer_Type_Id='" & Me.typeFind.SelectedValue & "'"
        End If
        If txtNameFind.Text.Trim <> "" Then
            strWhere &= " AND Customer_Name LIKE '" & txtNameFind.Text & "%'"
        End If
        If cboStatusFind.SelectedIndex <> 0 And cboStatusFind.SelectedIndex <> -1 Then
            strWhere &= "AND ms_Customer.Status='" & cboStatusFind.SelectedValue & "'"

        End If

        Return strWhere

    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            showMainData()
        Catch ex As Exception
            Throw ex
        
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            Dim frm As New frmAddCustomer
            frm.SaveType = 1
            frm.Text = "แก้ไขลูกค้า"
            frm.Customer_Index = grdCustomer.Rows(grdCustomer.CurrentRow.Index).Cells("Col_Index").Value.ToString
            frm.ShowDialog()
            showMainData()
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class