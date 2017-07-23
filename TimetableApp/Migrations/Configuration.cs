namespace TimetableApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using TimetableApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TimetableApp.Models.TimetableAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TimetableApp.Models.TimetableAppContext context)
        {

            DateTime dateNow = DateTime.Now;
            context.TrainConnections.AddOrUpdate(x => x.Id,
            new Models.TrainConnection() { Id = 1, Name = "IC 6306 (KOSSAK)", Start = "Wroclaw Glowny", Destination = "Krakow Glowny", ConnectionType = Models.TrainConnectionType.Pendolino });

            context.Stations.AddOrUpdate(x => x.Id,
            new Station() { Id = 1, Name = "Wroclaw Glowny", DepartureTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 18, 20, 0), TrainConnectionId = 1 },
            new Station() { Id = 2, Name = "Olawa", ArrivalTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 18, 36, 0), DepartureTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 18, 37, 0), TrainConnectionId = 1 },

            new Station() { Id = 3, Name = "Brzeg", ArrivalTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 18, 46, 0), DepartureTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 18, 47, 0), TrainConnectionId = 1 },

            new Station() { Id = 4, Name = "Opole Glowne", ArrivalTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 19, 08, 0), DepartureTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 19, 10, 0), TrainConnectionId = 1 },

            new Station() { Id = 5, Name = "Lubliniec", ArrivalTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 19, 41, 0), DepartureTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 19, 42, 0), TrainConnectionId = 1 },

            new Station() { Id = 6, Name = "Czestochowa Stradom", ArrivalTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 20, 05, 0), DepartureTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 20, 06, 0), TrainConnectionId = 1 },

            new Station() { Id = 7, Name = "Koniecpol", ArrivalTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 20, 50, 0), DepartureTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 20, 52, 0), TrainConnectionId = 1 },

            new Station() { Id = 8, Name = "Krakow Glowny", ArrivalTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 21, 35, 0), TrainConnectionId = 1 });

            context.SaveChanges();


        }
    }
}
