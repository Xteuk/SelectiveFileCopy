Public Class MainWindowUI

    Public Overridable Sub UpdateUI()
        BottomPanel3.Visible = CurrentStep = Steps.ElementsSelection Or CurrentStep = Steps.Running

        MainTreeView.Enabled = Not CurrentStep = Steps.Running
        FoldersTreeView.Enabled = Not CurrentStep = Steps.Running
        ByTypesTreeView.Enabled = Not CurrentStep = Steps.Running

        Me.Update()
    End Sub

    Private _currentStep As Steps = Steps.FolderSelection
    Public Property CurrentStep As Steps
        Get
            Return _currentStep
        End Get
        Set(value As Steps)
            _currentStep = value
            If InvokeRequired Then
                BeginInvoke(Sub() CurrentStep = value)
            Else
                UpdateUI()
            End If
        End Set
    End Property

    Public Property StatusText As String
        Get
            Return StatusLabel.Text
        End Get
        Set(value As String)
            If InvokeRequired Then
                BeginInvoke(Sub() StatusLabel.Text = value)
            Else
                StatusLabel.Text = value
            End If
        End Set
    End Property

    Private _destinationPath As String = ""
    Public Property DestinationPath As String
        Get
            Return _destinationPath
        End Get
        Set(value As String)
            _destinationPath = value
            DestinationPathTS.Text = value
        End Set
    End Property

    Public Property DestinationType As DestinationTypes
        Get
            If My.Settings.DestinationType = "" Then Return Nothing
            Try
                Return [Enum].Parse(GetType(DestinationTypes), My.Settings.DestinationType)
            Catch ex As Exception
                Return Nothing
            End Try
        End Get
        Set(value As DestinationTypes)
            My.Settings.DestinationType = value.ToString()
            Select Case value
                Case DestinationTypes.Folder
                    SelectDestFolderAction.Checked = True
                    SelectDestZipAction.Checked = False
                Case DestinationTypes.ZipFile
                    SelectDestFolderAction.Checked = False
                    SelectDestZipAction.Checked = True
            End Select
        End Set
    End Property

    Private _inputDirectory As String = ""
    Public Property InputDirectory As String
        Get
            Return _inputDirectory
        End Get
        Set(value As String)
            _inputDirectory = value
        End Set
    End Property

#Region "Actions"
    Public Overridable Sub SelectInputFolder(sender As CustomAction, args As EventArgs) _
    Handles SelectInputFolderAction.OnActionStart
        Throw New Exception("Function must be overriden")
    End Sub

    Public Overridable Sub SelectDestinationFolder()
        Throw New Exception("Function must be overriden")
    End Sub

    Public Overridable Sub SelectionDestinationZip()
        Throw New Exception("Function must be overriden")
    End Sub

    Public Overridable Sub StartCopy()
        Throw New Exception("Function must be overriden")
    End Sub

#End Region

End Class
