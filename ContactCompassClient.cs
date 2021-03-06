﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosential.Integrations.Compass.Client.Models;
using RestSharp;

namespace Cosential.Integrations.Compass.Client
{
    public class ContactCompassClient : CompassClient
    {

        public ContactCompassClient(
                int firmId, 
                Guid apiKey, 
                string username, 
                string password, 
                Uri host = null
            ) 
            : 
            base(
                firmId, 
                apiKey, 
                username, 
                password
                )
        { }

        #region CRUD

        public Contact Get(int ContactId)
        {
            var request = NewRequest(
                "contacts/{id}", 
                Method.GET
                );

            request.AddUrlSegment("id", ContactId.ToString());

            var results = Execute<Contact>(request);

            return results.Data;

        }

        public IList<Contact> List(
                int from, int take, bool fullRecord=true
            )
        {
            var request = NewRequest(
                "contacts",
                Method.GET
                );

            request.AddQueryParameter("from", from.ToString());
            request.AddQueryParameter("size", take.ToString());
            request.AddQueryParameter("full", fullRecord.ToString());

            var results = Execute<List<Contact>>(request);
            return results.Data;
        }

        #endregion

    }
}
