﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ReverseEngineer20.ReverseEngineer
{
    [DataContract]
    public class TableRenamer
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string NewName { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public List<ColumnNamer> Columns { get; set; }
    }
}
