﻿using System;
using System.Text.Json.Nodes;

namespace Druzhbank.Models
{
    public class BankomatModel
    {
        public int? id { get; set; }
        public string? adress { get; set; }
        public Boolean? is_working { get; set; }
        public Boolean? is_atm { get; set; }
        public String? time_start { get; set; }
        public String? time_end { get; set; }
        public String? coordinates { get; set; }
    }
}