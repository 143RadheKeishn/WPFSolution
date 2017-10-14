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

namespace WPFDemoApp.Bindings
{
   /// <summary>
   /// Interaction logic for PersonBindingWindow.xaml
   /// </summary>
   public partial class PersonBindingWindow : Window
   {
      Person _Person;
      public PersonBindingWindow()
      {
         InitializeComponent();
         Loaded += PersonBindingWindow_Loaded;
      }

      private void PersonBindingWindow_Loaded(object sender, RoutedEventArgs e)
      {
         _Person = new Person { Age = 20, pName = "Vikas" };
         this.DataContext = _Person;
      }

      private void btnAssign_Click(object sender, RoutedEventArgs e)
      {
         _Person.pName = "Pinki";
         _Person.Age = 23;
      }

      private void btnShow_Click(object sender, RoutedEventArgs e)
      {
         MessageBox.Show($" Name :{_Person.pName}\n Age :{_Person.Age} ");
      }
   }
}
