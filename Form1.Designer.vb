<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComicConvention
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComicConvention))
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoConvention = New System.Windows.Forms.RadioButton()
        Me.rdoAutographs = New System.Windows.Forms.RadioButton()
        Me.rdoSuperheroExperience = New System.Windows.Forms.RadioButton()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(349, 474)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(146, 47)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(100, 474)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(146, 47)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(625, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chocolate
        Me.Label2.Location = New System.Drawing.Point(31, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(572, 40)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Comic Convention Registration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Chocolate
        Me.Label3.Location = New System.Drawing.Point(172, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Group size:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Chocolate
        Me.Label4.Location = New System.Drawing.Point(116, 406)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Registration Cost:"
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Location = New System.Drawing.Point(326, 247)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(46, 20)
        Me.txtGroupSize.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox1.Controls.Add(Me.rdoConvention)
        Me.GroupBox1.Controls.Add(Me.rdoAutographs)
        Me.GroupBox1.Controls.Add(Me.rdoSuperheroExperience)
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Chocolate
        Me.GroupBox1.Location = New System.Drawing.Point(100, 293)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 100)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Badge Type:"
        '
        'rdoConvention
        '
        Me.rdoConvention.AutoSize = True
        Me.rdoConvention.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoConvention.ForeColor = System.Drawing.Color.Chocolate
        Me.rdoConvention.Location = New System.Drawing.Point(17, 68)
        Me.rdoConvention.Name = "rdoConvention"
        Me.rdoConvention.Size = New System.Drawing.Size(141, 25)
        Me.rdoConvention.TabIndex = 2
        Me.rdoConvention.TabStop = True
        Me.rdoConvention.Text = "Convention"
        Me.rdoConvention.UseVisualStyleBackColor = True
        '
        'rdoAutographs
        '
        Me.rdoAutographs.AutoSize = True
        Me.rdoAutographs.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAutographs.ForeColor = System.Drawing.Color.Chocolate
        Me.rdoAutographs.Location = New System.Drawing.Point(17, 44)
        Me.rdoAutographs.Name = "rdoAutographs"
        Me.rdoAutographs.Size = New System.Drawing.Size(278, 25)
        Me.rdoAutographs.TabIndex = 1
        Me.rdoAutographs.TabStop = True
        Me.rdoAutographs.Text = "Convention + Autographs"
        Me.rdoAutographs.UseVisualStyleBackColor = True
        '
        'rdoSuperheroExperience
        '
        Me.rdoSuperheroExperience.AutoSize = True
        Me.rdoSuperheroExperience.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSuperheroExperience.ForeColor = System.Drawing.Color.Chocolate
        Me.rdoSuperheroExperience.Location = New System.Drawing.Point(17, 20)
        Me.rdoSuperheroExperience.Name = "rdoSuperheroExperience"
        Me.rdoSuperheroExperience.Size = New System.Drawing.Size(376, 25)
        Me.rdoSuperheroExperience.TabIndex = 0
        Me.rdoSuperheroExperience.TabStop = True
        Me.rdoSuperheroExperience.Text = "Convention + Superhero Experience"
        Me.rdoSuperheroExperience.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.Chocolate
        Me.lblTotalCost.Location = New System.Drawing.Point(359, 406)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(63, 20)
        Me.lblTotalCost.TabIndex = 9
        Me.lblTotalCost.Text = "Label5"
        '
        'frmComicConvention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 553)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "frmComicConvention"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoConvention As RadioButton
    Friend WithEvents rdoAutographs As RadioButton
    Friend WithEvents rdoSuperheroExperience As RadioButton
    Friend WithEvents lblTotalCost As Label
End Class
