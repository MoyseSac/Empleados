using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form1 : Form
    {
        List<empleado> empleados = new List <empleado>();
        List<Asistencia> asistencias = new List<Asistencia>();
        List<Reportes> reporte = new List<Reportes>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        public void cargar_Empleado() {

            string fileName = "empleadoslist.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() != -1)
            {

                empleado empleado = new empleado();
                empleado.NoEmpleado = Convert.ToInt32(reader.ReadLine());
                empleado.Nombre = reader.ReadLine();
                empleado.SueldoHora = Convert.ToDecimal(reader.ReadLine());


                empleados.Add(empleado);

            }

            reader.Close();


        }

        public void cargar_Asistencia()
        {

            string fileName ="Asistencia.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)

            {
                //leer los datos de un empleado
                Asistencia asistencia1 = new Asistencia();
                asistencia1.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                asistencia1.HorasMes = Convert.ToInt16(reader.ReadLine());
                asistencia1.Mes = Convert.ToInt16(reader.ReadLine());

                //guardar el empleado a la lista de empleados
                asistencias.Add(asistencia1);
            }
            reader.Close();
        }

        public void Mostrar_Asistencia()
        {
            dataGridViewAsistencia.DataSource = null;
            dataGridViewAsistencia.DataSource = asistencias;
            dataGridViewAsistencia.Refresh();
        }
        public void Mostrar_Empleados()
        {
            dataGridViewEmpleado.DataSource = null;
            dataGridViewEmpleado.DataSource = empleados;
            dataGridViewEmpleado.Refresh();
        }
        private void buttonleer_Click(object sender, EventArgs e)
        {
            cargar_Empleado();
            Mostrar_Empleados();
            cargar_Asistencia();
            Mostrar_Asistencia();

        }




        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Sueldo_Click(object sender, EventArgs e)
        {
            List<Reportes> reportes = new List<Reportes>();


            foreach (empleado Empleado in empleados)
            {
                int noEmpleado = Empleado.NoEmpleado;

                foreach (Asistencia asistencia in asistencias)
                {
                    if (Empleado.NoEmpleado == asistencia.NoEmpleado)
                    {

                        Reportes reporte = new Reportes();
                        reporte.NombrEmpleado = Empleado.Nombre;
                        reporte.Mes = asistencia.Mes;
                        reporte.SueldoMensual = Empleado.SueldoHora * asistencia.HorasMes;

                        reportes.Add(reporte);
                    }
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reportes;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargar_Asistencia();
            cargar_Empleado();
            Mostrar_Empleados();
            Mostrar_Asistencia();
        }
    }

}

