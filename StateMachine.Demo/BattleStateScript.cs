﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine.Demo
{
    public abstract class BattleStateScript : IStateScript
    {
        protected Battle Battle { get; set; }

        public virtual void Deinitialize()
        {
        }

        public virtual void Initialize(IObjectWithState owner, object paramObj = null)
        {
            Battle = (Battle)owner;
        }

        public abstract void Process();
    }
}
