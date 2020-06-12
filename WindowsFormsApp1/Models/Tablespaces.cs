using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***TABLESPACE MODEL***/
  [Table("TABLESPACES")]
 public partial class Tablespace : IMicron
 {
        public String TABLESPACE_NAME {get; set;}
        public String ENGINE {get; set;}
        public String TABLESPACE_TYPE {get; set;}
        public String LOGFILE_GROUP_NAME {get; set;}
        public UInt64 EXTENT_SIZE {get; set;}
        public UInt64 AUTOEXTEND_SIZE {get; set;}
        public UInt64 MAXIMUM_SIZE {get; set;}
        public UInt64 NODEGROUP_ID {get; set;}
        public String TABLESPACE_COMMENT {get; set;}
 }
}
