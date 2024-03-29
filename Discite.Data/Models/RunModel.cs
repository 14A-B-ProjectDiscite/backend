﻿using Discite.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discite.Data.Models
{
    [Table("run")]
    public class RunModel : IModelWithId
    {
        public int Id { get; set; }
        public UserModel User { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }
        [NotMapped]
        public int Runtime => (int)(EndDate - StartDate).TotalSeconds;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }

        public ICollection<RunArtifactModel> Artifacts { get; set; }
        public ICollection<RunWeaponModel> Weapons { get; set; }
        public ICollection<RunEnemyModel> Enemies { get; set; }

    }
}
