using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CallMeName.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            mainModel = new Models.MainModel();
        }

        Models.MainModel mainModel;
        public Models.MainModel MainModel
        {
            get { return mainModel; }
            set { mainModel = value; }
        }
        public string Name
        {
            get { return MainModel.Name; }
            set
            {
                if (MainModel.Name != value)
                {
                    MainModel.Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }



        #region INotifyPropertyChanged Member

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region INotifyPropertyChanged Methods

        private void RaisePropertyChanged(string propertyName)
        {
            // take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
