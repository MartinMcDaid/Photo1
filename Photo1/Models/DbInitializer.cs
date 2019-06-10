using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photo1.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if(!context.Photos.Any())
            {
                context.AddRange
                    (
                    new Photo { Title= "On a Knife Edge", Description= "A Mountaineer walks along the ridge at Aiguille du midi above Chamonix and below Mt. Blanc, It cannot be seen from this shot but the ridge this guy is on is approximately 1 metre wide with sheer drops to both sides, as those of you who have been there will know.", Location="France", PhotoUrl= "https://www.flickr.com/photos/martymcdaidphotography/8998626418/", Special=false},
                    new Photo { Title = "Breath it in", Description = "Another panorama of the Lac du Mont Cenis, this time taken from the top of the Le Met ski lift. A nice place to take a break from skiing and have a snack.", Location = "France", PhotoUrl = "https://www.flickr.com/photos/martymcdaidphotography/11969290215/", Special =true },
                    new Photo { Title = "Cirque de Mafate", Description = "The Cirque de Mafate on Ile de la Reunion,This one was a stroke of pure luck really.The cloud covering the cirque lifted for less than a few minutes and I was able to get a few quick shots, I like the shape of the cloud in this one, it almost creates the shape of an eye opening.", Location = "Ile De La Reunion", PhotoUrl = "https://www.flickr.com/photos/martymcdaidphotography/13039257904/", Special =false },
                    new Photo { Title = "Grossglockner Road", Description = "Taken from the carpark of the edelweissspitze on the Grossglockner road in Austria, you can make out two of the tunnels off in the distance", Location = "Austria", PhotoUrl = "https://www.flickr.com/photos/martymcdaidphotography/14297760433/", Special =false },
                    new Photo { Title = "Spray", Description = "Again taken at Krimml falls, i really like the colours in this one, the mosses come to life.", Location = "Austria", PhotoUrl = "https://www.flickr.com/photos/martymcdaidphotography/14265315951/", Special = true},
                    new Photo { Title = "Chillin' in Paris", Description = "Two of the lions in the Parc Zoologique de Paris, Taken through one of the windows to the enclosure.", Location = "France", PhotoUrl = "https://www.flickr.com/photos/martymcdaidphotography/14917509243/", Special = true},
                    new Photo { Title = "Fanad Lighthouse and Helipad", Description = "Fanad Head Lighthouse and Helipad, Co Donegal Ireland, one of the many beautiful sites to visit along the Wild Atlantic Way in Donegal", Location = "Ireland", PhotoUrl = "https://www.flickr.com/photos/martymcdaidphotography/28717624416/", Special =false },
                    new Photo { Title = "Bád Eddie", Description = "Bád Eddie, Co. Donegal Ireland", Location = "Ireland", PhotoUrl = "https://www.flickr.com/photos/martymcdaidphotography/42712165112/", Special = true }
                    );
            }
            context.SaveChanges();
        }
    }
}
