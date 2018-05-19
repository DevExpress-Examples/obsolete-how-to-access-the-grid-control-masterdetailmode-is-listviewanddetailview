Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace WinSolution.Module
	<DefaultClassOptions, DefaultListViewOptionsAttribute(MasterDetailMode.ListViewOnly)> _
	Public Class ListViewOnly
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class
	<DefaultClassOptions, DefaultListViewOptionsAttribute(MasterDetailMode.ListViewAndDetailView)> _
	Public Class ListViewAndDetailView
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class
End Namespace
