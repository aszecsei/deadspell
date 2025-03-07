﻿using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Deadspell.Systems
{
    public class DebugMessageSystem : ReactiveSystem<GameEntity>
    {
        public DebugMessageSystem(Contexts contexts) : base(contexts.game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.DebugMessage);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasDebugMessage;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                Debug.Log(e.debugMessage.Message);
            }
        }
    }
}