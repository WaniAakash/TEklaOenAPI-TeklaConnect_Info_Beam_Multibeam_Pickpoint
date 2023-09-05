using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TSG = Tekla.Structures.Geometry3d; // TSG means alias = urf
using TSM = Tekla.Structures.Model;
using Tekla.Structures.Model.Geometry;
using Tekla.Structures.Model.Operations;
using TkUI = Tekla.Structures.Model.UI;
using Tekla.Structures.Drawing;
using Tekla.Structures.Model;

namespace TeklaConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Model tkModel;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            // TriangleFunctions TF = new TriangleFunctions();
            tkModel = new Model();

            bool status = tkModel.GetConnectionStatus();

            if (status == true)
                lblInfo.Text = "Connected...!";

            if (status == false)
                lblInfo.Text = "Not Connected...!";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ModelInfo tkInfo = tkModel.GetInfo();
            string sName = tkInfo.ModelName + "\nand Path is " + tkInfo.ModelPath;
            lblInfo.Text = sName;
        }

        private void btnBeam_Click(object sender, EventArgs e)
        {
            TSG.Point P1 = new TSG.Point(0, 0);
            TSG.Point P2 = new TSG.Point(3000, 0);

            // TriangleFunctions TF = new TriangleFunctions(); // default constructor
            // TriangleFunctions TF = new TriangleFunctions(12, 5); // overloaded constructor

            //Beam tkBeam = new Beam(P1, P2); // call or invoke overloaded constructor

            Beam tkBeam = new Beam(); // call or invoke defualt constructor
            tkBeam.StartPoint = P1;
            tkBeam.EndPoint = P2;

            tkBeam.Material.MaterialString = "Steel_Undefined";
            tkBeam.Profile.ProfileString = "WI300-15-20 * 300";
            tkBeam.Class = "3";

            tkBeam.Insert();

            tkModel.CommitChanges();
        }

        private void btnBeamPP_Click(object sender, EventArgs e)
        {
            TkUI.Picker tkPicker = new TkUI.Picker();

            TSG.Point P1 = tkPicker.PickPoint("Pick Start Point.");
            TSG.Point P2 = tkPicker.PickPoint("Pick End Point.");

            Beam tkBeam = new Beam(); // call or invoke defualt constructor
            tkBeam.StartPoint = P1;
            tkBeam.EndPoint = P2;

            tkBeam.Material.MaterialString = "Steel_Undefined";
            tkBeam.Profile.ProfileString = "WI300-15-20 * 300";
            tkBeam.Class = "3";

            tkBeam.Insert();

            tkModel.CommitChanges();
        }

        private void btnMBeam_Click(object sender, EventArgs e)
        {
            TSG.Point P1;
            TSG.Point P2;

            double dGap = 0;
            int n = 10;

            Beam tkBeam;

            for (int i = 1; i <= n; i = i + 1)
            {
                P1 = new TSG.Point(0, dGap);
                P2 = new TSG.Point(3000, dGap);
            
                tkBeam = new Beam();
                tkBeam.StartPoint = P1;
                tkBeam.EndPoint = P2;

                tkBeam.Material.MaterialString = "Steel_Undefined";
                tkBeam.Profile.ProfileString = "WI300-15-20 * 300";
                tkBeam.Class = "3";
                
                tkBeam.Insert();
                tkModel.CommitChanges();

                dGap = dGap + 1000;
            }
        }
    }
}
