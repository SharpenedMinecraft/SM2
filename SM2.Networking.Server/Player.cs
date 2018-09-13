using System;
using System.Collections.Generic;
using System.Text;
using SM2.Core.BaseTypes;

namespace SM2.Core.Server
{
    public class Player : Entity
    {
        private readonly Context _ctx;

        public Player(Context ctx)
        {
            _ctx = ctx;
            Position = new Vector3D(0, 0, 0);
            Rotation = new Rotation(0, 0);
            SpawnPosition = new Position(0, 0, 0);
            Settings = new PlayerSettings();
        }

        public String Username { get; set; }
        public Guid UUID { get; set; }
        public Position SpawnPosition { get; set; }
        public PlayerSettings Settings { get; set; }
        public Rotation Rotation { get; set; }
        public Vector3D Position { get; set; }
    }
}
