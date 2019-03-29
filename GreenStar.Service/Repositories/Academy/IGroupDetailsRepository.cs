﻿using GreenStar.Entity.Academy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenStar.Service.Repositories.Academy
{
    public interface IGroupDetailsRepository : IRepository <GroupDetails>
    {
        IEnumerable<GroupDetails> GetGroupsDetails();
    }
}
