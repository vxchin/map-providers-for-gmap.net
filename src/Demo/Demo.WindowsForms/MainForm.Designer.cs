
namespace GMap.NET.MapProviders.Tianditu.Demo.WindowsForms
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.lbMapProviders = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainMap
            // 
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemory = 5;
            this.MainMap.Location = new System.Drawing.Point(0, 0);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 24;
            this.MainMap.MinZoom = 0;
            this.MainMap.MouseWheelZoomEnabled = true;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(1024, 641);
            this.MainMap.TabIndex = 0;
            this.MainMap.Zoom = 10D;
            this.MainMap.Load += new System.EventHandler(this.MainMap_Load);
            // 
            // lbMapProviders
            // 
            this.lbMapProviders.FormattingEnabled = true;
            this.lbMapProviders.ItemHeight = 12;
            this.lbMapProviders.Location = new System.Drawing.Point(12, 33);
            this.lbMapProviders.Name = "lbMapProviders";
            this.lbMapProviders.Size = new System.Drawing.Size(180, 100);
            this.lbMapProviders.TabIndex = 2;
            this.lbMapProviders.SelectedIndexChanged += new System.EventHandler(this.lbMapProviders_SelectedIndexChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 620);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 12);
            this.lblInfo.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 641);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lbMapProviders);
            this.Controls.Add(this.MainMap);
            this.Name = "MainForm";
            this.Text = "GMap.NET Providers Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NET.WindowsForms.GMapControl MainMap;
        private System.Windows.Forms.ListBox lbMapProviders;
        private System.Windows.Forms.Label lblInfo;
    }
}

