//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NHibernate.CMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial  class sys_acl_user
    {
        public  virtual int ID { get; set; }
        public  virtual int userID { get; set; }
        public  virtual int actionID { get; set; }
        public  virtual bool access { get; set; }
    }
}
