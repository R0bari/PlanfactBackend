using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PlanfactREST.Models;

namespace PlanfactREST.Controllers
{
    public class BirthdateSumController : ApiController
    {
        private PlanfactEntities db = new PlanfactEntities();

        // GET: api/BirthdateSum
        public IQueryable<BirthdateSum_Result> GetBirthdateSum_Result()
        {
            return db.BirthdateSum_Result;
        }
    }
}