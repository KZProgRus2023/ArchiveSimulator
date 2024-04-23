using System;

namespace ArchiveSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddDocument = new System.Windows.Forms.Button();
            this.BorrowDocument = new System.Windows.Forms.Button();
            this.ReturnDocument = new System.Windows.Forms.Button();
            this.ReceiveDocument = new System.Windows.Forms.Button();
            this.AddToInventory = new System.Windows.Forms.Button();
            this.txtDocumentName = new System.Windows.Forms.Label();
            this.txtDocumentContent = new System.Windows.Forms.TextBox();
            this.txtBorrowDocument = new System.Windows.Forms.Label();
            this.txtInventoryDocument = new System.Windows.Forms.Label();
            this.txtReturnDocument = new System.Windows.Forms.Label();
            this.txtReceiveDocument = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddDocument
            // 
            this.AddDocument.Location = new System.Drawing.Point(38, 372);
            this.AddDocument.Name = "AddDocument";
            this.AddDocument.Size = new System.Drawing.Size(75, 44);
            this.AddDocument.TabIndex = 0;
            this.AddDocument.Text = "Добавить документ";
            this.AddDocument.UseVisualStyleBackColor = true;
            // 
            // BorrowDocument
            // 
            this.BorrowDocument.Location = new System.Drawing.Point(145, 372);
            this.BorrowDocument.Name = "BorrowDocument";
            this.BorrowDocument.Size = new System.Drawing.Size(75, 44);
            this.BorrowDocument.TabIndex = 1;
            this.BorrowDocument.Text = "Выдать документ";
            this.BorrowDocument.UseVisualStyleBackColor = true;
            // 
            // ReturnDocument
            // 
            this.ReturnDocument.Location = new System.Drawing.Point(248, 372);
            this.ReturnDocument.Name = "ReturnDocument";
            this.ReturnDocument.Size = new System.Drawing.Size(75, 44);
            this.ReturnDocument.TabIndex = 2;
            this.ReturnDocument.Text = "Возврат документа";
            this.ReturnDocument.UseVisualStyleBackColor = true;
            // 
            // ReceiveDocument
            // 
            this.ReceiveDocument.Location = new System.Drawing.Point(345, 372);
            this.ReceiveDocument.Name = "ReceiveDocument";
            this.ReceiveDocument.Size = new System.Drawing.Size(162, 44);
            this.ReceiveDocument.TabIndex = 3;
            this.ReceiveDocument.Text = "Получить документы от источника комплектования";
            this.ReceiveDocument.UseVisualStyleBackColor = true;
            // 
            // AddToInventory
            // 
            this.AddToInventory.Location = new System.Drawing.Point(530, 372);
            this.AddToInventory.Name = "AddToInventory";
            this.AddToInventory.Size = new System.Drawing.Size(126, 44);
            this.AddToInventory.TabIndex = 4;
            this.AddToInventory.Text = "Добавить документ в справочный аппарат";
            this.AddToInventory.UseVisualStyleBackColor = true;
            // 
            // txtDocumentName
            // 
            this.txtDocumentName.AutoSize = true;
            this.txtDocumentName.Location = new System.Drawing.Point(38, 24);
            this.txtDocumentName.Name = "txtDocumentName";
            this.txtDocumentName.Size = new System.Drawing.Size(35, 13);
            this.txtDocumentName.TabIndex = 5;
            this.txtDocumentName.Text = "label1";
            this.txtDocumentName.Click += new System.EventHandler(this.txtDocumentName_Click);
            // 
            // txtDocumentContent
            // 
            this.txtDocumentContent.Location = new System.Drawing.Point(38, 40);
            this.txtDocumentContent.Multiline = true;
            this.txtDocumentContent.Name = "txtDocumentContent";
            this.txtDocumentContent.Size = new System.Drawing.Size(209, 269);
            this.txtDocumentContent.TabIndex = 6;
            this.txtDocumentContent.TextChanged += new System.EventHandler(this.txtDocumentContent_TextChanged);
            // 
            // txtBorrowDocument
            // 
            this.txtBorrowDocument.AutoSize = true;
            this.txtBorrowDocument.Location = new System.Drawing.Point(287, 40);
            this.txtBorrowDocument.Name = "txtBorrowDocument";
            this.txtBorrowDocument.Size = new System.Drawing.Size(100, 13);
            this.txtBorrowDocument.TabIndex = 7;
            this.txtBorrowDocument.Text = "txtBorrowDocument";
            this.txtBorrowDocument.Click += new System.EventHandler(this.txtBorrowDocument_Click);
            // 
            // txtInventoryDocument
            // 
            this.txtInventoryDocument.AutoSize = true;
            this.txtInventoryDocument.Location = new System.Drawing.Point(290, 75);
            this.txtInventoryDocument.Name = "txtInventoryDocument";
            this.txtInventoryDocument.Size = new System.Drawing.Size(35, 13);
            this.txtInventoryDocument.TabIndex = 8;
            this.txtInventoryDocument.Text = "label1";
            this.txtInventoryDocument.Click += new System.EventHandler(this.txtInventoryDocument_Click);
            // 
            // txtReturnDocument
            // 
            this.txtReturnDocument.AutoSize = true;
            this.txtReturnDocument.Location = new System.Drawing.Point(290, 119);
            this.txtReturnDocument.Name = "txtReturnDocument";
            this.txtReturnDocument.Size = new System.Drawing.Size(35, 13);
            this.txtReturnDocument.TabIndex = 9;
            this.txtReturnDocument.Text = "label1";
            this.txtReturnDocument.Click += new System.EventHandler(this.txtReturnDocument_Click);
            // 
            // txtReceiveDocument
            // 
            this.txtReceiveDocument.AutoSize = true;
            this.txtReceiveDocument.Location = new System.Drawing.Point(290, 160);
            this.txtReceiveDocument.Name = "txtReceiveDocument";
            this.txtReceiveDocument.Size = new System.Drawing.Size(35, 13);
            this.txtReceiveDocument.TabIndex = 10;
            this.txtReceiveDocument.Text = "label1";
            this.txtReceiveDocument.Click += new System.EventHandler(this.txtReceiveDocument_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtReceiveDocument);
            this.Controls.Add(this.txtReturnDocument);
            this.Controls.Add(this.txtInventoryDocument);
            this.Controls.Add(this.txtBorrowDocument);
            this.Controls.Add(this.txtDocumentContent);
            this.Controls.Add(this.txtDocumentName);
            this.Controls.Add(this.AddToInventory);
            this.Controls.Add(this.ReceiveDocument);
            this.Controls.Add(this.ReturnDocument);
            this.Controls.Add(this.BorrowDocument);
            this.Controls.Add(this.AddDocument);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtDocumentName_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtDocumentContent_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtBorrowDocument_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtReceiveDocument_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtInventoryDocument_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtReturnDocument_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button AddDocument;
        private System.Windows.Forms.Button BorrowDocument;
        private System.Windows.Forms.Button ReturnDocument;
        private System.Windows.Forms.Button ReceiveDocument;
        private System.Windows.Forms.Button AddToInventory;
        private System.Windows.Forms.Label txtDocumentName;
        private System.Windows.Forms.TextBox txtDocumentContent;
        private System.Windows.Forms.Label txtBorrowDocument;
        private System.Windows.Forms.Label txtInventoryDocument;
        private System.Windows.Forms.Label txtReturnDocument;
        private System.Windows.Forms.Label txtReceiveDocument;
    }
}

