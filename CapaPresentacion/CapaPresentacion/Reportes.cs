using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Reportes : Form
    {
        bool r4 = false;
        bool r5 = false;
        public Reportes()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            fechas();
            panel1.Visible = true;
            Codigo_Reportes rep = new Codigo_Reportes();
            ArrayList rep1 = rep.reporte1();
            this.chart1.Series.Clear();
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("Reporte 1  \n Reservaciones por hotel");
            Series Grafico = this.chart1.Series.Add("Reporte 1  \n Reservaciones por hotel");
            Grafico.ChartType = SeriesChartType.Pie;
            for (int i = 0; i < rep1.Count;i+=2)
            {
                Grafico.Points.AddXY(rep1[i], rep1[i+1]);
            }
            chart1.Series["Reporte 1  \n Reservaciones por hotel"].IsValueShownAsLabel = true;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            fechas();
            panel1.Visible = true;
            Codigo_Reportes rep = new Codigo_Reportes();
            ArrayList rep2 = rep.reporte2();
            this.chart1.Series.Clear();
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("Reporte 2  \n Personas por hotel");
            Series Grafico = this.chart1.Series.Add("Reporte 2  \n Personas por hotel");
            Grafico.ChartType = SeriesChartType.Pie;
            for (int i = 0; i < rep2.Count; i += 2)
            {
                Grafico.Points.AddXY(rep2[i], rep2[i + 1]);
            }
            chart1.Series["Reporte 2  \n Personas por hotel"].IsValueShownAsLabel = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            fechas();
            panel1.Visible = true;
            Codigo_Reportes rep = new Codigo_Reportes();
            ArrayList rep3 = rep.reporte3();
            this.chart1.Series.Clear();
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("Reporte 3  \n Porcentaje de visitas por pais");
            Series Grafico = this.chart1.Series.Add("Reporte 3  \n Porcentaje de visitas por pais");
            Grafico.ChartType = SeriesChartType.Pie;
            for (int i = 0; i < rep3.Count; i += 2)
            {
                Grafico.Points.AddXY(rep3[i], rep3[i + 1]);
            }
            chart1.Series["Reporte 3  \n Porcentaje de visitas por pais"].IsValueShownAsLabel = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            r4 = true;
            r5 = false;
            panel1.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            Dtp1.Visible = true;
            Dtp1.Value = DateTime.Now.Date;
            Dtp2.Value = DateTime.Now.Date;
            Dtp2.Visible = true;
            btnrep.Visible = true;
            Dtp1.Format = DateTimePickerFormat.Custom;
            Dtp1.CustomFormat = "dd/MM/yyyy";
            Dtp2.Format = DateTimePickerFormat.Custom;
            Dtp2.CustomFormat = "dd/MM/yyyy";
        }

        private void btnrep_Click(object sender, EventArgs e)
        {

            if (r4 == true & r5 == false)
            {
                if (Dtp2.Value.Date < Dtp1.Value.Date)
                {
                    MessageBox.Show("La fecha final no puede ser menor a la fecha de inicio");
                }
                else
                {
                    try
                    {

                        panel1.Visible = true;
                        Codigo_Reportes rep = new Codigo_Reportes();
                        ArrayList rep4 = rep.reporte4(Convert.ToString(Dtp1.Value.Date), Convert.ToString(Dtp2.Value.Date));
                        this.chart1.Series.Clear();
                        this.chart1.Titles.Clear();
                        this.chart1.Titles.Add("Reporte 4  \n Visitas Adultos por fecha");
                        Series Grafico = this.chart1.Series.Add("Reporte 4  \n Visitas Adultos por fecha");
                        Grafico.ChartType = SeriesChartType.Pie;
                        Grafico.Points.AddXY("Adultos que han viajado en el rango de fecha", rep4[0]);
                        Grafico.Points.AddXY("Total de adultos que han viajado", rep4[1]);
                        chart1.Series["Reporte 4  \n Visitas Adultos por fecha"].IsValueShownAsLabel = true;
                        r4 = false;
                        fechas();
                    }
                    catch
                    {

                    }
                }
            }
            if (r4 == false & r5 == true)
            {
                if (Dtp2.Value.Date < Dtp1.Value.Date)
                {
                    MessageBox.Show("La fecha final no puede ser menor a la fecha de inicio");
                }
                else
                {
                    try
                    {
                        panel1.Visible = true;
                        Codigo_Reportes rep = new Codigo_Reportes();
                        ArrayList rep5 = rep.reporte5(Convert.ToString(Dtp1.Value.Date), Convert.ToString(Dtp2.Value.Date));
                        this.chart1.Series.Clear();
                        this.chart1.Titles.Clear();
                        this.chart1.Titles.Add("Reporte 5  \n Visitas Niños por fecha");
                        Series Grafico = this.chart1.Series.Add("Reporte 5  \n Visitas Niños por fecha");
                        Grafico.ChartType = SeriesChartType.Pie;
                        Grafico.Points.AddXY("Niños que han viajado en el rango de fecha", rep5[0]);
                        Grafico.Points.AddXY("Total de Niños que han viajado", rep5[1]);
                        chart1.Series["Reporte 5  \n Visitas Niños por fecha"].IsValueShownAsLabel = true;
                        r5 = false;
                        fechas();
                    }
                    catch
                    {

                    }
                }
            }
        }
        public void fechas()
        {
            label1.Visible = false;
            label2.Visible = false;
            Dtp1.Visible = false;
            Dtp2.Visible = false;
            btnrep.Visible = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            r4 = false;
            r5 = true;
            panel1.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            Dtp1.Visible = true;
            Dtp1.Value = DateTime.Now.Date;
            Dtp2.Value = DateTime.Now.Date;
            Dtp2.Visible = true;
            btnrep.Visible = true;
            Dtp1.Format = DateTimePickerFormat.Custom;
            Dtp1.CustomFormat = "dd/MM/yyyy";
            Dtp2.Format = DateTimePickerFormat.Custom;
            Dtp2.CustomFormat = "dd/MM/yyyy";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            fechas();
            panel1.Visible = true;
            Codigo_Reportes rep = new Codigo_Reportes();
            ArrayList rep6 = rep.reporte6();
            this.chart1.Series.Clear();
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("Reporte 6  \n Marcas de vehiculos mas rentadas");
            Series Grafico = this.chart1.Series.Add("Reporte 6  \n Marcas de vehiculos mas rentadas");
            Grafico.ChartType = SeriesChartType.Pie;
            for (int i = 0; i < rep6.Count; i += 2)
            {
                Grafico.Points.AddXY(rep6[i], rep6[i + 1]);
            }
            chart1.Series["Reporte 6  \n Marcas de vehiculos mas rentadas"].IsValueShownAsLabel = true;

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            fechas();
            panel1.Visible = true;
            Codigo_Reportes rep = new Codigo_Reportes();
            ArrayList rep7 = rep.reporte7();
            this.chart1.Series.Clear();
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("Reporte 7  \n Cantidad de veces en que se ha echo escalas por pais");
            Series Grafico = this.chart1.Series.Add("Reporte 7  \n Cantidad de veces en que se ha echo escalas por pais");
            Grafico.ChartType = SeriesChartType.Pie;
            for (int i = 0; i < rep7.Count; i += 2)
            {
                Grafico.Points.AddXY(rep7[i], rep7[i + 1]);
            }
            chart1.Series["Reporte 7  \n Cantidad de veces en que se ha echo escalas por pais"].IsValueShownAsLabel = true;
        }
    }
}
