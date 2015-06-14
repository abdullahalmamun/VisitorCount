using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitorCountApp.BLL;
using VisitorCountApp.DAL.Model;

namespace VisitorCountApp.UI
{
    public partial class VisitorEntryUI : Form
    {
        public VisitorEntryUI()
        {
            InitializeComponent();
            GetAllZoneType();
        }
        ZoneManager zoneManager = new ZoneManager();
        VisitorManager visitorManager=new VisitorManager();
        
        

        public void GetAllZoneType() {
           
            int position=30;
            List<Zone> zoneList = zoneManager.GetAllZone();
            foreach (var zone in zoneList) {

                CheckBox aCheckBox = new CheckBox();
                aCheckBox.Text = zone.ZoneType;
                aCheckBox.AutoSize = true;
                aCheckBox.Checked = true;
                aCheckBox.Location = new Point(20, position);
                visitorGroupBox.Controls.Add(aCheckBox);
                aCheckBox.Tag = (Zone)zone;
                position += 20;

            }
        }
       

        public void CheckedZone()
        {
            foreach (Control can in visitorGroupBox.Controls) {
                if (can is CheckBox)
                {

                    CheckBox temp = (CheckBox)can;
                    if (temp.Checked)
                    {
                        
                        Visitor aVisitor = new Visitor();
                        aVisitor.Name = nameTextBox.Text;
                        aVisitor.Email = emailTextBox.Text;
                        aVisitor.ContactNumber = contactNumberTextBox.Text;
                        Zone selectedZone = (Zone)temp.Tag;
                        Zone aZone = new Zone();
                        aZone.Id = selectedZone.Id;
                        aVisitor.AZon = aZone;
                        visitorManager.SaveVisitor(aVisitor);

                        zoneManager.UpdateTotalVisitors(aZone.Id);
                    }
                }
                }
                
 
            }
        
        private void visitorEntrySaveButton_Click(object sender, EventArgs e)
        {
            CheckedZone();

            MessageBox.Show("Visitor Saved Successfully!");
        }
    }
}
