﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearnWeb.Domain
{
    public class LessonAttachments
    {
        public int Id { get; set; }

        public int LessonId { get; set; }

        public string  Attachment { get; set; }
    }
}
