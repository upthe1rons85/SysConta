Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.frmActivoFijo
Imports WindowsApplication1.ClsActivos
Imports WindowsApplication1.mdVariables
Public Class frmCtasActivosFijos_list
    Dim Variable As String = 0
    Private Sub frmCtasActivosFijos_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenalista()

        txtDescripcion.Text = "Descripción"
        txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtCuenta.ForeColor = Color.Black
        txtCuenta.Text = "Cuenta"
        txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtDescripcion.ForeColor = Color.Black
    End Sub
    Private Sub llenalista()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet


        If tipocuenta = "Activo" Then
            Dim consulta As String = "select * from catcuentas(nolock) where cuenta>12001300000000 and cuenta<12003110000000 order by cuenta"
            Dim cmd As New SqlCommand(consulta, cnnConexion)
            'cmd.CommandType = CommandType.Text
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(ds, "CatActivos")
            Dim objListItem As New ListViewItem
            Me.lstMuestraCtaActivo.Items.Clear()
            For Each drw As DataRow In ds.Tables("CatActivos").Rows
                objListItem = lstMuestraCtaActivo.Items.Add(drw.Item("Cuenta").ToString, 0)
                objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
            Next
        ElseIf tipocuenta = "Depreciacion" Then
            Dim consulta As String = "select * from catcuentas(nolock) where cuenta>12005300000000 and cuenta<12007110000000 order by cuenta"
            Dim cmd As New SqlCommand(consulta, cnnConexion)
            'cmd.CommandType = CommandType.Text
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(ds, "CatActivos")
            Dim objListItem As New ListViewItem
            Me.lstMuestraCtaActivo.Items.Clear()
            For Each drw As DataRow In ds.Tables("CatActivos").Rows
                objListItem = lstMuestraCtaActivo.Items.Add(drw.Item("Cuenta").ToString, 0)
                objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
            Next
        ElseIf tipocuenta = "Gasto" Then
            Dim consulta As String = "select * from catcuentas(nolock) where cuenta>61008900000000 and cuenta<61008910000000 order by cuenta"
            Dim cmd As New SqlCommand(consulta, cnnConexion)
            'cmd.CommandType = CommandType.Text
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(ds, "CatActivos")
            Dim objListItem As New ListViewItem
            Me.lstMuestraCtaActivo.Items.Clear()
            For Each drw As DataRow In ds.Tables("CatActivos").Rows
                objListItem = lstMuestraCtaActivo.Items.Add(drw.Item("Cuenta").ToString, 0)
                objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
            Next
        End If

        
        VPCatCuentasPuente = ""
    End Sub
    Private Sub txtCuenta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuenta.GotFocus
        txtDescripcion.Text = "Descripción"
        txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtCuenta.Text = ""
        txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtCuenta.ForeColor = Color.Black
    End Sub
    Private Sub txtDescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.GotFocus
        txtCuenta.Text = "Cuenta"
        txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtDescripcion.Text = ""
        txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtDescripcion.ForeColor = Color.Black
    End Sub
    Private Sub txtCuenta_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuenta.KeyUp
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim bclsCtasActivos = New ClsActivos()

        dr = bclsCtasActivos.SeleccionaCtaActivos(Me.txtCuenta.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        lstMuestraCtaActivo.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("Cuenta").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstMuestraCtaActivo.Items.Add(lstLista)
        Next
    End Sub
    Private Sub txtDescripcion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyUp
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim bclsCtasActivos = New ClsActivos()

        dr = bclsCtasActivos.SeleccionaCtaActivosdesc(Me.txtDescripcion.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        lstMuestraCtaActivo.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("Cuenta").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstMuestraCtaActivo.Items.Add(lstLista)
        Next
    End Sub
    Private Sub lstMuestraCtaActivo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstMuestraCtaActivo.DoubleClick
        VPCatCuentasPuente = lstMuestraCtaActivo.SelectedItems(0).Text

        Me.Close()
    End Sub
    Private Sub lstMuestraCtaActivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstMuestraCtaActivo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If lstMuestraCtaActivo.Items(0).Selected = False Then
                MsgBox("No se ha Seleccionado Ningun Elemento", MsgBoxStyle.Exclamation)
                Return
            End If
            VPCatCuentasPuente = lstMuestraCtaActivo.SelectedItems(0).Text
            Me.Close()
        End If
    End Sub
End Class

