
Imports WMS_STD_Formula
Public Class frmAddCustomer
    Public SaveType As Integer = 0 ' Type Insert and Update
    Public Customer_Index As String = ""
    Private objCustomerType As New CustomerType()
    Private Sub frmAddCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        W_Module.WV_ConnectionString = "Data Source=KASCO_B\MSSQL2014;Initial Catalog=ms_Customer;User ID=sa;PWD=kascodb;Connect Timeout=90000;max pool size=10000;"
        Me.SetCboCustomerType()
        Me.SetCboCustomerStatus()

        If SaveType = 1 Then
            Dim obj As New customer()
            Dim dt As DataTable = New DataTable
            Try
                obj.ShowData("", " WHERE Customer_Id = '" & Customer_Index & "'")
                dt = obj.DataTable
                If dt.Rows.Count > 0 Then
                    With dt.Rows(0)
                        txtCustomerId.Text = .Item("Customer_Id").ToString
                        CustomerType.SelectedIndex = CustomerType.FindStringExact(.Item("Customer_Type_Name"))
                        txtCustomerName.Text = .Item("Customer_Name").ToString
                        CustomerAddr.Text = .Item("Customer_Addr").ToString
                        StartDate.Value = CDate(.Item("Start_Date"))
                        EndDate.Value = CDate(.Item("End_Date"))
                        cboCustomerStatus.SelectedIndex = cboCustomerStatus.FindStringExact(.Item("Status_Name"))

                    End With
                End If

            Catch ex As Exception
                Throw ex
            End Try
        ElseIf SaveType = 0 Then
            'Dim obj As New customer()
            'Dim dt As DataTable = New DataTable
            Try
                'obj.GetIndex()
                'dt = obj.DataTable
                'If dt.Rows.Count > 0 Then
                'With dt.Rows(0)
                'txtCustomerId.Text = Format((Int(.Item("Customer_Id")) + 1), "000")
                'End With
                'End If
                Dim objDBIndex As New Sy_AutoNumber
                txtCustomerId.Text = Format(Int(objDBIndex.SelectLast_Sys_Value("Customer_Id")), "000")
                objDBIndex = Nothing
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub SetCboCustomerType()
        Try
            Dim objDT As New DataTable
            objCustomerType.getCustomerType()
            objDT = objCustomerType.DataTable
            If objDT.Rows.Count > 0 Then

                With CustomerType
                    .ValueMember = "Customer_Type_Id"
                    .DisplayMember = "Customer_Type_Name"
                    .DataSource = objDT
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SetCboCustomerStatus()
        Try
            Dim objDT As New DataTable
            objCustomerType.getCustomerStatus()
            objDT = objCustomerType.DataTable
            If objDT.Rows.Count > 0 Then
                With cboCustomerStatus
                    .ValueMember = "Status"
                    .DisplayMember = "Status_Name"
                    .DataSource = objDT
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim objCRUD As New Customer_CRUD()
            Select Case SaveType
                Case 0 ' New Insert

                    If txtCustomerId.Text = "" Or IsNumeric(txtCustomerId.Text) = False Then
                        MsgBox("กรูณากรอกรหัสลูกค้าด้วยค่ะ!")
                        txtCustomerId.Focus()
                        Exit Sub

                    End If
                    If txtCustomerName.Text = "" Then
                        MsgBox("กรูณากรอกชื่อลูกค้าด้วยค่ะ!")
                        txtCustomerName.Focus()
                        Exit Sub

                    End If
                    If CustomerAddr.Text = "" Then
                        MsgBox("กรูณากรอกที่อยู่ลูกค้าด้วยค่ะ!")
                        CustomerAddr.Focus()
                        Exit Sub

                    End If

                    Dim _CustomerType As String = ""
                    Dim _CustomerStatus As String = ""
                    If CustomerType.SelectedValue IsNot Nothing Then
                        _CustomerType = CustomerType.SelectedValue.ToString
                    End If

                    If cboCustomerStatus.SelectedValue IsNot Nothing Then
                        _CustomerStatus = cboCustomerStatus.SelectedValue.ToString
                    End If


                    Dim check As Boolean = objCRUD.SaveData(txtCustomerId.Text.ToString, _CustomerType.ToString, txtCustomerName.Text.ToString, CustomerAddr.Text.ToString, StartDate.Value, EndDate.Value, _CustomerStatus.ToString, Date.Now)
                    If check Then
                        Me.Close()

                    End If
                Case 1 ' Edit Recode
                    Dim _CustomerType As String
                    Dim _CustomerStatus As String
                    If CustomerType.SelectedValue IsNot Nothing Then
                        _CustomerType = CustomerType.SelectedValue.ToString
                    End If
                    If cboCustomerStatus.SelectedValue IsNot Nothing Then
                        _CustomerStatus = cboCustomerStatus.SelectedValue.ToString
                    End If
                    Dim check As Boolean = objCRUD.UpdateData(txtCustomerId.Text.ToString, _CustomerType.ToString, txtCustomerName.Text.ToString, CustomerAddr.Text.ToString, StartDate.Value, EndDate.Value, _CustomerStatus.ToString, Date.Now)
                    If check Then
                        Me.Close()
                    End If

            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class