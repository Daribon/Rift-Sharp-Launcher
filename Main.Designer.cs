using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace RiftSharp_Launcher
{
    public partial class Main : Form
    {
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this._btnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkboxWindowed = new System.Windows.Forms.CheckBox();
            this.chkboxOpenGL = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(220, 110);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // _btnLogin
            // 
            this._btnLogin.Location = new System.Drawing.Point(133, 177);
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Size = new System.Drawing.Size(75, 23);
            this._btnLogin.TabIndex = 2;
            this._btnLogin.Text = "Login";
            this._btnLogin.UseVisualStyleBackColor = true;
            this._btnLogin.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(74, 116);
            this.txtUserName.MaxLength = 32;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(134, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 119);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Username:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 145);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(74, 142);
            this.txtPassword.MaxLength = 32;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(134, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkboxWindowed
            // 
            this.chkboxWindowed.AutoSize = true;
            this.chkboxWindowed.Checked = true;
            this.chkboxWindowed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxWindowed.Location = new System.Drawing.Point(15, 168);
            this.chkboxWindowed.Name = "chkboxWindowed";
            this.chkboxWindowed.Size = new System.Drawing.Size(77, 17);
            this.chkboxWindowed.TabIndex = 5;
            this.chkboxWindowed.Text = "Windowed";
            this.chkboxWindowed.UseVisualStyleBackColor = true;
            this.chkboxWindowed.CheckedChanged += new System.EventHandler(this.chkboxWindowed_CheckedChanged);
            // 
            // chkboxOpenGL
            // 
            this.chkboxOpenGL.AutoSize = true;
            this.chkboxOpenGL.Checked = true;
            this.chkboxOpenGL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxOpenGL.Location = new System.Drawing.Point(15, 191);
            this.chkboxOpenGL.Name = "chkboxOpenGL";
            this.chkboxOpenGL.Size = new System.Drawing.Size(77, 17);
            this.chkboxOpenGL.TabIndex = 6;
            this.chkboxOpenGL.Text = "OpenGL";
            this.chkboxOpenGL.UseVisualStyleBackColor = true;
            this.chkboxOpenGL.CheckedChanged += new System.EventHandler(this.chkboxOpenGL_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 211);
            this.Controls.Add(this.chkboxOpenGL);
            this.Controls.Add(this.chkboxWindowed);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this._btnLogin);
            this.Controls.Add(this.imgLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal PictureBox imgLogo;
        private Button _btnLogin;

        internal Button btnLogin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnLogin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnLogin != null)
                {
                    _btnLogin.Click -= Button1_Click;
                }

                _btnLogin = value;
                if (_btnLogin != null)
                {
                    _btnLogin.Click += Button1_Click;
                }
            }
        }

        internal TextBox txtUserName;
        internal Label Label1;
        internal Label Label2;
        internal TextBox txtPassword;
        internal CheckBox chkboxWindowed;
        internal CheckBox chkboxOpenGL;
    }
}