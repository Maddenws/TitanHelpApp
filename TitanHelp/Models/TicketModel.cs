﻿namespace TitanHelp.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public string? Description { get; set; }
    }
}
