using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace GameLoop
{
    public partial class Form1 : Form
    {
        FastLoop _fastLoop;
        bool _fullscreen = false;


        /* Весь закоментированный код ниже можно удалить, 
         * он нужен только чтоб вспомнить, как работает программа*/

        public Form1()
        {
            /* Создает gameloop внутри формы, для обработки элементов и их гладкой анимации */
            //_fastLoop = new FastLoop(GameLoop);   

            //InitializeComponent();
            //_openGLControl.InitializeContexts();


            //if (_fullscreen)
            //{
            //    FormBorderStyle = FormBorderStyle.None;
            //    WindowState = FormWindowState.Maximized;
            //}
        }

        void GameLoop(double elapsedTime)
        {
            //Gl.glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            //Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            //Gl.glRotated(elapsedTime * 50, 0, 1, 0);
            //Gl.glBegin(Gl.GL_TRIANGLE_STRIP);
            //{
            //    Random r = new Random();
            //    Gl.glColor3d(1, 0, 0);
            //    Gl.glVertex3d(-0.5, 0, 0);
            //    Gl.glColor3d(0, 1, 0);
            //    Gl.glVertex3d(0.5, 0, 0);
            //    Gl.glColor3d(0, 0, 1);
            //    Gl.glVertex3d(0, 0.5, 0);
            //}
            //Gl.glEnd();

            //Gl.glFinish();
            //_openGLControl.Refresh();
            
        }
    }

}
