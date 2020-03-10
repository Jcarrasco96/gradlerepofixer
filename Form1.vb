Public Class Form1

    Private Sub btnSelectProject_Click(sender As Object, e As EventArgs) Handles btnSelectProject.Click
        If fbd.ShowDialog = Windows.Forms.DialogResult.OK Then
            If fbd.SelectedPath.EndsWith("\") Then
                pathProject = fbd.SelectedPath
            Else
                pathProject = fbd.SelectedPath & "\"
            End If
            txtPathProject.Text = pathProject
        End If
    End Sub

    Private Sub btnSelectGradle_Click(sender As Object, e As EventArgs) Handles btnSelectGradle.Click
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtPathGradle.Text = ofd.FileName
            pathGradle = ofd.FileName
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtVersionGradle.Text.Equals("") Then
            'MsgBox("Debe especificar la version del plugin Gradle a usar en el proyecto")
            'Exit Sub
            txtVersionGradle.Text = "3.5.1"
        End If

        If pathProject.Equals("") Then
            MsgBox("Debe seleccionar un proyecto")
            Exit Sub
        End If

        If pathGradle.Equals("") Then
            MsgBox("Debe seleccionar un archivo gradle-x.x.x-all.zip")
            Exit Sub
        End If

        Select Case cboRepos.SelectedItem
            Case "Nexus UCf"
                configureUCF(txtVersionGradle.Text)
                MsgBox("Proyecto configurado usando los repositorios de la UCf")
            Case "Nexus UCI"
                configureUCI(txtVersionGradle.Text)
                MsgBox("Proyecto configurado usando los repositorios de la UCI")
            Case "Repositorios de Google"
                configureGOOGLE(txtVersionGradle.Text)
                MsgBox("Proyecto configurado usando los repositorios de Google")
            Case Else
                'MsgBox("Debe seleccionar un repositorio para configurar el proyecto")
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRepos.SelectedIndex = 2
    End Sub

End Class
