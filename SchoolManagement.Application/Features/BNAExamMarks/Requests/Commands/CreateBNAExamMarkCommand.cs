﻿using SchoolManagement.Application.DTOs.BnaExamMark;
using SchoolManagement.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Features.BnaExamMarks.Requests.Commands
{
    public class CreateBnaExamMarkCommand : IRequest<BaseCommandResponse>
    {
        public CreateBnaExamMarkDto BnaExamMarkDto { get; set; }

    }
}
 