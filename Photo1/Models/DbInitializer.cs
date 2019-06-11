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
                    new Photo { Title= "On a Knife Edge", ShortDescription= "Mountaineer at Aiguille du midi above Chamonix", Description= "A Mountaineer walks along the ridge at Aiguille du midi above Chamonix and below Mt. Blanc, It cannot be seen from this shot but the ridge this guy is on is approximately 1 metre wide with sheer drops to both sides, as those of you who have been there will know.", Location="France", PhotoUrl= "https://live.staticflickr.com/5321/8998626418_b9f9bc3d4e_o_d.jpg", Price = 25.00m, Special =false},
                    new Photo { Title = "Breath it in", ShortDescription = "The Lac du Mont Cenis in winter", Description = "Another panorama of the Lac du Mont Cenis, this time taken from the top of the Le Met ski lift. A nice place to take a break from skiing and have a snack.", Location = "France", PhotoUrl = "https://live.staticflickr.com/5484/11969290215_1fffb3de6c_k_d.jpg", Price = 32.50m, Special =true },
                    new Photo { Title = "Cirque de Mafate", ShortDescription = "Cirque de Mafate, Ile de la Reunion", Description = "The Cirque de Mafate on Ile de la Reunion,This one was a stroke of pure luck really.The cloud covering the cirque lifted for less than a few minutes and I was able to get a few quick shots, I like the shape of the cloud in this one, it almost creates the shape of an eye opening.", Location = "Ile De La Reunion", PhotoUrl = "https://live.staticflickr.com/7314/13039257904_ddb0ac30d0_k_d.jpg/", Price = 25.00m, Special =false },
                    new Photo { Title = "Grossglockner Road", ShortDescription = "Grossglockner Road, Austria", Description = "Taken from the carpark of the edelweissspitze on the Grossglockner road in Austria, you can make out two of the tunnels off in the distance", Location = "Austria", PhotoUrl = "https://live.staticflickr.com/2916/14297760433_1be450c6f4_k_d.jpg", Price = 28.00m, Special =false },
                    new Photo { Title = "Spray", ShortDescription = "A small section of Krimml falls, Austria", Description = "Again taken at Krimml falls, i really like the colours in this one, the mosses come to life.", Location = "Austria", PhotoUrl = "https://live.staticflickr.com/3750/14265315951_9788971793_k_d.jpg", Price = 30.00m, Special = true},
                    new Photo { Title = "Chillin' in Paris", ShortDescription = "Lions at the Zoo in Paris", Description = "Two of the lions in the Parc Zoologique de Paris, Taken through one of the windows to the enclosure.", Location = "France", PhotoUrl = "https://live.staticflickr.com/5607/14917509243_7c8c1ec3a0_b_d.jpg", Price = 20.00m, Special = true},
                    new Photo { Title = "Fanad Lighthouse and Helipad",ShortDescription= "Fanad Lighthouse, Donegal, Ireland", Description = "Fanad Head Lighthouse and Helipad, Co Donegal Ireland, one of the many beautiful sites to visit along the Wild Atlantic Way in Donegal", Location = "Ireland", PhotoUrl = "https://live.staticflickr.com/7311/28717624416_a2a6535853_b_d.jpg/", Price = 25.00m, Special =false },
                    new Photo { Title = "Bád Eddie", ShortDescription = "Bád Eddie, Magheraclogher Beach, Donegal", Description = "Bád Eddie, Co. Donegal Ireland", Location = "Ireland", PhotoUrl = "https://live.staticflickr.com/1725/42712165112_acbe950712_k_d.jpg/",Price=22.50m, Special = true }
                    );
            }
            context.SaveChanges();
        }
    }
}
