﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_ONION_PROJECT.APPLICATION.DTo_s.OrganizationDtos
{
    public class OrganizationListDto
    {
        public Guid Id { get; set; }
        public string OrganizationName { get; set; }
        public string? OrganizationAddress { get; set; }
        public string OrganizationEmail { get; set; }
        public Byte[]? logo { get; set; }
        public DateTime ContractStart { get; set; }
        public DateTime ContractEnd { get; set; }
        public bool IsActive { get; set; }
    }
}
