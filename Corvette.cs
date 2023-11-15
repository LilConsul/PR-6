using System;

namespace PR_6 {
    public class Corvette : IShip, ISailable {
        private readonly Random _ran = new Random();
        private string Name { get; set; }
        private int _health;
        private bool _sailsSet;

        public event EventHandler ShipSinking; 
        public event EventHandler SailsSet; 
        public event EventHandler SailsFurled; 


        public Corvette(string name) {
            Name = name;
            _health = 100;
            _sailsSet = false;
        }
        
        public void TakeDamage(int damage) {
            _health -= damage;
            if (_health <= 0)
                StartSinking(); 
        }

        public void SetSail() {
            _sailsSet = true;
            OnSailsSet(); 
        }

        public void FurlSails() {
            _sailsSet = false;
            OnSailsFurled(); 
        }

        public void Move() {
            if (!_sailsSet)
                throw new InvalidOperationException("Sails not set.");
            
            var damage = _ran.Next(0, 10);
            TakeDamage(damage);
        }

        public void StartSinking() {
            OnShipSinking(); 
        }

        protected virtual void OnShipSinking() {
            ShipSinking?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnSailsSet() {
            SailsSet?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnSailsFurled() {
            SailsFurled?.Invoke(this, EventArgs.Empty);
        }
    }
}