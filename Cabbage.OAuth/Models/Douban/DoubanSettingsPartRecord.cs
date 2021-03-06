﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orchard.ContentManagement.Records;
using Orchard.Environment.Extensions;

namespace Cabbage.OAuth.Models
{
    [OrchardFeature("Cabbage.OAuth.Douban")]
    public class DoubanSettingsPartRecord : ContentPartRecord
    {
        public virtual string ClientId { get; set; }
        public virtual string EncryptedClientSecret { get; set; }
        public virtual string Additional { get; set; }
    }
}
