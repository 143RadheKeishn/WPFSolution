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
   /// Interaction logic for BubblingEventWindow.xaml
   /// </summary>
   public partial class BubblingEventWindow : Window
   {
      public BubblingEventWindow()
      {
         InitializeComponent();
         CheckBox1.KeyDown += CheckBox1_KeyDown;
         Button1.KeyDown += Button1_KeyDown;
         InnserStack.KeyDown += InnserStack_KeyDown;
         RootStack.KeyDown += RootStack_KeyDown;
      }

      private void RootStack_KeyDown(object sender, KeyEventArgs e)
      {
         MessageBox.Show("Comng From Root Stack");
      }

      private void InnserStack_KeyDown(object sender, KeyEventArgs e)
      {
         MessageBox.Show("Comng From Inner Stack");
      }

      private void Button1_KeyDown(object sender, KeyEventArgs e)
      {
         MessageBox.Show("Comng From Btton");
      }

      private void CheckBox1_KeyDown(object sender, KeyEventArgs e)
      {
         MessageBox.Show("Comng From CheckBox");
      }
   }
}
