Imports System

Public Class Form1
	Function copy_to_clipboard(ByVal Str As String) As Boolean
		Dim ret As Boolean
		ret = False
		
		If Str = "" Then
			MsgBox("Nothing to copy")
		Else
			Try
				Clipboard.SetText(Str)
				ret = True
			Catch ex As Exception
				MsgBox("Coulnd't write clipboard. Plz try after sometime")
			End Try
		End If
		
		Return ret
		
	End Function
	
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		copy_to_clipboard(TextBox2.Text)
	End Sub
	
	Function convert(ByVal MetHod As Boolean, ByVal SrcStr As String) As String
		Dim New_Str As String
		If MetHod = True Then   '\ to /
			New_Str = Replace(SrcStr, Chr(92), Chr(47), 1, -1, CompareMethod.Text)
		Else
			New_Str = Replace(SrcStr, Chr(47), Chr(92), 1, -1, CompareMethod.Text)
		End If
		Return (New_Str)
	End Function
	
	Private Sub convert_and_update()
		Dim method As Boolean
		method = True
		If RadioButton3.Checked Then   '\ to /
			If TextBox1.Text.IndexOf("/") = -1 Then
				method = True
			Else
				method = False
			End If
		ElseIf RadioButton1.Checked Then   '\ to /
			method = True
		Else
			method = False
		End If
		
		TextBox2.Text = convert(method, TextBox1.Text)
	End Sub
	
	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		convert_and_update()
	End Sub
	
	Private Sub copy_path_from_clipboard()
		Try
			TextBox1.Text = Clipboard.GetText()
		Catch ex As Exception
			MsgBox("Coulnd't read from clipboard. Plz try after sometime")
		End Try
	End Sub
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		copy_path_from_clipboard()
	End Sub
	
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		If (copy_to_clipboard(TextBox2.Text) = True) Then
			Close()
		End If
	End Sub
	
	Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
		convert_and_update()
	End Sub
	
	Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
		convert_and_update()
	End Sub
	
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		copy_path_from_clipboard()
	End Sub
	
	
	Function GetBasePath(ByVal Path As String, ByVal DeliM As String) As String
		Dim BasePath As String
		If Path = "" Then
			MsgBox("Nothing to copy")
		Else
			Try
				BasePath = Path.Substring(0, Path.LastIndexOf(DeliM))
			Catch ex As Exception
				MsgBox("Couldn't fetch base path.")
			End Try
		End If
		Return (BasePath)
	End Function
	
	
	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Try
			System.Diagnostics.Process.Start("explorer.exe",TextBox2.Text)
		Catch ex As Exception
			MsgBox("Coulnd't start Explorer.exe")
		End Try
		
	End Sub
	
	
	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		Dim BasePath As String
		Dim Delim As String
		If RadioButton1.Checked Then   '\ to /
			Delim = "/"
		Else
			Delim = "\"
		End If
		BasePath = GetBasePath(TextBox2.Text, Delim)
		If BasePath = "" Then
			'Couldn't fetch base path
		Else
			copy_to_clipboard(BasePath)
		End If
	End Sub
	
End Class
