namespace WindowsFormExercise
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Table1 = new System.Windows.Forms.TabControl();
            this.Q1Q2 = new System.Windows.Forms.TabPage();
            this.btnQ12AbrirArquivo = new System.Windows.Forms.Button();
            this.btnQ12GerarLista = new System.Windows.Forms.Button();
            this.q12List = new System.Windows.Forms.ListView();
            this.btnQ12Add = new System.Windows.Forms.Button();
            this.txtQ12 = new System.Windows.Forms.TextBox();
            this.InfNum = new System.Windows.Forms.Label();
            this.Q2 = new System.Windows.Forms.Label();
            this.Q1 = new System.Windows.Forms.Label();
            this.Q3Q4Q5 = new System.Windows.Forms.TabPage();
            this.btnQ345CarregarGrid = new System.Windows.Forms.Button();
            this.gvQ345 = new System.Windows.Forms.DataGridView();
            this.btnQ345CriarJson = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Q4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Q3 = new System.Windows.Forms.Label();
            this.Q6 = new System.Windows.Forms.TabPage();
            this.lvQ6 = new System.Windows.Forms.ListView();
            this.btnQ6Consultar = new System.Windows.Forms.Button();
            this.txtQ5Cep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.endCorreio = new System.Windows.Forms.Label();
            this.Quest6 = new System.Windows.Forms.Label();
            this.Q7 = new System.Windows.Forms.TabPage();
            this.gvQ7 = new System.Windows.Forms.DataGridView();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btnQ7Consultar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Quest7 = new System.Windows.Forms.Label();
            this.Q8 = new System.Windows.Forms.TabPage();
            this.btnQ8BaixarImagem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Table1.SuspendLayout();
            this.Q1Q2.SuspendLayout();
            this.Q3Q4Q5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQ345)).BeginInit();
            this.Q6.SuspendLayout();
            this.Q7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQ7)).BeginInit();
            this.Q8.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table1
            // 
            this.Table1.Controls.Add(this.Q1Q2);
            this.Table1.Controls.Add(this.Q3Q4Q5);
            this.Table1.Controls.Add(this.Q6);
            this.Table1.Controls.Add(this.Q7);
            this.Table1.Controls.Add(this.Q8);
            this.Table1.Location = new System.Drawing.Point(12, 30);
            this.Table1.Name = "Table1";
            this.Table1.SelectedIndex = 0;
            this.Table1.Size = new System.Drawing.Size(1030, 502);
            this.Table1.TabIndex = 0;
            // 
            // Q1Q2
            // 
            this.Q1Q2.Controls.Add(this.btnQ12AbrirArquivo);
            this.Q1Q2.Controls.Add(this.btnQ12GerarLista);
            this.Q1Q2.Controls.Add(this.q12List);
            this.Q1Q2.Controls.Add(this.btnQ12Add);
            this.Q1Q2.Controls.Add(this.txtQ12);
            this.Q1Q2.Controls.Add(this.InfNum);
            this.Q1Q2.Controls.Add(this.Q2);
            this.Q1Q2.Controls.Add(this.Q1);
            this.Q1Q2.Location = new System.Drawing.Point(4, 29);
            this.Q1Q2.Name = "Q1Q2";
            this.Q1Q2.Padding = new System.Windows.Forms.Padding(3);
            this.Q1Q2.Size = new System.Drawing.Size(1022, 469);
            this.Q1Q2.TabIndex = 0;
            this.Q1Q2.Text = "Q1 e Q2";
            this.Q1Q2.UseVisualStyleBackColor = true;
            // 
            // btnQ12AbrirArquivo
            // 
            this.btnQ12AbrirArquivo.Location = new System.Drawing.Point(223, 416);
            this.btnQ12AbrirArquivo.Name = "btnQ12AbrirArquivo";
            this.btnQ12AbrirArquivo.Size = new System.Drawing.Size(134, 30);
            this.btnQ12AbrirArquivo.TabIndex = 7;
            this.btnQ12AbrirArquivo.Text = "Abrir";
            this.btnQ12AbrirArquivo.UseVisualStyleBackColor = true;
            // 
            // btnQ12GerarLista
            // 
            this.btnQ12GerarLista.Location = new System.Drawing.Point(62, 416);
            this.btnQ12GerarLista.Name = "btnQ12GerarLista";
            this.btnQ12GerarLista.Size = new System.Drawing.Size(134, 30);
            this.btnQ12GerarLista.TabIndex = 6;
            this.btnQ12GerarLista.Text = "Gravar Lista";
            this.btnQ12GerarLista.UseVisualStyleBackColor = true;
            // 
            // q12List
            // 
            this.q12List.Location = new System.Drawing.Point(13, 118);
            this.q12List.Name = "q12List";
            this.q12List.Size = new System.Drawing.Size(560, 280);
            this.q12List.TabIndex = 5;
            this.q12List.UseCompatibleStateImageBehavior = false;
            // 
            // btnQ12Add
            // 
            this.btnQ12Add.Location = new System.Drawing.Point(281, 70);
            this.btnQ12Add.Name = "btnQ12Add";
            this.btnQ12Add.Size = new System.Drawing.Size(94, 29);
            this.btnQ12Add.TabIndex = 4;
            this.btnQ12Add.Text = "Adicionar";
            this.btnQ12Add.UseVisualStyleBackColor = true;
            this.btnQ12Add.Click += new System.EventHandler(this.btnQ12Add_Click);
            // 
            // txtQ12
            // 
            this.txtQ12.Location = new System.Drawing.Point(150, 70);
            this.txtQ12.Name = "txtQ12";
            this.txtQ12.Size = new System.Drawing.Size(125, 27);
            this.txtQ12.TabIndex = 1;
            this.txtQ12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQ12_KeyPress);
            // 
            // InfNum
            // 
            this.InfNum.AutoSize = true;
            this.InfNum.Location = new System.Drawing.Point(13, 73);
            this.InfNum.Name = "InfNum";
            this.InfNum.Size = new System.Drawing.Size(131, 20);
            this.InfNum.TabIndex = 2;
            this.InfNum.Text = "Informe 1 número:";
            // 
            // Q2
            // 
            this.Q2.AutoSize = true;
            this.Q2.Location = new System.Drawing.Point(13, 41);
            this.Q2.Name = "Q2";
            this.Q2.Size = new System.Drawing.Size(950, 20);
            this.Q2.TabIndex = 1;
            this.Q2.Text = "2. Agora grave os números vizualizados cada um em uma linha em um arquivo texto n" +
    "a pasta raiz da aplicação de nome numeros_ordenar.txt.";
            // 
            // Q1
            // 
            this.Q1.AutoSize = true;
            this.Q1.Location = new System.Drawing.Point(13, 12);
            this.Q1.Name = "Q1";
            this.Q1.Size = new System.Drawing.Size(702, 20);
            this.Q1.TabIndex = 0;
            this.Q1.Text = "1. Faça a aplicação permitir a digitação de números e mostre esses números em tel" +
    "a de forma ordenada.";
            // 
            // Q3Q4Q5
            // 
            this.Q3Q4Q5.Controls.Add(this.btnQ345CarregarGrid);
            this.Q3Q4Q5.Controls.Add(this.gvQ345);
            this.Q3Q4Q5.Controls.Add(this.btnQ345CriarJson);
            this.Q3Q4Q5.Controls.Add(this.label4);
            this.Q3Q4Q5.Controls.Add(this.Q4);
            this.Q3Q4Q5.Controls.Add(this.label3);
            this.Q3Q4Q5.Controls.Add(this.label2);
            this.Q3Q4Q5.Controls.Add(this.Q3);
            this.Q3Q4Q5.Location = new System.Drawing.Point(4, 29);
            this.Q3Q4Q5.Name = "Q3Q4Q5";
            this.Q3Q4Q5.Padding = new System.Windows.Forms.Padding(3);
            this.Q3Q4Q5.Size = new System.Drawing.Size(1022, 469);
            this.Q3Q4Q5.TabIndex = 1;
            this.Q3Q4Q5.Text = "Q3, Q4 e Q5";
            this.Q3Q4Q5.UseVisualStyleBackColor = true;
            // 
            // btnQ345CarregarGrid
            // 
            this.btnQ345CarregarGrid.Location = new System.Drawing.Point(311, 151);
            this.btnQ345CarregarGrid.Name = "btnQ345CarregarGrid";
            this.btnQ345CarregarGrid.Size = new System.Drawing.Size(198, 29);
            this.btnQ345CarregarGrid.TabIndex = 8;
            this.btnQ345CarregarGrid.Text = "Carrega Grid";
            this.btnQ345CarregarGrid.UseVisualStyleBackColor = true;
            // 
            // gvQ345
            // 
            this.gvQ345.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQ345.Location = new System.Drawing.Point(13, 194);
            this.gvQ345.Name = "gvQ345";
            this.gvQ345.RowHeadersWidth = 51;
            this.gvQ345.RowTemplate.Height = 29;
            this.gvQ345.Size = new System.Drawing.Size(955, 269);
            this.gvQ345.TabIndex = 7;
            // 
            // btnQ345CriarJson
            // 
            this.btnQ345CriarJson.Location = new System.Drawing.Point(68, 151);
            this.btnQ345CriarJson.Name = "btnQ345CriarJson";
            this.btnQ345CriarJson.Size = new System.Drawing.Size(198, 29);
            this.btnQ345CriarJson.TabIndex = 5;
            this.btnQ345CriarJson.Text = "Criar arquivo data.json";
            this.btnQ345CriarJson.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(617, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "5. Crie um grid, leia o arquivo data.jason que foi gravado, e mostre os dados no " +
    "Grid criado.";
            // 
            // Q4
            // 
            this.Q4.AutoSize = true;
            this.Q4.Location = new System.Drawing.Point(13, 86);
            this.Q4.Name = "Q4";
            this.Q4.Size = new System.Drawing.Size(590, 20);
            this.Q4.TabIndex = 3;
            this.Q4.Text = "4. Armazene a lista criada em um arquivo de nome data.json na pasta raiz da aplic" +
    "ação.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "2022/10/13 08:50:22.123)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(930, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "objetos deverão ser criados com a propriedade código com números sequenciais (ex:" +
    " 1,2,3,4,5) e a descrição como a data e hora atual (ex: ";
            // 
            // Q3
            // 
            this.Q3.AutoSize = true;
            this.Q3.Location = new System.Drawing.Point(13, 12);
            this.Q3.Name = "Q3";
            this.Q3.Size = new System.Drawing.Size(936, 20);
            this.Q3.TabIndex = 0;
            this.Q3.Text = "3. Crie uma lista contendo 100 itens de uma classe de nome cls Teste com as propr" +
    "iedades código como número e descrição como texto, os";
            // 
            // Q6
            // 
            this.Q6.Controls.Add(this.lvQ6);
            this.Q6.Controls.Add(this.btnQ6Consultar);
            this.Q6.Controls.Add(this.txtQ5Cep);
            this.Q6.Controls.Add(this.label6);
            this.Q6.Controls.Add(this.linkLabel1);
            this.Q6.Controls.Add(this.label5);
            this.Q6.Controls.Add(this.endCorreio);
            this.Q6.Controls.Add(this.Quest6);
            this.Q6.Location = new System.Drawing.Point(4, 29);
            this.Q6.Name = "Q6";
            this.Q6.Padding = new System.Windows.Forms.Padding(3);
            this.Q6.Size = new System.Drawing.Size(1022, 469);
            this.Q6.TabIndex = 2;
            this.Q6.Text = "Q6";
            this.Q6.UseVisualStyleBackColor = true;
            // 
            // lvQ6
            // 
            this.lvQ6.Location = new System.Drawing.Point(13, 103);
            this.lvQ6.Name = "lvQ6";
            this.lvQ6.Size = new System.Drawing.Size(616, 294);
            this.lvQ6.TabIndex = 7;
            this.lvQ6.UseCompatibleStateImageBehavior = false;
            // 
            // btnQ6Consultar
            // 
            this.btnQ6Consultar.Location = new System.Drawing.Point(256, 68);
            this.btnQ6Consultar.Name = "btnQ6Consultar";
            this.btnQ6Consultar.Size = new System.Drawing.Size(94, 29);
            this.btnQ6Consultar.TabIndex = 6;
            this.btnQ6Consultar.Text = "consultar";
            this.btnQ6Consultar.UseVisualStyleBackColor = true;
            // 
            // txtQ5Cep
            // 
            this.txtQ5Cep.Location = new System.Drawing.Point(125, 69);
            this.txtQ5Cep.Name = "txtQ5Cep";
            this.txtQ5Cep.Size = new System.Drawing.Size(125, 27);
            this.txtQ5Cep.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Informe o CEP";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(86, 35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(589, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?ws" +
    "dl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Método: consultaCEP";
            // 
            // endCorreio
            // 
            this.endCorreio.AutoSize = true;
            this.endCorreio.Location = new System.Drawing.Point(16, 35);
            this.endCorreio.Name = "endCorreio";
            this.endCorreio.Size = new System.Drawing.Size(74, 20);
            this.endCorreio.TabIndex = 1;
            this.endCorreio.Text = "Endereço:";
            // 
            // Quest6
            // 
            this.Quest6.AutoSize = true;
            this.Quest6.Location = new System.Drawing.Point(13, 12);
            this.Quest6.Name = "Quest6";
            this.Quest6.Size = new System.Drawing.Size(794, 20);
            this.Quest6.TabIndex = 0;
            this.Quest6.Text = "6. Consuma o webservice dos correios passando um CEP qualquer e mostre em tela o " +
    "endereço que o mesmo retornar.";
            // 
            // Q7
            // 
            this.Q7.Controls.Add(this.gvQ7);
            this.Q7.Controls.Add(this.linkLabel3);
            this.Q7.Controls.Add(this.linkLabel2);
            this.Q7.Controls.Add(this.btnQ7Consultar);
            this.Q7.Controls.Add(this.label9);
            this.Q7.Controls.Add(this.label8);
            this.Q7.Controls.Add(this.label7);
            this.Q7.Controls.Add(this.Quest7);
            this.Q7.Location = new System.Drawing.Point(4, 29);
            this.Q7.Name = "Q7";
            this.Q7.Padding = new System.Windows.Forms.Padding(3);
            this.Q7.Size = new System.Drawing.Size(1022, 469);
            this.Q7.TabIndex = 3;
            this.Q7.Text = "Q7";
            this.Q7.UseVisualStyleBackColor = true;
            // 
            // gvQ7
            // 
            this.gvQ7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQ7.Location = new System.Drawing.Point(19, 135);
            this.gvQ7.Name = "gvQ7";
            this.gvQ7.RowHeadersWidth = 51;
            this.gvQ7.RowTemplate.Height = 29;
            this.gvQ7.Size = new System.Drawing.Size(939, 316);
            this.gvQ7.TabIndex = 7;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(617, 40);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(255, 20);
            this.linkLabel3.TabIndex = 6;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "https://brasilapi.com.br/api/banks/v1";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(121, 41);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(449, 20);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://brasilapi.com.br/docs#tag/BANKS/paths/~1banks~1v1/get";
            // 
            // btnQ7Consultar
            // 
            this.btnQ7Consultar.Location = new System.Drawing.Point(375, 77);
            this.btnQ7Consultar.Name = "btnQ7Consultar";
            this.btnQ7Consultar.Size = new System.Drawing.Size(182, 29);
            this.btnQ7Consultar.TabIndex = 4;
            this.btnQ7Consultar.Text = "Consultar e Mostrar";
            this.btnQ7Consultar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mostre os dados de retorno da API em um Grid.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(580, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "URL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Documentação: ";
            // 
            // Quest7
            // 
            this.Quest7.AutoSize = true;
            this.Quest7.Location = new System.Drawing.Point(13, 12);
            this.Quest7.Name = "Quest7";
            this.Quest7.Size = new System.Drawing.Size(391, 20);
            this.Quest7.TabIndex = 0;
            this.Quest7.Text = "7. Consuma a API para buscar a lista de bancos brasileiros";
            // 
            // Q8
            // 
            this.Q8.Controls.Add(this.btnQ8BaixarImagem);
            this.Q8.Controls.Add(this.label10);
            this.Q8.Controls.Add(this.label1);
            this.Q8.Location = new System.Drawing.Point(4, 29);
            this.Q8.Name = "Q8";
            this.Q8.Padding = new System.Windows.Forms.Padding(3);
            this.Q8.Size = new System.Drawing.Size(1022, 469);
            this.Q8.TabIndex = 4;
            this.Q8.Text = "Q8";
            this.Q8.UseVisualStyleBackColor = true;
            // 
            // btnQ8BaixarImagem
            // 
            this.btnQ8BaixarImagem.Location = new System.Drawing.Point(58, 66);
            this.btnQ8BaixarImagem.Name = "btnQ8BaixarImagem";
            this.btnQ8BaixarImagem.Size = new System.Drawing.Size(210, 29);
            this.btnQ8BaixarImagem.TabIndex = 2;
            this.btnQ8BaixarImagem.Text = "Baixar imagem e Gravar";
            this.btnQ8BaixarImagem.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(632, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "do sistema, e criar alguma função para ler essa imagem e mostrar em tela no forma" +
    "to base64.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(956, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "8. Pela aplicação faça o download da imagem  https://redeservice.com.br/wpcontent" +
    "/uploads/2020/07/redeservice-logo.png,, colocar na pasta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 542);
            this.Controls.Add(this.Table1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Table1.ResumeLayout(false);
            this.Q1Q2.ResumeLayout(false);
            this.Q1Q2.PerformLayout();
            this.Q3Q4Q5.ResumeLayout(false);
            this.Q3Q4Q5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQ345)).EndInit();
            this.Q6.ResumeLayout(false);
            this.Q6.PerformLayout();
            this.Q7.ResumeLayout(false);
            this.Q7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQ7)).EndInit();
            this.Q8.ResumeLayout(false);
            this.Q8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Table1;
        private System.Windows.Forms.TabPage Q1Q2;
        private System.Windows.Forms.TabPage Q3Q4Q5;
        private System.Windows.Forms.ListView q12List;
        private System.Windows.Forms.Button btnQ12Add;
        private System.Windows.Forms.TextBox txtQ12;
        private System.Windows.Forms.Label InfNum;
        private System.Windows.Forms.Label Q2;
        private System.Windows.Forms.Label Q1;
        private System.Windows.Forms.Button btnQ345CriarJson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Q4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Q3;
        private System.Windows.Forms.TabPage Q6;
        private System.Windows.Forms.TabPage Q7;
        private System.Windows.Forms.TabPage Q8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvQ345;
        private System.Windows.Forms.Button btnQ345CarregarGrid;
        private System.Windows.Forms.Button btnQ6Consultar;
        private System.Windows.Forms.TextBox txtQ5Cep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label endCorreio;
        private System.Windows.Forms.Label Quest6;
        private System.Windows.Forms.DataGridView gvQ7;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btnQ7Consultar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Quest7;
        private System.Windows.Forms.Button btnQ8BaixarImagem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lvQ6;
        private System.Windows.Forms.Button btnQ12GerarLista;
        private System.Windows.Forms.Button btnQ12AbrirArquivo;
    }
}
