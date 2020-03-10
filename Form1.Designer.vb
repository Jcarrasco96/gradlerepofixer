<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPathProject = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboRepos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVersionGradle = New System.Windows.Forms.TextBox()
        Me.btnSelectProject = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSelectGradle = New System.Windows.Forms.Button()
        Me.txtPathGradle = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ruta del proyecto"
        '
        'txtPathProject
        '
        Me.txtPathProject.Location = New System.Drawing.Point(145, 12)
        Me.txtPathProject.Name = "txtPathProject"
        Me.txtPathProject.ReadOnly = True
        Me.txtPathProject.Size = New System.Drawing.Size(447, 22)
        Me.txtPathProject.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Repositorio"
        '
        'cboRepos
        '
        Me.cboRepos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRepos.FormattingEnabled = True
        Me.cboRepos.Items.AddRange(New Object() {"Nexus UCf", "Nexus UCI", "Repositorios de Google"})
        Me.cboRepos.Location = New System.Drawing.Point(145, 41)
        Me.cboRepos.Name = "cboRepos"
        Me.cboRepos.Size = New System.Drawing.Size(178, 24)
        Me.cboRepos.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(347, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Version del plugin Gradle"
        '
        'txtVersionGradle
        '
        Me.txtVersionGradle.Location = New System.Drawing.Point(521, 41)
        Me.txtVersionGradle.Name = "txtVersionGradle"
        Me.txtVersionGradle.Size = New System.Drawing.Size(70, 22)
        Me.txtVersionGradle.TabIndex = 4
        Me.txtVersionGradle.Text = "3.5.1"
        Me.txtVersionGradle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSelectProject
        '
        Me.btnSelectProject.Location = New System.Drawing.Point(598, 11)
        Me.btnSelectProject.Name = "btnSelectProject"
        Me.btnSelectProject.Size = New System.Drawing.Size(52, 27)
        Me.btnSelectProject.TabIndex = 2
        Me.btnSelectProject.Text = "..."
        Me.btnSelectProject.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ruta del gradle.zip"
        '
        'btnSelectGradle
        '
        Me.btnSelectGradle.Location = New System.Drawing.Point(598, 69)
        Me.btnSelectGradle.Name = "btnSelectGradle"
        Me.btnSelectGradle.Size = New System.Drawing.Size(52, 27)
        Me.btnSelectGradle.TabIndex = 6
        Me.btnSelectGradle.Text = "..."
        Me.btnSelectGradle.UseVisualStyleBackColor = True
        '
        'txtPathGradle
        '
        Me.txtPathGradle.Location = New System.Drawing.Point(145, 70)
        Me.txtPathGradle.Name = "txtPathGradle"
        Me.txtPathGradle.ReadOnly = True
        Me.txtPathGradle.Size = New System.Drawing.Size(447, 22)
        Me.txtPathGradle.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(500, 114)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 27)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Configurar proyecto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(355, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Desarrollado por jcarrasco96 - Idea original: Dairon Ian"
        '
        'fbd
        '
        Me.fbd.ShowNewFolderButton = False
        '
        'ofd
        '
        Me.ofd.DefaultExt = "zip"
        Me.ofd.Filter = "ZIP Files|*.zip"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 153)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnSelectGradle)
        Me.Controls.Add(Me.txtPathGradle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSelectProject)
        Me.Controls.Add(Me.txtVersionGradle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboRepos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPathProject)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GradleRepoFixer 1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPathProject As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboRepos As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVersionGradle As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectProject As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSelectGradle As System.Windows.Forms.Button
    Friend WithEvents txtPathGradle As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fbd As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog

End Class
