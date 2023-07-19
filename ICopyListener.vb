Public Interface ICopyListener

    Sub OnCopying(ByVal orig As IO.FileSystemInfo, ByVal new_path As IO.FileSystemInfo)
    Sub OnCopied(ByVal orig As IO.FileSystemInfo, ByVal new_path As IO.FileSystemInfo)
    Function OnFileExists(ByVal path As IO.FileSystemInfo) As Boolean
    Sub OnCopyFailed(ByVal orig As IO.FileSystemInfo, ByVal new_path As IO.FileSystemInfo, ex As Exception)

End Interface
