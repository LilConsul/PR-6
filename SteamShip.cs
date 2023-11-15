using System;

namespace PR_6 {
    public class SteamShip : IShip, ISteamPowered {
        private readonly Random _ran = new Random();
        private bool _engineStarted;
        public string Name { get; set; }
        private int _health;
        private int _amountOfFuel;
        
        public event EventHandler ShipMoved; 
        public event EventHandler ShipSinking;

        public SteamShip(string name, uint amountOfFuel) {
            Name = name;
            _amountOfFuel = (int)amountOfFuel;
            _health = 100;
        }

        private void BurnFuel(int burned) {
            _amountOfFuel -= burned;
            if (_amountOfFuel < 0)
                StartSinking();
        }

        public void Move() {
            if (!_engineStarted)
                throw new InvalidOperationException("Engine not started.");
            
            var damage = _ran.Next(0, 10);
            var burned = _ran.Next(5, 15);
            TakeDamage(damage);
            BurnFuel(burned);
            OnShipMoved();
        }
        
        public void TakeDamage(int damage) {
            _health -= damage;
            if (_health < 0)
                StartSinking();
        }

        public void StartSinking() {
            _engineStarted = false;
            OnShipSinking();
        }

        public void StartEngine() {
            _engineStarted = true;
        }
        
        protected virtual void OnShipMoved() {
            ShipMoved?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnShipSinking() {
            ShipSinking?.Invoke(this, EventArgs.Empty);
        }
    }
}