using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***PLUGIN MODEL***/
  [Table("PLUGINS")]
 public partial class Plugin : IMicron
 {
        public String PLUGIN_NAME {get; set;}
        public String PLUGIN_VERSION {get; set;}
        public String PLUGIN_STATUS {get; set;}
        public String PLUGIN_TYPE {get; set;}
        public String PLUGIN_TYPE_VERSION {get; set;}
        public String PLUGIN_LIBRARY {get; set;}
        public String PLUGIN_LIBRARY_VERSION {get; set;}
        public String PLUGIN_AUTHOR {get; set;}
        public String PLUGIN_DESCRIPTION {get; set;}
        public String PLUGIN_LICENSE {get; set;}
        public String LOAD_OPTION {get; set;}
 }
}
