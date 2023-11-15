using System;

namespace PR_6 {
    public class NuclearShip : IShip, ISteamPowered {
        private readonly Random _ran = new Random();
        public string Name { get; set; }
        private int _health;
        private bool _engineStarted;
        
        public event EventHandler ShipSinking;
        
        public NuclearShip(string name) {
            Name = name;
            _health = 100;
        }
        
        public void TakeDamage(int damage) {
            _health -= damage;
            if(_health < 0)
                StartSinking();
        }

        public void Move() {
            if (!_engineStarted)
                throw new Exception("The Engine is not started!");
            var damage = _ran.Next(0, 10);
            TakeDamage(damage);
        }
        public void StartSinking() {
            _engineStarted = false;
            OnShipSinking();
        }

        public void StartEngine() {
            _engineStarted = true;
        }
        
        protected virtual void OnShipSinking() {
            ShipSinking?.Invoke(this, EventArgs.Empty);
        }
    }
}