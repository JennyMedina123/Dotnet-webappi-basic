﻿namespace TODO.WebApi.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public bool IsCompleted { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
    } 
}
