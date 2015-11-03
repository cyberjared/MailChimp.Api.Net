﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;
using MailChimp.Api.Net.Enum;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Reports
{
    // ============================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Get recent feedback based on a campaign’s statistics. 
    // ============================================================================

    internal class MCReportsCampaignAdvice
    {
        /// <summary>
        /// Return recent feedback based on a campaign’s statistics
        /// <param name="campaignId">Campaign Id</param>
        /// </summary>
        internal async Task<CampaignAdvice> GetAdviceAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.advice, SubTargetType.not_applicable, campaignId);

            string content;
            using (var client = new HttpClient())
            {
                try
                {
                    Authenticate.ClientAuthentication(client);

                    content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    throw ex;
                } 
            }

            return JsonConvert.DeserializeObject<CampaignAdvice>(content);
        }

    }
}
