using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;


namespace TestApi.Controllers
{
   
    public class ImageController : ApiController
    {
        /*        [HttpPost]
                [Route("api/image")]
                public void StoreImage([FromBody] string Image)
                {


                    var hit = "hit";
                }


                [HttpPost]
                [Route("api/image")]
                public void StoreImage([FromBody] HttpContent Image)
                {


                    var hit = "hit";
                }

                [HttpPost]
                [Route("api/image")]
                public void StoreImage([FromBody] StringContent Image)
                {


                    var hit = "hit";
                }*/

        [HttpPost]
        [Route("api/image")]
        public void StoreImage([FromBody] string image)
        {


            var hit = "hit";
        }




    }
}

