﻿using MoveM8s.Converters;
using System.Text.Json.Serialization;

namespace MoveM8s.Data.Models
{
    public class Properties
    {
        public long? Source { get; set; }
        [JsonConverter(typeof(IdConverter))]
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Namn { get; set; }
        public string? Email { get; set; }
        public long? AltSource { get; set; }
        public string? VisitUrl { get; set; }
        public string? Updated { get; set; }
        public string? Description { get; set; }
        public bool? Lighting { get; set; }
        public bool? Accessibility { get; set; }
        public string? Theme { get; set; }
        public int? LastRenovated { get; set; }
        public string ActivityType { get; set; }
    }
}
