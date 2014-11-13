﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace TryLogIn
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::TryLogIn.TryLogIn_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace TryLogIn.TryLogIn_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[10];
            _typeNameTable[0] = "TryLogIn.ViewModel.MainViewModel";
            _typeNameTable[1] = "Object";
            _typeNameTable[2] = "System.Collections.ObjectModel.ObservableCollection`1<TryLogIn.Model.UserModel>";
            _typeNameTable[3] = "System.Collections.ObjectModel.Collection`1<TryLogIn.Model.UserModel>";
            _typeNameTable[4] = "TryLogIn.Model.UserModel";
            _typeNameTable[5] = "String";
            _typeNameTable[6] = "System.Windows.Input.ICommand";
            _typeNameTable[7] = "TryLogIn.MainPage";
            _typeNameTable[8] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[9] = "Windows.UI.Xaml.Controls.UserControl";

            _typeTable = new global::System.Type[10];
            _typeTable[0] = typeof(global::TryLogIn.ViewModel.MainViewModel);
            _typeTable[1] = typeof(global::System.Object);
            _typeTable[2] = typeof(global::System.Collections.ObjectModel.ObservableCollection<global::TryLogIn.Model.UserModel>);
            _typeTable[3] = typeof(global::System.Collections.ObjectModel.Collection<global::TryLogIn.Model.UserModel>);
            _typeTable[4] = typeof(global::TryLogIn.Model.UserModel);
            _typeTable[5] = typeof(global::System.String);
            _typeTable[6] = typeof(global::System.Windows.Input.ICommand);
            _typeTable[7] = typeof(global::TryLogIn.MainPage);
            _typeTable[8] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[9] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_MainViewModel() { return new global::TryLogIn.ViewModel.MainViewModel(); }
        private object Activate_2_ObservableCollection() { return new global::System.Collections.ObjectModel.ObservableCollection<global::TryLogIn.Model.UserModel>(); }
        private object Activate_3_Collection() { return new global::System.Collections.ObjectModel.Collection<global::TryLogIn.Model.UserModel>(); }
        private object Activate_4_UserModel() { return new global::TryLogIn.Model.UserModel(); }
        private object Activate_7_MainPage() { return new global::TryLogIn.MainPage(); }
        private void VectorAdd_2_ObservableCollection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::TryLogIn.Model.UserModel>)instance;
            var newItem = (global::TryLogIn.Model.UserModel)item;
            collection.Add(newItem);
        }
        private void VectorAdd_3_Collection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::TryLogIn.Model.UserModel>)instance;
            var newItem = (global::TryLogIn.Model.UserModel)item;
            collection.Add(newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::TryLogIn.TryLogIn_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::TryLogIn.TryLogIn_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  TryLogIn.ViewModel.MainViewModel
                userType = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_0_MainViewModel;
                userType.AddMemberName("Users");
                userType.AddMemberName("NewUserModel");
                userType.AddMemberName("AddNewUserCommand");
                userType.AddMemberName("FilteredUsers");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Object
                xamlType = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  System.Collections.ObjectModel.ObservableCollection`1<TryLogIn.Model.UserModel>
                userType = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<TryLogIn.Model.UserModel>"));
                userType.CollectionAdd = VectorAdd_2_ObservableCollection;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 3:   //  System.Collections.ObjectModel.Collection`1<TryLogIn.Model.UserModel>
                userType = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_3_Collection;
                userType.CollectionAdd = VectorAdd_3_Collection;
                xamlType = userType;
                break;

            case 4:   //  TryLogIn.Model.UserModel
                userType = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_4_UserModel;
                userType.AddMemberName("UserName");
                userType.AddMemberName("Password");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  String
                xamlType = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  System.Windows.Input.ICommand
                userType = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlUserType(this, typeName, type, null);
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 7:   //  TryLogIn.MainPage
                userType = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 9:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;
            }
            return xamlType;
        }


        private object get_0_MainViewModel_Users(object instance)
        {
            var that = (global::TryLogIn.ViewModel.MainViewModel)instance;
            return that.Users;
        }
        private void set_0_MainViewModel_Users(object instance, object Value)
        {
            var that = (global::TryLogIn.ViewModel.MainViewModel)instance;
            that.Users = (global::System.Collections.ObjectModel.ObservableCollection<global::TryLogIn.Model.UserModel>)Value;
        }
        private object get_1_UserModel_UserName(object instance)
        {
            var that = (global::TryLogIn.Model.UserModel)instance;
            return that.UserName;
        }
        private void set_1_UserModel_UserName(object instance, object Value)
        {
            var that = (global::TryLogIn.Model.UserModel)instance;
            that.UserName = (global::System.String)Value;
        }
        private object get_2_UserModel_Password(object instance)
        {
            var that = (global::TryLogIn.Model.UserModel)instance;
            return that.Password;
        }
        private void set_2_UserModel_Password(object instance, object Value)
        {
            var that = (global::TryLogIn.Model.UserModel)instance;
            that.Password = (global::System.String)Value;
        }
        private object get_3_MainViewModel_NewUserModel(object instance)
        {
            var that = (global::TryLogIn.ViewModel.MainViewModel)instance;
            return that.NewUserModel;
        }
        private void set_3_MainViewModel_NewUserModel(object instance, object Value)
        {
            var that = (global::TryLogIn.ViewModel.MainViewModel)instance;
            that.NewUserModel = (global::TryLogIn.Model.UserModel)Value;
        }
        private object get_4_MainViewModel_AddNewUserCommand(object instance)
        {
            var that = (global::TryLogIn.ViewModel.MainViewModel)instance;
            return that.AddNewUserCommand;
        }
        private void set_4_MainViewModel_AddNewUserCommand(object instance, object Value)
        {
            var that = (global::TryLogIn.ViewModel.MainViewModel)instance;
            that.AddNewUserCommand = (global::System.Windows.Input.ICommand)Value;
        }
        private object get_5_MainViewModel_FilteredUsers(object instance)
        {
            var that = (global::TryLogIn.ViewModel.MainViewModel)instance;
            return that.FilteredUsers;
        }
        private void set_5_MainViewModel_FilteredUsers(object instance, object Value)
        {
            var that = (global::TryLogIn.ViewModel.MainViewModel)instance;
            that.FilteredUsers = (global::System.Collections.ObjectModel.ObservableCollection<global::TryLogIn.Model.UserModel>)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::TryLogIn.TryLogIn_XamlTypeInfo.XamlMember xamlMember = null;
            global::TryLogIn.TryLogIn_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "TryLogIn.ViewModel.MainViewModel.Users":
                userType = (global::TryLogIn.TryLogIn_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TryLogIn.ViewModel.MainViewModel");
                xamlMember = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlMember(this, "Users", "System.Collections.ObjectModel.ObservableCollection`1<TryLogIn.Model.UserModel>");
                xamlMember.Getter = get_0_MainViewModel_Users;
                xamlMember.Setter = set_0_MainViewModel_Users;
                break;
            case "TryLogIn.Model.UserModel.UserName":
                userType = (global::TryLogIn.TryLogIn_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TryLogIn.Model.UserModel");
                xamlMember = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlMember(this, "UserName", "String");
                xamlMember.Getter = get_1_UserModel_UserName;
                xamlMember.Setter = set_1_UserModel_UserName;
                break;
            case "TryLogIn.Model.UserModel.Password":
                userType = (global::TryLogIn.TryLogIn_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TryLogIn.Model.UserModel");
                xamlMember = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlMember(this, "Password", "String");
                xamlMember.Getter = get_2_UserModel_Password;
                xamlMember.Setter = set_2_UserModel_Password;
                break;
            case "TryLogIn.ViewModel.MainViewModel.NewUserModel":
                userType = (global::TryLogIn.TryLogIn_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TryLogIn.ViewModel.MainViewModel");
                xamlMember = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlMember(this, "NewUserModel", "TryLogIn.Model.UserModel");
                xamlMember.Getter = get_3_MainViewModel_NewUserModel;
                xamlMember.Setter = set_3_MainViewModel_NewUserModel;
                break;
            case "TryLogIn.ViewModel.MainViewModel.AddNewUserCommand":
                userType = (global::TryLogIn.TryLogIn_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TryLogIn.ViewModel.MainViewModel");
                xamlMember = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlMember(this, "AddNewUserCommand", "System.Windows.Input.ICommand");
                xamlMember.Getter = get_4_MainViewModel_AddNewUserCommand;
                xamlMember.Setter = set_4_MainViewModel_AddNewUserCommand;
                break;
            case "TryLogIn.ViewModel.MainViewModel.FilteredUsers":
                userType = (global::TryLogIn.TryLogIn_XamlTypeInfo.XamlUserType)GetXamlTypeByName("TryLogIn.ViewModel.MainViewModel");
                xamlMember = new global::TryLogIn.TryLogIn_XamlTypeInfo.XamlMember(this, "FilteredUsers", "System.Collections.ObjectModel.ObservableCollection`1<TryLogIn.Model.UserModel>");
                xamlMember.Getter = get_5_MainViewModel_FilteredUsers;
                xamlMember.Setter = set_5_MainViewModel_FilteredUsers;
                break;
            }
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::TryLogIn.TryLogIn_XamlTypeInfo.XamlSystemBaseType
    {
        global::TryLogIn.TryLogIn_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::TryLogIn.TryLogIn_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::TryLogIn.TryLogIn_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::TryLogIn.TryLogIn_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}






