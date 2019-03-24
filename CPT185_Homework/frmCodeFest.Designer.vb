<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCodeFest
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblAttendeeNum = New System.Windows.Forms.Label()
        Me.lblDiscountDisplay = New System.Windows.Forms.Label()
        Me.lblTotalCostLabel = New System.Windows.Forms.Label()
        Me.grpDiscountQ = New System.Windows.Forms.GroupBox()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.txtAttendNum = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpDiscountQ.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(80, 45)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(663, 55)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Code Fest 2019 Registration"
        '
        'lblAttendeeNum
        '
        Me.lblAttendeeNum.AutoSize = True
        Me.lblAttendeeNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendeeNum.Location = New System.Drawing.Point(73, 163)
        Me.lblAttendeeNum.Name = "lblAttendeeNum"
        Me.lblAttendeeNum.Size = New System.Drawing.Size(581, 74)
        Me.lblAttendeeNum.TabIndex = 1
        Me.lblAttendeeNum.Text = "Please Enter the Number of Attendees: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblDiscountDisplay
        '
        Me.lblDiscountDisplay.AutoSize = True
        Me.lblDiscountDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountDisplay.Location = New System.Drawing.Point(165, 259)
        Me.lblDiscountDisplay.Name = "lblDiscountDisplay"
        Me.lblDiscountDisplay.Size = New System.Drawing.Size(479, 31)
        Me.lblDiscountDisplay.TabIndex = 2
        Me.lblDiscountDisplay.Text = "Returning Visitors get a 15% Discount!"
        '
        'lblTotalCostLabel
        '
        Me.lblTotalCostLabel.AutoSize = True
        Me.lblTotalCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostLabel.Location = New System.Drawing.Point(274, 486)
        Me.lblTotalCostLabel.Name = "lblTotalCostLabel"
        Me.lblTotalCostLabel.Size = New System.Drawing.Size(166, 31)
        Me.lblTotalCostLabel.TabIndex = 3
        Me.lblTotalCostLabel.Text = "Total Cost: "
        '
        'grpDiscountQ
        '
        Me.grpDiscountQ.BackColor = System.Drawing.Color.White
        Me.grpDiscountQ.Controls.Add(Me.radNo)
        Me.grpDiscountQ.Controls.Add(Me.radYes)
        Me.grpDiscountQ.Location = New System.Drawing.Point(242, 314)
        Me.grpDiscountQ.Name = "grpDiscountQ"
        Me.grpDiscountQ.Size = New System.Drawing.Size(266, 156)
        Me.grpDiscountQ.TabIndex = 4
        Me.grpDiscountQ.TabStop = False
        Me.grpDiscountQ.Text = "Returning Attendee?"
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Checked = True
        Me.radNo.Location = New System.Drawing.Point(6, 102)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(70, 29)
        Me.radNo.TabIndex = 1
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Location = New System.Drawing.Point(6, 48)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(81, 29)
        Me.radYes.TabIndex = 0
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'txtAttendNum
        '
        Me.txtAttendNum.AcceptsReturn = True
        Me.txtAttendNum.Location = New System.Drawing.Point(660, 169)
        Me.txtAttendNum.Name = "txtAttendNum"
        Me.txtAttendNum.Size = New System.Drawing.Size(81, 31)
        Me.txtAttendNum.TabIndex = 5
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(406, 528)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 25)
        Me.lblTotalCost.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(534, 572)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 47)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(345, 572)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(118, 47)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(171, 572)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(121, 47)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmCodeFest
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(833, 664)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.txtAttendNum)
        Me.Controls.Add(Me.grpDiscountQ)
        Me.Controls.Add(Me.lblTotalCostLabel)
        Me.Controls.Add(Me.lblDiscountDisplay)
        Me.Controls.Add(Me.lblAttendeeNum)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmCodeFest"
        Me.Text = "Code Fest 2019 Registration"
        Me.grpDiscountQ.ResumeLayout(False)
        Me.grpDiscountQ.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblAttendeeNum As Label
    Friend WithEvents lblDiscountDisplay As Label
    Friend WithEvents lblTotalCostLabel As Label
    Friend WithEvents grpDiscountQ As GroupBox
    Friend WithEvents radNo As RadioButton
    Friend WithEvents radYes As RadioButton
    Friend WithEvents txtAttendNum As TextBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
End Class
