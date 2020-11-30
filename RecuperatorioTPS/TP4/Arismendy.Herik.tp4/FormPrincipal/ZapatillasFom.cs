using Arismendy.Herik.tp4;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace FormPrincipal
{
    public partial class ZapatillasFom : Form
    {
        #region ATRIBUTOS 
        protected SqlDataAdapter dataAdapterSneakers;
        protected DataTable dataTableSneakers;

        protected SqlDataAdapter dataAdapterBotines;
        protected DataTable dataTableBotines;

        protected Carrito car;
        protected object[] filas;
        protected float precioAcumulado;
        #endregion

        #region CONSTRUCTORES
        public ZapatillasFom()
        {

            InitializeComponent();
            this.car = new Carrito();
            this.filas = new object[5];

            if (!this.ConfigurarDataAdapter() || !this.ConfigurarDataAdapterBotines())
            {
                MessageBox.Show("ERROR AL CONFIGURAR EL DATADAPTER!!!");
                this.Close();
            }

            this.ConfigurarDataTable();
            
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Arismendy Herik TP4");
            this.Text = "Arismendy_Herik";
        }

       
        #endregion

        #region CONFIGURACION DATAADAPTER
        

        #region SNEAKERS
        private bool ConfigurarDataAdapter()
        {
            bool rta = false;

            try
            {
                SqlConnection stringConection = new SqlConnection(Properties.Settings.Default.ConexionBD);

                this.dataAdapterSneakers = new SqlDataAdapter();

                this.dataAdapterSneakers.SelectCommand = new SqlCommand("SELECT Id_Zapatilla, Marca, Talla, Precio,Procedencia FROM Sneakers", stringConection);
                this.dataAdapterSneakers.InsertCommand = new SqlCommand("INSERT INTO Sneakers (Marca, Talla,Precio,Procedencia) VALUES (@marca, @talla, @precio,@procedencia )", stringConection);
                this.dataAdapterSneakers.UpdateCommand = new SqlCommand("UPDATE Sneakers SET Marca=@marca, Talla=@talla, Precio=@precio, Procedencia=@procedencia WHERE Id_Zapatilla=@id", stringConection);
                this.dataAdapterSneakers.DeleteCommand = new SqlCommand("DELETE FROM Sneakers WHERE Id_Zapatilla=@id", stringConection);

                this.dataAdapterSneakers.InsertCommand.Parameters.Add("@marca", SqlDbType.VarChar, 20, "Marca");
                this.dataAdapterSneakers.InsertCommand.Parameters.Add("@talla", SqlDbType.Float, 10, "Talla");
                this.dataAdapterSneakers.InsertCommand.Parameters.Add("@precio", SqlDbType.Float, 10, "Precio");
                this.dataAdapterSneakers.InsertCommand.Parameters.Add("@procedencia", SqlDbType.VarChar, 20, "Procedencia");

                this.dataAdapterSneakers.UpdateCommand.Parameters.Add("@marca", SqlDbType.VarChar, 20, "Marca");
                this.dataAdapterSneakers.UpdateCommand.Parameters.Add("@talla", SqlDbType.Float, 10, "Talla");
                this.dataAdapterSneakers.UpdateCommand.Parameters.Add("@precio", SqlDbType.Float, 10, "Precio");
                this.dataAdapterSneakers.InsertCommand.Parameters.Add("@procedencia", SqlDbType.VarChar, 20, "Procedencia");
                this.dataAdapterSneakers.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 10, "Id_Zapatilla");


                this.dataAdapterSneakers.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 10, "Id_Zapatilla");

                rta = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return rta;
        }
        #endregion

            #region BOTINES
        private bool ConfigurarDataAdapterBotines()
        {
            bool rta = false;

            try
            {
                SqlConnection stringConection = new SqlConnection(Properties.Settings.Default.ConexionBD);

                this.dataAdapterBotines = new SqlDataAdapter();

                this.dataAdapterBotines.SelectCommand = new SqlCommand("SELECT ID_Botin, Marca, Talla, Precio,Multiterreno FROM Botines", stringConection);
                this.dataAdapterBotines.InsertCommand = new SqlCommand("INSERT INTO Botines (Marca, Talla,Precio,Multiterreno) VALUES (@marca, @talla, @precio,@multiterreno )", stringConection);
                this.dataAdapterBotines.UpdateCommand = new SqlCommand("UPDATE Sneakers SET Marca=@marca, Talla=@talla, Precio=@precio, Multiterreno=@multiterreno WHERE ID_Botin=@id", stringConection);
                this.dataAdapterBotines.DeleteCommand = new SqlCommand("DELETE FROM Botines WHERE ID_Botin=@id", stringConection);

                this.dataAdapterBotines.InsertCommand.Parameters.Add("@marca", SqlDbType.VarChar, 20, "Marca");
                this.dataAdapterBotines.InsertCommand.Parameters.Add("@talla", SqlDbType.Float, 10, "Talla");
                this.dataAdapterBotines.InsertCommand.Parameters.Add("@precio", SqlDbType.Float, 10, "Precio");
                this.dataAdapterBotines.InsertCommand.Parameters.Add("@multiterreno", SqlDbType.VarChar, 10, "Multiterreno");

                this.dataAdapterBotines.UpdateCommand.Parameters.Add("@marca", SqlDbType.VarChar, 20, "Marca");
                this.dataAdapterBotines.UpdateCommand.Parameters.Add("@talla", SqlDbType.Float, 10, "Talla");
                this.dataAdapterBotines.UpdateCommand.Parameters.Add("@precio", SqlDbType.Float, 10, "Precio");
                this.dataAdapterBotines.InsertCommand.Parameters.Add("@multiterreno", SqlDbType.VarChar, 10, "Multiterreno");
                this.dataAdapterBotines.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 10, "ID_Botin");


                this.dataAdapterBotines.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 10, "ID_Botin");

                rta = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return rta;
        }
        #endregion

        #endregion

        #region CONFIGURACION DATATABLE

        private void ConfigurarDataTable()
        {
            #region SNEAKERS
            this.dataTableSneakers = new DataTable("Sneakers 2020");

            this.dataTableSneakers.Columns.Add("Id_Zapatilla", typeof(int));
            this.dataTableSneakers.Columns.Add("Marca", typeof(string));
            this.dataTableSneakers.Columns.Add("Talla", typeof(float));
            this.dataTableSneakers.Columns.Add("Precio", typeof(float));
            this.dataTableSneakers.Columns.Add("Procedencia", typeof(string));


            this.dataTableSneakers.PrimaryKey = new DataColumn[] { this.dataTableSneakers.Columns[0] };

            this.dataTableSneakers.Columns["Id_Zapatilla"].AutoIncrement = true;
            this.dataTableSneakers.Columns["Id_Zapatilla"].AutoIncrementSeed = 1;//obtener el último id insertado en la tabla
            this.dataTableSneakers.Columns["Id_Zapatilla"].AutoIncrementStep = 1;
            #endregion

            #region BOTINES

            this.dataTableBotines = new DataTable("Botines  2020");

            this.dataTableBotines.Columns.Add("ID_Botin", typeof(int));
            this.dataTableBotines.Columns.Add("Marca", typeof(string));
            this.dataTableBotines.Columns.Add("Talla", typeof(float));
            this.dataTableBotines.Columns.Add("Precio", typeof(float));
            this.dataTableBotines.Columns.Add("Multiterreno", typeof(string));


            this.dataTableBotines.PrimaryKey = new DataColumn[] { this.dataTableBotines.Columns[0] };

            this.dataTableBotines.Columns["ID_Botin"].AutoIncrement = true;
            this.dataTableBotines.Columns["ID_Botin"].AutoIncrementSeed = 1;//obtener el último id insertado en la tabla
            this.dataTableBotines.Columns["ID_Botin"].AutoIncrementStep = 1;

            #endregion
        }

        #endregion

        #region CONFIGURACION GRILLA

        private void ConfigurarGrilla()
        {
            // Coloco color de fondo para las filas
            this.GrillaSneakers.RowsDefaultCellStyle.BackColor = Color.Gold;
            this.GrillaBotines.RowsDefaultCellStyle.BackColor = Color.Gold;

            // Alterno colores
            this.GrillaSneakers.AlternatingRowsDefaultCellStyle.BackColor = Color.Goldenrod;
            this.GrillaBotines.AlternatingRowsDefaultCellStyle.BackColor = Color.Goldenrod;

            // Pongo color de fondo a la grilla
            this.GrillaSneakers.BackgroundColor = Color.Gray;
            this.GrillaBotines.BackgroundColor = Color.Gray;

            // Defino fuente para el encabezado y alineación del encabezado
            this.GrillaSneakers.ColumnHeadersDefaultCellStyle.Font = new Font(GrillaSneakers.Font, FontStyle.Bold);
            this.GrillaSneakers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.GrillaBotines.ColumnHeadersDefaultCellStyle.Font = new Font(GrillaSneakers.Font, FontStyle.Bold);
            this.GrillaBotines.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Defino el color de las lineas de separación
            this.GrillaSneakers.GridColor = Color.HotPink;
            this.GrillaBotines.GridColor = Color.HotPink;

            // La grilla será de sólo lectura
            this.GrillaSneakers.ReadOnly = false;
            this.GrillaBotines.ReadOnly = false;

            // No permito la multiselección
            this.GrillaSneakers.MultiSelect = true;
            this.GrillaBotines.MultiSelect = false;
            // Selecciono toda la fila a la vez
            this.GrillaSneakers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GrillaBotines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Hago que las columnas ocupen todo el ancho del 'DataGrid'
            this.GrillaSneakers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaBotines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Indico el color de la fila seleccionada
            this.GrillaSneakers.RowsDefaultCellStyle.SelectionBackColor = Color.DarkOliveGreen;
            this.GrillaSneakers.RowsDefaultCellStyle.SelectionForeColor = Color.Aqua;

            this.GrillaBotines.RowsDefaultCellStyle.SelectionBackColor = Color.DarkOliveGreen;
            this.GrillaBotines.RowsDefaultCellStyle.SelectionForeColor = Color.DarkOliveGreen;

            // No permito modificar desde la grilla
            this.GrillaSneakers.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.GrillaBotines.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Saco los encabezados de las filas
            this.GrillaSneakers.RowHeadersVisible = false;
            this.GrillaBotines.RowHeadersVisible = false;
        }
        #endregion

        #region EVENTOS 
        /// <summary>
        /// Evento que permite la  carga de  informacion del stock de SNEAKERS, los cuales vendran de una base de datos SQL.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CargarStockSneakers_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataAdapterSneakers.Fill(this.dataTableSneakers);

                this.ConfigurarGrilla();

                this.GrillaSneakers.DataSource = this.dataTableSneakers;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Evento que permite cargar el stock de BOTINES en la grilla, mediante un comando de seleccion en la base de datos. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CargarStockBotines_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataAdapterBotines.Fill(this.dataTableBotines);

                this.ConfigurarGrilla();

                this.GrillaBotines.DataSource = this.dataTableBotines;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Evento encargado de almacenar el producto seleccionado de la grilla con toda su informacion. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                int indexSneaker = this.GrillaSneakers.SelectedRows[0].Index; // guardo el numero de la fila index 


                DataRow filaSneaker = this.dataTableSneakers.Rows[indexSneaker]; //obtengo la fila 


                //int indexLibre = Carrito.BuscarLibre(this.filas); // encuentro una posicionj para guardar el index 

                this.filas[this.BuscarLibre()] = indexSneaker;

                int id = int.Parse(filaSneaker["Id_Zapatilla"].ToString());
                string marca = filaSneaker["Marca"].ToString();
                float talla = float.Parse(filaSneaker["Talla"].ToString());
                float precio = float.Parse(filaSneaker["Precio"].ToString());
                string procedencia = filaSneaker["Procedencia"].ToString();

                this.precioAcumulado += precio;

                Sneakers sneaker = new Sneakers(marca, talla, precio, Sneakers.StringaProcedencia(procedencia));

                car += sneaker;
                this.FinalizarPagobutton.Enabled = true;
                this.VerCarritobutton.Enabled = true;
            }
            catch(SneakerRepetidoExcepcion sE)
            {
                MessageBox.Show(sE.Message);
            }
            
            catch (Exception)
            {

                MessageBox.Show("NO HA SELECCIONADO NADA.");
            }
            
           
        }
        /// <summary>
        /// Evento que permite visualizar la informacion del carrito. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MostrarCarrito_Click(object sender, EventArgs e)
        {
            CarritoForm formularioCarrito = new CarritoForm(car);
            formularioCarrito.StartPosition = FormStartPosition.CenterScreen;
            formularioCarrito.ShowDialog();
        }

        /// <summary>
        /// Evento que permite hace la baja en la base de datos, finalizando con ello la compra. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinalizarCompraButton(object sender, EventArgs e)
        {
            Thread t = new Thread(this.GuardarBaseDatos);
            // Falta verificar la  compra de  mas de un producto.

            int idEliminar = -1;
            int largo = this.filas.Length;
            
            Cliente clienteaux = new Cliente();

            ClienteForm formularioCliente = new ClienteForm(clienteaux,this.precioAcumulado);

            formularioCliente.StartPosition = FormStartPosition.CenterScreen;
            formularioCliente.ShowDialog();

            

            for (int i = 0; i < largo; i++)
            {
                if(this.filas!=null)
                {
                    foreach (int item in this.filas)
                    {

                        idEliminar = item;
                        break;
                    }
                    // Ubica la fila a eliminar y ejecuta comando 
                    DataRow fila = this.dataTableSneakers.Rows[idEliminar];
                    fila.Delete();
                }else
                {
                    break;
                }
                
            }

            t.Start();

        }
        #endregion

        #region METODOS AGREGADOS
        /// <summary>
        /// Metodo que permite Buscar una posicion libre en el array donde se guardara el  index de las filas. 
        /// </summary>
        /// <returns></returns>
        public int BuscarLibre()
        {

            for (int i = 0; i < this.filas.Length; i++)
            {
                if (this.filas[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }
        protected void GuardarBaseDatos()
        {
            try
            {
                this.dataAdapterSneakers.Update(this.dataTableSneakers);

                MessageBox.Show("Sincronizado!!!");
                
            }
            catch (Exception )
            {

                MessageBox.Show("Error de Sincronizacion. ");
            }

        }
        #endregion
    }
}
