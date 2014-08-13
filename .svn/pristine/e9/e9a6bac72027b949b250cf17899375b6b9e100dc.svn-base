Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Public Class frmPolizasIVA

    Dim cbxBancos As Object

    Private Sub frmPolizasIVA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-----------------VALIDA PERFIL USUARIO------------------
        Dim Perfil As String
        Perfil = "00-05-06"

        If Perfil Like "*" + Perfilesusuario + "*" Then
            Me.Text = "Generar Polizas IVA" + Space(10) + CStr(VersionCont())
            STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario

            Me.MaximizeBox = False
            'dtpFecha.Text = DateTime.Now

        Else
            MsgBox("No tiene Derechos Sobre esta Opcion", vbCritical, "Sistema Contable")
            Me.Close()
        End If
        'CargarBancos()
    End Sub
    'Private Sub CargarBancos()

    '    Dim cnnConexion = New SqlConnection()
    '    Dim clsDB = New clsBD()
    '    cnnConexion = clsDB.CreaConexion()

    '    Dim consulta As String = "select codigo,banco from catBancos (NOLOCK)"
    '    Dim cmd As New SqlCommand(consulta, cnnConexion)
    '    cmd.CommandType = CommandType.Text

    '    Dim da As New SqlDataAdapter(cmd)
    '    Dim dt As New DataTable

    '    da.Fill(dt)


    '    cbxBancos.ValueMember = Trim("Codigo")
    '    cbxBancos.DisplayMember = Trim("Banco")
    '    cbxBancos.DataSource = dt

    'End Sub

    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click

        'Dim fecha As String
        Dim dr As SqlDataReader
        Dim oclsPolizasIVA = New clsPolizasIVA()
        'fecha = Format(dtpFecha.Value, "yyyyMMdd")
        dr = oclsPolizasIVA.SeleccionaChequesIVA()
        Dim dt = New DataTable()
        dt.Load(dr)

        If dt.Rows.Count > 0 Then

            '' llenar DATAGRID ------------------

            DGVFacturasIVA.Enabled = True
            DGVFacturasIVA.AutoGenerateColumns = False 'Aqui digo que las columnas no se generen automaticamente, sino que yo las lleno manualmente

            'DGVFacturasIVA.Columns(0).DataPropertyName = Trim("CodigoBanco") 'Inserta la cuenta contable
            'DGVFacturasIVA.Columns(1).DataPropertyName = Trim("TipoDoc")
            DGVFacturasIVA.Columns(0).DataPropertyName = Trim("CodigoProveedor")
            DGVFacturasIVA.Columns(1).DataPropertyName = Trim("Proveedor")
            DGVFacturasIVA.Columns(2).DataPropertyName = Trim("FacturaProveedor")
            'DGVFacturasIVA.Columns(5).DataPropertyName = Trim("Fecha")
            DGVFacturasIVA.Columns(4).DataPropertyName = Trim("Total")
            DGVFacturasIVA.Columns(5).DataPropertyName = Trim("IVA16")
            DGVFacturasIVA.Columns(6).DataPropertyName = Trim("IVA11")
            DGVFacturasIVA.Columns(7).DataPropertyName = Trim("IVAIMP")
            DGVFacturasIVA.Columns(8).DataPropertyName = Trim("IVARetencionFlete")
            DGVFacturasIVA.Columns(9).DataPropertyName = Trim("RetHonorarios")
            DGVFacturasIVA.Columns(10).DataPropertyName = Trim("RetArrendamientos")
            DGVFacturasIVA.Columns(11).DataPropertyName = Trim("ISRHonorarios")
            DGVFacturasIVA.Columns(12).DataPropertyName = Trim("ISRArrendamientos")
            DGVFacturasIVA.Columns(13).DataPropertyName = Trim("IEPS")


            DGVFacturasIVA.DataSource = dt
        Else
            MsgBox("No Existen Documentos a Mostrar", MsgBoxStyle.Information, "Sistema Contable")
        End If
    End Sub

    Private Sub SumaIVA()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVA.Rows

            If row.Cells("mSelecciona").Value = True Then

                Cantidad = Cantidad + row.Cells("dIVA").Value

            End If
        Next
        txtTotalIVA.Text = Cantidad
    End Sub

    Private Sub SumaIVA11()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVA.Rows

            If row.Cells("mSelecciona").Value = True Then

                Cantidad = Cantidad + row.Cells("dIVA11").Value

            End If
        Next
        txtTotalIVA11.Text = Cantidad
    End Sub

    Private Sub SumaIVAIMP()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVA.Rows

            If row.Cells("mSelecciona").Value = True Then

                Cantidad = Cantidad + row.Cells("dIVAIMP").Value

            End If
        Next
        txtTotalIVAIMP.Text = Cantidad
    End Sub
    Private Sub SumaRet4()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVA.Rows

            If row.Cells("mSelecciona").Value = True Then

                Cantidad = Cantidad + row.Cells("dRetFlete").Value

            End If
        Next
        txtTotalRet4.Text = Cantidad
    End Sub
    Private Sub SumaRetHon()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVA.Rows

            If row.Cells("mSelecciona").Value = True Then

                Cantidad = Cantidad + row.Cells("dRETHono").Value

            End If
        Next
        txtTotalRETHon.Text = Cantidad
    End Sub
    Private Sub SumaRetArr()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVA.Rows

            If row.Cells("mSelecciona").Value = True Then

                Cantidad = Cantidad + row.Cells("dRETArrenda").Value

            End If
        Next
        txtTotalRETArr.Text = Cantidad
    End Sub
    Private Sub SumaISRHon()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVA.Rows

            If row.Cells("mSelecciona").Value = True Then

                Cantidad = Cantidad + row.Cells("dISRHono").Value

            End If
        Next
        txtTotalISRHon.Text = Cantidad
    End Sub

    Private Sub SumaISRArr()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVA.Rows

            If row.Cells("mSelecciona").Value = True Then

                Cantidad = Cantidad + row.Cells("dISRArren").Value

            End If
        Next
        txtTotalISRArr.Text = Cantidad
    End Sub

    Private Sub SumaIEPS()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVA.Rows

            If row.Cells("mSelecciona").Value = True Then

                Cantidad = Cantidad + row.Cells("dIEPS").Value

            End If
        Next
        txtTotalIEPS.Text = Cantidad
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        DGVFacturasIVA.DataSource = Nothing
        DGVFacturasIVA.Rows.Clear()
        DGVFacturasIVADet.DataSource = Nothing
        DGVFacturasIVADet.Rows.Clear()
        cbxBancos.SelectedIndex = 0
        txtTotalIVA.Text = "0.00"
        txtTotalIVA11.Text = "0.00"
        txtTotalIVAIMP.Text = "0.00"
        txtTotalRet4.Text = "0.00"
        txtTotalRETHon.Text = "0.00"
        txtTotalRETArr.Text = "0.00"
        txtTotalISRArr.Text = "0.00"
        txtTotalISRHon.Text = "0.00"
        txtTotalIEPS.Text = "0.00"

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim cmd As New SqlCommand
        Dim transaction As SqlTransaction

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        transaction = cnnConexion.BeginTransaction

        cmd.Connection = cnnConexion
        cmd.Transaction = transaction

        Try

            For Each row As DataGridViewRow In DGVFacturasIVA.Rows
                If row.Cells("mSelecciona").Value = True Then

                    cmd.Parameters.Clear()
                    cmd.CommandText = "spPolizaRecuperaIVA"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = cnnConexion

                    cmd.Parameters.Add("@CodigoProv", SqlDbType.Int).Value = row.Cells("dCodProveedor").Value
                    cmd.Parameters.Add("@FacturaProv", SqlDbType.NVarChar).Value = row.Cells("dfactura").Value
                    cmd.Parameters.Add("@IVA16", SqlDbType.Decimal).Value = row.Cells("dIVA").Value
                    cmd.Parameters.Add("@IVA11", SqlDbType.Decimal).Value = row.Cells("dIVA11").Value
                    cmd.Parameters.Add("@IVAIMP", SqlDbType.Decimal).Value = row.Cells("dIVAIMP").Value
                    cmd.Parameters.Add("@IVARetHon", SqlDbType.Decimal).Value = row.Cells("dRETHono").Value
                    cmd.Parameters.Add("@IVARetArr", SqlDbType.Decimal).Value = row.Cells("dRETArrenda").Value
                    cmd.Parameters.Add("@IVARet4", SqlDbType.Decimal).Value = row.Cells("dRetFlete").Value
                    cmd.Parameters.Add("@ISRHon", SqlDbType.Decimal).Value = row.Cells("dISRHono").Value
                    cmd.Parameters.Add("@ISRArr", SqlDbType.Decimal).Value = row.Cells("dISRArren").Value
                    cmd.Parameters.Add("@IEPS", SqlDbType.Decimal).Value = row.Cells("dIEPS").Value
                    cmd.Parameters.Add("@pUsuario", SqlDbType.NVarChar).Value = LoginUsuario

                    cmd.ExecuteNonQuery()
                End If
            Next
            transaction.Commit()
            MsgBox("Se Genero la Poliza Correctamente", MsgBoxStyle.Information, "Sistema Contable")


        Catch err As Exception
            transaction.Rollback()
            MsgBox("Error al Grabar Poliza de IVA", MsgBoxStyle.Critical, "Sistema Contable")
            MessageBox.Show("Error:" & err.Message)
        End Try

    End Sub


    Private Sub DGVFacturasIVA_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVFacturasIVA.CellValueChanged
        SumaIVA()
        SumaIVA11()
        SumaIVAIMP()
        SumaRet4()
        SumaRetArr()
        SumaRetHon()
        SumaISRHon()
        SumaISRArr()
        SumaIEPS()
    End Sub


    Private Sub DGVFacturasIVA_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGVFacturasIVA.MouseUp
        DGVFacturasIVA.EndEdit()
    End Sub

    Private Sub DGVFacturasIVA_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGVFacturasIVA.CellMouseClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        DGVFacturasIVADet.DataSource = Nothing
        DGVFacturasIVADet.Rows.Clear()
        DGVFacturasIVADet.AutoGenerateColumns = False

        Dim row As DataGridViewRow = DGVFacturasIVA.Rows(e.RowIndex)

        Dim cmd As New SqlCommand
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        Dim dr As SqlDataReader

        cnnConexion = clsDB.CreaConexion()
        cmd.Connection = cnnConexion

        cmd.Parameters.Clear()
        cmd.CommandText = "spSelDocumentoIVA_detalle"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@pCodProv", SqlDbType.Int).Value = row.Cells("dCodProveedor").Value
        cmd.Parameters.Add("@pFactura", SqlDbType.NVarChar).Value = row.Cells("dfactura").Value


        dr = cmd.ExecuteReader

        Dim dt = New DataTable()
        dt.Load(dr)

        If dt.Rows.Count > 0 Then

            DGVFacturasIVADet.Columns(0).DataPropertyName = Trim("CodigoBanco") 'Inserta la cuenta contable
            DGVFacturasIVADet.Columns(1).DataPropertyName = Trim("TipoDoc")
            DGVFacturasIVADet.Columns(5).DataPropertyName = Trim("Fecha")
            DGVFacturasIVADet.Columns(2).DataPropertyName = Trim("CodigoProveedor")
            DGVFacturasIVADet.Columns(3).DataPropertyName = Trim("Proveedor")
            DGVFacturasIVADet.Columns(4).DataPropertyName = Trim("FacturaProveedor")
            DGVFacturasIVADet.Columns(6).DataPropertyName = Trim("Total")
            DGVFacturasIVADet.Columns(7).DataPropertyName = Trim("IVA16")
            DGVFacturasIVADet.Columns(8).DataPropertyName = Trim("IVA11")
            DGVFacturasIVADet.Columns(9).DataPropertyName = Trim("IVAIMP")
            DGVFacturasIVADet.Columns(10).DataPropertyName = Trim("IVARetencionFlete")
            DGVFacturasIVADet.Columns(11).DataPropertyName = Trim("RetHonorarios")
            DGVFacturasIVADet.Columns(12).DataPropertyName = Trim("RetArrendamientos")
            DGVFacturasIVADet.Columns(13).DataPropertyName = Trim("ISRHonorarios")
            DGVFacturasIVADet.Columns(14).DataPropertyName = Trim("ISRArrendamientos")
            DGVFacturasIVADet.Columns(15).DataPropertyName = Trim("IEPS")

            DGVFacturasIVADet.DataSource = dt

            SumaIVAdet()
            SumaIVA11det()
            SumaIVAIMPdet()
            SumaRet4det()
            SumaRetHondet()
            SumaRetArrdet()
            SumaISRHondet()
            SumaISRArrdet()
            SumaIEPSdet()

        Else

            ' MsgBox("No existen Documentos a Mostrar", vbInformation, "Sistema Contable")

        End If

    End Sub

    '------------INICIA SUMA DETALLE ------------

    Private Sub SumaIVAdet()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVADet.Rows



            Cantidad = Cantidad + row.Cells("dIVA_det").Value


        Next
        txttotalIVA_det.Text = Cantidad
    End Sub

    Private Sub SumaIVA11det()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVADet.Rows



            Cantidad = Cantidad + row.Cells("dIVA11_det").Value


        Next
        txtTotalIVA11_det.Text = Cantidad
    End Sub

    Private Sub SumaIVAIMPdet()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVADet.Rows



            Cantidad = Cantidad + row.Cells("dIVAIMP_det").Value


        Next
        txtTotalIVAIMP_det.Text = Cantidad
    End Sub
    Private Sub SumaRet4det()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVADet.Rows



            Cantidad = Cantidad + row.Cells("dRetFlete_det").Value


        Next
        txtTotalRet4_det.Text = Cantidad
    End Sub
    Private Sub SumaRetHondet()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVADet.Rows



            Cantidad = Cantidad + row.Cells("dRETHono_det").Value


        Next
        txtTotalRETHon_det.Text = Cantidad
    End Sub
    Private Sub SumaRetArrdet()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVADet.Rows



            Cantidad = Cantidad + row.Cells("dRETArr_det").Value


        Next
        txtTotalRETArr_det.Text = Cantidad
    End Sub
    Private Sub SumaISRHondet()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVADet.Rows



            Cantidad = Cantidad + row.Cells("dISRHon_det").Value


        Next
        txtTotalISRHon_det.Text = Cantidad
    End Sub

    Private Sub SumaISRArrdet()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVADet.Rows



            Cantidad = Cantidad + row.Cells("dISRArre_det").Value


        Next
        txtTotalISRArr_det.Text = Cantidad
    End Sub

    Private Sub SumaIEPSdet()
        Dim Cantidad As Decimal = 0.0
        For Each row As DataGridViewRow In DGVFacturasIVADet.Rows



            Cantidad = Cantidad + row.Cells("dIEPS_det").Value


        Next
        txtTotalIEPS_det.Text = Cantidad
    End Sub

End Class