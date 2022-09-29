using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormsPrueba
{
    public partial class FrmInformador : Form
    {
        public FrmInformador()
        {
            InitializeComponent();
        }

        private void FrmInformador_Load(object sender, EventArgs e)
        {
            List<Aplicacion> listaApps = new List<Aplicacion>()
            {
             // Lo debe agregar
             new AppJuegos("Super Mario Bros", ESistemaOperativo.ANDROID, 20),

             // No lo debe agregar, está repetido
             new AppJuegos("Super Mario Bros", ESistemaOperativo.ANDROID, 20),

             // Lo debe agregar
             new AppJuegos("Angry Birds", ESistemaOperativo.ANDROID, 100), 

             // No lo debe agregar, sistema operativo distinto
             new AppJuegos("League of Legends", ESistemaOperativo.IOS, 500),
             
             
             // Lo agrega con las canciones.
             new AppMusical("Spotify", ESistemaOperativo.ANDROID, 50,
                new List<string>()
                {
                    "Bohemian Rhapsody - Queen",
                    "Billie Jean – Michael Jackson",
                    "Another Brick In The Wall – Pink Floyd",
                    "Romeo And Juliet – Dire Straits",
                    "Where The Streets Have No Name -U2",
                    "Let It Be – The Beatles",
                    "Could You Be Loved – Bob Marley",
                    "Every Breath You Take – The Police",
                    "November Rain – Guns n Roses",
                    "Crazy Train – Ozzy Osbourne",
                    "Volver – Carlos Gardel",
                    "En La Ciudad De La Furia – Soda Stereo",
                    "Gualicho – Patricio Rey",
                    "Paint It Black – Rolling Stones"
                }),

             // No lo debe agregar, repetido.
             new AppMusical("Spotify", ESistemaOperativo.ANDROID, 50),
             
             // Lo debe agregar.
             new AppMusical("YouTube Music", ESistemaOperativo.ANDROID, 30)
            };


            foreach (Aplicacion app in listaApps)
            {
                // Intenta instalar apps.
                if (!Dispositivo.InstalarApp(app))
                {
                    // Agrega apps no instaladas al RichTextBox de no-instaladas.
                    rtbAppNoInstaladas.Text += string.Concat(app.ToString(), "\n");
                }

                // Obtiene la información del dispositivo y sus apps instaladas.
                // Lo asigna al RichTextBox de apps instaladas.
                this.rtbAppInstaladas.Text = Dispositivo.ObtenerInformacionDispositivo();
            }
        }
    }
}
