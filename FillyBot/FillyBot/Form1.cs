using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FillyBot.Controller;

namespace FillyBot
{
    public partial class frmMain : Form
    {
        const string background_color = "#1F1F1F";
        const string menubar_color = "#0A0A0A";
        const string footer_color = "#141414";
        const string content_color = "#141414";
        const int createTaskMenuIndex = 0;
        const int viewTaskMenuIndex = 1;
        const int profileMenuIndex = 2;
        const int proxiesMenuIndex = 3;
        List<Panel> menuItems = new List<Panel>();
        List<UserControl> contentItems = new List<UserControl>();
        DbController DataAccess = new DbController();

        public frmMain()
        {
            InitializeComponent();
            pnlMain.BackColor = ColorTranslator.FromHtml(background_color);
            pnlMenu.BackColor = ColorTranslator.FromHtml(menubar_color);
            pnlFooter.BackColor = ColorTranslator.FromHtml(footer_color);
            panel1.BackColor = ColorTranslator.FromHtml(content_color);
            menuItems.Add(pnlCreate);
            menuItems.Add(pnlView);
            menuItems.Add(pnlProfile);
            menuItems.Add(pnlProxies);
            contentItems.Add(createTaskControl1);
            contentItems.Add(viewTasksControl1);
            contentItems.Add(profileControl1);
            contentItems.Add(proxyControl1);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnCreateTask.PerformClick();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            setActiveMenuItem(createTaskMenuIndex);
        }

        private void setActiveMenuItem(int index)
        {
            for( int i=0; i<menuItems.Count;i++)
            {
                menuItems[i].Visible = false;
                contentItems[i].Visible = false;
                if (index == i)
                {
                    menuItems[i].Visible = true;
                    contentItems[i].Size = new System.Drawing.Size(750, 350);
                    contentItems[i].Location = new Point(18, 16);
                    contentItems[i].Visible = true;
                }
            }
        }

        private void btnViewTask_Click(object sender, EventArgs e)
        {
            setActiveMenuItem(viewTaskMenuIndex);
        }

        private void btnProfiles_Click(object sender, EventArgs e)
        {
            setActiveMenuItem(profileMenuIndex);
        }

        private void btnProxies_Click(object sender, EventArgs e)
        {
            setActiveMenuItem(proxiesMenuIndex);
        }

        private void btnNewStore_Click(object sender, EventArgs e)
        {
            frmNewStore store = new frmNewStore();
            store.ShowDialog();
        }
    }
}
