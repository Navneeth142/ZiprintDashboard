using BlazorAssignment.Models;

namespace BlazorAssignment.Services
{
    public class AndonRealtimeService
    {
        private readonly Random rnd = new();

        public AndonState GetState()
        {
            return new AndonState
            {
                DateTime = DateTime.Now,
                Parts = new()
            {
                new("A1223450", rnd.Next(500,900), 1300),
                new("B1223450", rnd.Next(300,600), 1300),
                new("C1223450", rnd.Next(200,500), 1300),
                new("D1223450", rnd.Next(900,1200),1300),
            },
                ShiftCounts = new()
                {
                    ["B1223450"] = new[] { rnd.Next(200, 260), rnd.Next(240, 300) },
                    ["C1223450"] = new[] { rnd.Next(70, 100) },
                    ["D1223450"] = new[] { rnd.Next(60, 100) }
                }
            };
        }
    }
}
