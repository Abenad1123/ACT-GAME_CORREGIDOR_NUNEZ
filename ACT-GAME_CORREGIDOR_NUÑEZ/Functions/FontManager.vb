Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Module FontManager
    Public pfc As New PrivateFontCollection()
    Public fonts As New Dictionary(Of String, FontFamily)

    Public Sub LoadFont(name As String, fontData As Byte())
        Dim ptr As IntPtr = Marshal.AllocCoTaskMem(fontData.Length)
        Marshal.Copy(fontData, 0, ptr, fontData.Length)
        pfc.AddMemoryFont(ptr, fontData.Length)
        fonts(name) = pfc.Families.Last()
        Marshal.FreeCoTaskMem(ptr)
    End Sub

    Public Function GetFont(name As String, size As Single, Optional style As FontStyle = FontStyle.Regular) As Font
        Return New Font(fonts(name), size, style, GraphicsUnit.Pixel)
    End Function
End Module