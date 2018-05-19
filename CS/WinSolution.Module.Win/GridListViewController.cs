using System;
using DevExpress.XtraGrid;
using DevExpress.XtraLayout;
using DevExpress.ExpressApp;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.ExpressApp.Win.Layout;
using DevExpress.ExpressApp.Win.Editors;

namespace WinSolution.Module.Win {
    public class GridListViewController : ViewController {
        public GridListViewController() {
            TargetViewType = ViewType.ListView;
        }
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            ListView lv = ((ListView)View);
            //This code works for both the ListViewOnly and ListViewAndDetailView objects.
            GridListEditor listEditor = lv.Editor as GridListEditor;
            if (listEditor != null) {
                GridControl grid = listEditor.Grid;
                GridView gv = listEditor.GridView;
                //Do something great here.
            }
            //The code below works only for the ListViewAndDetailView object.
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