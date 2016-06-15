﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tera.Game;

namespace DamageMeter.Database.Data
{
    public class Skill
    {

        public Skill(long amount, Database.Type type, EntityId target, EntityId source, int skill_id, bool critic, long time)
        {
            Amount = amount;
            Type = type;
            Target = target;
            Source = source;
            SkillId = skill_id;
            Critic = critic;
            Time = time;
        }

         public long Amount { get; }
         public Database.Type Type { get; }
        public EntityId Target { get; }
        public EntityId Source { get; }
        public int SkillId { get; }
        public bool Critic { get; }
        public long Time { get; }

    }
}
