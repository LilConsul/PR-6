using System;

namespace PR_6 {
    public class SteamShip : IShip, ISteamPowered {
        private readonly Random _ran = new Random();
        public bool EngineStarted { get; set; }
        public int AmountOfFuel { get; set; }
        
        public event EventHandler ShipMoved; 
        public event EventHandler ShipSinking;

        public SteamShip(string name) {
            Name = name;
            AmountOfFuel = 250;
            Health = 100;
        }

        private void BurnFuel(int burned) {
            AmountOfFuel -= burned;
            if (AmountOfFuel < 0)
                StartSinking();
        }

        public override void Move() {
            if (!EngineStarted)
                throw new InvalidOperationException("Engine not started.");
            
            var damage = _ran.Next(0, 10);
            var burned = _ran.Next(5, 15);
            TakeDamage(damage);
            BurnFuel(burned);
            OnShipMoved();
        }
        
        public override void TakeDamage(int damage) {
            Health -= damage;
            if (Health < 0)
                StartSinking();
        }

        public override void StartSinking() {
            EngineStarted = false;
            OnShipSinking();
        }

        public void StartEngine() {
            EngineStarted = true;
        }
        
        protected virtual void OnShipMoved() {
            ShipMoved?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnShipSinking() {
            ShipSinking?.Invoke(this, EventArgs.Empty);
        }
    }
}