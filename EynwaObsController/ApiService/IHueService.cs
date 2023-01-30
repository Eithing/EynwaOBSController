using EynwaObsController.Model.Hue;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EynwaObsController.ApiService
{
    [Headers("Authorization:" + "Bearer bucs7svqf708gdmzaz0dvldsfkjaoo", "Client-Id:" + "l018hupxji48bv3mtxjkj38ibh468j")]
    public interface IHueService
    {
        [Put("/POHb9tsuCoFuPVhKIHkqLbX7A6JbRHJicUn47oIw/lights/{id}/state")]
        Task ChangeLight([Body] LightUpdateParams param, string id);
    }
}
