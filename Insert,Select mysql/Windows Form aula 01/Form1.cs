using MySql.Data.MySqlClient;


namespace Windows_Form_aula_01
{
    public partial class Form1 : Form
    {
        MySqlConnection? conn;

        public Form1()
        {
            InitializeComponent();
            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=csharp";
                //Criar conexão com MySql
                conn = new MySqlConnection(data_source);

                //Executar o Comando Insert
            }
            catch(Exception ex) { 
                MessageBox.Show(ex.Message);
            }
            listContato.View = View.Details;
            listContato.LabelEdit = true;
            listContato.AllowColumnReorder = true;
            listContato.FullRowSelect = true;
            listContato.GridLines = true;
            listContato.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listContato.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listContato.Columns.Add("Email", 150, HorizontalAlignment.Left);
            listContato.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

 


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criar a query de inserir ao banco de dados
            string sql = "INSERT INTO contato (nome,email,telefone) VALUES('" + txtNome.Text + "', '" + txtEmail.Text + "', '" + txtTelefone.Text +"')";
            MySqlCommand inserir_dados = new MySqlCommand(sql, conn);

            conn.Open();

            inserir_dados.ExecuteReader();

            MessageBox.Show("Os dados foram cadastrados com sucesso.");
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pesquisa_Click(object sender, EventArgs e)
        {
                string q = "'%" + txtBusca.Text + "%'";

                string select_query = "SELECT * FROM contato WHERE nome LIKE " + q + "OR email LIKE " + q + "";

                string data_source = "datasource=localhost;username=root;password=;database=csharp";
                //Criar conexão com MySql
                conn = new MySqlConnection(data_source);

                 conn.Open();

            MySqlCommand select_contato = new MySqlCommand(select_query, conn);
                
                MySqlDataReader reader = select_contato.ExecuteReader();
             
                listContato.Items.Clear();

                while (reader.Read()) {
                string[] row = {
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                };
                var linha_listview = new ListViewItem(row);

                listContato.Items.Add(linha_listview);
            }

            

                
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}