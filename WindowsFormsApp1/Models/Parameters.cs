using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***PARAMETER MODEL***/
  [Table("PARAMETERS")]
 public partial class Parameter : IMicron
 {
        public String SPECIFIC_CATALOG {get; set;}
        public String SPECIFIC_SCHEMA {get; set;}
        public String SPECIFIC_NAME {get; set;}
        public Int32 ORDINAL_POSITION {get; set;}
        public String PARAMETER_MODE {get; set;}
        public String PARAMETER_NAME {get; set;}
        public String DATA_TYPE {get; set;}
        public Int32 CHARACTER_MAXIMUM_LENGTH {get; set;}
        public Int32 CHARACTER_OCTET_LENGTH {get; set;}
        public UInt64 NUMERIC_PRECISION {get; set;}
        public Int32 NUMERIC_SCALE {get; set;}
        public UInt64 DATETIME_PRECISION {get; set;}
        public String CHARACTER_SET_NAME {get; set;}
        public String COLLATION_NAME {get; set;}
        public String DTD_IDENTIFIER {get; set;}
        public String ROUTINE_TYPE {get; set;}
 }
}
