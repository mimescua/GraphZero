using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphZero.API.Data.Entities;

namespace GraphZero.API.Data
{
    public static class InitialData
    {
        public static void Seed(this LandDbContext dbContext)
        {
            if (!dbContext.Blocks.Any())
            {
                dbContext.Blocks.Add(new Block
                {
                    Name = "A",
                    AreaCode = 150101,
                    Area = 1881.45,
                    UseType = "Residencial",
                    LotsQty = 14,
                    LotIds = new List<Lot>
                    {
                        new Lot
                        {
                            Name = "15",
                            AreaCode = 150101,
                            Area = 1881.45,
                            UseType = "Residencial",
                            FrontMeasure = 8,
                            LeftMeasure = 12,
                            BackMeasure = 7.5,
                            RightMeasure = 13
                        },
                        new Lot
                        {
                            Name = "16",
                            AreaCode = 130101,
                            Area = 2731.45,
                            UseType = "Comercial",
                            FrontMeasure = 6,
                            LeftMeasure = 15,
                            BackMeasure = 7,
                            RightMeasure = 14
                        }
                    }
                });
                dbContext.Blocks.Add(new Block
                {
                    Name = "B",
                    AreaCode = 130101,
                    Area = 2731.45,
                    UseType = "Comercial",
                    LotsQty = 18,
                    LotIds = new List<Lot>
                    {
                        new Lot
                        {
                            Name = "15",
                            AreaCode = 150101,
                            Area = 1881.45,
                            UseType = "Residencial",
                            FrontMeasure = 8,
                            LeftMeasure = 12,
                            BackMeasure = 7.5,
                            RightMeasure = 13
                        },
                        new Lot
                        {
                            Name = "16",
                            AreaCode = 130101,
                            Area = 2731.45,
                            UseType = "Comercial",
                            FrontMeasure = 6,
                            LeftMeasure = 15,
                            BackMeasure = 7,
                            RightMeasure = 14
                        }
                    }
                });
                dbContext.SaveChanges();
            }
        }
    }
}
