Imports System.Data.SqlClient

Public Class frmInformeMovimientosProveedor

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If TxtCodigo.Text = "" Then
            Dim frm As New frmRPTInformeMovCatProveedores
            frm.FchIni = dtpFchIni.Value
            frm.FchFin = dtpFchFin.Value
            frm.Show()
        Else
            Dim frm As New frmRPTInformeMovProveedores
            frm.codigo = Val(TxtCodigo.Text)
            frm.FchIni = dtpFchIni.Value
            frm.FchFin = dtpFchFin.Value
            frm.Show()
        End If
    End Sub

    Private Sub frmInformeMovimientosProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        llenalista()
    End Sub

    Private Sub llenalista()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "Select * from Almacen.Dbo.catProveedores(nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "catProveedores")
        Dim objListItem As New ListViewItem
        lstProveedor.Items.Clear()
        For Each drw As DataRow In ds.Tables("catProveedores").Rows
            objListItem = lstProveedor.Items.Add(drw.Item("Codigo").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Proveedor").ToString)
        Next
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Private Sub TxtBuscar_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBuscar.KeyUp
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsClientes = New ClsProveedores()
        dr = oclsClientes.BuscaNombreProveedor(Me.TxtBuscar.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        lstProveedor.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("Codigo").ToString)
            lstLista.SubItems.Add(rRow("Proveedor").ToString)
            lstProveedor.Items.Add(lstLista)
        Next
    End Sub

    Private Sub TxtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If TxtCodigo.Text = "" Then
                btnImprimir.PerformClick()
            Else
                Dim dr As SqlDataReader
                Dim oClsProveedores As New ClsProveedores
                dr = oClsProveedores.SeleccionaProveedores(TxtCodigo.Text)

                If dr.Read() Then
                    btnImprimir.PerformClick()
                Else
                    MsgBox("No Existe el Codigo de Proveedor", MsgBoxStyle.Critical)
                    TxtCodigo.SelectAll()
                End If
            End If
        End If
    End Sub

    Private Sub lstProveedor_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstProveedor.MouseDoubleClick
        TxtCodigo.Text = lstProveedor.SelectedItems(0).SubItems(0).Text
        TxtBuscar.Text = "Buscar Proveedor"
    End Sub

    Private Sub TxtBuscar_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtBuscar.MouseClick
        TxtBuscar.Clear()
    End Sub
End Class