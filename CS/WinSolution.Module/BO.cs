using System;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace WinSolution.Module {
    [DefaultClassOptions]
    [DefaultListViewOptionsAttribute(MasterDetailMode.ListViewOnly)]
    public class ListViewOnly : BaseObject {
        public ListViewOnly(Session session) : base(session) { }
    }
    [DefaultClassOptions]
    [DefaultListViewOptionsAttribute(MasterDetailMode.ListViewAndDetailView)]
    public class ListViewAndDetailView : BaseObject {
        public ListViewAndDetailView(Session session) : base(session) { }
    }
}
