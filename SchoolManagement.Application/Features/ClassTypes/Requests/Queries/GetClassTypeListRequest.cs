﻿using MediatR;
using SchoolManagement.Application.DTOs.Common;
using SchoolManagement.Application.DTOs.ClassType;
using SchoolManagement.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Features.ClassTypes.Requests.Queries
{
   public class GetClassTypeListRequest : IRequest<PagedResult<ClassTypeDto>>
    {
        public QueryParams QueryParams { get; set; }
    }
}
