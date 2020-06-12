using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***REFERENTIAL_CONSTRAINT MODEL***/
  [Table("REFERENTIAL_CONSTRAINTS")]
 public partial class Referential_Constraint : IMicron
 {
        public String CONSTRAINT_CATALOG {get; set;}
        public String CONSTRAINT_SCHEMA {get; set;}
        public String CONSTRAINT_NAME {get; set;}
        public String UNIQUE_CONSTRAINT_CATALOG {get; set;}
        public String UNIQUE_CONSTRAINT_SCHEMA {get; set;}
        public String UNIQUE_CONSTRAINT_NAME {get; set;}
        public String MATCH_OPTION {get; set;}
        public String UPDATE_RULE {get; set;}
        public String DELETE_RULE {get; set;}
        public String TABLE_NAME {get; set;}
        public String REFERENCED_TABLE_NAME {get; set;}
 }
}
