<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales_Tax_Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales_Tax_Calculator))
        Me.lblStore = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFinalCostLabel = New System.Windows.Forms.Label()
        Me.lblFinalCost = New System.Windows.Forms.Label()
        Me.picTech = New System.Windows.Forms.PictureBox()
        Me.lblTaxCost = New System.Windows.Forms.Label()
        Me.lblOriginalCostLabel = New System.Windows.Forms.Label()
        Me.lblOriginalCost = New System.Windows.Forms.Label()
        Me.lblItemCostLabel = New System.Windows.Forms.Label()
        CType(Me.picTech, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStore
        '
        Me.lblStore.AutoSize = True
        Me.lblStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStore.Location = New System.Drawing.Point(278, 32)
        Me.lblStore.Name = "lblStore"
        Me.lblStore.Size = New System.Drawing.Size(507, 61)
        Me.lblStore.TabIndex = 0
        Me.lblStore.Text = "Thomas Electronics"
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(316, 156)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(366, 31)
        Me.txtItemName.TabIndex = 1
        Me.txtItemName.Text = "Enter Item Name Here"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(563, 233)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(119, 40)
        Me.txtPrice.TabIndex = 2
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(112, 331)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(179, 78)
        Me.btnConfirm.TabIndex = 3
        Me.btnConfirm.Text = "Display Cost"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(341, 502)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(176, 37)
        Me.lblTax.TabIndex = 4
        Me.lblTax.Text = "Sales Tax: "
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(386, 331)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(157, 78)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(629, 333)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(156, 76)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFinalCostLabel
        '
        Me.lblFinalCostLabel.AutoSize = True
        Me.lblFinalCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalCostLabel.Location = New System.Drawing.Point(342, 557)
        Me.lblFinalCostLabel.Name = "lblFinalCostLabel"
        Me.lblFinalCostLabel.Size = New System.Drawing.Size(155, 33)
        Me.lblFinalCostLabel.TabIndex = 7
        Me.lblFinalCostLabel.Text = "Final Cost:"
        '
        'lblFinalCost
        '
        Me.lblFinalCost.AutoSize = True
        Me.lblFinalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalCost.Location = New System.Drawing.Point(552, 557)
        Me.lblFinalCost.Name = "lblFinalCost"
        Me.lblFinalCost.Size = New System.Drawing.Size(0, 33)
        Me.lblFinalCost.TabIndex = 8
        '
        'picTech
        '
        Me.picTech.Image = Global.CPT185_Homework.My.Resources.Resources.techimage
        Me.picTech.InitialImage = CType(resources.GetObject("picTech.InitialImage"), System.Drawing.Image)
        Me.picTech.Location = New System.Drawing.Point(-2, 636)
        Me.picTech.Name = "picTech"
        Me.picTech.Size = New System.Drawing.Size(942, 206)
        Me.picTech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTech.TabIndex = 9
        Me.picTech.TabStop = False
        '
        'lblTaxCost
        '
        Me.lblTaxCost.AutoSize = True
        Me.lblTaxCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxCost.Location = New System.Drawing.Point(552, 506)
        Me.lblTaxCost.Name = "lblTaxCost"
        Me.lblTaxCost.Size = New System.Drawing.Size(0, 33)
        Me.lblTaxCost.TabIndex = 10
        '
        'lblOriginalCostLabel
        '
        Me.lblOriginalCostLabel.AutoSize = True
        Me.lblOriginalCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOriginalCostLabel.Location = New System.Drawing.Point(342, 455)
        Me.lblOriginalCostLabel.Name = "lblOriginalCostLabel"
        Me.lblOriginalCostLabel.Size = New System.Drawing.Size(201, 33)
        Me.lblOriginalCostLabel.TabIndex = 11
        Me.lblOriginalCostLabel.Text = "Original Cost: "
        '
        'lblOriginalCost
        '
        Me.lblOriginalCost.AutoSize = True
        Me.lblOriginalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOriginalCost.Location = New System.Drawing.Point(552, 455)
        Me.lblOriginalCost.Name = "lblOriginalCost"
        Me.lblOriginalCost.Size = New System.Drawing.Size(0, 33)
        Me.lblOriginalCost.TabIndex = 12
        '
        'lblItemCostLabel
        '
        Me.lblItemCostLabel.AutoSize = True
        Me.lblItemCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCostLabel.Location = New System.Drawing.Point(310, 236)
        Me.lblItemCostLabel.Name = "lblItemCostLabel"
        Me.lblItemCostLabel.Size = New System.Drawing.Size(233, 33)
        Me.lblItemCostLabel.TabIndex = 13
        Me.lblItemCostLabel.Text = "Enter Item Cost: "
        '
        'Sales_Tax_Calculator
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 844)
        Me.Controls.Add(Me.lblItemCostLabel)
        Me.Controls.Add(Me.lblOriginalCost)
        Me.Controls.Add(Me.lblOriginalCostLabel)
        Me.Controls.Add(Me.lblTaxCost)
        Me.Controls.Add(Me.picTech)
        Me.Controls.Add(Me.lblFinalCost)
        Me.Controls.Add(Me.lblFinalCostLabel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.lblStore)
        Me.Name = "Sales_Tax_Calculator"
        Me.Text = "Thomas Electronics"
        CType(Me.picTech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStore As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblTax As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFinalCostLabel As Label
    Friend WithEvents lblFinalCost As Label
    Friend WithEvents picTech As PictureBox
    Friend WithEvents lblTaxCost As Label
    Friend WithEvents lblOriginalCostLabel As Label
    Friend WithEvents lblOriginalCost As Label
    Friend WithEvents lblItemCostLabel As Label
End Class
