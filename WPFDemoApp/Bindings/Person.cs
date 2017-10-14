using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemoApp.Bindings
{
   public class Person : INotifyPropertyChanged
   {
      int _age;
      string _name;

      public int Age
      {
         get
         {
            return _age;
         }

         set
         {
            _age = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Age"));
         }
      }

      public string pName
      {
         get
         {
            return _name;
         }

         set
         {
            _name = value;
            PropertyChanged(this, new PropertyChangedEventArgs("pName"));
         }
      }

      public event PropertyChangedEventHandler PropertyChanged = delegate {};
   }
}
