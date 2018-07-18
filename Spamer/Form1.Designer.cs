namespace Spamer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.LGrupos = new System.Windows.Forms.CheckedListBox();
            this.LLinks = new System.Windows.Forms.CheckedListBox();
            this.Start = new System.Windows.Forms.Button();
            this.LComentario = new System.Windows.Forms.CheckedListBox();
            this.Comentariotext = new System.Windows.Forms.TextBox();
            this.Grupostext = new System.Windows.Forms.TextBox();
            this.Linkstext = new System.Windows.Forms.TextBox();
            this.Listo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Emojis = new System.Windows.Forms.Button();
            this.sesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 4);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(469, 322);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1_DocumentCompletedAsync);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.WebBrowser1_Navigating);
            // 
            // LGrupos
            // 
            this.LGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LGrupos.FormattingEnabled = true;
            this.LGrupos.Location = new System.Drawing.Point(717, 0);
            this.LGrupos.Name = "LGrupos";
            this.LGrupos.Size = new System.Drawing.Size(116, 334);
            this.LGrupos.TabIndex = 2;
            // 
            // LLinks
            // 
            this.LLinks.FormattingEnabled = true;
            this.LLinks.Location = new System.Drawing.Point(601, 0);
            this.LLinks.Name = "LLinks";
            this.LLinks.Size = new System.Drawing.Size(110, 334);
            this.LLinks.TabIndex = 4;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(39, 46);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(353, 91);
            this.Start.TabIndex = 6;
            this.Start.Text = "button1";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // LComentario
            // 
            this.LComentario.FormattingEnabled = true;
            this.LComentario.Location = new System.Drawing.Point(475, 0);
            this.LComentario.Name = "LComentario";
            this.LComentario.Size = new System.Drawing.Size(120, 334);
            this.LComentario.TabIndex = 8;
            // 
            // Comentariotext
            // 
            this.Comentariotext.CausesValidation = false;
            this.Comentariotext.Location = new System.Drawing.Point(431, 27);
            this.Comentariotext.Multiline = true;
            this.Comentariotext.Name = "Comentariotext";
            this.Comentariotext.Size = new System.Drawing.Size(373, 264);
            this.Comentariotext.TabIndex = 12;
            this.Comentariotext.Visible = false;
            // 
            // Grupostext
            // 
            this.Grupostext.Location = new System.Drawing.Point(12, 27);
            this.Grupostext.Multiline = true;
            this.Grupostext.Name = "Grupostext";
            this.Grupostext.Size = new System.Drawing.Size(210, 264);
            this.Grupostext.TabIndex = 13;
            this.Grupostext.Tag = "";
            this.Grupostext.Visible = false;
            // 
            // Linkstext
            // 
            this.Linkstext.Location = new System.Drawing.Point(228, 28);
            this.Linkstext.Multiline = true;
            this.Linkstext.Name = "Linkstext";
            this.Linkstext.Size = new System.Drawing.Size(193, 264);
            this.Linkstext.TabIndex = 14;
            this.Linkstext.Visible = false;
            // 
            // Listo
            // 
            this.Listo.Location = new System.Drawing.Point(321, 297);
            this.Listo.Name = "Listo";
            this.Listo.Size = new System.Drawing.Size(201, 23);
            this.Listo.TabIndex = 15;
            this.Listo.Text = "Listo!";
            this.Listo.UseVisualStyleBackColor = true;
            this.Listo.Visible = false;
            this.Listo.Click += new System.EventHandler(this.Listo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Grupos";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Links";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Comentario";
            this.label3.Visible = false;
            // 
            // Emojis
            // 
            this.Emojis.Location = new System.Drawing.Point(621, 297);
            this.Emojis.Name = "Emojis";
            this.Emojis.Size = new System.Drawing.Size(200, 23);
            this.Emojis.TabIndex = 20;
            this.Emojis.Text = "Emojis / Emoticones";
            this.Emojis.UseVisualStyleBackColor = true;
            this.Emojis.Visible = false;
            this.Emojis.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // sesion
            // 
            this.sesion.Location = new System.Drawing.Point(39, 164);
            this.sesion.Name = "sesion";
            this.sesion.Size = new System.Drawing.Size(366, 106);
            this.sesion.TabIndex = 22;
            this.sesion.Text = "Iniciar/Cerrar Sesion";
            this.sesion.UseVisualStyleBackColor = true;
            this.sesion.Click += new System.EventHandler(this.sesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(833, 329);
            this.Controls.Add(this.sesion);
            this.Controls.Add(this.Emojis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Listo);
            this.Controls.Add(this.LComentario);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.LLinks);
            this.Controls.Add(this.LGrupos);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Linkstext);
            this.Controls.Add(this.Grupostext);
            this.Controls.Add(this.Comentariotext);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.CheckedListBox LGrupos;
        private System.Windows.Forms.CheckedListBox LLinks;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.CheckedListBox LComentario;
        private System.Windows.Forms.TextBox Comentariotext;
        private System.Windows.Forms.TextBox Grupostext;
        private System.Windows.Forms.TextBox Linkstext;
        private System.Windows.Forms.Button Listo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Emojis;
        private System.Windows.Forms.Button sesion;
    }
}

