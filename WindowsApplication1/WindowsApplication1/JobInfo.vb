Public Class JobInfo
    Const salestax = 0.08D
    Const laborrate = 50D
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        jobnumtxtbox.Clear()
        cusnamtxtbox.Clear()
        partchantxtbox.Clear()
        laborhourstxtbox.Clear()
        partscost.Clear()
        laborcost.Clear()
        subtotal.Clear()
        taxtxtbox.Clear()
        tottxtbox.Clear()
        With jobnumtxtbox
            .Focus()
        End With


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim laborhours, partscharge, partstot, labortot, taxtot, subtot, total As Decimal
        Try
            laborhours = Decimal.Parse(laborhourstxtbox.Text)
            partscharge = Decimal.Parse(partchantxtbox.Text)
        Catch ex As Exception
            MessageBox.Show("Labor and Parts Entry must be numeric", "Data Entry Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        taxtot = partscharge * salestax
        partstot = partscharge + taxtot
        labortot = laborhours * laborrate
        subtot = partscharge + labortot
        total = partstot + labortot

        partscost.Text = partscharge.ToString("C")
        laborcost.Text = labortot.ToString("C")
        subtotal.Text = subtot.ToString("C")
        taxtxtbox.Text = taxtot.ToString("C")
        tottxtbox.Text = total.ToString("C")

    End Sub
End Class