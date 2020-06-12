using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***USER MODEL***/
  [Table("users")]
 public partial class User : IMicron
 {
        [Primary]
        public Int32 id {get; set;}
        public String firstname {get; set;}
        public String secondname {get; set;}
        public String patronymic {get; set;}
        public Int32 passport_series {get; set;}
        public Int32 passport_number {get; set;}
        public String placeliving {get; set;}
        public DateTime birthday {get; set;}
        public String passport_place {get; set;}
        [Foreign(typeof(Role))]
        public Int32 role_id {get; set;}
        public DateTime created_at {get; set;}
 }
}
