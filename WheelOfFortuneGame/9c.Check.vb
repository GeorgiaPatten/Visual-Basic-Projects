'Name-          Georgia Patten
'Date-          May 29, 2017
'Description-   This is the final form, and where you see the amount of money you won.
'___________________________________________________________________________________________


Public Class frmCheck

    Private Sub frmCheck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDollarValue.Text = intMoney
        lblName.Text = strFirstName & strLastName
        lblDate.Text = Date.Now
    End Sub
End Class