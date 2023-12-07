<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128640704/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1675)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Menu - Display a Context Menu for a Text Box

This example demonstrates how to create a popup menu with Copy, Paste, Undo, and Redo commands ([bar items](https://docs.devexpress.com/WPF/6553/controls-and-libraries/ribbon-bars-and-menu/bars/populating-bars/items-and-links)). The menu is displayed when the user right-clicks in the text box.

![WPF Context Menu - Display a Context Menu for a Text Box](https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-context-menu-with-devexpress-bar-items-e1675/22.2.2%2B/i/wpf-context-menu-devexpress.png)

The [BarManager.DXContextMenu](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarManager.DXContextMenu) attached property is used to associate the menu with a `TextBox` control:

```xaml
<TextBox
  ...
  <dxb:BarManager.DXContextMenu>
      <dxb:PopupMenu>
          <dxb:PopupMenu.Items>
              <dxb:BarButtonItem
                  Content="Copy"
                  Glyph="pack://application:,,,/Images/copy16x16.png"
                  ItemClick="itemCopy_ItemClick" />
              <dxb:BarButtonItem
                  Content="Paste"
                  Glyph="pack://application:,,,/Images/paste16x16.png"
                  ItemClick="itemPaste_ItemClick" />
              <dxb:BarButtonItem
                  Content="Undo"
                  Glyph="pack://application:,,,/Images/undo16x16.png"
                  ItemClick="itemUndo_ItemClick" />
              <dxb:BarButtonItem
                  Content="Redo"
                  Glyph="pack://application:,,,/Images/redo16x16.png"
                  ItemClick="itemRedo_ItemClick" />
          </dxb:PopupMenu.Items>
      </dxb:PopupMenu>
  </dxb:BarManager.DXContextMenu>
</TextBox>
```

## Files to Review

* [Window1.xaml](./CS/DXContextMenu_Ex/Window1.xaml) (VB: [Window1.xaml.vb](./VB/DXContextMenu_Ex/Window1.xaml.vb))
* [Window1.xaml.cs](./CS/DXContextMenu_Ex/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/DXContextMenu_Ex/Window1.xaml.vb))

## Documentation

* [Popup Menu](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.PopupMenu)
* [Bar Items and Links](https://docs.devexpress.com/WPF/6553/controls-and-libraries/ribbon-bars-and-menu/bars/populating-bars/items-and-links)
