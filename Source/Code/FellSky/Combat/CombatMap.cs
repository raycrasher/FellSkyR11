using ca.axoninteractive.Geometry.Hex;
using Duality;
using Duality.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Combat
{
    public enum CombatMapState
    {
        Idle, PlayerMove, PlayerAttack, EnemyMove, EnemyAttack
    }

    public class CombatMap: Component, ICmpUpdatable
    {
        public static readonly HexGrid Hex = new HexGrid(FellSkyGame.CombatHexRadius);

        public CombatMapState State { get; private set; }

        public void OnUpdate()
        {
            switch (State)
            {
                case CombatMapState.Idle:
                    
                    break;
            }
        }
    }
}
