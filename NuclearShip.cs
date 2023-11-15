using System;

namespace PR_6 {
    public class NuclearShip : IShip, ISteamPowered {
        private readonly Random _ran = new Random();
        public bool EngineStarted { get; set; }
        
        public event EventHandler ShipSinking;
        
        public NuclearShip(string name) {
            Name = name;
            Health = 100;
        }
        
        public override void TakeDamage(int damage) {
            Health -= damage;
            if(Health < 0)
                StartSinking();
        }

        public override void Move() {
            if (!EngineStarted)
                throw new Exception("The Engine is not started!");
            var damage = _ran.Next(0, 10);
            TakeDamage(damage);
        }
        public override void StartSinking() {
            EngineStarted = false;
            OnShipSinking();
        }

        public void StartEngine() {
            EngineStarted = true;
        }
        
        protected virtual void OnShipSinking() {
            ShipSinking?.Invoke(this, EventArgs.Empty);
        }
    }
}