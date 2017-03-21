using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using ConflictGraph.Models;
using GraphX.Controls;
using GraphX.Controls.Models;
using GraphX.PCL.Common.Enums;
using GraphX.PCL.Logic.Algorithms.OverlapRemoval;
using GraphX.PCL.Logic.Models;
using QuickGraph;
using MessageBox = System.Windows.MessageBox;

namespace ConflictGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private ZoomControl _zoomctrl;
        private GraphAreaExample _gArea;

        private UIElement GenerateWpfVisuals()
        {
            _zoomctrl = new ZoomControl();
            ZoomControl.SetViewFinderVisibility(_zoomctrl, Visibility.Visible);
            var logic = new GXLogicCore<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>>();
            _gArea = new GraphAreaExample
            {
               // EnableWinFormsHostingMode = false,
                LogicCore = logic,
                EdgeLabelFactory = new DefaultEdgelabelFactory()
            };
            _gArea.ShowAllEdgesLabels(false);
            
            logic.EnableParallelEdges = true;
            
            logic.Graph = Process.GenerateGraph();
            logic.DefaultLayoutAlgorithm = LayoutAlgorithmTypeEnum.KK;
            logic.DefaultLayoutAlgorithmParams = logic.AlgorithmFactory.CreateLayoutParameters(LayoutAlgorithmTypeEnum.LinLog);
            //((LinLogLayoutParameters)logic.DefaultLayoutAlgorithmParams). = 100;
            logic.DefaultOverlapRemovalAlgorithm = OverlapRemovalAlgorithmTypeEnum.FSA;
            logic.DefaultOverlapRemovalAlgorithmParams = logic.AlgorithmFactory.CreateOverlapRemovalParameters(OverlapRemovalAlgorithmTypeEnum.FSA);
            ((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).HorizontalGap = 50;
            ((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).VerticalGap = 50;
            logic.DefaultEdgeRoutingAlgorithm = EdgeRoutingAlgorithmTypeEnum.None;
            logic.AsyncAlgorithmCompute = false;
            _zoomctrl.Content = _gArea;
            _gArea.RelayoutFinished += gArea_RelayoutFinished;


            var myResourceDictionary = new ResourceDictionary { Source = new Uri("Templates\\template.xaml", UriKind.Relative) };
            _zoomctrl.Resources.MergedDictionaries.Add(myResourceDictionary);

            return _zoomctrl;
        }

        void gArea_RelayoutFinished(object sender, EventArgs e)
        {
            _zoomctrl.ZoomToFill();
        }

        

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var input = txtInput.Text;
            if (String.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập vào chuỗi lập lịch!", "Cảnh báo", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            else
            {
                Process.Caculate(txtInput.Text);
                elementHost1.Child = GenerateWpfVisuals();
                _gArea.GenerateGraph(true);
                _gArea.SetVerticesDrag(true, true);
                _zoomctrl.ZoomToFill();
                txtSSResult.Text = Process.a;
                if (Process.result == true)
                {
                    txtResult.Text = "Is Conflict Serializable";
                    txtSSResult.Text = Process.serialSchedule.ToUpper();
                    DrawDTGV(txtInput.Text, txtSSResult.Text);
                }
                else
                {
                    txtResult.Text = "Is not Conflict Serializable";
                    DrawNullDTGV();
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            _gArea.RelayoutGraph();
        }

        private void DrawNullDTGV()
        {
            dtgvSchedule.DataSource = null;
            dtgvSerialSchedule.DataSource = null;
        }




        private void DrawDTGV(string strInputSchedule, string strSerialSchedule)
        {
            StringScheduleInput strOutputSchedule = Process.StringSchedule(strInputSchedule);
            StringScheduleInput strOutSerialSchedule = Process.StringSchedule(strSerialSchedule);
            DataTable table = new DataTable();
            foreach (var step in strOutputSchedule.Schedule.Steps)
            {
                // dtgvSchedule.Columns.Add(step.Transaction.ToString(), step.Transaction.ToString());
                if (!table.Columns.Contains(step.Transaction.ToString()))
                    table.Columns.Add(step.Transaction.ToString());
            }
            foreach (var step in strOutputSchedule.Schedule.Steps)
            {
                DataRow dr = table.NewRow();
                dr[step.Transaction.ToString()] = step.Operation.ToString().Remove(1) +" (" + step.Target.ToString() + ")";
                table.Rows.Add(dr);
            }
            dtgvSchedule.DataSource = table;


            List<int> col = new List<int>();
            DataTable table2 = new DataTable();
            foreach (var step in strOutSerialSchedule.Schedule.Steps)
            {
                // dtgvSchedule.Columns.Add(step.Transaction.ToString(), step.Transaction.ToString());
                if (!col.Contains(int.Parse(step.Transaction.ToString())))
                    col.Add(int.Parse(step.Transaction.ToString()));
            }
            col.Sort();
            foreach (var step in col)
            {
                // dtgvSchedule.Columns.Add(step.Transaction.ToString(), step.Transaction.ToString());
                    table2.Columns.Add(step.ToString());
            }
            foreach (var step in strOutSerialSchedule.Schedule.Steps)
            {
                DataRow dr = table2.NewRow();
                dr[step.Transaction.ToString()] = step.Operation.ToString().Remove(1) + " (" + step.Target.ToString() + ")";
                table2.Rows.Add(dr);
            }
            dtgvSerialSchedule.DataSource = table2;

        }

       

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            var strMess = "Vui lòng nhập Schedule input theo định dạng: [Operation][Transaction]([Target]),\n\n" +
                          "Ví dụ: W1(A), R2(A), W1(B).....\n\n" +
                          "Mỗi Step cách nhau 1 dấu ','";

            MessageBox.Show(strMess);
        }
    }
}
