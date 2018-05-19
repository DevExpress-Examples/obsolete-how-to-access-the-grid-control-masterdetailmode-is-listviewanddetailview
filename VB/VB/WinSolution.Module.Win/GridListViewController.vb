Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGrid
Imports DevExpress.XtraLayout
Imports DevExpress.ExpressApp
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.ExpressApp.Win.Layout
Imports DevExpress.ExpressApp.Win.Editors

Namespace WinSolution.Module.Win
	Public Class GridListViewController
		Inherits ViewController
		Public Sub New()
			TargetViewType = ViewType.ListView
		End Sub
		Protected Overrides Overloads Sub OnViewControlsCreated()
			MyBase.OnViewControlsCreated()
			Dim lv As ListView = (CType(View, ListView))
			'This code works for both the ListViewOnly and ListViewAndDetailView objects.
			Dim listEditor As GridListEditor = TryCast(lv.Editor, GridListEditor)
			If listEditor IsNot Nothing Then
				Dim grid As GridControl = listEditor.Grid
				Dim gv As GridView = listEditor.GridView
				'Do something great here.
			End If
			'The code below works only for the ListViewAndDetailView object.
			Dim dv As DetailView = lv.EditView
			If dv IsNot Nothing Then
				Dim layoutManager As WinLayoutManager = TryCast(dv.LayoutManager, WinLayoutManager)
				If layoutManager IsNot Nothing Then
					Dim layout As LayoutControl = layoutManager.Container
					'Do something great here.
				End If
			End If
		End Sub
	End Class
End Namespace