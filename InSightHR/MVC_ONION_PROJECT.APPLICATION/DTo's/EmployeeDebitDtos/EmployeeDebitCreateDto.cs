﻿using MVC_ONION_PROJECT.DOMAIN.ENUMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_ONION_PROJECT.APPLICATION.DTo_s.EmployeeDebitDtos
{
    public class EmployeeDebitCreateDto
    {
        public Guid OrgAssetId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime AssignmentDate { get; set; }
        public ReturnStatus ReturnStatus { get; set; }
        public string? Description { get; set; }

    }
}
