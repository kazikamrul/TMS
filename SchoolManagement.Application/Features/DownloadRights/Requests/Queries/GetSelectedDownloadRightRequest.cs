﻿using MediatR;
using SchoolManagement.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Features.DownloadRights.Requests.Queries
{
    public class GetSelectedDownloadRightRequest : IRequest<List<SelectedModel>>
    {
    }
}
