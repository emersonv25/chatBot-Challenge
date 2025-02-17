﻿namespace api_git.Models
{
    public class Repository
    {
        public string full_name { get; set; }
        public string description { get; set; }
        public string created_at { get; set; }
        public string language { get; set; }
        public Owner owner { get; set; }
    }
    public class Owner
    {
        public string login { get; set; }
        public string avatar_url { get; set; }
    }
}
