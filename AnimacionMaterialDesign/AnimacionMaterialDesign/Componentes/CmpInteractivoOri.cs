using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimacionMaterialDesign.Componentes
{
    public partial class CmpInteractivoOri : PictureBox
    {
        private float Velocidad = 1;
        private float X;
        private float Y;
        private float XOrigen;
        private float YOrigen;

        List<float> Aceleracion;
        List<List<float>> listaMovimientos;
        bool bMover = false;
        int Paso = 0;
        float Distancia = 200;

        private tipoMovimiento tipo;

        public tipoMovimiento Tipo { get => tipo; set => tipo = value; }
        public List<List<float>> ListaMovimientos { get => listaMovimientos; set => listaMovimientos = value; }

        public enum tipoMovimiento
        {
            CubicIn = 0,
            CubicOut = 1,
            CubicInOut = 2
        }

        public CmpInteractivoOri(IContainer container)
        {
            container.Add( this );
            InitializeComponent();
            Inicializar();
        }

        public CmpInteractivoOri()
        {
            InitializeComponent();
            Inicializar();
        }

        public void Inicializar()
        {
            var loc = Location;
         
            X = loc.X;
            Y = loc.Y;
            XOrigen = X;
            YOrigen = Y;

            listaMovimientos = new List<List<float>>();
        }

        public void Mover( float distanciaHorizontal, int milisegundos )
        {
            float B = 0;
            float D = .2f;
            float T = 0;
            float C = 0.2f;
            Paso = 0;
            float acumulador = 0;
            Distancia = Math.Abs(distanciaHorizontal);

            X = XOrigen;
            D = milisegundos / 1000f;
            BringToFront();
            
            Aceleracion = new List<float>();

            if ( Distancia == 0 ) 
            {
                for (float i = 0; i < milisegundos ; i+= (milisegundos/1000f) ) 
                {
                    Aceleracion.Add( 0 );
                }
            }
            
            for (float i = 0; i <= D; i+= 0.001f) {
                T = i;
                float acel = 0;
                switch (tipo) {
                    case tipoMovimiento.CubicIn:
                        acel = ClsBezier.easeInCubic( T, B, C, D ) / .001f;
                    break;
                    case tipoMovimiento.CubicOut:
                        acel = ClsBezier.easeOutCubic( T, B, C, D ) / .01f;
                    break;
                    case tipoMovimiento.CubicInOut:
                        acel = ClsBezier.easeInOutCubic( T, B, C, D ) / .001f;
                    break;
                    default:
                    break;
                }

                acumulador += acel;
                
                
                if ( acumulador >= Distancia) {
                    acel = ( Distancia - acumulador);

                    Console.WriteLine( "Acel: " + acel + " - Acumulador: " + acumulador );
                    //Aceleracion.Insert( Aceleracion.Count, acel );
                    break;
                }

                Console.WriteLine( "Acel: " + acel + " - Acumulador: " + acumulador );
                //Aceleracion.Add( acel );
               
                if ( distanciaHorizontal < 0 ) {
                    acel *= -1;
                }

                switch (tipo) {
                    case tipoMovimiento.CubicIn:
                        //Aceleracion.Add( acel);
                        Aceleracion.Insert( 0, acel );
                    break;
                    case tipoMovimiento.CubicOut:
                        Aceleracion.Add( acel );
                        //Aceleracion.Insert( 0, acel );
                    break;
                    case tipoMovimiento.CubicInOut:
                        //Aceleracion.Add( acel);
                        Aceleracion.Insert( 0, acel );
                    break;
                    default:
                    break;
                }
            }

            listaMovimientos.Add( Aceleracion );
        }

        public void GO( float XOrig )
        {
            XOrigen = XOrig;
            bMover = true;
            listaActual = 0;
        }

        
        public void Step()
        {
            if ( bMover == false) {
                return;
            }
            else 
            {
                var acel = listaMovimientos[ listaActual ];
                Velocidad = acel[ Paso ];
                Paso++;
                X += Velocidad;

                if ( Paso > acel.Count-1) {
                    Terminado();
                }
            }


            Dibujar();
        }


        private int listaActual = 0;

        public void Terminado()
        {
            if (listaActual < listaMovimientos.Count - 1) 
            {
                Paso = 0;
                listaActual++;
            }
            else
            {
                bMover = false;
                listaActual = 0;
                listaMovimientos = new List<List<float>>();
            }
            

        }

        public void Dibujar()
        {
            var loc = Location;

            loc.X = (int) X;
            loc.Y = (int) Y;

            Location = loc;
        }

        private void CmpInteractivoOri_Paint(object sender, PaintEventArgs e)
        {
            Inicializar();
        }
    }
}
