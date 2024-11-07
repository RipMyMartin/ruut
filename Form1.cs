using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tringle
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            components = new System.ComponentModel.Container();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 450);
            Text = "Minu Form";

            DisplayTriangleInfo();
            Side();
        }

        private void DisplayTriangleInfo()
        {
            DataGridView dataGridView = new DataGridView
            {
                ColumnCount = 2,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                ColumnHeadersVisible = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,
                ScrollBars = ScrollBars.None,
                BackgroundColor = Color.White
            };

            dataGridView.Size = new Size(400, 250);
            dataGridView.Location = new Point(420, 10);

            dataGridView.Columns[0].Name = "Väli";
            dataGridView.Columns[1].Name = "Väärtus";
            dataGridView.DefaultCellStyle.Padding = new Padding(5);

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.MediumPurple,
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            dataGridView.ColumnHeadersDefaultCellStyle = headerStyle;
            dataGridView.ColumnHeadersHeight = 40;

            dataGridView.Rows.Add("Küljepikkus a", " ");
            dataGridView.Rows.Add("Küljepikkus b", " ");
            dataGridView.Rows.Add("Küljepikkus c", " ");
            dataGridView.Rows.Add("Perimeeter", " ");
            dataGridView.Rows.Add("Pindala", " ");
            dataGridView.Rows.Add("Eksisteerib?", " ");
            dataGridView.Rows.Add("Tüüp", "");

            Controls.Add(dataGridView);
        }

        private void Side()
        {
            Label labelA = new Label
            {
                Text = "Külg A:",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.DarkOrange,
                Location = new Point(10, 270),
                AutoSize = true
            };
            Controls.Add(labelA);

            TextBox textBoxA = new TextBox
            {
                Name = "textBoxA",
                Font = new Font("Arial", 12, FontStyle.Regular),
                Location = new Point(150, 270),
                Size = new Size(100, 30)
            };
            Controls.Add(textBoxA);

            Label labelB = new Label
            {
                Text = "Külg B:",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.DarkOrange,
                Location = new Point(10, 310),
                AutoSize = true
            };
            Controls.Add(labelB);

            TextBox textBoxB = new TextBox
            {
                Name = "textBoxB",
                Font = new Font("Arial", 12, FontStyle.Regular),
                Location = new Point(150, 310),
                Size = new Size(100, 30)
            };
            Controls.Add(textBoxB);

            Label labelC = new Label
            {
                Text = "Külg C:",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.DarkOrange,
                Location = new Point(10, 350),
                AutoSize = true
            };
            Controls.Add(labelC);

            TextBox textBoxC = new TextBox
            {
                Name = "textBoxC",
                Font = new Font("Arial", 12, FontStyle.Regular),
                Location = new Point(150, 350),
                Size = new Size(100, 30)
            };
            Controls.Add(textBoxC);
        }
    }
}
