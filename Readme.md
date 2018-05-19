# OBSOLETE - How to access the grid control when a List View's MasterDetailMode attribute is set to ListViewAndDetailView


<p><strong>==========================================</strong><br><strong>This example is obsolete. Refer to the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2739">Access Grid Control Properties</a> and <a href="https://documentation.devexpress.com/eXpressAppFramework/112817/Concepts/UI-Construction/View-Items/View-Items-Layout-Customization">View Items Layout Customization</a>  help topics instead.</strong><br><strong>==========================================</strong><br><br>You might write the following code within your ViewController:</p>


```cs
(GridControl)View.Control
```




```vb
CType(View.Control, GridControl)
```


<p>and it might work in certain cases when your List View showed only one grid control, i.e. the MasterDetailMode = ListViewOnly. This code is not reliable and may fail if a List View was displayed alongside a Detail View or in other scenarios. <br>This example shows how to fix this problem and write the correct code for both cases:</p>


```vb
using System;
using DevExpress.XtraGrid;
using DevExpress.XtraLayout;
using DevExpress.ExpressApp;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.ExpressApp.Win.Layout;
using DevExpress.ExpressApp.Win.Editors;

namespace YourSolutionName.Module.Win {
    public class GridListViewController : ViewController {
        public GridListViewController() {
            TargetViewType = ViewType.ListView;
        }
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            ListView lv = ((ListView)View);
            //This code works for both the ListViewOnly and ListViewAndDetailView option.
            GridListEditor listEditor = lv.Editor as GridListEditor;
            if (listEditor != null) {
                GridControl grid = listEditor.Grid;
                GridView gv = listEditor.GridView;
                //Do something great here.
            }
            //The code below works only for the ListViewAndDetailView option.
            DetailView dv = lv.EditView;
            if (dv != null) {
                WinLayoutManager layoutManager = dv.LayoutManager as WinLayoutManager;
                if (layoutManager != null) {
                    LayoutControl layout = layoutManager.Container;
                    //Do something great here.
                }
            }
        }
    }
}
Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGrid
Imports DevExpress.XtraLayout
Imports DevExpress.ExpressApp
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.ExpressApp.Win.Layout
Imports DevExpress.ExpressApp.Win.Editors

Namespace YourSolutionName.Module.Win
    Public Class GridListViewController
        Inherits ViewController
        Public Sub New()
            TargetViewType = ViewType.ListView
        End Sub
        Protected Overrides Overloads Sub OnViewControlsCreated()
            MyBase.OnViewControlsCreated()
            Dim lv As ListView = (CType(View, ListView))
            'This code works for both the ListViewOnly and ListViewAndDetailView options.
            Dim listEditor As GridListEditor = TryCast(lv.Editor, GridListEditor)
            If listEditor IsNot Nothing Then
                Dim grid As GridControl = listEditor.Grid
                Dim gv As GridView = listEditor.GridView
                'Do something great here.
            End If
            'The code below works only for the ListViewAndDetailView option.
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
```


<br>
<p>The best practice is always to access the List View's control via the corresponding ListEditor properties. The same thing is for Detail View - you should access the Detail View's control via the corresponding LayoutManager properties.<br><br><strong>See Also:<br></strong><a href="https://www.devexpress.com/Support/Center/p/E372">How to access a tab control in a Detail View layout</a><br><a href="https://www.devexpress.com/Support/Center/p/KA18895">FAQ: How to traverse and customize XAF View items and their underlying controls</a></p>

<br/>


