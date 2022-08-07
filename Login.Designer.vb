<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.llblRegister = New System.Windows.Forms.LinkLabel()
        Me.txtAcctNo = New System.Windows.Forms.TextBox()
        Me.txtAcctName = New System.Windows.Forms.TextBox()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(318, 141)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 37)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(168, 112)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 15)
        Me.lblError.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(15, 34)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(131, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Account Name:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(15, 74)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(147, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Account Number:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.llblRegister)
        Me.groupBox1.Controls.Add(Me.btnLogin)
        Me.groupBox1.Controls.Add(Me.txtAcctNo)
        Me.groupBox1.Controls.Add(Me.txtAcctName)
        Me.groupBox1.Controls.Add(Me.lblError)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(424, 192)
        Me.groupBox1.TabIndex = 4
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "LogIn"
        '
        'llblRegister
        '
        Me.llblRegister.AutoSize = True
        Me.llblRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblRegister.Location = New System.Drawing.Point(16, 150)
        Me.llblRegister.Name = "llblRegister"
        Me.llblRegister.Size = New System.Drawing.Size(71, 18)
        Me.llblRegister.TabIndex = 6
        Me.llblRegister.TabStop = True
        Me.llblRegister.Text = "Register"
        '
        'txtAcctNo
        '
        Me.txtAcctNo.Location = New System.Drawing.Point(171, 74)
        Me.txtAcctNo.Name = "txtAcctNo"
        Me.txtAcctNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAcctNo.Size = New System.Drawing.Size(233, 20)
        Me.txtAcctNo.TabIndex = 4
        '
        'txtAcctName
        '
        Me.txtAcctName.Location = New System.Drawing.Point(171, 34)
        Me.txtAcctName.Name = "txtAcctName"
        Me.txtAcctName.Size = New System.Drawing.Size(233, 20)
        Me.txtAcctName.TabIndex = 3
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 221)
        Me.Controls.Add(Me.groupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogIn"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnLogin As System.Windows.Forms.Button
    Public WithEvents lblError As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents llblRegister As System.Windows.Forms.LinkLabel
    Public WithEvents txtAcctNo As System.Windows.Forms.TextBox
    Public WithEvents txtAcctName As System.Windows.Forms.TextBox

End Class
