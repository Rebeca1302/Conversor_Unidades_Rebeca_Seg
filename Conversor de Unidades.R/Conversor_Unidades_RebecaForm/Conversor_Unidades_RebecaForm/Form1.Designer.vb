<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        cmbUnidadDesde = New ComboBox()
        cmbUnidadA = New ComboBox()
        txtValor = New TextBox()
        btnConvertir = New Button()
        lblResultado = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbUnidadDesde
        ' 
        cmbUnidadDesde.FormattingEnabled = True
        cmbUnidadDesde.Location = New Point(86, 189)
        cmbUnidadDesde.Name = "cmbUnidadDesde"
        cmbUnidadDesde.Size = New Size(151, 28)
        cmbUnidadDesde.TabIndex = 0
        ' 
        ' cmbUnidadA
        ' 
        cmbUnidadA.FormattingEnabled = True
        cmbUnidadA.Location = New Point(538, 189)
        cmbUnidadA.Name = "cmbUnidadA"
        cmbUnidadA.Size = New Size(151, 28)
        cmbUnidadA.TabIndex = 1
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(299, 134)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(169, 27)
        txtValor.TabIndex = 2
        ' 
        ' btnConvertir
        ' 
        btnConvertir.BackColor = Color.SandyBrown
        btnConvertir.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConvertir.Location = New Point(313, 271)
        btnConvertir.Name = "btnConvertir"
        btnConvertir.Size = New Size(142, 43)
        btnConvertir.TabIndex = 3
        btnConvertir.Text = "Convertir"
        btnConvertir.UseVisualStyleBackColor = False
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.BackColor = Color.Coral
        lblResultado.Font = New Font("Tempus Sans ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblResultado.Location = New Point(24, 365)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(133, 37)
        lblResultado.TabIndex = 4
        lblResultado.Text = "Resultado"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(311, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 22)
        Label1.TabIndex = 5
        Label1.Text = "Ingresa un Valor:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(86, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 22)
        Label2.TabIndex = 6
        Label2.Text = "De la Unidad:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(578, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 22)
        Label3.TabIndex = 7
        Label3.Text = "A la Unidad:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Tempus Sans ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(227, 34)
        Label4.Name = "Label4"
        Label4.Size = New Size(311, 41)
        Label4.TabIndex = 8
        Label4.Text = "Conversor de Unidades"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._475523955ce4ccc10029e9955420dd40
        PictureBox1.Location = New Point(590, 271)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(180, 167)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblResultado)
        Controls.Add(btnConvertir)
        Controls.Add(txtValor)
        Controls.Add(cmbUnidadA)
        Controls.Add(cmbUnidadDesde)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbUnidadDesde As ComboBox
    Friend WithEvents cmbUnidadA As ComboBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents btnConvertir As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
