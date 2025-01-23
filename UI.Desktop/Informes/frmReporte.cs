using Data.Database;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Informes
{
    public partial class frmReporte : Form
    {
        #region /*/*/*   VARIABLES LOCALES   *\*\*\

        InformeAdapter Datos_InformeAdapter = new InformeAdapter();
        List<ReporteCashflow> ListaCashFlow;
        ReporteVentasComisiones VentasComisiones;
        DateTime fechaDesde;
        DateTime fechaHasta;
        string nombreImpresora;
        int linesPerPage = 0;
        int currentLineIndex = 0;
        decimal grandTotal = 0;
        Reportes _ModoForm;
        ComboBox cbxAno = new ComboBox();
        ComboBox cbxMes = new ComboBox();
        private Dictionary<string, int> months;
        #endregion
        public frmReporte(string comanderaReportes, Reportes title)
        {
            InitializeComponent();
            //this.lblTitle.Text = title;
            //this._ModoForm = title;
            this.setModo(title);
            this.nombreImpresora = comanderaReportes;
        }
        private void completaMesAno()
        {
            cbxAno.Items.Clear();
            this.cbxAno.Items.Add("2023");
            this.cbxAno.Items.Add("2024");
            if(DateTime.Now.Year>=2025)
            this.cbxAno.Items.Add("2025");
            if(DateTime.Now.Year>=2026)
            this.cbxAno.Items.Add("2026");

            //this.cbxMes.Items.AddRange(new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre" }) ;
            months = new Dictionary<string, int>
        {
            { "Enero", 1 },
            { "Febrero", 2 },
            { "Marzo", 3 },
            { "Abril", 4 },
            { "Mayo", 5 },
            { "Junio", 6 },
            { "Julio", 7 },
            { "Agosto", 8 },
            { "Septiembre", 9 },
            { "Octubre", 10 },
            { "Noviembre", 11 },
            { "Deciembre", 12 }
        };
            cbxMes.DataSource = new BindingSource(months, null);
            cbxMes.DisplayMember = "Key";
            cbxMes.ValueMember = "Value";
        }
        //private int mesANumber(string mes)
        //{
        //    int mesInt = 1;
        //    switch(mes)
        //    {
        //        case "Enero": 
        //            mesInt = 1;
        //            break;
        //        case "Febrero":
        //            mesInt = 2;
        //            break;
        //        case "Marzo":
        //            mesInt = 3;
        //            break;
        //        case "Abril":
        //            mesInt = 4;
        //            break;
        //        case "Mayo":
        //            mesInt = 5;
        //            break;
        //        case "Junio":
        //            mesInt = 6;
        //            break;
        //        case "Julio":
        //            mesInt = 7;
        //            break;
        //        case "Agosto":
        //            mesInt = 8;
        //            break;
        //        case "Septiembre":
        //            mesInt = 9;
        //            break;
        //        case "Octubre":
        //            mesInt = 10;
        //            break;
        //        case "Noviembre":
        //            mesInt = 11;
        //            break;
        //        case "Diciembre":
        //            mesInt = 12;
        //            break;

        //        default:break;
        //    }
        //    return mesInt;
        //}
        private void setModo(Reportes title)
        {
            switch (title)
            {
                case Reportes.VentasComisiones:
                    this.lblTitle.Text = "Ventas  - Comisiones";
                    groupBox2.Controls.Clear();
                    groupBox1.Controls.Clear();
                    groupBox2.Text = "Año";
                    groupBox1.Text = "Mes";
                    //ComboBox cbxAno = new ComboBox();
                    this.cbxAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                    this.cbxAno.Dock = DockStyle.Fill;
                    this.cbxAno.SelectedIndexChanged += new EventHandler(cbxAno_SelectedIndexChanged);
                    groupBox2.Controls.Add(cbxAno);
                    //ComboBox cbxMes = new ComboBox();
                    this.cbxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                    this.cbxMes.Dock = DockStyle.Fill;
                    groupBox1.Controls.Add(cbxMes);
                    //dtpDesde.Visible = dtpHasta.Visible = false;
                    this.completaMesAno();
                    this._ModoForm = title;
                    break;
                case Reportes.CashFlow:
                    this.lblTitle.Text = "CashFlow";
                    this._ModoForm = title;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (_ModoForm)
            {
                case Reportes.CashFlow:
                    this.GeneraCashFlow();
                    break;
                case Reportes.VentasComisiones:
                    this.GeneraVentasComisiones();
                    break;
            }
        }


        #region VentaComisiones

        private void setFechas(string mes, string ano) {
            fechaDesde = new DateTime(Convert.ToInt32(ano), Convert.ToInt32(mes), 01);
            fechaHasta = fechaDesde.AddMonths(1).AddDays(-1);
        }
        private void GeneraVentasComisiones()
        {
            if (cbxMes.SelectedItem != null && cbxAno.SelectedItem != null)
            {
                this.setFechas(cbxMes.SelectedValue.ToString(), cbxAno.SelectedItem.ToString());
                VentasComisiones = this.Datos_InformeAdapter.getVentaComisiones(fechaDesde,fechaHasta);
                this.PrintVentaComisiones();
            }
        }

        private void PrintVentaComisiones()
        {

            try
            {
                PrintDocument pd = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                this.linesPerPage = (int)(pd.DefaultPageSettings.PrinterSettings.DefaultPageSettings.PrinterResolution.Y) * 10;

                pd.PrintPage += new PrintPageEventHandler(this.pd_PrintVentaComisionesPage);
                pd.PrinterSettings.PrinterName = nombreImpresora;
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pd_PrintVentaComisionesPage(object sender, PrintPageEventArgs ev)
        {
            Font boldFont = new System.Drawing.Font("Calibri", 18, System.Drawing.FontStyle.Bold);
            Font normalFont = new System.Drawing.Font("Calibri", 11, System.Drawing.FontStyle.Regular);
            Font totalFont = new System.Drawing.Font("Calibri", 14, System.Drawing.FontStyle.Bold);

            float topMargin = ev.MarginBounds.Top;
            float leftMargin = ev.MarginBounds.Left;

            Pen linePen = new Pen(Color.Black);
            float height = 0;
            string nombreReporte = "Reporte Venta-Comisiones";
            //string nombreReporte = "Reporte CashFlow";


            //Print Cabecera
            SizeF Cabecera = ev.Graphics.MeasureString(nombreReporte, boldFont);
            ev.Graphics.DrawString(nombreReporte, boldFont, Brushes.Black, 400 - (Cabecera.Width / 2), height, new StringFormat());
            height += 40;
            //Print Line

            ev.Graphics.DrawLine(linePen, 10, height, 800, height);
            height += 5;
            //Print Line
            ev.Graphics.DrawString("Fecha Desde: " + this.fechaDesde.ToString("dd/MM/yyyy"), normalFont, Brushes.Black, 10, height, new StringFormat());
            height += 20;
            ev.Graphics.DrawString("Fecha Hasta: " + this.fechaHasta.ToString("dd/MM/yyyy"), normalFont, Brushes.Black, 10, height, new StringFormat());
            height += 20;
            //Print Line
            ev.Graphics.DrawLine(linePen, 10, height, 800, height);
            height += 5;


            //Printe Table Headings
            ev.Graphics.DrawString("RUBRO", boldFont, Brushes.Black, 10, height, new StringFormat());
            ev.Graphics.DrawString("VENTAS", boldFont, Brushes.Black, 150, height, new StringFormat());
            ev.Graphics.DrawString("COMISION", boldFont, Brushes.Black, 350, height, new StringFormat());
            height += 30;

            ev.Graphics.DrawLine(linePen, 10, height, 800, height);

            height += 15;
                ev.Graphics.DrawString("CARESTINO", normalFont, Brushes.Black, 10, height, new StringFormat());
                ev.Graphics.DrawString(VentasComisiones.MontoCarestino.ToString("c"), normalFont, Brushes.Black, 150, height, new StringFormat());
            ev.Graphics.DrawString(VentasComisiones.ComisionCarestino.ToString("c"), normalFont, Brushes.Black, 350, height, new StringFormat());
            height += 15;
                ev.Graphics.DrawString("INDUMENTARIA", normalFont, Brushes.Black, 10, height, new StringFormat());
                ev.Graphics.DrawString(VentasComisiones.MontoIndumentaria.ToString("c"), normalFont, Brushes.Black, 150, height, new StringFormat());
            ev.Graphics.DrawString(VentasComisiones.ComisionIndumentaria.ToString("c"), normalFont, Brushes.Black, 350, height, new StringFormat());

            //Print Line
            height += 20;
            ev.Graphics.DrawLine(linePen, 10, height, 800, height);
            height += 20;

            ev.Graphics.DrawString("Totales", totalFont, Brushes.Black, 10, height, new StringFormat());
            ev.Graphics.DrawString(VentasComisiones.MontoTotal.ToString("c"), totalFont, Brushes.Black, 150, height, new StringFormat());
            ev.Graphics.DrawString((VentasComisiones.ComisionCarestino+VentasComisiones.ComisionIndumentaria).ToString("c"), totalFont, Brushes.Black, 350, height, new StringFormat());
            height += 25;

            ev.Graphics.DrawString("Emision: " + DateTime.Now.ToString(), normalFont, Brushes.Black, 600, height, new StringFormat());
            //height += 20;

            ev.HasMorePages = false;
        }
        #endregion

        #region CASHFLOW
        private void GeneraCashFlow()
        {
            if (dtpDesde.Value != null && dtpHasta.Value != null && dtpHasta.Value >= dtpDesde.Value)
            {
                fechaDesde = dtpDesde.Value;
                fechaHasta = dtpHasta.Value;
                ListaCashFlow = this.Datos_InformeAdapter.getCashFlow(dtpDesde.Value, dtpHasta.Value);
                this.PrintCashFlow();
            }
        }

        private void PrintCashFlow()
        {

            try
            {
                PrintDocument pd = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                this.linesPerPage = (int)(pd.DefaultPageSettings.PrinterSettings.DefaultPageSettings.PrinterResolution.Y)*10;

                pd.PrintPage += new PrintPageEventHandler(this.pd_PrintCashFlowPage);
                pd.PrinterSettings.PrinterName = nombreImpresora; 
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pd_PrintCashFlowPage(object sender, PrintPageEventArgs ev)
        {
            Font boldFont = new System.Drawing.Font("Calibri", 18, System.Drawing.FontStyle.Bold);
            Font normalFont = new System.Drawing.Font("Calibri", 11, System.Drawing.FontStyle.Regular);
            Font totalFont = new System.Drawing.Font("Calibri", 14, System.Drawing.FontStyle.Bold);

            float topMargin = ev.MarginBounds.Top;
            float leftMargin = ev.MarginBounds.Left;

            Pen linePen = new Pen(Color.Black);
            float height = 0;
            string nombreReporte = "Reporte CashFlow";
            //string nombreReporte = "Reporte CashFlow";


            //Print Cabecera
            SizeF Cabecera = ev.Graphics.MeasureString(nombreReporte, boldFont);
            ev.Graphics.DrawString(nombreReporte, boldFont, Brushes.Black, 138 - (Cabecera.Width / 2), height, new StringFormat());
            height += 40;
            //Print Line
            
            ev.Graphics.DrawLine(linePen,10,height,800,height);
            height += 20;
            //Print Line
            ev.Graphics.DrawString("Fecha Desde: " + this.fechaDesde.ToString("dd/MM/yyyy"), normalFont, Brushes.Black, 10, height, new StringFormat());
            height += 20;
            ev.Graphics.DrawString("Fecha Hasta: " + this.fechaHasta.ToString("dd/MM/yyyy"), normalFont, Brushes.Black, 10, height, new StringFormat());
            height += 20;
            //Print Line
            ev.Graphics.DrawLine(linePen,10,height,800,height);
            height += 20;


            //Printe Table Headings
            ev.Graphics.DrawString("ID", boldFont, Brushes.Black, 10, height, new StringFormat());
            ev.Graphics.DrawString("FECHA", boldFont, Brushes.Black, 100, height, new StringFormat());
            ev.Graphics.DrawString("DESCRIPCION", boldFont, Brushes.Black, 200, height, new StringFormat());
            ev.Graphics.DrawString("TIPO", boldFont, Brushes.Black, 450, height, new StringFormat());
            ev.Graphics.DrawString("SUBCLAS", boldFont, Brushes.Black, 550, height, new StringFormat());
            ev.Graphics.DrawString("MONTO", boldFont, Brushes.Black, 700, height, new StringFormat());
            height += 30;

            ev.Graphics.DrawLine(linePen,10,height,800,height);

            if (grandTotal != 0)
            {
            ev.Graphics.DrawString("Transporte", totalFont, Brushes.Black, 450, height, new StringFormat());
            ev.Graphics.DrawString(grandTotal.ToString("c"), totalFont, Brushes.Black, 650, height, new StringFormat());
            height += 20;
            }
            height += 10;
            //decimal total = 0;
            //Printe Table Rows
            //foreach (var item in ListaCashFlow)
            //{
            //    ev.Graphics.DrawString(item.ID.ToString(), normalFont, Brushes.Black, 10, height, new StringFormat());
            //    ev.Graphics.DrawString(item.FechaMovimiento.ToString("dd/MM/yy"), normalFont, Brushes.Black, 100, height, new StringFormat());
            //    ev.Graphics.DrawString(item.Descripcion, normalFont, Brushes.Black, 200, height, new StringFormat());
            //    ev.Graphics.DrawString(item.TipoMovimiento, normalFont, Brushes.Black, 450, height, new StringFormat());
            //    ev.Graphics.DrawString(item.Subclasificacion, normalFont, Brushes.Black, 550, height, new StringFormat());
            //    ev.Graphics.DrawString(item.Monto.ToString("c"), normalFont, Brushes.Black, 700, height, new StringFormat());
            //    total += item.Monto;
            //    height += 15;
            //    if (height > this.linesPerPage) {
            //        page++;
            //        break; }

            //}
            while (currentLineIndex < ListaCashFlow.Count)
            {
                var item = ListaCashFlow[currentLineIndex];
                ev.Graphics.DrawString(item.ID.ToString(), normalFont, Brushes.Black, 10, height, new StringFormat());
                ev.Graphics.DrawString(item.FechaMovimiento.ToString("dd/MM/yy"), normalFont, Brushes.Black, 100, height, new StringFormat());
                ev.Graphics.DrawString(item.Descripcion, normalFont, Brushes.Black, 200, height, new StringFormat());
                ev.Graphics.DrawString(item.TipoMovimiento, normalFont, Brushes.Black, 450, height, new StringFormat());
                ev.Graphics.DrawString(item.Subclasificacion, normalFont, Brushes.Black, 550, height, new StringFormat());
                if (item.TipoMovimiento == "INGRESO")
                { 
                    ev.Graphics.DrawString(item.Monto.ToString("c"), normalFont, Brushes.Black, 700, height, new StringFormat()); 
                grandTotal += item.Monto;
                }
                else
                { 
                    ev.Graphics.DrawString((-1 * item.Monto).ToString("c"), normalFont, Brushes.Black, 700, height, new StringFormat()); 
                grandTotal -= item.Monto;
                }

                height += 15;
                currentLineIndex++;

                if (height > ev.MarginBounds.Bottom)
                {
                    height += 5;
                    ev.Graphics.DrawString("Subtotal", totalFont, Brushes.Black, 450, height, new StringFormat());
                    ev.Graphics.DrawString(grandTotal.ToString("c"), totalFont, Brushes.Black, 650, height, new StringFormat());
                    ev.HasMorePages = true;
                    return;
                }
            }
            //Print Line
            height += 10;
            ev.Graphics.DrawLine(linePen,10,height,800,height);
            height += 20;

            ev.Graphics.DrawString("Total", totalFont, Brushes.Black, 450, height, new StringFormat());
            ev.Graphics.DrawString(grandTotal.ToString("c"), totalFont, Brushes.Black, 650, height, new StringFormat());
            height += 20;

            ev.Graphics.DrawString("Emision: " + DateTime.Now.ToString(), normalFont, Brushes.Black, 10, height, new StringFormat());
            //height += 20;

            ev.HasMorePages = false;
            currentLineIndex = 0; // Reset for next print job
        }

        #endregion

        private void cbxMes_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbxAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMonths(); 
        }
        private void UpdateMonths()
        {
            int selectedYear = Convert.ToInt32(cbxAno.SelectedItem);
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            var filteredMonths = months;

            if (selectedYear == currentYear)
            {
                filteredMonths = months.Where(m => m.Value <= currentMonth).ToDictionary(m => m.Key, m => m.Value);
            }

            cbxMes.DataSource = new BindingSource(filteredMonths, null);
            cbxMes.DisplayMember = "Key";
            cbxMes.ValueMember = "Value";
        }


    }
}
