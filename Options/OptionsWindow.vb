Imports System.Security.Principal
Imports Microsoft.Win32

Public Class OptionsWindow
    Private Sub OptionsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim parent = Me.Owner
        If parent IsNot Nothing Then
            Me.Icon = parent.Icon
            Me.Text = parent.Text + " - Options"
        End If

        CopyIncludesRoot.Checked = Configuration.CopyIncludesRootFolder
        IgnoredFolders.Text = String.Join(vbCrLf, Configuration.IgnoredFolders)

        Button1.Image = ConvertAndResize(SystemIcons.Shield, New Size(20, 20))
        Button2.Image = ConvertAndResize(SystemIcons.Shield, New Size(20, 20))

        UpdateUI()
    End Sub

    Private Sub UpdateUI()
        ' Is the app already registered to folder's context menu ?
        Dim isRegistered = Program.IsContextMenuRegistered()
        If isRegistered Then
            Label4.Text = "SelectiveFileCopy is already registered in the context menu:"
            Button1.Enabled = False
            Button2.Enabled = True
        Else
            Label4.Text = "SelectiveFileCopy is not registered yet in the context menu:"
            Button1.Enabled = True
            Button2.Enabled = False
        End If

    End Sub

    Public Function ConvertAndResize(icon As Icon, size As Size) As Image
        ' Using Lanczos
        Dim bmp = New Bitmap(size.Width, size.Height)
        Using g = Graphics.FromImage(bmp)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(icon.ToBitmap(), New Rectangle(Point.Empty, size))
        End Using
        Return bmp
    End Function

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Configuration.CopyIncludesRootFolder = CopyIncludesRoot.Checked
        Configuration.IgnoredFolders = IgnoredFolders.Text _
            .Split(vbCrLf) _
            .Where(Function(x) Not String.IsNullOrWhiteSpace(x)) _
            .Select(Function(x) x.Trim()) _
            .ToArray()

        Configuration.PreProcess()
        Configuration.Save()

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub AddInFoldersContextMenu_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            ' Request admin rights using standard windows' functions
            If IsCurrentProcessAdmin() = False Then
                ' Restart as admin
                Dim startInfo = New ProcessStartInfo With {
                .UseShellExecute = True,
                .WorkingDirectory = Environment.CurrentDirectory,
                .FileName = Application.ExecutablePath,
                .Arguments = $"--{ProgramArguments.GetLongArgument(NameOf(ProgramArguments.RegisterContextMenu))}",
                .Verb = "runas"
            }

                Process.Start(startInfo).WaitForExit()

            Else
                Program.RegisterContextMenu()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        UpdateUI()

    End Sub

    Private Sub RemoveFromFoldersContextMenu_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try

            ' Request admin rights using standard windows' functions
            If IsCurrentProcessAdmin() = False Then
                ' Restart as admin
                Dim startInfo = New ProcessStartInfo With {
                .UseShellExecute = True,
                .WorkingDirectory = Environment.CurrentDirectory,
                .FileName = Application.ExecutablePath,
                .Arguments = $"--{ProgramArguments.GetLongArgument(NameOf(ProgramArguments.UnregisterContextMenu))}",
                .Verb = "runas"
            }

                Process.Start(startInfo).WaitForExit()

            Else
                Program.UnregisterContextMenu()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        UpdateUI()

    End Sub

    Public Function IsCurrentProcessAdmin() As Boolean
        Using identity = WindowsIdentity.GetCurrent()
            Dim principal = New WindowsPrincipal(identity)
            Return principal.IsInRole(WindowsBuiltInRole.Administrator)
        End Using
    End Function

End Class