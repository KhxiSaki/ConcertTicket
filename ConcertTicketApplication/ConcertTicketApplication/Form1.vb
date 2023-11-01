Public Class Form1
    Dim intTicket As Integer
    Dim decDiscount As Decimal

    Const decStandard As Decimal = 150
    Const decVIP As Decimal = 250

    Private Function ValidateInputField() As Boolean
        If Not Integer.TryParse(txtTicket.Text, intTicket) Then
            lblMessage.Text = "Please input ticket number correctly"
            Return False
        End If

        Return True

    End Function

    Private Function CalculateTicketPrice(ByVal intTicket As Integer)
        Dim decTicketPrice As Decimal
        If radStandard.Checked = True Then
            decTicketPrice = decStandard * intTicket
        ElseIf radVIP.Checked = True Then
            decTicketPrice = decVIP * intTicket
        End If

        Return decTicketPrice
    End Function

    Function CalculateDiscount(ByVal intTicket As Integer, ByVal decTicketPrice As Decimal)
        Select Case intTicket
            Case Is >= 10
                decDiscount = decTicketPrice * 0.1
            Case Is >= 5
                decDiscount = decTicketPrice * 0.05
            Case Else
                decDiscount = 0
        End Select

        Return decDiscount


    End Function

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        Dim decTicketPrice As Decimal
        Dim decDiscount As Decimal
        Dim decTotalDue As Decimal

        lblMessage.Text = String.Empty

        If ValidateInputField() Then
            decTicketPrice = CalculateTicketPrice(intTicket)
            lblSubTotal.Text = decTicketPrice.ToString("C")

            decDiscount = CalculateDiscount(intTicket, decTicketPrice)
            lblDiscount.Text = decDiscount.ToString("C")

            decTotalDue = decTicketPrice - decDiscount
            lblTotalDue.Text = decTotalDue.ToString("C")

            If Not decDiscount = 0 Then
                lblMessage.Text = "You have earned a discount of: " & decDiscount.ToString("c") & ControlChars.CrLf & "Toral need to pay: " & decTotalDue.ToString("c")
            Else
                lblMessage.Text = "Total need to pay: " & decTotalDue.ToString("c")

            End If
        End If

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        radStandard.Checked = True
        txtTicket.Clear()
        lblDiscount.Text = String.Empty
        lblSubTotal.Text = String.Empty
        lblTotalDue.Text = String.Empty

        lblMessage.Text = "Discount 5% if you purchase more than 5 tickets|
                           Discount 10% if you purchase more than 10 tickets"

        txtTicket.Focus()


    End Sub

    Private Sub mnuColorDefault_Click(sender As Object, e As EventArgs) Handles mnuColorDefault.Click
        lblMessage.ForeColor = Color.Black

    End Sub

    Private Sub mnuColorChoose_Click(sender As Object, e As EventArgs) Handles mnuColorChoose.Click
        If cdColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblMessage.ForeColor = cdColor.Color


        End If
    End Sub
End Class
