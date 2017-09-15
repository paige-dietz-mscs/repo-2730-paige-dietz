<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtStraw = New System.Windows.Forms.TextBox()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtRasp = New System.Windows.Forms.TextBox()
        Me.txtProjIncrease = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblProjStraw = New System.Windows.Forms.Label()
        Me.lblProjBlue = New System.Windows.Forms.Label()
        Me.lblProjRasp = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Strawberries:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(163, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Blueberries:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(160, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "&Raspberries:"
        '
        'txtStraw
        '
        Me.txtStraw.Location = New System.Drawing.Point(251, 152)
        Me.txtStraw.Name = "txtStraw"
        Me.txtStraw.Size = New System.Drawing.Size(103, 23)
        Me.txtStraw.TabIndex = 2
        Me.txtStraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBlue
        '
        Me.txtBlue.Location = New System.Drawing.Point(250, 193)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(103, 23)
        Me.txtBlue.TabIndex = 4
        Me.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRasp
        '
        Me.txtRasp.Location = New System.Drawing.Point(250, 238)
        Me.txtRasp.Name = "txtRasp"
        Me.txtRasp.Size = New System.Drawing.Size(103, 23)
        Me.txtRasp.TabIndex = 6
        Me.txtRasp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProjIncrease
        '
        Me.txtProjIncrease.Location = New System.Drawing.Point(363, 53)
        Me.txtProjIncrease.Name = "txtProjIncrease"
        Me.txtProjIncrease.Size = New System.Drawing.Size(116, 23)
        Me.txtProjIncrease.TabIndex = 0
        Me.txtProjIncrease.Text = "0.05"
        Me.txtProjIncrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(237, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Projected i&ncrease % (in decimal form):"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(104, 294)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(87, 27)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(198, 294)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(87, 27)
        Me.btnPrint.TabIndex = 16
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(293, 294)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 27)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(387, 294)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 27)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblProjStraw
        '
        Me.lblProjStraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjStraw.Location = New System.Drawing.Point(373, 152)
        Me.lblProjStraw.Name = "lblProjStraw"
        Me.lblProjStraw.Size = New System.Drawing.Size(101, 23)
        Me.lblProjStraw.TabIndex = 13
        Me.lblProjStraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProjBlue
        '
        Me.lblProjBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjBlue.Location = New System.Drawing.Point(374, 194)
        Me.lblProjBlue.Name = "lblProjBlue"
        Me.lblProjBlue.Size = New System.Drawing.Size(101, 23)
        Me.lblProjBlue.TabIndex = 14
        Me.lblProjBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProjRasp
        '
        Me.lblProjRasp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjRasp.Location = New System.Drawing.Point(373, 238)
        Me.lblProjRasp.Name = "lblProjRasp"
        Me.lblProjRasp.Size = New System.Drawing.Size(101, 23)
        Me.lblProjRasp.TabIndex = 15
        Me.lblProjRasp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pdietz1f1.My.Resources.Resources.berry
        Me.PictureBox1.Location = New System.Drawing.Point(14, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(258, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Current Sales"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(374, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Projected Sales"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 350)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblProjRasp)
        Me.Controls.Add(Me.lblProjBlue)
        Me.Controls.Add(Me.lblProjStraw)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProjIncrease)
        Me.Controls.Add(Me.txtRasp)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtStraw)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStraw As TextBox
    Friend WithEvents txtBlue As TextBox
    Friend WithEvents txtRasp As TextBox
    Friend WithEvents txtProjIncrease As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblProjStraw As Label
    Friend WithEvents lblProjBlue As Label
    Friend WithEvents lblProjRasp As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
End Class
