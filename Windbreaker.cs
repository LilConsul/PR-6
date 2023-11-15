using System;

namespace PR_6 {
    public class Windbreaker : IShip, ISailable {
        private readonly Random _ran = new Random();
        public bool IsSatSailsSet{ get; set; }
        public event EventHandler ShipSinking; 
        public event EventHandler SailsFurled; 
        
        public Windbreaker(string name) {
            Name = name;
            Health = 100;
            IsSatSailsSet = false;
        }
        
        public override void TakeDamage(int damage) {
            Health -= damage;
            if (Health <= 0)
                StartSinking(); 
        }

        public void SetSail() {
            IsSatSailsSet = true;
        }

        public void FurlSails() {
            IsSatSailsSet = false;
            OnSailsFurled();
        }

        public override void Move() {
            if (!IsSatSailsSet)
               return;
            var damage = _ran.Next(0, 3);
            TakeDamage(damage);
            
            if(_ran.Next(0, 20) > 2)
                FurlSails();
        }

        public override void StartSinking() {
            IsSatSailsSet = false;
            OnShipSinking(); 
        }

        protected virtual void OnShipSinking() {
            ShipSinking?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnSailsFurled() {
            SailsFurled?.Invoke(this, EventArgs.Empty);
        }
    }
}