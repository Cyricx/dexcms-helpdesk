using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexCMS.HelpDesk.Host.WebApi.Controllers
{
    //[Authorize(Roles="Admin")]
    //public class CustomObjectController: ApiController
    //{
    //    private ICustomObjectRepository repository;

    //    public CustomObjectController(ICustomObjectRepository repo)
    //    {
    //        repository = repo;
    //    }

    //    public List<CustomObjectApiModel> GetCustomObjects()
    //    {
    //        var items = repository.Items.Select(x => new CustomObjectApiModel
    //        {
    //            CustomOjectID = x.CustomOjectID,
    //            CustomObjectTypeName = x.CustomObjectType.Name
    //        }).ToList();

    //        return items;
    //    }

    //    [ResponseType(typeof(CustomObject))]
    //    public async Task<IHttpActionResult> GetCustomObject(int id)
    //    {
    //        CustomObject customObject = await repository.RetrieveAsync(id);
    //        if (contact == null)
    //        {
    //            return NotFound();
    //        }

    //        CustomObjectApiModel model = new CustomObjectApiModel()
    //        {
    //            CustomOjectID = customObject.CustomOjectID,
    //            CustomObjectTypeName = customObject.CustomObjectType.Name
    //        };

    //        return Ok(model);
    //    }

    //    public async Task<IHttpActionResult> PutCustomObject(int id, CustomObject customObject)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        if (id != customObject.CustomObjectID)
    //        {
    //            return BadRequest();
    //        }

    //        await repository.UpdateAsync(customObject, customObject.CustomObjectID);

    //        return StatusCode(HttpStatusCode.NoContent);
    //    }

    //    [ResponseType(typeof(CustomObject))]
    //    public async Task<IHttpActionResult> PostCustomObject(CustomObject customObject)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        await repository.AddAsync(customObject);

    //        return CreatedAtRoute("DefaultApi", new { id = customObject.CustomObjectID }, customObject);
    //    }

    //    [ResponseType(typeof(Contact))]
    //    public async Task<IHttpActionResult> DeleteCustomObject(int id)
    //    {
    //        CustomObject customObject = await repository.RetrieveAsync(id);
    //        if (customObject == null)
    //        {
    //            return NotFound();
    //        }

    //        await repository.DeleteAsync(customObject);

    //        return Ok(customObject);
    //    }
    //}
}
