namespace PR_6 {
    public class Ship : IShip, ISteamPowered {
        private string _name;
        private int _health;

        public Ship(string name) {
            _name = name;
            _health = 100;
        }
        
        public void TakeDamage(int damage) {
            _health -= damage;
            if(_health < 0)
                StartSinking();
        }

        public void StartSinking() {
            throw new System.NotImplementedException();
        }

        public void StartEngine() {
            throw new System.NotImplementedException();
        }
    }
}