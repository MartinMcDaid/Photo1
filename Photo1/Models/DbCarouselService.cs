using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photo1.Models
{
    public class DbCarouselService : ICarouselRepository
    {
        private readonly AppDbContext _appDbContext;

        public DbCarouselService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Carousel> GetCarousels()
        {
            List<Carousel> Carousel = new List<Carousel>();

            foreach (var photo in _appDbContext.Carousels)
            {
                    Carousel.Add(photo);
            }
            return Carousel;
        }

    }
}
