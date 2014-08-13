Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTipocambio
Imports WindowsApplication1.clsTools
Public Class frmTipoCambio
    Dim FechaTc As String
    Dim FechaTc2 As String
    Dim xFecha As Date = Now
    Private Sub frmTipoCambio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DtpFecha.Value = Today
        Dim Perfil As String
        Perfil = "00-05-06"

        If Perfil Like "*" + Perfilesusuario + "*" Then
            Me.Text = "Mantenimiento Catálogo de Tipo de Cambio" + Space(10) + CStr(VersionCont())
            STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
            MaximizeBox = False
            diastipocambio()
        Else
            MsgBox("No tiene Derechos Sobre esta Opcion", vbCritical, "Sistema Contable")
            Me.Close()
        End If
    End Sub

    Private Sub TxtCambio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCambio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtCaptacion.Focus()
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtCaptacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCaptacion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BtnGrabar.Focus()
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub DtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFecha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()

                'conversion para validar la fecha
                FechaTc = Me.DtpFecha.Value.ToShortDateString
                FechaTc = Format(CDate(FechaTc), "yyyy/MM/dd")

                Dim cmdvalida As New SqlCommand("spValidaFechTCambio", cnnConexion)
                cmdvalida.CommandType = CommandType.StoredProcedure

                cmdvalida.Parameters.AddWithValue("@Fecha", FechaTc)

                Dim n As Integer
                n = RTrim(cmdvalida.ExecuteScalar())
                If n > "0" Then
                    MsgBox("Ya esta capturado el tipo cambio para este dia, solo se puede modificar, si el tipo de cambio es del dia", vbInformation, "Sistema Contable")

                    Dim FechaHoy As String = Now
                    FechaHoy = Format(CDate(FechaHoy), "yyyy/MM/dd")

                    If FechaHoy = FechaTc Then
                        TxtCambio.Enabled = True
                        TxtCaptacion.Enabled = True
                        TxtCambio.Focus()
                        BtnGrabar.Enabled = False
                        btnModificar.Enabled = True
                    End If

                Else
                    TxtCambio.Enabled = True
                    TxtCaptacion.Enabled = True
                    BtnGrabar.Enabled = True
                    btnModificar.Enabled = False
                    TxtCambio.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
            End Try

        End If
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If TxtCambio.Text = "" Or TxtCaptacion.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Contable")
            TxtCambio.Focus()
        Else
            Try
                'variable que integra la fecha seleccionada en datetimepicker
                FechaTc2 = Me.DtpFecha.Value.ToShortDateString

                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()

                Dim commandIns As New SqlCommand("spInsFechaTC", cnnConexion)
                commandIns.CommandType = CommandType.StoredProcedure
                commandIns.Parameters.AddWithValue("@nFecha", FechaTc2)
                commandIns.Parameters.AddWithValue("@nTipoCambio", TxtCambio.Text)
                commandIns.Parameters.AddWithValue("@nTipoCaptacion", TxtCaptacion.Text)
                commandIns.Parameters.AddWithValue("@nFechaModificacion", xFecha)
                commandIns.Parameters.AddWithValue("@nUsuario", LoginUsuario)

                commandIns.ExecuteNonQuery()
                cnnConexion.Close()
                cnnConexion.Dispose()
                commandIns.Dispose()
                MsgBox("Registrado Correctamente", vbInformation, "Sistema Contable")

                Dim limpiar As New clsTools
                limpiar.LimpiarControles(Me)
                TxtCambio.Clear()
                TxtCaptacion.Clear()
                TxtCambio.Enabled = False
                TxtCaptacion.Enabled = False
                DtpFecha.Focus()
                btnModificar.Enabled = False
                BtnGrabar.Enabled = False
                diastipocambio()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
            End Try
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()

            FechaTc2 = Me.DtpFecha.Value.ToShortDateString

            Dim commupdate As New SqlCommand("spModFechaTC", cnnConexion)
            commupdate.CommandType = CommandType.StoredProcedure
            commupdate.Parameters.AddWithValue("@nFecha", FechaTc2)
            commupdate.Parameters.AddWithValue("@nTipoCambio", TxtCambio.Text)
            commupdate.Parameters.AddWithValue("@nTipoCaptacion", TxtCaptacion.Text)
            commupdate.Parameters.AddWithValue("@nFechaModificacion", xFecha)
            commupdate.Parameters.AddWithValue("@nUsuario", LoginUsuario)

            commupdate.ExecuteNonQuery()
            cnnConexion.Close()
            cnnConexion.Dispose()
            commupdate.Dispose()
            MsgBox("Actualizado Correctamente", vbInformation, "Sistema Contable")

            TxtCambio.Clear()
            TxtCaptacion.Clear()
            DtpFecha.Focus()
            TxtCambio.Enabled = False
            TxtCaptacion.Enabled = False
            btnModificar.Enabled = False
            BtnGrabar.Enabled = False
            diastipocambio()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
        End Try
    End Sub

    Private Sub diastipocambio()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Dim consulta As String = "Select top 10 CONVERT(varchar(10), Fecha, 111)as Fecha,TipoCambio,TipoCaptacion from CatTipoCambio(nolock) order by fecha desc"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        da.Fill(ds, "CatTipoCambio")


        Dim objListItem As New ListViewItem
        Me.lstTipoCambio.Items.Clear()

        For Each drw As DataRow In ds.Tables("CatTipoCambio").Rows
            objListItem = lstTipoCambio.Items.Add(drw.Item("Fecha").ToString, 0)
            objListItem.SubItems.Add(drw.Item("TipoCambio").ToString)
            objListItem.SubItems.Add(drw.Item("TipoCaptacion").ToString)
        Next
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        My.Forms.frmRPTTipoCambio.Show()
    End Sub
End Class