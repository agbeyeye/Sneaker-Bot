using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FillyBot.Controller;
using FillyBot.Models;
using IronPython.Hosting;
using System.IO;

namespace FillyBot.UIControls
{
    public partial class ViewTasksControl : UserControl
    {
        List<Models.Task> tasks;
        DbController DbAccess;
        string task_initial_status = "Not running";
        public ViewTasksControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DbAccess = new DbController();
            tasks = new List<Models.Task>();
            dataGridView1.Rows.Clear();
            tasks = DbAccess.GetTasks();
            dataGridView1.Rows.Add(tasks.Count);
            for(int i=0;i<tasks.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = tasks[i].store.name;
                dataGridView1.Rows[i].Cells[1].Value = tasks[i].product;
                dataGridView1.Rows[i].Cells[2].Value = tasks[i].url;
                dataGridView1.Rows[i].Cells[3].Value = tasks[i].size;
                dataGridView1.Rows[i].Cells[4].Value = tasks[i].quantity.ToString();
                dataGridView1.Rows[i].Cells[5].Value = task_initial_status;
                dataGridView1.Rows[i].Cells[6].Value = tasks[i].id;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DbAccess = new DbController();

            DialogResult result = MessageBox.Show("Delete this task permanently?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DbAccess.RemoveTask(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var engine = Python.CreateEngine();
            var script = "myscript.py";
            var source = engine.CreateScriptSourceFromFile(script);
            //engine.GetSysModule().SetVariable("argv", argv);
            var eIO = engine.Runtime.IO;
            var error = new MemoryStream();
            eIO.SetErrorOutput(error, Encoding.Default);
            var results = new MemoryStream();
            eIO.SetOutput(results, Encoding.Default);

            var scope = engine.CreateScope();
            source.Execute(scope);
            string str(byte[] x) => Encoding.Default.GetString(x);
            MessageBox.Show(str(error.ToArray())+" " +str(results.ToArray()));


        }
    }
}
