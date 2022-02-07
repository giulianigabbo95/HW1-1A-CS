using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace HW1
{
    public partial class Finestra : Form
    {
        // Inizializzo le variabili, le prime due definiscono la dimensione della palla, le successive la sua posizione e le ultime di quanto deve spostarsi
        private int ballWidth = 50;
        private int ballHeight = 50;
        private int ballPosX = 100;
        private int ballPosY = 100;
        private int moveStepX = 1;
        private int moveStepY = 1;

        public Finestra()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }

        // Questo metodo fa apparire il testo nello spazio designato quando viene premuto l'apposito tasto
        private void bottoneTesto_Click(object sender, EventArgs e)
        {
            spazioTesto.Text = "qwertyuiop\nasdfghjkl\nzxcvbnm";
        }

        // Questo metodo fa apparire la palla nel rettangolo e la fa muovere quando viene premuto l'apposito tasto
        // Per evitare che sia troppo veloce ogni volta che fa un movimento si ferma per 20 millisecondi
        private void bottonePalle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 500; i++)
            {
                MoveBall(sender, e);
                spazioTesto.Refresh();
                Thread.Sleep(20);
            }
        }

        //  Questo metodo cambia la posizione della palla nel rettangolo
        private void MoveBall(object sender, EventArgs e)
        {
            ballPosX += moveStepX;
            if (ballPosX < 0 || ballPosX + ballWidth > rettangoloPalla.ClientSize.Width)
            {
                moveStepX = -moveStepX;
            }
            ballPosY += moveStepY;
            if (ballPosY < 0 || ballPosY + ballHeight > rettangoloPalla.ClientSize.Height)
            {
                moveStepY = -moveStepY;
            }
            rettangoloPalla.Refresh();
        }

        // Questo è un metodo che disegma il cerchio nel rettangolo
        private void PaintCircle(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(rettangoloPalla.BackColor);
            e.Graphics.FillEllipse(Brushes.Green, ballPosX, ballPosY, ballWidth, ballHeight);
        }
    }
}
