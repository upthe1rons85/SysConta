Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Public Class ListPolizasSistemasCompras

    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.Text = ""
        txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtBuscar.ForeColor = Color.Black
    End Sub
    Private Sub txtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyUp
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsPoliza = New clsPolizaCompras()
        dr = oclsPoliza.BuscarPoliza(Me.txtBuscar.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        LlenarLista()
        If dt.Rows.Count > 0 Then
            lstBuscar.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("Fecha").ToString)
                lstLista.SubItems.Add(rRow("TipoPoliza").ToString)
                lstLista.SubItems.Add(rRow("Poliza").ToString)
                lstLista.SubItems.Add(rRow("Cuenta").ToString)
                lstLista.SubItems.Add(rRow("Importe").ToString)
                lstLista.SubItems.Add(rRow("CargoAbono").ToString)
                lstLista.SubItems.Add(rRow("Concepto").ToString)
                lstLista.SubItems.Add(rRow("Referencia").ToString)
                lstLista.SubItems.Add(rRow("RefDocumento").ToString)
                lstLista.SubItems.Add(rRow("Estatus").ToString)
                lstLista.SubItems.Add(rRow("NumeroLinea").ToString)
                lstLista.SubItems.Add(rRow("CECO").ToString)
                lstBuscar.Items.Add(lstLista)
            Next
        End If
    End Sub
   Private Sub LlenarLista()
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsPoliza = New clsPolizaCompras()
        dr = oclsPoliza.BuscarPoliza(Me.txtBuscar.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstBuscar.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("Fecha").ToString)
                lstLista.SubItems.Add(rRow("TipoPoliza").ToString)
                lstLista.SubItems.Add(rRow("Poliza").ToString)
                lstLista.SubItems.Add(rRow("Cuenta").ToString)
                lstLista.SubItems.Add(rRow("Importe").ToString)
                lstLista.SubItems.Add(rRow("CargoAbono").ToString)
                lstLista.SubItems.Add(rRow("Concepto").ToString)
                lstLista.SubItems.Add(rRow("Referencia").ToString)
                lstLista.SubItems.Add(rRow("RefDocumento").ToString)
                lstLista.SubItems.Add(rRow("Estatus").ToString)
                lstLista.SubItems.Add(rRow("NumeroLinea").ToString)
                lstLista.SubItems.Add(rRow("CECO").ToString)
                lstBuscar.Items.Add(lstLista)
            Next
        End If
    End Sub
    Private Sub lstBuscar_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstBuscar.MouseDoubleClick
        Dim n As String
        n = lstBuscar.SelectedItems(0).SubItems(0).Text
        LlenarLista()
    End Sub
End Class