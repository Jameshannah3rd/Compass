﻿using System.Collections.Generic;

namespace Cosential.Integrations.Compass.Client.Models
{
    public class ChangeEvent
    {
        public bool Deleted { get; set; }
        public int Id { get; set; }
        public byte[] Version { get; set; }
        public int? ParentId { get; set; }
    }
}