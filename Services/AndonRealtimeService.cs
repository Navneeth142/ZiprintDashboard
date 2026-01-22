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
                    new("A1223450", rnd.Next(500, 900), 1300),
                    new("B1223450", rnd.Next(300, 600), 1300),
                    new("C1223450", rnd.Next(200, 500), 1300),
                    new("D1223450", rnd.Next(900, 1200), 1300),

                    // ➕ Extra rows to fill table vertically
                    new("A1223451", rnd.Next(400, 850), 1300),
                    new("B1223451", rnd.Next(250, 650), 1300),
                    new("C1223451", rnd.Next(300, 700), 1300),
                    new("D1223451", rnd.Next(600, 1100), 1300)
                },

                ShiftCounts = new()
                {
                    ["B1223450"] = new[]
                    {
                        rnd.Next(200, 260),
                        rnd.Next(240, 300)
                    },

                    ["C1223450"] = new[]
                    {
                        rnd.Next(70, 100)
                    },

                    ["D1223450"] = new[]
                    {
                        rnd.Next(60, 100)
                    },

                    // ➕ Shift data for added rows (optional but clean)
                    ["A1223451"] = new[]
                    {
                        rnd.Next(180, 240),
                        rnd.Next(220, 280)
                    },

                    ["B1223451"] = new[]
                    {
                        rnd.Next(150, 210)
                    }
                }
            };
        }
    }
}
