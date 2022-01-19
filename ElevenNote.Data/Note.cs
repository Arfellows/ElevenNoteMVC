﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    class Note
    {
        [Key]
        public int NoteID { get; set; }

        [Required]
        public Guid OwnerID { get; set; }

        [Required]
        [Display(Name = "Your Note")]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }


        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
