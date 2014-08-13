Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports WindowsApplication1.mdVariables
Imports WindowsApplication1.frmProgramacionPago_FacProv
Imports System.Data.SqlClient
Public Class frmProgramacionPago_CambioFacturaReporte

    Private Sub frmProgramacionPago_CambioFacturaReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LlenarCamposFacturas()
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
    End Sub

    Private Sub LlenarCamposFacturas()
        Dim dr As SqlDataReader
        Dim oclsProgramacionPago = New clsProgramacionPago()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        Dim cmd As New SqlCommand
        Dim dt = New DataTable()

        cnnConexion = clsDB.CreaConexion()

        cmd.CommandText = "spCambiarFacturaPagoReporte"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@cFactura", SqlDbType.VarChar).Value = txtFactura.Text
        cmd.Parameters.Add("@cProvedor", SqlDbType.VarChar).Value = txtCCProveedor.Text
        cmd.Parameters.Add("@CuentaContable", SqlDbType.VarChar).Value = txtCuentaContable.Text
        dr = cmd.ExecuteReader()


        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstDatos.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("nProveedor").ToString)
                lstLista.SubItems.Add(Trim(rRow("Proveedor").ToString))
                lstLista.SubItems.Add(Trim(rRow("CuentaContable").ToString))
                lstLista.SubItems.Add(Trim(rRow("Factura_old").ToString))
                lstLista.SubItems.Add(Trim(rRow("dFecha_old").ToString))
                lstLista.SubItems.Add(Trim(rRow("Factura_new").ToString))
                lstLista.SubItems.Add(Trim(rRow("dFecha_new").ToString))
                lstLista.SubItems.Add(Trim(rRow("usuario_cambio").ToString))
                lstDatos.Items.Add(lstLista)

            Next
        Else
            lstDatos.Items.Clear()
            MsgBox("No Existen informacion ", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactura.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            LlenarCamposFacturas()
        End If
    End Sub

    Private Sub txtCCProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCCProveedor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            LlenarCamposFacturas()
        End If
    End Sub

    Private Sub txtCuentaContable_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuentaContable.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            LlenarCamposFacturas()
        End If
    End Sub

End Class