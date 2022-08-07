<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainmenu
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDep = New System.Windows.Forms.Button()
        Me.btnWith = New System.Windows.Forms.Button()
        Me.btnBal = New System.Windows.Forms.Button()
        Me.txtHidden = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.btnExit)
        Me.groupBox1.Controls.Add(Me.btnDep)
        Me.groupBox1.Controls.Add(Me.btnWith)
        Me.groupBox1.Controls.Add(Me.btnBal)
        Me.groupBox1.Location = New System.Drawing.Point(19, 68)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(344, 212)
        Me.groupBox1.TabIndex = 15
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Select Transaction"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(167, -16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(62, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Date & Time:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(182, 128)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 58)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Log Out"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDep
        '
        Me.btnDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDep.Location = New System.Drawing.Point(182, 46)
        Me.btnDep.Name = "btnDep"
        Me.btnDep.Size = New System.Drawing.Size(133, 58)
        Me.btnDep.TabIndex = 2
        Me.btnDep.Text = "Deposit"
        Me.btnDep.UseVisualStyleBackColor = True
        '
        'btnWith
        '
        Me.btnWith.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWith.Location = New System.Drawing.Point(23, 128)
        Me.btnWith.Name = "btnWith"
        Me.btnWith.Size = New System.Drawing.Size(133, 58)
        Me.btnWith.TabIndex = 1
        Me.btnWith.Text = "Withdraw"
        Me.btnWith.UseVisualStyleBackColor = True
        '
        'btnBal
        '
        Me.btnBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBal.Location = New System.Drawing.Point(23, 46)
        Me.btnBal.Name = "btnBal"
        Me.btnBal.Size = New System.Drawing.Size(133, 58)
        Me.btnBal.TabIndex = 0
        Me.btnBal.Text = "Balance Inquiry"
        Me.btnBal.UseVisualStyleBackColor = True
        '
        'txtHidden
        '
        Me.txtHidden.Location = New System.Drawing.Point(42, 303)
        Me.txtHidden.Name = "txtHidden"
        Me.txtHidden.Size = New System.Drawing.Size(100, 20)
        Me.txtHidden.TabIndex = 20
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.Blue
        Me.label6.Location = New System.Drawing.Point(16, 34)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(45, 16)
        Me.label6.TabIndex = 18
        Me.label6.Text = "Hello"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Blue
        Me.lblName.Location = New System.Drawing.Point(60, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 16)
        Me.lblName.TabIndex = 19
        Me.lblName.Text = "Name"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Blue
        Me.lblTime.Location = New System.Drawing.Point(224, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(41, 13)
        Me.lblTime.TabIndex = 17
        Me.lblTime.Text = "label3"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(166, 9)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(55, 13)
        Me.label2.TabIndex = 16
        Me.label2.Text = "Today is"
        '
        'Mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 295)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.txtHidden)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Mainmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnExit As System.Windows.Forms.Button
    Private WithEvents btnDep As System.Windows.Forms.Button
    Private WithEvents btnWith As System.Windows.Forms.Button
    Private WithEvents btnBal As System.Windows.Forms.Button
    Public WithEvents txtHidden As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents lblName As System.Windows.Forms.Label
    Private WithEvents lblTime As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
End Class
