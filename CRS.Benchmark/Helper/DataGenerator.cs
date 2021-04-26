using System;
using System.Collections.Generic;

namespace CRS.Benchmark
{
    public class DataGenerator
    {
        public IEnumerable<WeatherForecastClass> GenerateClass()
        {
            int limit = 100000;
            var items = new List<WeatherForecastClass>();

            for (var i = 0; i < limit; i++)
            {
                items.Add(new WeatherForecastClass
                {
                    Date = DateTime.UtcNow.AddDays(i),
                    Summary = $"Summary{i}",
                    TemperatureC = i % 30
                });
            }

            return items;
        }

        public IEnumerable<WeatherForecastRecord> GenerateRecord()
        {
            int limit = 100000;
            var items = new List<WeatherForecastRecord>();

            for (var i = 0; i < limit; i++)
            {
                items.Add(new WeatherForecastRecord
                {
                    Date = DateTime.UtcNow.AddDays(i),
                    Summary = $"Summary{i}",
                    TemperatureC = i % 30
                });
            }

            return items;
        }

        public IEnumerable<WeatherForecastStruct> GenerateStruct()
        {
            int limit = 100000;
            var items = new List<WeatherForecastStruct>();

            for (var i = 0; i < limit; i++)
            {
                items.Add(new WeatherForecastStruct
                {
                    Date = DateTime.UtcNow.AddDays(i),
                    Summary = $"Summary{i}",
                    TemperatureC = i % 30
                });
            }

            return items;
        }
    }
}