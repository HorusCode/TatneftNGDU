using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***USER_PRIVILEGE MODEL***/
  [Table("USER_PRIVILEGES")]
 public partial class User_Privilege : IMicron
 {
        public String GRANTEE {get; set;}
        public String TABLE_CATALOG {get; set;}
        public String PRIVILEGE_TYPE {get; set;}
        public String IS_GRANTABLE {get; set;}
 }
}
