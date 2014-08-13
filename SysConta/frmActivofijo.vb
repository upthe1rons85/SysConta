Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.ClsActivos
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.mdVariables
Public Class frmActivoFijo
    Dim FechadeAdquisicion As String
    Dim FechadeUso As String
    Dim TipoActivo As Integer
    Dim PorcDepreciacion As String
    Dim deduccioninvanual As String
    Private Sub frmActivoFijo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento Catálogo de Activos" + Space(10) + CStr(VersionCont())
        SLblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Dim toolTipGrabar As New ToolTip()
        toolTipGrabar.SetToolTip(Me.BtnGrabar, "Grabar")
        Dim toolTipNuevo As New ToolTip()
        toolTipNuevo.SetToolTip(Me.BtnNuevo, "Nuevo")
        Dim toolTipModificar As New ToolTip()
        toolTipModificar.SetToolTip(Me.btnModificar, "Modificar")
        Dim toolTipEliminar As New ToolTip()
        toolTipEliminar.SetToolTip(Me.BtnEliminar, "Eliminar")
        CargaDtosDepreciacion()
        CargaCecos()
        llenalista()
        CbxTipoActivoGen.Focus()
    End Sub
    Sub CargaDtosDepreciacion()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "Select area_depto,des_depto from compras.dbo.deptos(nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        Me.CbxCecos.ValueMember = "area_depto"
        Me.CbxCecos.DisplayMember = "des_depto"
        Me.CbxCecos.DataSource = dt
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub CargaCecos()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "Select * from catdeptosdepreciacion(nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        'llenara el combo box  CbxTipoActivoGen
        CbxTipoActivoGen.ValueMember = "idActivo"
        CbxTipoActivoGen.DisplayMember = "Descripcion"
        CbxTipoActivoGen.DataSource = dt
        'llenara el combo box  CbxTipoActivoDet
        CbxTipoActivoDet.ValueMember = "idActivo"
        CbxTipoActivoDet.DisplayMember = "Descripcion"
        CbxTipoActivoDet.DataSource = dt
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub llenalista()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Dim consulta As String = "Select CA.Descripcion,CDD.Descripcion as Depto,CA.MontoOriginal,CA.CuentaActivo,CA.CuentaGasto,CA.CuentaDepreciacion,CONVERT(varchar(10), CA.FechaAdquisicion, 111) as FechaAdquisicion,CONVERT(varchar(10),CA.FechaUso,111) as FechaUso,CA.MontoOriginal,CA.PorcentajeDepreciacion,CA.DeduccionInvAnual,CD.des_depto as Cecos,CA.MesesADepreciar,CA.Inpc from CatActivos CA Inner Join CatDeptosDepreciacion CDD on CDD.idActivo=CA.Depto Inner Join Compras.dbo.Deptos CD on CD.area_depto=CA.Cecos Where Depto= '" & CbxTipoActivoGen.SelectedValue & "' "
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        da.Fill(ds, "CatActivos")

        Dim objListItem As New ListViewItem
        Me.LstDatos.Items.Clear()

        For Each drw As DataRow In ds.Tables("CatActivos").Rows
            objListItem = LstDatos.Items.Add(drw.Item("Descripcion").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Depto").ToString)
            objListItem.SubItems.Add(drw.Item("DeduccionInvAnual").ToString)
            objListItem.SubItems.Add(drw.Item("MontoOriginal").ToString)
            objListItem.SubItems.Add(drw.Item("FechaAdquisicion").ToString)
            objListItem.SubItems.Add(drw.Item("FechaUso").ToString)
            objListItem.SubItems.Add(drw.Item("CuentaActivo").ToString)
            objListItem.SubItems.Add(drw.Item("CuentaGasto").ToString)
            objListItem.SubItems.Add(drw.Item("CuentaDepreciacion").ToString)
            objListItem.SubItems.Add(drw.Item("Cecos").ToString)
            objListItem.SubItems.Add(drw.Item("MesesADepreciar").ToString)
            objListItem.SubItems.Add(drw.Item("Inpc").ToString)
        Next
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If Me.TxtDescripcion.Text = "" Or Me.TxtCtaActivo.Text = "" Or Me.TxtCtaDepreciacion.Text = "" Or Me.TxtMonto.Text = "" Or Me.TxtInpc.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Contable")
            Me.CbxTipoActivoDet.Focus()
        Else
            If Me.DtpFechaUso.Text < Me.DtpFechaAdquisicion.Text Then
                MsgBox("La fecha de Uso no Puede ser menor a la fecha de adquisicion..!!!", vbInformation, "Sistema Contable")
            Else
                Try
                    'variable que integra la fecha seleccionada en datetimepicker
                    FechadeAdquisicion = Me.DtpFechaAdquisicion.Value.ToShortDateString
                    FechadeUso = Me.DtpFechaUso.Value.ToShortDateString

                    Dim cnnConexion = New SqlConnection()
                    Dim clsDB = New clsBD()
                    cnnConexion = clsDB.CreaConexion()

                    TipoActivo = Me.CbxTipoActivoDet.SelectedValue
                    Dim Monto As Decimal = Me.TxtMonto.Text
                    Dim DeduccionInvAnual2 As Decimal = Me.TxtDedInvAnual.Text

                    Dim idactivo As Integer
                    idactivo = 1

                    Me.TxtDescripcion.Text = UCase(Me.TxtDescripcion.Text)
                    Dim commandIns As New SqlCommand("spInsActivos", cnnConexion)
                    commandIns.CommandType = CommandType.StoredProcedure
                    commandIns.Parameters.AddWithValue("@nDescripcion", Me.TxtDescripcion.Text)
                    commandIns.Parameters.AddWithValue("@nDepto", TipoActivo)
                    commandIns.Parameters.AddWithValue("@nCuentaActivo", Me.TxtCtaActivo.Text)
                    commandIns.Parameters.AddWithValue("@nCuentaGasto", Me.TxtCtaGasto.Text)
                    commandIns.Parameters.AddWithValue("@nCuentaDepreciacion", Me.TxtCtaDepreciacion.Text)
                    commandIns.Parameters.AddWithValue("@nFechaAdquisicion", Me.DtpFechaAdquisicion.Text)
                    commandIns.Parameters.AddWithValue("@nFechaUso", Me.DtpFechaUso.Text)
                    commandIns.Parameters.AddWithValue("@nMontoOriginal", Monto)
                    commandIns.Parameters.AddWithValue("@nPorcentajeDepreciacion", Me.TxtPorcDepr.Text)
                    commandIns.Parameters.AddWithValue("@nDeduccionInvAnual", deduccioninvanual)
                    commandIns.Parameters.AddWithValue("@nCecos", Me.CbxCecos.SelectedValue)
                    commandIns.Parameters.AddWithValue("@nUsuarioModificacion", LoginUsuario)
                    commandIns.Parameters.AddWithValue("@nInpc", Me.TxtInpc.Text)
                    commandIns.ExecuteNonQuery()
                    cnnConexion.Close()
                    cnnConexion.Dispose()
                    commandIns.Dispose()
                    MsgBox("Registrado Correctamente", vbInformation, "Sistema Contable")
                    Me.TxtDescripcion.Clear()
                    Me.TxtMonto.Clear()
                    Me.TxtInpc.Clear()
                    Me.TxtPorcDepr.Clear()
                    Me.TxtDedInvAnual.Clear()
                    Me.TxtCtaActivo.Clear()
                    Me.TxtCtaGasto.Clear()
                    Me.TxtPorcDepr.Clear()
                    Me.TxtCtaDepreciacion.Clear()
                    Me.GbxAdquisicion.Enabled = False
                    Me.GbxCuentas.Enabled = False
                    Me.CbxTipoActivoDet.Enabled = False
                    Me.CbxCecos.Enabled = False
                    Me.TxtDescripcion.Enabled = False
                    Me.TxtMonto.Enabled = False
                    Me.TxtInpc.Enabled = False
                    Me.btnModificar.Enabled = False
                    Me.BtnGrabar.Enabled = False
                    llenalista()
                    CargaDtosDepreciacion()
                    TabGeneral.Focus()
                    Me.CbxTipoActivoGen.Focus()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
                End Try
            End If
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Me.CbxTipoActivoDet.Enabled = True
        Me.CbxCecos.Enabled = True
        Me.TxtDescripcion.Enabled = True
        Me.TxtMonto.Enabled = True
        Me.TxtInpc.Enabled = True
        Me.GbxAdquisicion.Enabled = True
        Me.GbxCuentas.Enabled = True
        Me.BtnGrabar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.BtnEliminar.Enabled = False
    End Sub
    Private Sub CbxTipoActivoGen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxTipoActivoGen.SelectedIndexChanged
        llenalista()
    End Sub
    Private Sub CbxTipoActivoDet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxTipoActivoDet.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtDescripcion.Focus()
        End If
    End Sub
    Private Sub TxtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.CbxCecos.Focus()
        End If
    End Sub
    Private Sub CbxCecos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxCecos.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.DtpFechaAdquisicion.Focus()
        End If
    End Sub
    Private Sub DtpFechaAdquisicion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFechaAdquisicion.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.DtpFechaUso.Focus()
        End If
    End Sub
    Private Sub DtpFechaUso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFechaUso.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtMonto.Focus()
        End If
    End Sub
    Private Sub TxtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMonto.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtInpc.Focus()
        End If
        If InStr(1, ".0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtInpc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtInpc.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.BtnGrabar.Focus()
        End If
        If InStr(1, ".0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtInpc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtInpc.LostFocus
       
        If Me.TxtInpc.Text = "" Then
            Me.TxtInpc.Text = 0.0
        Else
            Me.TxtInpc.Text = Format(CDec(Me.TxtInpc.Text), "###,###,##0.#0")
        End If
    End Sub
    Private Sub TxtMonto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtMonto.LostFocus
        Me.TxtMonto.Text = Format(CDec(Me.TxtMonto.Text), "##,##0.00")
        PorcDepreciacion = (Me.TxtMonto.Text)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim wQuery As String = ""
        Dim LocalCommand As SqlCommand
        Dim porcentajedepr As String
        wQuery = "Select TasaDepreciacion from catdeptosdepreciacion Where idActivo = '" & CbxTipoActivoDet.SelectedValue & "' "

        LocalCommand = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
        LocalCommand.CommandType = Data.CommandType.Text
        porcentajedepr = LocalCommand.ExecuteScalar()
        Me.TxtPorcDepr.Text = porcentajedepr
        deduccioninvanual = (Me.TxtMonto.Text * ((Me.TxtPorcDepr.Text) / 100))
        Me.TxtDedInvAnual.Text = Format(CDec(deduccioninvanual), "##,##0.00")
    End Sub
    Private Sub TxtPorcDepr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPorcDepr.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtCtaActivo.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBuscar.GotFocus
        TxtBuscar.Text = ""
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        TxtBuscar.ForeColor = Color.Black
    End Sub
    Private Sub TxtCtaActivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCtaActivo.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtCtaGasto.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtCtaGasto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCtaGasto.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtCtaDepreciacion.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtCtaDepreciacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCtaDepreciacion.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtMonto.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBuscar.KeyUp
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsActivos = New ClsActivos()

        dr = oclsActivos.BuscaDescActivos(Me.TxtBuscar.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        LstDatos.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("Descripcion").ToString)
            lstLista.SubItems.Add(rRow("Depto").ToString)
            lstLista.SubItems.Add(rRow("DeduccionInvAnual").ToString)
            lstLista.SubItems.Add(rRow("MontoOriginal").ToString)
            lstLista.SubItems.Add(rRow("FechaAdquisicion").ToString)
            lstLista.SubItems.Add(rRow("FechaUso").ToString)
            lstLista.SubItems.Add(rRow("CuentaActivo").ToString)
            lstLista.SubItems.Add(rRow("CuentaGasto").ToString)
            lstLista.SubItems.Add(rRow("CuentaDepreciacion").ToString)
            lstLista.SubItems.Add(rRow("Cecos").ToString)
            lstLista.SubItems.Add(rRow("MesesADepreciar").ToString)
            LstDatos.Items.Add(lstLista)
        Next
    End Sub
    Private Sub BtnCtaActivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCtaActivo.Click
        tipocuenta = "Activo"
        frmCtasActivosFijos_list.ShowDialog()
        Me.Refresh()
        TxtCtaActivo.Text = VPCatCuentasPuente
        Me.TxtCtaGasto.Focus()
    End Sub
    Private Sub BtnCtaGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCtaGasto.Click
        tipocuenta = "Gasto"
        frmCtasActivosFijos_list.ShowDialog()
        Me.Refresh()
        TxtCtaGasto.Text = VPCatCuentasPuente
        Me.TxtCtaDepreciacion.Focus()
    End Sub

    Private Sub BtnCtaDepreciacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCtaDepreciacion.Click
        tipocuenta = "Depreciacion"
        frmCtasActivosFijos_list.ShowDialog()
        Me.Refresh()
        TxtCtaDepreciacion.Text = VPCatCuentasPuente
        Me.TxtMonto.Focus()
    End Sub
    Private Sub DtpFechaUso_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpFechaUso.LostFocus
        If Me.DtpFechaUso.Value <= Me.DtpFechaAdquisicion.Value Then
            MsgBox("La Fecha Uso, debe ser al menos un mes posterior a la Fecha de Adquisicion, Favor de Revisar.", vbInformation, "Sistema Contable")
        End If
    End Sub
End Class