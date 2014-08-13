Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports WindowsApplication1.mdVariables
Imports WindowsApplication1.frmProgramacionPago_FacProv
Imports System.Data.SqlClient
Public Class frmProgramacionPago_CambioFactura

    Private Sub SeleccionaEstatusFactura(ByVal Folio As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spCambiarFacturaPago"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1
        cmd.Parameters.Add("@FolioContraRecibo", SqlDbType.Int).Value = Folio
        cmd.Parameters.Add("@FacturaProveedor_old", SqlDbType.VarChar).Value = txtFactura.Text
        cmd.Parameters.Add("@FacturaProveedor_new", SqlDbType.VarChar).Value = ""
        cmd.Parameters.Add("@dFechaFactura_new", SqlDbType.DateTime).Value = Today
        cmd.Parameters.Add("@LoginUsuario", SqlDbType.VarChar).Value = ""

        dr = cmd.ExecuteReader()

        If dr.Read Then
            If dr("nEstatus").ToString = "0" Then
                MsgBox("No es posible modificar la factura ya que tiene pagos realizados", MsgBoxStyle.Information)
                lblEstatus.Text = dr("Estatus").ToString()
                'lblEstatus.ForeColor = Color.Red
                txtFacturaNueva.Enabled = False
            Else
                lblCodigo.Text = dr("CodigoProveedor").ToString()
                BtnGuardar.Enabled = True
                txtFacturaNueva.Enabled = True
                txtFacturaNueva.Select()
            End If

        End If

    End Sub

    Private Sub txtFacturaNueva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFacturaNueva.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnGuardar.Select()
        End If
    End Sub

    Private Sub txtFacturaNueva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFacturaNueva.TextChanged

    End Sub

    Private Sub frmProgramacionPago_CambioFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
        SeleccionaEstatusFactura(txtFolio.Text)
        'dtpFechaFactura.Value = Today
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        Dim transaction As SqlTransaction
        Dim XError As String

        If txtFacturaNueva.Text = "" Then
            MsgBox("Favor de capturar el folio nuevo de la factura a cambiar", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim oclsprogramacionPago As New clsProgramacionPago
        Dim dr As SqlDataReader
        dr = oclsprogramacionPago.VerificaFactura(lblCodigo.Text, txtFacturaNueva.Text)
        If dr.Read() Then
            Dim folioexiste As String
            Dim fecha As String
            folioexiste = dr("foliocontrarecibo").ToString()
            fecha = Mid(Trim(dr("fechacontrarecibo").ToString()), 1, 10)
            MsgBox("La Factura " & txtFacturaNueva.Text & " ya se encuentra registrada en la fecha " & fecha & " en el folio " & folioexiste & " NO PROCEDE !!", MsgBoxStyle.Information, "Sistema Contable")
        Else
            Dim facturaproveedor As String
            Dim contiene As Integer = 0
            For i = 0 To frmProgramacionPago.lstFacturas.Items.Count - 1
                facturaproveedor = Trim(frmProgramacionPago.lstFacturas.Items(i).SubItems(2).Text) '
                If txtFacturaNueva.Text = facturaproveedor Then
                    contiene = 1
                End If
            Next
            If contiene = 1 Then
                Exit Sub
                MsgBox("La Factura " & txtFacturaNueva.Text & " ya se encuentra agregada", MsgBoxStyle.Exclamation, "Sistema contable")
            End If
            cnnConexion = clsDB.CreaConexion()

            Dim cmd As New SqlCommand
            transaction = cnnConexion.BeginTransaction

            cmd.Connection = cnnConexion
            cmd.Transaction = transaction
            XError = ""
            Try
                XError = "Error al hacer el cambio de folio factura"

                cmd.Parameters.Clear()
                cmd.CommandText = "spCambiarFacturaPago"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnnConexion

                cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 2
                cmd.Parameters.Add("@FolioContraRecibo", SqlDbType.Int).Value = txtFolio.Text
                cmd.Parameters.Add("@FacturaProveedor_old", SqlDbType.NChar).Value = txtFactura.Text
                cmd.Parameters.Add("@FacturaProveedor_new", SqlDbType.NChar).Value = txtFacturaNueva.Text
                cmd.Parameters.Add("@dFechaFactura_new", SqlDbType.DateTime).Value = Format(Me.dtpFechaFactura.Value, "dd/MM/yyyy")
                cmd.Parameters.Add("@LoginUsuario", SqlDbType.NChar).Value = LoginUsuario

                cmd.ExecuteNonQuery()

                transaction.Commit()
                MsgBox("Se Grabo Correctamente, el cambio de Factura : " & txtFacturaNueva.Text, MsgBoxStyle.Information)
            Catch
                MsgBox("Ocurrio un Error al Grabar " & XError, MsgBoxStyle.Critical)
                transaction.Rollback()
            Finally
                cnnConexion.Dispose()
                cnnConexion.Close()
                Me.Close()
            End Try
        End If
    End Sub
End Class


