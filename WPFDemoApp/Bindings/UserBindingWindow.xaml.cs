using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
   /// Interaction logic for UserBindingWindow.xaml
   /// </summary>
   public partial class UserBindingWindow : Window
   {
      //clsUser user;

      ObservableCollection<clsUser> _user;
      public UserBindingWindow()
      {
         InitializeComponent();
         Loaded += UserBindingWindow_Loaded;
      }

      private void UserBindingWindow_Loaded(object sender, RoutedEventArgs e)
      {
         _user = new ObservableCollection<clsUser>();
         _user.Add(new clsUser { UserName = "Vikas", Age = 25, FavColor = "Orange" });
         _user.Add(new clsUser { UserName = "Pinki", Age = 22, FavColor = "Green" });
         _user.Add(new clsUser { UserName = "Rinki", Age = 24, FavColor = "Red" });

         this.DataContext = _user;
      }

      private void btnAdd_Click(object sender, RoutedEventArgs e)
      {
         _user.Add(new clsUser { UserName = txtUserName.Text, Age=Convert.ToInt32(txtAge.Text),FavColor=txtFavColor.Text});
         txtAge.Text = "";
         txtFavColor.Text = "";
         txtUserName.Text = "";
      }
   }
}
