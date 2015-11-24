﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class RootContent
    {
            public string plain_text { get; set; }
            public string html { get; set; }
            public List<Link> _links { get; set; }
    }
}