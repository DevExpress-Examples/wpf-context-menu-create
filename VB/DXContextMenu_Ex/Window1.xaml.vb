Imports System.Windows

Namespace DXContextMenu_Ex
	Partial Public Class Window1
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub itemCopy_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
			textEdit1.Copy()
		End Sub

		Private Sub itemPaste_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
			textEdit1.Paste()
		End Sub

		Private Sub itemUndo_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
			textEdit1.Undo()
		End Sub

		Private Sub itemRedo_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
			textEdit1.Redo()
		End Sub
	End Class
End Namespace