using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gatcha
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "장비 등록";
            AllEquip.load();
            AllStigma.load();
            //초기화
            comboBox_pickUpEquip.Items.Clear();
            comboBox_pickUpStigma.Items.Clear();
            comboBox_equip1.Items.Clear();
            comboBox_equip2.Items.Clear();
            comboBox_equip3.Items.Clear();
            comboBox_equip4.Items.Clear();
            comboBox_equip5.Items.Clear();
            comboBox_equip6.Items.Clear();
            comboBox_stigma1.Items.Clear();
            comboBox_stigma2.Items.Clear();
            comboBox_stigma3.Items.Clear();
            comboBox_stigma4.Items.Clear();
            //드롭다운에 아이템 셋팅
            for (int i = 0; i < AllEquip.allEquip.Count(); i++)
            {
                comboBox_pickUpEquip.Items.Add(AllEquip.allEquip[i].name);
                comboBox_equip1.Items.Add(AllEquip.allEquip[i].name);
                comboBox_equip2.Items.Add(AllEquip.allEquip[i].name);
                comboBox_equip3.Items.Add(AllEquip.allEquip[i].name);
                comboBox_equip4.Items.Add(AllEquip.allEquip[i].name);
                comboBox_equip5.Items.Add(AllEquip.allEquip[i].name);
                comboBox_equip6.Items.Add(AllEquip.allEquip[i].name);
            }
            for (int i = 0; i < AllStigma.allStigma.Count(); i++)
            {
                comboBox_pickUpStigma.Items.Add(AllStigma.allStigma[i].name);
                comboBox_stigma1.Items.Add(AllStigma.allStigma[i].name);
                comboBox_stigma2.Items.Add(AllStigma.allStigma[i].name);
                comboBox_stigma3.Items.Add(AllStigma.allStigma[i].name);
                comboBox_stigma4.Items.Add(AllStigma.allStigma[i].name);
            }
        }
    }
}
