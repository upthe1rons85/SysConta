Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Public Class frmMovBancos_Elimina

    Private Sub frmMovBancos_Elimina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarBancos()
        MaximizeBox = False
    End Sub

    Private Sub CargarBancos()

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "select codigo,banco from catBancos (NOLOCK)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)


        cbxBancos.ValueMember = Trim("codigo")
        cbxBancos.DisplayMember = Trim("Banco")
        cbxBancos.DataSource = dt
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        DGVEliminaCheque.DataSource = Nothing
        DGVEliminaCheque.Rows.Clear()
        'cbxBancos.Enabled = False

        'Dim fecha As String
        If cbxBancos.SelectedValue = Nothing Then
            MsgBox("No se ha seleccionado ningun Banco valido", vbCritical, "Sistema Contable")
        Else
            '--------
            'fecha = Format(DTPChequeElim.Value, "yyyyMMdd")


            Dim dr As SqlDataReader
            Dim oclsMovBancos = New clsMovBancos()

            Dim Fecha As String
            Fecha = Format(DTPFecha.Value, "yyyyMMdd")

            dr = oclsMovBancos.SeleccionaChequesCancela(Fecha, cbxBancos.SelectedValue, txtCheque.Text)
            Dim dt = New DataTable()
            dt.Load(dr)

            If dt.Rows.Count > 0 Then


                '' llenar DATAGRID ------------------

                DGVEliminaCheque.Enabled = True
                DGVEliminaCheque.AutoGenerateColumns = False 'Aqui digo que las columnas no se generen automaticamente, sino que yo las lleno manualmente

                DGVEliminaCheque.Columns(0).DataPropertyName = Trim("folio") 'Inserta la cuenta contable
                DGVEliminaCheque.Columns(1).DataPropertyName = Trim("fecha")
                DGVEliminaCheque.Columns(2).DataPropertyName = Trim("codigobanco")
                DGVEliminaCheque.Columns(3).DataPropertyName = Trim("TipoDoc")
                DGVEliminaCheque.Columns(4).DataPropertyName = Trim("DOCUMENTO")
                DGVEliminaCheque.Columns(5).DataPropertyName = Trim("proveedor")
                DGVEliminaCheque.Columns(6).DataPropertyName = Trim("Subtotal")
                DGVEliminaCheque.Columns(7).DataPropertyName = Trim("IVA")
                DGVEliminaCheque.Columns(8).DataPropertyName = Trim("IVARetencion")
                DGVEliminaCheque.Columns(9).DataPropertyName = Trim("total")


                DGVEliminaCheque.DataSource = dt


            Else

                MsgBox("No existen Documentos Pendientes del banco y Folio seleccionado", vbInformation, "Sistema Contable")

            End If
        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If MessageBox.Show("¿Desea Eliminar los Registros Seleccionados?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            

                If DGVEliminaCheque.RowCount = 0 Then
                    MsgBox("Debe Seleccionar un Documento", MsgBoxStyle.Information)
                Else
                Try
                    Dim Selecciona As Integer = 0
                    For Each row As DataGridViewRow In DGVEliminaCheque.Rows

                        If row.Cells("dselecciona").Value = True Then
                            Selecciona = Selecciona + 1
                        End If
                    Next

                    If Selecciona = 0 Then
                        MsgBox("No Se ah Seleccionado Ningun Documento", MsgBoxStyle.Exclamation, "Sistema Contable")
                        Exit Sub
                    End If
                    For Each row As DataGridViewRow In DGVEliminaCheque.Rows
                        If row.Cells("dselecciona").Value = True Then

                            If Trim(row.Cells("dTipoDoc").Value) = "CHEQUE" Then
                                Dim oClsMovBancos As New clsMovBancos
                                oClsMovBancos.CancelaCheque(row.Cells("dFolioKardex").Value, row.Cells("dBanco").Value, row.Cells("dDocumento").Value)
                                MsgBox("CHEQUE Cancelado Correctamente", MsgBoxStyle.Information, "Sistema Contable")
                                btnBuscar.PerformClick()
                            Else
                                Dim oClsMovBancos As New clsMovBancos
                                oClsMovBancos.CancelaTransferencia(row.Cells("dFolioKardex").Value, row.Cells("dBanco").Value)
                                MsgBox("TRANSFERENCIA Cancelada Correctamente", MsgBoxStyle.Information, "Sistema Contable")
                                btnBuscar.PerformClick()

                            End If
                        End If
                    Next
                Catch ex As Exception
                    MsgBox("Error del Sistema" & vbCrLf & ex.Message)
                End Try
                End If
        End If
    End Sub

    Private Sub txtCheque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCheque.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnBuscar.PerformClick()
        End If

        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
End Class