using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gatcha
{
    public partial class Form1 : Form
    {
        const int COUNTPERMONEY = 280;
        int count = 0;
        int itemCount = 0;
        List<Item> drawList = new List<Item>();
        public Form1()
        {
            InitializeComponent();
            ItemManager.load();
            this.Text = "뽑기";
            label_pickUp_equip.Text = ItemManager.pickUpEquip.name;
            label_pickUp_stigma.Text = ItemManager.pickUpStigma[0].name.Split(new char[] { '-' })[0];
            label_equip_1.Text = ItemManager.equip[0].name;
            label_equip_2.Text = ItemManager.equip[1].name;
            label_equip_3.Text = ItemManager.equip[2].name;
            label_equip_4.Text = ItemManager.equip[3].name;
            label_equip_5.Text = ItemManager.equip[4].name;
            label_equip_6.Text = ItemManager.equip[5].name;
            label_stigma_1.Text = ItemManager.stigma[0].name.Split(new char[] { '-' })[0];
            label_stigma_2.Text = ItemManager.stigma[3].name.Split(new char[] { '-' })[0];
            label_stigma_3.Text = ItemManager.stigma[6].name.Split(new char[] { '-' })[0];
            label_stigma_4.Text = ItemManager.stigma[9].name.Split(new char[] { '-' })[0];
            label_count.Text = count.ToString();
            label_count_money.Text = (count * COUNTPERMONEY).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            itemCount++;
            Item drawedItem = Draw.DrawOne(itemCount);
            if (itemCount == 10)
            {
                itemCount = 0;
            }
            drawList.Add(drawedItem);
            label_count.Text = "";
            label_count.Text = count.ToString();
            label_count_money.Text = "";
            label_count_money.Text = (count * COUNTPERMONEY).ToString();
            dataGridView_result.DataSource = null;
            dataGridView_result.DataSource = drawList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count += 10;
            for (int i = 0; i < 10; i++)
            {
                itemCount++;
                Item drawedItem = Draw.DrawOne(count);
                if (itemCount == 10)
                {
                    itemCount = 0;
                }
                drawList.Add(drawedItem);
                Thread.Sleep(10);
            }
            label_count.Text = "";
            label_count.Text = count.ToString();
            label_count_money.Text = "";
            label_count_money.Text = (count * COUNTPERMONEY).ToString();
            dataGridView_result.DataSource = null;
            dataGridView_result.DataSource = drawList;

        }

        private void 장비등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
