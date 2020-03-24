namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dcname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.domains = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aliases = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailaddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.objclass = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.givenname = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.dcname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 49);
            this.panel1.TabIndex = 0;
            // 
            // dcname
            // 
            this.dcname.Location = new System.Drawing.Point(40, 14);
            this.dcname.Name = "dcname";
            this.dcname.Size = new System.Drawing.Size(228, 20);
            this.dcname.TabIndex = 2;
            this.dcname.Text = "um-dc-01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DC";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect to LDAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 49);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(250, 473);
            this.treeView1.TabIndex = 1;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.CursorChanged += new System.EventHandler(this.treeView1_CursorChanged);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(250, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 473);
            this.panel2.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(0, 198);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(381, 275);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Email cím";
            this.columnHeader1.Width = 320;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.domains);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.aliases);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.emailaddress);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.objclass);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.givenname);
            this.panel3.Controls.Add(this.surname);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 198);
            this.panel3.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(164, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // domains
            // 
            this.domains.Location = new System.Drawing.Point(83, 137);
            this.domains.Name = "domains";
            this.domains.Size = new System.Drawing.Size(264, 20);
            this.domains.TabIndex = 11;
            this.domains.Text = "umbrella.tv,umbrella.hu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Domains:";
            // 
            // aliases
            // 
            this.aliases.Location = new System.Drawing.Point(83, 111);
            this.aliases.Name = "aliases";
            this.aliases.Size = new System.Drawing.Size(264, 20);
            this.aliases.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "OtherAlias:";
            // 
            // emailaddress
            // 
            this.emailaddress.Location = new System.Drawing.Point(83, 85);
            this.emailaddress.Name = "emailaddress";
            this.emailaddress.Size = new System.Drawing.Size(264, 20);
            this.emailaddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "EmailAddress:";
            // 
            // objclass
            // 
            this.objclass.AutoSize = true;
            this.objclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.objclass.Location = new System.Drawing.Point(9, 7);
            this.objclass.Name = "objclass";
            this.objclass.Size = new System.Drawing.Size(0, 20);
            this.objclass.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // givenname
            // 
            this.givenname.Location = new System.Drawing.Point(83, 59);
            this.givenname.Name = "givenname";
            this.givenname.Size = new System.Drawing.Size(264, 20);
            this.givenname.TabIndex = 3;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(83, 33);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(264, 20);
            this.surname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Keresztnév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vezetéknév:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "AD email cím alias készítő kéziszerszám";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dcname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox givenname;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label objclass;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox domains;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aliases;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailaddress;
        private System.Windows.Forms.Label label4;
    }
}

