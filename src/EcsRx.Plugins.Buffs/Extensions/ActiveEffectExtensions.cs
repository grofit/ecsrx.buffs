﻿using System.Collections.Generic;
using System.Linq;
using EcsRx.Plugins.Buffs.Models;

namespace EcsRx.Plugins.Buffs.Extensions
{
    public static class ActiveEffectExtensions
    {
        public static float SumPotencyFor(this IEnumerable<ActiveEffect> activeEffects, short effectType)
        {
            return activeEffects
                .Where(x => x.Effect.Type == effectType)
                .Sum(x => x.Effect.Potency);
        }

        public static int TicksSoFar(this ActiveEffect activeEffect)
        { return (int)(activeEffect.ActiveTime/activeEffect.Effect.Frequency); }
    }
}