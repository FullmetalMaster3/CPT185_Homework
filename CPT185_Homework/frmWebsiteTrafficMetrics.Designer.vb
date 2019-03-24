<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWebsiteTrafficMetrics
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
        Me.btnAnalytics = New System.Windows.Forms.Button()
        Me.btnTitle = New System.Windows.Forms.Label()
        Me.lstMetric = New System.Windows.Forms.ListBox()
        Me.lblTimeSpent = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAnalytics
        '
        Me.btnAnalytics.Location = New System.Drawing.Point(78, 175)
        Me.btnAnalytics.Name = "btnAnalytics"
        Me.btnAnalytics.Size = New System.Drawing.Size(336, 53)
        Me.btnAnalytics.TabIndex = 0
        Me.btnAnalytics.Text = "Enter Visitor Metrics"
        Me.btnAnalytics.UseVisualStyleBackColor = True
        '
        'btnTitle
        '
        Me.btnTitle.AutoSize = True
        Me.btnTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTitle.Location = New System.Drawing.Point(161, 61)
        Me.btnTitle.Name = "btnTitle"
        Me.btnTitle.Size = New System.Drawing.Size(444, 42)
        Me.btnTitle.TabIndex = 2
        Me.btnTitle.Text = "Website Traffic Estimate"
        '
        'lstMetric
        '
        Me.lstMetric.FormattingEnabled = True
        Me.lstMetric.ItemHeight = 25
        Me.lstMetric.Location = New System.Drawing.Point(499, 164)
        Me.lstMetric.Name = "lstMetric"
        Me.lstMetric.Size = New System.Drawing.Size(222, 304)
        Me.lstMetric.TabIndex = 3
        '
        'lblTimeSpent
        '
        Me.lblTimeSpent.AutoSize = True
        Me.lblTimeSpent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeSpent.Location = New System.Drawing.Point(94, 594)
        Me.lblTimeSpent.Name = "lblTimeSpent"
        Me.lblTimeSpent.Size = New System.Drawing.Size(448, 31)
        Me.lblTimeSpent.TabIndex = 4
        Me.lblTimeSpent.Text = "Average Time Spent: xx.xx Seconds"
        Me.lblTimeSpent.Visible = False
        '
        'frmWebsiteTrafficMetrics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 904)
        Me.Controls.Add(Me.lblTimeSpent)
        Me.Controls.Add(Me.lstMetric)
        Me.Controls.Add(Me.btnTitle)
        Me.Controls.Add(Me.btnAnalytics)
        Me.Name = "frmWebsiteTrafficMetrics"
        Me.Text = "Website Traffic Metrics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAnalytics As Button
    Friend WithEvents btnTitle As Label
    Friend WithEvents lstMetric As ListBox
    Friend WithEvents lblTimeSpent As Label
End Class
