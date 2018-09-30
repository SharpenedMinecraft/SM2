using System;
using System.Collections.Generic;
using System.Text;
using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Enums;
using SM2.MojangAPI;

namespace SM2.Core.Server
{
    public class Player : Entity
    {
        private readonly Context _ctx;

        public Player(Context ctx)
        {
            _ctx = ctx;
            Position = new Vector3D(0, 10, 0);
            Rotation = new Rotation(0, 0);
            SpawnPosition = new Position(0, 0, 0);
            Settings = new PlayerSettings();
        }

        public Gamemode GameMode { get; set; } = Gamemode.Creative;
        public String Username { get; set; }
        public Guid UUID { get; set; }
        public Position SpawnPosition { get; set; }
        public PlayerSettings Settings { get; set; }
        public int ClientLatency => _ctx.Client.Latency;

        public MojangPlayerProfile Profile { get; set; }
    }
}
