using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photo1.Models
{
    public interface ICarouselRepository
    {
        List<Carousel> GetCarousels();
    }
}
