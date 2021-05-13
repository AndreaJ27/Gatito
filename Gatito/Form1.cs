﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gatito
{
    public partial class Form1 : Form
    {

        int turno = 1;
        int[,] Gato;
        int PuntosPlayer1 = 0;
        int PuntosPlayer2 = 0;
        bool YaHayGanador;
        public Form1()
        {
            InitializeComponent();
            IniciarJuego();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            IniciarJuego();


        }

        public void IniciarJuego()
        {

            //Iniciar valores en Juego
            turno = 1;
            Gato = new int[3, 3];
            YaHayGanador = false;

            PicGanador.Image = Properties.Resources.Sunflower;
            FichasGato.Controls.Clear();

            //Arreglos para mostrar las fichas y meter valores en una matriz
            for (var i = 0; i < 3; i++)
            {

                for (var j = 0; j < 3; j++)
                {

                    //Asignamos una variable tipo picturebox
                    var FichaJuego = new PictureBox();
                    //Asignamos la imagen de sunflower a todas las celdas
                    FichaJuego.Image = Properties.Resources.Sunflower;
                    FichaJuego.Name = string.Format("{0}", i + "_" + j);
                    FichaJuego.Cursor = Cursors.Hand;
                    FichaJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    FichaJuego.Click += Jugar;

                    FichasGato.Controls.Add(FichaJuego, j, i);
                    Gato[i, j] = 0;


                }


            }

        }

        private void Jugar(object sender, EventArgs e)
        {

            var FichaSeleccionadaUsuario = (PictureBox)sender;
            FichaSeleccionadaUsuario.Enabled = false;
            FichaSeleccionadaUsuario.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turno);
            string[] Posicion = FichaSeleccionadaUsuario.Name.Split("_".ToCharArray());
            int Fila = Convert.ToInt32(Posicion[0]);
            int Columna = Convert.ToInt32(Posicion[1]);
            Gato[Fila, Columna] = turno;
            verificarJuego(Fila, Columna);
            turno = (turno == 1) ? 2 : 1;

        }

        public void verificarJuego(int Fila, int Columna)
        {


            int GanoFilas = 0;
            int GanoColumnas = 0;
            int DiagonalPrincipal = 0;
            int DiagonalInversa = 0;
            int TamanioGato = 3;

            for (var i = 0; i < TamanioGato; i++)
            {
                for (var j = 0; j < TamanioGato; j++)
                {
                    if (i == Fila)
                    {
                        if (Gato[i, j] == turno)
                        {
                            GanoFilas++;
                        }

                    }

                    if (j == Columna)
                    {
                        if (Gato[i, j] == turno)
                        {
                            GanoColumnas++;
                        }

                    }

                    if (i == j) //Diagonal Principal
                    {
                        if (Gato[i, j] == turno)
                        {
                            DiagonalPrincipal++;
                        }
                    }

                    if ((i + j) == (TamanioGato - 1)) //diagonal inversa
                    {
                        if (Gato[i, j] == turno)
                        {
                            DiagonalInversa++;
                        }
                    }

                }
            }

            if ((GanoFilas == TamanioGato) || (GanoColumnas == TamanioGato) || (DiagonalInversa == TamanioGato) || (DiagonalPrincipal == TamanioGato))
            {
                YaHayGanador = true;
            }

            //Validar cuando sea empate
            //else
            //bool Empate =true;
            //for(var i=0; i< TamanioGato; i++)
            //{ 
            //for(var j=0; j< TamanioGato; j++)
            //{
            // if()
            //Empate = false;
            //}

            //}
            //if (Empate)
            //{
            //    MessageBox.Show("Esto es un empate ¡Reinicia el juego!");
            //    IniciarJuego();
            //}

            if (YaHayGanador)
            {
                MessageBox.Show("Ya hay ganador");
                PicGanador.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turno);
                if (turno == 1)
                {
                    PuntosPlayer1++;
                    LBLp1.Text = PuntosPlayer1.ToString();
                }
                else
                {
                    PuntosPlayer2++;
                    LBLp2.Text = PuntosPlayer2.ToString();
                }
            }
        }

    }

}

    
