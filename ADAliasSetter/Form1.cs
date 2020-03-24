using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DirectoryEntry rootEntry;
        DirectoryEntry currentEntry;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rootEntry = new DirectoryEntry("LDAP://" + dcname.Text);
            loadEntry(null, null);
        }



        public void loadEntry( DirectoryEntry parent, TreeNode parentNode )
        {
            if ( parent == null )
            {
                parent = this.rootEntry;
            }
            if ( parentNode == null )
            {
                treeView1.Nodes.Clear();
            }
            else
            {
                parentNode.Nodes.Clear();
            }
            foreach (DirectoryEntry i in parent.Children)
            {
                TreeNode node;
                if (parentNode == null)
                {
                    node = treeView1.Nodes.Add(i.Name);
                }
                else
                {
                    node = parentNode.Nodes.Add(i.Name);
                }
                node.Tag = i;
                node.Nodes.Add("");
            }
            if (parentNode != null)
            {
                parentNode.Expand();
            }
        }

        public void loadEmailAddresses( DirectoryEntry entry )
        {
            this.currentEntry = entry;
            listView1.Items.Clear();
            surname.Text = "";
            givenname.Text = "";
            foreach ( PropertyValueCollection p in entry.Properties )
            {
                if (p.PropertyName == "objectClass") { objclass.Text = p[1].ToString(); }
                if ( p.PropertyName == "sn" ) { surname.Text = p.Value.ToString(); }
                if (p.PropertyName == "givenName") { givenname.Text = p.Value.ToString(); }
                if (p.PropertyName == "userPrincipalName") { emailaddress.Text = p.Value.ToString(); }
                if (p.PropertyName == "proxyAddresses") {
                    foreach (Object v in p)
                    {
                        String email = v.ToString();
                        Regex r = new Regex( @"^(.*?\:)(.*)$");
                        Match gs = r.Match(email);
                        ListViewItem item = listView1.Items.Add( gs.Groups[2].Value );
                        if (gs.Groups[1].Value == "SMTP:" )
                        {
                            item.Checked = true;
                        }
                    }
                }
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            loadEmailAddresses((DirectoryEntry)e.Node.Tag);
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            loadEntry((DirectoryEntry)e.Node.Tag, e.Node);
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }

        public String delocalise( String s )
        {
            s = s.Trim();
            s = s.ToLower();
            s = s.Replace('á', 'a').Replace('é', 'e').Replace('í', 'i').Replace('ó', 'o').Replace('ö', 'o').Replace('ő', 'o').Replace('ú', 'u').Replace('ü', 'u').Replace('ű', 'u');
            s = s.Replace('Á', 'a').Replace('É', 'e').Replace('Í', 'i').Replace('Ó', 'o').Replace('Ö', 'o').Replace('Ő', 'o').Replace('Ú', 'u').Replace('Ü', 'u').Replace('Ű', 'u');
            return s;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(",");
            List<String> doms = new List<String>( r.Split(domains.Text) );
            List<String> als = new List<String>( r.Split(aliases.Text) );
            listView1.Items.Clear();
            String surname = delocalise( this.surname.Text );
            String givenname = delocalise( this.givenname.Text );
            if (givenname != "" && surname != "")
            {
                foreach (String d in doms)
                {
                    listView1.Items.Add(givenname + "." + surname + "@" + d);
                    listView1.Items.Add(surname + "." + givenname + "@" + d);
                    foreach (String a in als)
                    {
                        String at = a.Trim();
                        if (at != "")
                        {
                            listView1.Items.Add(at + "@" + d);
                        }
                    }
                }
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                foreach (ListViewItem li in listView1.Items)
                {
                    if (e.Item != li)
                    {
                        li.Checked = false;
                    }
                }
            }
        }

        private void treeView1_CursorChanged(object sender, EventArgs e)
        {
            loadEmailAddresses((DirectoryEntry)treeView1.Cursor.Tag);
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyValue == 46 )
            {
                foreach (ListViewItem li in listView1.SelectedItems)
                {
                    listView1.Items.Remove(li);
                }
            }
            if (e.KeyValue == 45)
            {
                listView1.Items.Add("");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( this.currentEntry != null )
            {
                PropertyValueCollection addresses = null;
                if ( this.currentEntry.Properties.Contains("userPrincipalName") )
                {
                    this.currentEntry.Properties["userPrincipalName"].Add(emailaddress.Text);
                }
                else
                {
                    this.currentEntry.Properties["userPrincipalName"][0] = emailaddress.Text;
                }
                this.currentEntry.Properties["proxyAddresses"].Clear();
                foreach (ListViewItem li in listView1.Items)
                {
                    String s = "";
                    s = (li.Checked ? "SMTP:" : "smtp:") + li.Text;
                    this.currentEntry.Properties["proxyAddresses"].Add(s);
                }
                this.currentEntry.CommitChanges();
                MessageBox.Show("OK");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
