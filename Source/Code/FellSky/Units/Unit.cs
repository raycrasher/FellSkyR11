using ca.axoninteractive.Geometry.Hex;
using Duality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Units
{
    public class Unit: Component
    {
        private int moveDistance = 4;
        private int actionsLeft = 2;
        private int health = 1000;
        private int maxHealth = 1000;
        private int armor = 250;
        private int maxArmor = 250;
        private int shield = 0;
        private int maxShield = 0;
        private MoveTypes moveType = MoveTypes.Bipedal;
        private AxialHexCoord pos;

        public AxialHexCoord Pos { get => pos; set => pos = value; }

        public MoveTypes MoveType { get => moveType; set => moveType = value; }
        public int MoveDistance { get => moveDistance; set => moveDistance = value; }
        public int ActionsLeft { get => actionsLeft; set => actionsLeft = value; }
        public int Health { get => health; set => health = value; }
        public int MaxHealth { get => maxHealth; set => maxHealth = value; }
        public int Armor { get => armor; set => armor = value; }
        public int MaxArmor { get => maxArmor; set => maxArmor = value; }
        public int Shield { get => shield; set => shield = value; }
        public int MaxShield { get => maxShield; set => maxShield = value; }
    }
}
