using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducazioneA6ZampeApp.Models;

namespace EducazioneA6ZampeApp.Services
{
    public class DistanceService
    {
        const double CostoKm = 0.60;
        
        public List<CityDistanceModel> Cities { get; } =
            [new() { Name = "Altamura", DistanceKm = 63 },
            new() { Name = "Andria", DistanceKm = 30 },
            new() { Name = "Bisceglie", DistanceKm = 10 },
            new() { Name = "Barletta", DistanceKm = 25 },
            new() { Name = "Bari", DistanceKm = 35 },
            new() { Name = "Bitonto", DistanceKm = 18 },
            new() { Name = "Corato", DistanceKm = 27 },
            new() { Name = "Giovinazzo", DistanceKm = 1 },
            new() { Name = "Gravina in Puglia", DistanceKm = 50 },
            new() { Name = "Gioia del Colle", DistanceKm = 60 },
            new() { Name = "Monopoli", DistanceKm = 73 },
            new() { Name = "Modugno", DistanceKm = 25 },
            new() { Name = "Trani", DistanceKm = 15 },
            new() { Name = "Terlizzi", DistanceKm = 10 },
            new() { Name = "Triggiano", DistanceKm = 30 },
            new() { Name = "Putignano", DistanceKm = 70 },
            new() { Name = "Santeramo In Colle", DistanceKm = 70 },
            new() { Name = "Noicattaro", DistanceKm = 40 },
            new() { Name = "Conversano", DistanceKm = 65 },
            new() { Name = "Mola di Bari", DistanceKm = 50 },
            new() { Name = "Ruvo di Puglia", DistanceKm = 15 },
            new() { Name = "Palo del Colle", DistanceKm = 32 },
            new() { Name = "Acquaviva delle Fonti", DistanceKm = 50 },
            new() { Name = "Casamassima", DistanceKm = 50 },
            new() { Name = "Castellana Grotte", DistanceKm = 70 },
            new() { Name = "Noci", DistanceKm = 80 },
            new() { Name = "Rutigliano", DistanceKm = 55 },
            new() { Name = "Polignano", DistanceKm = 65 },
            new() { Name = "Valenzano", DistanceKm = 40 },
            new() { Name = "Adelfia", DistanceKm = 45 },
            new() { Name = "Capurso", DistanceKm = 40 },
            new() { Name = "Cassano", DistanceKm = 50 },
            new() { Name = "Locorotondo", DistanceKm = 100 },
            new() { Name = "Turi", DistanceKm = 55 },
            new() { Name = "Grumo Appula", DistanceKm = 40 },
            new() { Name = "Bitetto", DistanceKm = 40 },
            new() { Name = "Bitritto", DistanceKm = 35 },
            new() { Name = "Alberobello", DistanceKm = 85 },
            new() { Name = "Sannicandro", DistanceKm = 40 },
            new() { Name = "Toritto", DistanceKm = 40 },
            new() { Name = "Sammichele", DistanceKm = 55 },
            new() { Name = "Cellamare", DistanceKm = 42 },
            new() { Name = "Binetto", DistanceKm = 35 },
            new() { Name = "Poggiorsini", DistanceKm = 50 },
            new() { Name = "Molfetta", DistanceKm = 1 },
            new() { Name = "Canosa di Puglia", DistanceKm = 55 },
            new() { Name = "Margherita di Savoia", DistanceKm = 48 },
            new() { Name = "Minervino Murge", DistanceKm = 68 },
            new() { Name = "San Ferdinando di P.", DistanceKm = 55 },
            new() { Name = "Spinazzola", DistanceKm = 85 },
            new() { Name = "Trinitapoli", DistanceKm = 50 },

            ];

        public CityDistanceModel? FindCity(string name)
        {
            return Cities.FirstOrDefault(c =>
                c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public double CalculateExtra(double km)
        {
            return km * CostoKm;
        }
        public double? GetDistance(string name)
        {
            var city = FindCity(name);
            return city?.DistanceKm;
        }

    }
}
