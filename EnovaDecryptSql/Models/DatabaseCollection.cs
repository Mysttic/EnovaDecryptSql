using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnovaDecryptSql.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class DatabaseCollection
    {

        private DatabaseCollectionMsSqlDatabase[] msSqlDatabaseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MsSqlDatabase")]
        public DatabaseCollectionMsSqlDatabase[] MsSqlDatabase
        {
            get
            {
                return this.msSqlDatabaseField;
            }
            set
            {
                this.msSqlDatabaseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DatabaseCollectionMsSqlDatabase
    {

        private string nameField;

        private string operatorNameField;

        private string operatorPasswordField;

        private string serverField;

        private string databaseNameField;

        private string userField;

        private string passwordField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
                        
        /// <remarks/>
        public string OperatorName
        {
            get
            {
                return this.operatorNameField;
            }
            set
            {
                this.operatorNameField = value;
            }
        }

        /// <remarks/>
        public string OperatorPassword
        {
            get
            {
                return this.operatorPasswordField;
            }
            set
            {
                this.operatorPasswordField = value;
            }
        }
        
        /// <remarks/>
        public string Server
        {
            get
            {
                return this.serverField;
            }
            set
            {
                this.serverField = value;
            }
        }

        /// <remarks/>
        public string DatabaseName
        {
            get
            {
                return this.databaseNameField;
            }
            set
            {
                this.databaseNameField = value;
            }
        }

        /// <remarks/>
        public string User
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }

        /// <remarks/>
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
               
        public string ShowedPassword { get; set; } = "********";

        public string ShowedOperatorPassword { get; set; } = "********";

        internal string Key
        {
            get
            {
                return $"{OperatorName}.{Name}.{Server}.{DatabaseName}.{User}";
            }
        }
    }


}
