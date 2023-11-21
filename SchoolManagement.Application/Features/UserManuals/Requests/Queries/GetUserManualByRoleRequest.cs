﻿using MediatR;
using SchoolManagement.Application.DTOs.Common;
using SchoolManagement.Application.DTOs.UserManual;
using SchoolManagement.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Features.UserManuals.Requests.Queries
{
   public class GetUserManualByRoleRequest : IRequest<object>
    {
        public string RoleName { get; set; }
    }
}
