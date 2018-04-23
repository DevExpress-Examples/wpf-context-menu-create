using System.Windows;

namespace DXContextMenu_Ex {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        private void itemCopy_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            textEdit1.Copy();
        }

        private void itemPaste_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            textEdit1.Paste();
        }

        private void itemUndo_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            textEdit1.Undo();
        }

        private void itemRedo_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            textEdit1.Redo();
        }
    }
}