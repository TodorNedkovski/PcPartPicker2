namespace PcPartPicker2.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using PcPartPicker2.Data.Models;

    public class BuildSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var builds = new List<Build>
            {
                new Build()
                {
                    Author = new ApplicationUser()
                    {
                        NormalizedUserName = "JOZUEF",
                        NormalizedEmail = "TNEDKOVSKI@GMAIL.COM",
                    },
                    Case = new Case()
                    {
                        Manufacturer = "Case Inc",
                    },
                    Cpu = new Cpu()
                    {
                        Manufacturer = "AMD",
                    },
                    CpuCooler = new CpuCooler()
                    {
                        Manufacturer = "COOLER MASTER",
                    },
                    Memory = new Memory()
                    {
                        Manufacturer = "Hyper x",
                    },
                    VideoCard = new VideoCard()
                    {
                        Manufacturer = "NVidia",
                    },
                    Motherboard = new Motherboard()
                    {
                        Manufacturer = "MSI",
                    },
                    PowerSupply = new PowerSupply()
                    {
                        Manufacturer = "PowerSupply inc",
                    },
                    Storage = new Storage()
                    {
                        Manufacturer = "Samsung",
                    },
                },
            };

            await dbContext.AddRangeAsync(builds);
        }
    }
}
