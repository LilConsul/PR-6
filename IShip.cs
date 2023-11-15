namespace PR_6 {
    public abstract class IShip {
        public string Name { get; set; }
        public int Health{ get; set; }
        public abstract void Move();
        public abstract void TakeDamage(int damage);
        public abstract void StartSinking();
    }
}