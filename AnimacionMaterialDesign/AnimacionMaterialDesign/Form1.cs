using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnimacionMaterialDesign.Componentes;

namespace AnimacionMaterialDesign
{
    public partial class Form1 : Form
    {

        private BackgroundWorker backWorker;

        public Form1()
        {
            InitializeComponent();

            backWorker = new BackgroundWorker();
            backWorker.WorkerReportsProgress = true;
            backWorker.WorkerSupportsCancellation = true;
            backWorker.DoWork += IniciarWorker;
            backWorker.ProgressChanged += InformarWorker;
            backWorker.RunWorkerCompleted += WorkerTerminado;
        }

        #region Colores

        // Fondo            -> #4e4e60  -> 78, 78, 96
        // Fondo botones    -> #464651  -> 70, 70, 81
        // Texto primario   -> #ffffff  -> 255, 255, 255
        // Texto inactivo   -> #5f5f76  -> 95, 95, 118
        #endregion
        double start = 0;
        private void FPS( double fps)
        {
            double diff, wait;
            wait = 1000 / fps;
            diff = DateTime.Now.Millisecond - start;
            if (diff < wait) {
                var valorAEsperar = wait - diff;
                System.Threading.Thread.Sleep( (int) valorAEsperar );
            }
            start = DateTime.Now.Millisecond;
        }

        // This event handler is where the time-consuming work is done.
        private void IniciarWorker(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine( "Se ha iniciado el worker!" );

            //BackgroundWorker worker = sender as BackgroundWorker;
            start = DateTime.Now.Millisecond;
          //  for (int i = 0; i < 300; i++) {
          while ( true ) { 
                if (backWorker.CancellationPending == true) {
                    e.Cancel = true;
                    break;
                }
                else {
                    // Perform a time consuming operation and report progress.
                    //System.Threading.Thread.Sleep( 20 );
                    FPS( 60 );
                    backWorker.ReportProgress( 1 );
                }
            }
        }

        // This event handler updates the progress.
        private void InformarWorker(object sender, ProgressChangedEventArgs e)
        {
           // Console.WriteLine( "Se ha actualizado el worker." );
            foreach (var item in Controls) {

                if ( item is CmpInteractivoOri )
                {
                    CmpInteractivoOri ar = (CmpInteractivoOri) item;
                    ar.Step();
                }
            }
        }

        // This event handler deals with the results of the background operation.
        private void WorkerTerminado(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true) {
                Text = "Canceled!";
            }
            else if (e.Error != null) {
                Text = "Error: " + e.Error.Message;
            }
            else {
                Text = "Done!";
            }

            Console.WriteLine( "Worker finalizado" );

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine( "Boton clickeado!" );

            cmpInteractivoOri1.Mover( 300, 200 );
            cmpInteractivoOri1.Mover( 0, 1000 );
            cmpInteractivoOri2.Mover( 300, 200 );
            cmpInteractivoOri2.Mover( 0, 1000 );
            cmpInteractivoOri3.Mover( 300, 200 );
            cmpInteractivoOri3.Mover( 0, 5000 );
            cmpInteractivoOri3.Mover( 50, 200 );

            cmpInteractivoOri1.GO( 131 );
            cmpInteractivoOri2.GO( 131 );
            cmpInteractivoOri3.GO( 131 );

            if (backWorker.IsBusy != true) {
                // Start the asynchronous operation.
                backWorker.RunWorkerAsync();
            }
        }
    }
}
