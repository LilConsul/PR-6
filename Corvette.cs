using System;

namespace PR_6 {
    public class Corvette : IShip, ISailable {
        private readonly Random _ran = new Random();
        public bool IsSailsSet{ get; set; }

        public event EventHandler ShipSinking; 


        public Corvette(string name) {
            Name = name;
            Health = 100;
            IsSailsSet = false;
        }
        
        public override void TakeDamage(int damage) {
            Health -= damage;
            if (Health <= 0)
                StartSinking(); 
        }

        public void SetSail() {
            IsSailsSet = true;
        }

        public void FurlSails() {
            IsSailsSet = false;
        }

        public override void Move() {
            if (!IsSailsSet)
                throw new InvalidOperationException("Sails not set.");
            
            var damage = _ran.Next(0, 10);
            TakeDamage(damage);
        }

        public override void StartSinking() {
            OnShipSinking(); 
        }

        protected virtual void OnShipSinking() {
            ShipSinking?.Invoke(this, EventArgs.Empty);
        }
        
    }
}