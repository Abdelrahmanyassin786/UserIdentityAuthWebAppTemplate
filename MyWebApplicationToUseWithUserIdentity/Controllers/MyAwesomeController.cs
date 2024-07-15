using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApplicationToUseWithUserIdentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class MyAwesomeController : ControllerBase
    {
        private List<int> _result
        {
            get
            {
                var result = new List<int>();
                var lengthOfList = Random.Shared.Next(10);
                for (int i = 1; i < lengthOfList; i++)
                {
                    result.Add(Random.Shared.Next());
                }
                return result;
            }
        }

        [HttpGet]
        [Route("Values")]
        public ActionResult<List<int>> GetMyAwesomeValues() => Ok(_result);

        [HttpGet]
        [Route("Return404")]
        public ActionResult Return404()
        {
            var myAwesomeValues = GetMyAwesomeValues();
            var result = myAwesomeValues.Result;
            var value = myAwesomeValues.Value;
            return NotFound(value);
        }

        [HttpGet]
        [Route("DoesNotNeedAuthorization")]
        [AllowAnonymous]
        public ActionResult DoesNotNeedAuthorization() => Ok(_result);

        [HttpGet]
        [Route("NeedsADMINRole")]
        [Authorize(Roles = "ADMIN")]  //get roles from another variable. 
        public ActionResult<List<int>> NeedsADMINRole() => Ok(_result);

        [HttpGet]
        [Route("NeedsAnImaginaryRole")]
        [Authorize(Policy = "", Roles = "ImaginaryRole")]  //get roles from another variable. 
        public ActionResult<List<int>> NeedsAnImaginaryRole() => Ok(_result);

    }
}
