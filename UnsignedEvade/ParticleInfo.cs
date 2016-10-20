﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsignedEvade
{
    class ParticleInfo
    {
        public string ParticleName;

        public int Width,
            Length,
            XOffset = 0,
            YOffset = 0;
        public float Radius = 0;
        public List<string> otherNames = new List<string>();

        public SpellTypeInfo SpellType;

        public bool isDangerous = false;
        public enum SpellTypeInfo
        {
            CircularSkillshot,
            LinearSkillshot,
            ArcSkillshot,
            SelfActive,
            PassiveActive,
            Targeted,
            Wall,
            MovingWall,
            ConeSkillshot,
            None
        }
    }
}
