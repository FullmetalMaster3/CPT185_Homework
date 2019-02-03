<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTechFair
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picFair = New System.Windows.Forms.PictureBox()
        CType(Me.picFair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(106, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(420, 71)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Tech Job Fair"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(126, 122)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(341, 35)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "All Students are Welcome"
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(167, 313)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(246, 55)
        Me.btnDetails.TabIndex = 2
        Me.btnDetails.Text = "View Job Fair Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(203, 404)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(173, 35)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "May 2, 2016"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Tahoma", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(136, 509)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(310, 35)
        Me.lblLocation.TabIndex = 4
        Me.lblLocation.Text = "Located in Lochlan Hall"
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Font = New System.Drawing.Font("Tahoma", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoom.Location = New System.Drawing.Point(216, 578)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(146, 35)
        Me.lblRoom.TabIndex = 5
        Me.lblRoom.Text = "Room 101"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(209, 791)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(181, 50)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picFair
        '
        Me.picFair.Location = New System.Drawing.Point(678, 44)
        Me.picFair.Name = "picFair"
        Me.picFair.Size = New System.Drawing.Size(495, 843)
        Me.picFair.TabIndex = 7
        Me.picFair.TabStop = False
        '
        'frmTechFair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 921)
        Me.Controls.Add(Me.picFair)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmTechFair"
        CType(Me.picFair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents btnDetails As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblRoom As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents picFair As PictureBox
End Class
