//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace WindowsFormsApplication
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CMART0Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CMART0Entities object using the connection string found in the 'CMART0Entities' section of the application configuration file.
        /// </summary>
        public CMART0Entities() : base("name=CMART0Entities", "CMART0Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CMART0Entities object.
        /// </summary>
        public CMART0Entities(string connectionString) : base(connectionString, "CMART0Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CMART0Entities object.
        /// </summary>
        public CMART0Entities(EntityConnection connection) : base(connection, "CMART0Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
    }
    

    #endregion

    
    
}