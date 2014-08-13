
Imports System.Data.SqlClient
Public Class frmReporteCheques

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRPTReporteCheques
        frm.FechaIni = dtpFechaIni.Value 'Format(dtpFechaIni.Value, "yyyyMMdd")
        frm.FechaFin = dtpFechaFin.Value 'Format(dtpFechaFin.Value, "yyyyMMdd")
        frm.CodProveedor = Val(txtCodigo.Text)
        frm.ShowDialog()
    End Sub

    Private Sub frmReporteCheques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '------------------- CARGA LISTA PROVEEDORES ----------------------
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        
        Dim consulta As String = "select * from almacen.dbo.catProveedores (NOLOCK)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        cbxProveedores.ValueMember = "cuentacontable"
        cbxProveedores.DisplayMember = "proveedor"

        cbxProveedores.DataSource = dt
        '--------------------------------

        cbxProveedores.Text = ""
        rbtFecha.Checked = True
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
    End Sub

    Private Sub cbxProveedores_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxProveedores.SelectedIndexChanged
        If cbxProveedores.SelectedValue = "" Then
            MsgBox("No se ah Seleccionado ningun proveedor", MsgBoxStyle.Critical)
        Else
            buscaCodigoProveedor()
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()
            Dim consulta As String = "select Codigo from almacen.dbo.catProveedores where Proveedor='" & cbxProveedores.SelectedValue & "'"
            Dim cmd As New SqlCommand(consulta, cnnConexion)
            Dim dr As SqlDataReader
            cmd.CommandType = CommandType.Text
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Me.txtCodigo.Text = RTrim(dr("Codigo").ToString())
            End If
            'txtCodigo.Text = ""
        End If
    End Sub
    Sub buscaCodigoProveedor()

        '----BUSCAR NUMERO DE PROVEEDOR ----
        Dim dr2 As SqlDataReader
        Dim oclsProgramacionPago2 = New clsProgramacionPago()
        dr2 = oclsProgramacionPago2.SeleccionaCodigoProveedor(Me.cbxProveedores.SelectedValue)
        'Dim dt = New DataTable()
        'dt.Rows.Count > 0mspa
        If dr2.Read Then
            txtCodigo.Text = dr2("codigo").ToString
            '---------------------------------------
        Else
            MsgBox("El Proveedor no tiene asignado un Codigo", vbCritical, "Sistema Contable")
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtCodigo.Text = "" Then
                MsgBox("No se Capturo un Codigo de Proveedor", MsgBoxStyle.Critical)
            Else
                Dim dr As SqlDataReader
                Dim oClsProveedores As New ClsProveedores

                dr = oClsProveedores.SeleccionaProveedores(txtCodigo.Text)

                If dr.Read() Then

                    cbxProveedores.Text = Trim(dr("Proveedor").ToString())
                    cbxProveedores.Focus()
                Else
                    MsgBox("No Existe el Codigo de Proveedor", MsgBoxStyle.Critical)
                    txtCodigo.SelectAll()
                    cbxProveedores.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub rbtFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtFecha.CheckedChanged
        If rbtFecha.Checked = True Then
            dtpFechaIni.Enabled = True
            dtpFechaFin.Enabled = True
            cbxProveedores.Enabled = False
            txtCodigo.Enabled = False
            txtCodigo.Clear()
        End If
    End Sub

    Private Sub rbtProveedor_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtProveedor.CheckedChanged
        If rbtProveedor.Checked = True Then

            cbxProveedores.Enabled = True
            txtCodigo.Enabled = True

            dtpFechaIni.Enabled = False
            dtpFechaFin.Enabled = False
        End If
    End Sub
    
    Private Sub cbxProveedores_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxProveedores.SelectedValueChanged
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        If cbxProveedores.SelectedValue Is Nothing Then
            Exit Sub
        End If

        Dim consulta As String = "select Codigo from almacen.dbo.catProveedores where Proveedor='" & cbxProveedores.SelectedValue & "'"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        Dim dr As SqlDataReader
        cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            Me.txtCodigo.Text = RTrim(dr("Codigo").ToString())
        End If
    End Sub
End Class