namespace GameLoop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._openGLControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // simpleOpenGlControl1
            // 
            this._openGLControl.AccumBits = ((byte)(0));
            this._openGLControl.AutoCheckErrors = false;
            this._openGLControl.AutoFinish = false;
            this._openGLControl.AutoMakeCurrent = true;
            this._openGLControl.AutoSwapBuffers = true;
            this._openGLControl.BackColor = System.Drawing.Color.Black;
            this._openGLControl.ColorBits = ((byte)(32));
            this._openGLControl.DepthBits = ((byte)(16));
            this._openGLControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._openGLControl.Location = new System.Drawing.Point(0, 0);
            this._openGLControl.Name = "simpleOpenGlControl1";
            this._openGLControl.Size = new System.Drawing.Size(800, 450);
            this._openGLControl.StencilBits = ((byte)(0));
            this._openGLControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._openGLControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl _openGLControl;

        
    }
}

