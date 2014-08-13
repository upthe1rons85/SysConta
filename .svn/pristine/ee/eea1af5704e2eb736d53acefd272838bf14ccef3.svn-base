Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTools

Public Class frmTipoMovPoliza
    Dim FechaTc As String
    Dim FechaTc2 As String
    Dim xFecha As Date = Now

    Private Sub frmTipoMovPoliza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Perfil As String
        Perfil = "00-03-06"

        If Perfil Like "*" + Perfilesusuario + "*" Then

            Me.Text = "Mantenimiento Tipo de Movimiento de Poliza" + Space(10) + CStr(VersionCont())
            STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
            MaximizeBox = False
            muestraAbreviacion()
        Else

            MsgBox("No tiene Derechos Sobre esta Opcion", vbCritical, "Sistema Contable")
            Me.Close()

        End If
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If TxtAbr.Text = "" Then
        '    MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Contable")
        '    TxtPoliza.Focus()
        'Else
        '    Try


        '        Dim cnnConexion = New SqlConnection()
        '        Dim clsDB = New clsBD()
        '        cnnConexion = clsDB.CreaConexion()

        '        Dim commandIns As New SqlCommand("spInsAbreviacionTP", cnnConexion)
        '        commandIns.CommandType = CommandType.StoredProcedure
        '        commandIns.Parameters.AddWithValue("@nAbreviacion", TxtAbr.Text)
        '        commandIns.Parameters.AddWithValue("@nTipoPoliza", TxtPoliza.Text)


        '        commandIns.ExecuteNonQuery()
        '        cnnConexion.Close()
        '        cnnConexion.Dispose()
        '        commandIns.Dispose()
        '        MsgBox("Registrado Correctamente", vbInformation, "Sistema Contable")

        '        Dim limpiar As New clsTools
        '        limpiar.LimpiarControles(Me)
        '        TxtPoliza.Clear()
        '        TxtAbr.Clear()
        '        TxtPoliza.Enabled = False
        '        TxtAbr.Enabled = False

        '        btnModificar.Enabled = False
        '        BtnGrabar.Enabled = False
        '        muestraAbreviacion()
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '        MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
        '    End Try
        'End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()

            Dim commupdate As New SqlCommand("spModAbreviacion", cnnConexion)
            commupdate.CommandType = CommandType.StoredProcedure
            commupdate.Parameters.AddWithValue("@nAbreviacion", TxtAbr.Text)
            commupdate.Parameters.AddWithValue("@nTipoPoliza", TxtPoliza.Text)

            commupdate.ExecuteNonQuery()
            cnnConexion.Close()
            cnnConexion.Dispose()
            commupdate.Dispose()
            MsgBox("Actualizado Correctamente", vbInformation, "Sistema Contable")

            TxtAbr.Clear()
            TxtPoliza.Clear()

            'TxtAbr.Enabled = False
            'TxtPoliza.Enabled = False
            'btnModificar.Enabled = False
            'BtnGrabar.Enabled = False
            muestraAbreviacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
        End Try
    End Sub

    Private Sub TxtPoliza_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPoliza.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtAbr.Focus()
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtMov_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAbr.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnModificar.Focus()
        End If       
    End Sub

    Private Sub muestraAbreviacion()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Dim consulta As String = "Select TipoPoliza, Descripcion, Abreviacion from conTipoMovPoliza(nolock) order by TipoPoliza"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        da.Fill(ds, "conTipoMovPoliza")

        Dim objListItem As New ListViewItem
        Me.lstTipoMov.Items.Clear()

        For Each drw As DataRow In ds.Tables("conTipoMovPoliza").Rows
            objListItem = lstTipoMov.Items.Add(drw.Item("TipoPoliza").ToString)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
            objListItem.SubItems.Add(drw.Item("Abreviacion").ToString)
        Next
    End Sub

    Private Sub lstTipoMov_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTipoMov.DoubleClick
        TxtPoliza.Text = lstTipoMov.SelectedItems(0).SubItems(0).Text
        TxtAbr.Text = lstTipoMov.SelectedItems(0).SubItems(2).Text
        TxtBuscar.Text = "Buscar Tipo Poliza"
    End Sub

    Private Sub TxtBuscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBuscar.KeyDown
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsPoliza = New clsPolizasContables
        dr = oclsPoliza.BuscaTipoPoliza(Me.TxtBuscar.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        lstTipoMov.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("TipoPoliza").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstLista.SubItems.Add(rRow("Abreviacion").ToString)
            lstTipoMov.Items.Add(lstLista)
        Next
    End Sub

    Private Sub TxtBuscar_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtBuscar.MouseClick
        TxtBuscar.Clear()
    End Sub
End Class