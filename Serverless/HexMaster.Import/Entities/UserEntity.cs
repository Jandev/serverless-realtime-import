﻿using System;
using Microsoft.WindowsAzure.Storage.Table;

namespace HexMaster.Import.Models
{
    public sealed class UserEntity : TableEntity
    {
        public bool IsActive { get; set; }
        public int Age { get; set; }
        public string EyeColor { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Greeting { get; set; }
        public string FavoriteFruit { get; set; }

    }
}
