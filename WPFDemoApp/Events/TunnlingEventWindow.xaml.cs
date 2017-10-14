using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFDemoApp.Events
{
   /// <summary>
   /// Interaction logic for TunnlingEventWindow.xaml
   /// </summary>
   public partial class TunnlingEventWindow : Window
   {
      public TunnlingEventWindow()
      {
         InitializeComponent();
         Button1.PreviewMouseDown += Button1_PreviewMouseDown;
         InnserStack.PreviewMouseDown += InnserStack_PreviewMouseDown;
         RootStack.PreviewMouseDown += RootStack_PreviewMouseDown;
      }

      private void RootStack_PreviewMouseDown(object sender, MouseButtonEventArgs e)
      {
         MessageBox.Show("Coming from Root Stack");
      }

      private void InnserStack_PreviewMouseDown(object sender, MouseButtonEventArgs e)
      {
         MessageBox.Show("Coming from innerStack");
      }

      private void Button1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
      {
         MessageBox.Show("Coming from button");
      }
   }
}
