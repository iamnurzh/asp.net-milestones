using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milestones.Models
{
    public class SampleData
    {
        public static void Initialize(Milestones milestones)
        {
            if (!milestones.Jewelry.Any())
            {
                milestones.Jewelry.AddRange(
                    new Jewelry
                    {
                        Name = "Huggie",
                        Price = 600,
                    },

                    new Jewelry
                    {
                        Name = "Chain",
                        Price = 550,
                    },
                    new Jewelry
                    {
                        Name = "Charm",
                        Price = 500
                    }
                );
                milestones.SaveChanges();
            }
        }
    }
}
