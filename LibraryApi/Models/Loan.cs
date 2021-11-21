﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public class Loan : BaseModel
    {
        public long BookId { get; set; }

        public DateTime DueDate { get; set; }

        public long CustomerId { get; set; }

    }
}