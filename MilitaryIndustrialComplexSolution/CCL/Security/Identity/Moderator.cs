﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL.Security.Identity
{
    public class Moderator
        : User
    {
        public Moderator(int userId, string name)
            : base(userId, name, nameof(Moderator))
        {

        }
    }
}
