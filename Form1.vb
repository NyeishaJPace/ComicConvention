Public Class frmComicConvention
    Const COST_LEVEL1 As Decimal = 380D
    Const COST_LEVEL2 As Decimal = 275D
    Const COST_LEVEL3 As Decimal = 209D
    Private Sub frmComicConvention_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdoSuperheroExperience.Checked = True
        txtGroupSize.Clear()
        lblTotalCost.Text = ""
        txtGroupSize.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rdoSuperheroExperience.Checked = True
        txtGroupSize.Clear()
        lblTotalcost.Text = ""
        txtGroupSize.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim groupSize As Integer
        Dim badgeCost As Decimal
        Dim totalCost As Decimal

        If Not Integer.TryParse(txtGroupSize.Text, groupSize) Then
            MessageBox.Show("Please enter a numeric value for the group size.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGroupSize.Clear()
            txtGroupSize.Focus()
            Return
        End If

        If groupSize < 1 Or groupSize > 20 Then
            MessageBox.Show("Please enter a valid group size (1 to 20).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGroupSize.Clear()
            txtGroupSize.Focus()
            Return
        End If

        If rdoSuperheroExperience.Checked Then
            badgeCost = COST_LEVEL1
        ElseIf rdoAutographs.Checked Then
            badgeCost = COST_LEVEL2
        ElseIf rdoConvention.Checked Then
            badgeCost = COST_LEVEL3
        End If

        totalCost = groupSize * badgeCost

        lblTotalCost.Text = totalCost.ToString("C")
    End Sub
End Class
