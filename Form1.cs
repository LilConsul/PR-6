using System;
using System.Windows.Forms;

namespace PR_6 {
    public partial class Form1 : Form {
        private NuclearShip _ship;
        private Windbreaker _windbreaker;
        private Corvette _corvette;
        private SteamShip _steamship;
        private bool _sailsSet;

        private delegate void MyDelegate();

        private readonly MyDelegate _setSails;
        private MyDelegate _moveShips;


        private MyDelegate moveShipAction;
        private MyDelegate moveWindAction;
        private MyDelegate moveCorvetteAction;
        private MyDelegate moveSteamAction;

        public Form1() {
            InitializeComponent();

            _setSails += () => { shipName.Enabled = false; _ship.StartEngine();};
            _setSails += () => { sailableName.Enabled = false; _windbreaker.SetSail(); };
            _setSails += () => { corvetteName.Enabled = false; _corvette.SetSail();};
            _setSails += () => { steamName.Enabled = false; _steamship.StartEngine();};
            _setSails += () => { set_sails.Enabled = false; };
            _setSails += () => { _sailsSet = true; };
            
            moveShipAction = () => {
                _ship.Move(); 
                shipEn.Text = _ship.EngineStarted ? "Так!" : "Ні";
                healthShip.Text = _ship.Health.ToString();
                fuelShip.Text = "Inf";
            };
            moveWindAction = () => {
                _windbreaker.Move(); 
                sailEn.Text = _windbreaker.IsSatSailsSet ? "Так!" : "Ні";
                healthWind.Text = _windbreaker.Health.ToString();
                fuelWind.Text = "Inf";
            };
            moveCorvetteAction = () => {
                _corvette.Move(); 
                corvEn.Text = _corvette.IsSailsSet ? "Так!" : "Ні";
                healthCorv.Text = _corvette.Health.ToString();
                fuelCorv.Text = "Inf";
            };
            moveSteamAction = () => {
                _steamship.Move(); 
                steamEn.Text = _steamship.EngineStarted ? "Так!" : "Ні";
                healthSteam.Text = _steamship.Health.ToString();
                fuelSteam.Text = _steamship.AmountOfFuel.ToString();
            };
        }
        
        private void set_sails_Click(object sender, EventArgs e) {
            try {
                _ship = new NuclearShip(Convert.ToString(shipName.Text));
                _windbreaker = new Windbreaker(Convert.ToString(sailableName.Text));
                _corvette = new Corvette(Convert.ToString(corvetteName.Text));
                _steamship = new SteamShip(Convert.ToString(steamName.Text));

                _ship.ShipSinking += SinkingHandler;
                _windbreaker.ShipSinking += SinkingHandler;
                _corvette.ShipSinking += SinkingHandler;
                _steamship.ShipSinking += SinkingHandler;

                _steamship.ShipMoved += ShipMovedHandler;
                _windbreaker.SailsFurled += Furled;

                _moveShips += moveShipAction;
                _moveShips += moveWindAction;
                _moveShips += moveCorvetteAction;
                _moveShips += moveSteamAction;

                _setSails?.Invoke();
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void move_button_Click(object sender, EventArgs e) {
            if (!_sailsSet)
                MessageBox.Show("Лодки ще не запущено!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            try {
                _moveShips?.Invoke();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void SinkingHandler(object sender, EventArgs e) {
            var sh = (IShip)sender;
            MessageBox.Show($"{sh.Name} тоне!!!", "О ні!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DeleteDelegate(sender);
        }
        
        private void ShipMovedHandler(object sender, EventArgs e) {
            var sh = (IShip)sender;
            MessageBox.Show($"{sh.Name} пливе...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Furled(object sender, EventArgs e) {
            var sh = (IShip)sender;
            MessageBox.Show($"{sh.Name} попустив паруса! Піднімаємо...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            _windbreaker.SetSail();
        }

        private void DeleteDelegate(object sender) {
            switch (sender) {
                case NuclearShip _:
                    _moveShips -= moveShipAction;
                    return;
                case Windbreaker _:
                    _moveShips -= moveWindAction;
                    return;
                case Corvette _:
                    _moveShips -= moveCorvetteAction;
                    return;
                case SteamShip _:
                    _moveShips -= moveSteamAction;
                    return;
            }
        }
    }
}