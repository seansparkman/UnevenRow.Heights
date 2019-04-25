using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uneven.Heights
{
    public class CagesViewModel
    {
        private string[] SUFFIXES = new string[]
        {
            string.Empty,
            "/g",
            "/c",
            "/gif"
        };
        private Random random = new Random();
        public CagesViewModel()
        {
            Cages = Enumerable.Range(1, 150).Select(x => new Cage
            {
                ImageURL = GenerateImageURL()
            }).ToList();
        }
        public List<Cage> Cages { get; set; }
        private string GenerateImageURL()
        {
            string suffix = GenerateSuffix();
            string width = GenerateNumber();
            string height = GenerateNumber();

            return $"https://www.placecage.com{suffix}{width}{height}";
        }

        private string GenerateSuffix()
        {
            return SUFFIXES[random.Next(0, SUFFIXES.Length)];
        }

        private string GenerateNumber()
        {
            var number = random.Next(1, 6);
            return $"/{number}00";
        }
    }
}
