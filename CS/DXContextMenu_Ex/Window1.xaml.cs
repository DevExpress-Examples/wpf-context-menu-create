using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DXContextMenu_Ex {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e) {
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
