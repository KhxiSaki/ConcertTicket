<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.radVIP = New System.Windows.Forms.RadioButton()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorChoose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor = New System.Windows.Forms.MenuStrip()
        Me.cdColor = New System.Windows.Forms.ColorDialog()
        Me.mnuColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SubTotal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Discount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total Due:"
        '
        'txtTicket
        '
        Me.txtTicket.Location = New System.Drawing.Point(181, 95)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.Size = New System.Drawing.Size(100, 22)
        Me.txtTicket.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ticket:"
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Location = New System.Drawing.Point(541, 67)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(233, 247)
        Me.lblMessage.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(371, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Type:"
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Checked = True
        Me.radStandard.Location = New System.Drawing.Point(374, 123)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(83, 20)
        Me.radStandard.TabIndex = 11
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "Standard"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'radVIP
        '
        Me.radVIP.AutoSize = True
        Me.radVIP.Location = New System.Drawing.Point(374, 165)
        Me.radVIP.Name = "radVIP"
        Me.radVIP.Size = New System.Drawing.Size(49, 20)
        Me.radVIP.TabIndex = 12
        Me.radVIP.Text = "VIP"
        Me.radVIP.UseVisualStyleBackColor = True
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(113, 375)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(147, 35)
        Me.cmdCalculate.TabIndex = 13
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(310, 375)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(147, 35)
        Me.cmdClear.TabIndex = 14
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(504, 375)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(147, 35)
        Me.cmdExit.TabIndex = 15
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(181, 140)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(100, 26)
        Me.lblSubTotal.TabIndex = 16
        '
        'lblDiscount
        '
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscount.Location = New System.Drawing.Point(181, 187)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(100, 26)
        Me.lblDiscount.TabIndex = 17
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalDue.Location = New System.Drawing.Point(181, 229)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(100, 26)
        Me.lblTotalDue.TabIndex = 18
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColorDefault, Me.mnuColorChoose})
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'mnuColorDefault
        '
        Me.mnuColorDefault.Name = "mnuColorDefault"
        Me.mnuColorDefault.Size = New System.Drawing.Size(224, 26)
        Me.mnuColorDefault.Text = "Default"
        '
        'mnuColorChoose
        '
        Me.mnuColorChoose.Name = "mnuColorChoose"
        Me.mnuColorChoose.Size = New System.Drawing.Size(224, 26)
        Me.mnuColorChoose.Text = "Choose"
        '
        'mnuColor
        '
        Me.mnuColor.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuColor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem})
        Me.mnuColor.Location = New System.Drawing.Point(0, 0)
        Me.mnuColor.Name = "mnuColor"
        Me.mnuColor.Size = New System.Drawing.Size(800, 28)
        Me.mnuColor.TabIndex = 0
        Me.mnuColor.Text = "MenuStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.radVIP)
        Me.Controls.Add(Me.radStandard)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtTicket)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnuColor)
        Me.Name = "Form1"
        Me.Text = "Concert Ticket Application"
        Me.mnuColor.ResumeLayout(False)
        Me.mnuColor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTicket As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents radStandard As RadioButton
    Friend WithEvents radVIP As RadioButton
    Friend WithEvents cmdCalculate As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuColorDefault As ToolStripMenuItem
    Friend WithEvents mnuColorChoose As ToolStripMenuItem
    Friend WithEvents mnuColor As MenuStrip
    Friend WithEvents cdColor As ColorDialog
End Class
