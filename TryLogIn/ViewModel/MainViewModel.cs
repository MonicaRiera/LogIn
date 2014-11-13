using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using TryLogIn.Annotations;
using TryLogIn.Model;

namespace TryLogIn.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<UserModel> _users;
        private UserModel _newUserModel;
        private ICommand _addNewUserCommand;

        public MainViewModel()
        {
            _addNewUserCommand = new RelayCommand(AddNewUserModelCommand);
            _newUserModel = new UserModel();
            LoadUsers();
        }

        private async void LoadUsers()
        {
            StorageFile file = null;
            try
            {
                file = await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync("Users.xml");
            }
            catch (Exception)
            {
            }

            if (file == null)
            {
                StorageFolder installationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                string xmlfile = @"Assets\Xml\Users.xml";
                file = await installationFolder.GetFileAsync(xmlfile);
            }

            Stream userStream = await file.OpenStreamForReadAsync();
            XDocument usersModelDocument = XDocument.Load(userStream);

            IEnumerable<XElement> usersModelList = usersModelDocument.Descendants("user");
            Users = new ObservableCollection<UserModel>();

            foreach (XElement xElement in usersModelList)
            {
                Users.Add(new UserModel()
                {
                    UserName = xElement.Element("username").Value,
                    Password = xElement.Element("password").Value
                });
            }

            //FilteredUsers = new ObservableCollection<UserModel>();
            //if (NewUserModel.UserName == null)
            //{
            //    FilteredUsers = Users;
            //}
            //else
            //{
            //    foreach (UserModel userModel in Users)
            //    {
            //        if (NewUserModel.UserName == userModel.UserName)
            //        {
            //            new MessageDialog("This user name is not avaliable");
            //        }
            //    }
            //} OnPropertyChanged("FilteredUsers");

            OnPropertyChanged("Users");
        }

        private async void AddNewUserModelCommand()
        {
            StorageFile file = null;
            try
            {
                file = await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync("users.xml");
            }
            catch (Exception)
            {
            }

            if (file == null)
            {
                StorageFolder installationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                string xmlfile = @"Assets\Xml\Users.xml";
                file = await installationFolder.GetFileAsync(xmlfile);
            }

            Stream LoadStream = await file.OpenStreamForReadAsync();
            XDocument userDocument = XDocument.Load(LoadStream);
            LoadStream.Dispose();

            XElement userList = userDocument.Element("users");

            XElement user = new XElement("user");
            user.Add(new XElement("username", NewUserModel.UserName));
            user.Add(new XElement("password", NewUserModel.Password));

            foreach (UserModel userModel in Users)
            {
                if (NewUserModel.UserName == userModel.UserName)
                {
                    string message = "No";
                    MessageDialog dialog = new MessageDialog(message);
                    await dialog.ShowAsync();
                    NewUserModel.UserName = "";
                }
                else
                {
                    userList.LastNode.AddAfterSelf(user);

                    StorageFile saveFile = null;

                    try
                    {
                        saveFile = await Windows.Storage.ApplicationData.Current.LocalFolder.CreateFileAsync("Users.xml");
                    }
                    catch { }

                    if (saveFile == null)
                    {
                        saveFile = await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync("Users.xml");
                    }

                    Stream saveStream = await saveFile.OpenStreamForWriteAsync();
                    userDocument.Save(saveStream);
                    saveStream.Dispose();
                    OnPropertyChanged("Users");
                    LoadUsers();
                }
            }

        }

        public ObservableCollection<UserModel> Users
        {
            get { return _users; }
            set { _users = value; }
        }

        public UserModel NewUserModel
        {
            get { return _newUserModel; }
            set { _newUserModel = value; }
        }

        public ICommand AddNewUserCommand
        {
            get { return _addNewUserCommand; }
            set { _addNewUserCommand = value; }
        }

        public ObservableCollection<UserModel> FilteredUsers { get; set; }

        #region
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
