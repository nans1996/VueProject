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
using CompStore;
using CompStore.Models.DAO;

namespace CompStore.Controllers.WebController
{
    public class SellingsController : ApiController
    {
        DAOSelling dao = new DAOSelling();

        // GET: api/Sellings
        public IEnumerable<Selling> GetSelling()
        {
            return dao.GetAllSelling();
        }

        // GET: api/Sellings/5
        //    [ResponseType(typeof(Selling))]
        //    public IHttpActionResult GetSelling(int id)
        //    {
        //        Selling selling = db.Selling.Find(id);
        //        if (selling == null)
        //        {
        //            return NotFound();
        //        }

        //        return Ok(selling);
        //    }

        //    // PUT: api/Sellings/5
        //    [ResponseType(typeof(void))]
        //    public IHttpActionResult PutSelling(int id, Selling selling)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest(ModelState);
        //        }

        //        if (id != selling.Id)
        //        {
        //            return BadRequest();
        //        }

        //        db.Entry(selling).State = EntityState.Modified;

        //        try
        //        {
        //            db.SaveChanges();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SellingExists(id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return StatusCode(HttpStatusCode.NoContent);
        //    }

        //    // POST: api/Sellings
        //    [ResponseType(typeof(Selling))]
        //    public IHttpActionResult PostSelling(Selling selling)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest(ModelState);
        //        }

        //        db.Selling.Add(selling);
        //        db.SaveChanges();

        //        return CreatedAtRoute("DefaultApi", new { id = selling.Id }, selling);
        //    }

        //    // DELETE: api/Sellings/5
        //    [ResponseType(typeof(Selling))]
        //    public IHttpActionResult DeleteSelling(int id)
        //    {
        //        Selling selling = db.Selling.Find(id);
        //        if (selling == null)
        //        {
        //            return NotFound();
        //        }

        //        db.Selling.Remove(selling);
        //        db.SaveChanges();

        //        return Ok(selling);
        //    }

        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }

        //    private bool SellingExists(int id)
        //    {
        //        return db.Selling.Count(e => e.Id == id) > 0;
        //    }
        //}
    }
}