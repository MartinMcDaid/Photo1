using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photo1.Models
{
    public class DbPhotoService : IPhotoRepository
    {
        private readonly AppDbContext _appDbContext;

        public DbPhotoService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Photo> GetAllPhotos()
        {
            return _appDbContext.Photos;
        }

        public Photo GetPhotoById(int photoId)
        {
            return _appDbContext.Photos.FirstOrDefault(p => p.PhotoId == photoId);
        }
    }
}
