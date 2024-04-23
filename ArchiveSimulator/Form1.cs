using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ArchiveSimulator
{
    public partial class Form1 : Form
    {
        private List archiveDocuments = new List();
        private List borrowedDocuments = new List();
        private List receivedDocuments = new List();
        private List inventoryList = new List();
        
        
        
        
        
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void AddDocument_Click(object sender, EventArgs e)
        {
            string documentName = txtDocumentName.Text;
            string documentContent = txtDocumentContent.Text;

            // Архивирование документа
            archiveDocuments.Add(documentName);

            MessageBox.Show("Документ успешно добавлен в архив!");
        }

        private void BorrowDocument_Click(object sender, EventArgs e)
        {
            string documentName = txtBorrowDocument.Text;

            if (archiveDocuments.Contains(documentName))
            {
                // Выдача документа пользователю
                borrowedDocuments.Add(documentName);
                archiveDocuments.Remove(documentName);

                MessageBox.Show("Документ успешно выдан пользователю!");
            }
            else
            {
                MessageBox.Show("Документ не найден в архиве!");
            }
        }

        private void ReturnDocument_Click(object sender, EventArgs e)
        {
            string documentName = txtReturnDocument.Text;

            if (borrowedDocuments.Contains(documentName))
            {
                // Возврат документа из временного пользования
                borrowedDocuments.Remove(documentName);
                archiveDocuments.Add(documentName);

                MessageBox.Show("Документ успешно возвращен в архив!");
            }
            else
            {
                MessageBox.Show("Документ не найден в списке выданных!");
            }
        }

        private void ReceiveDocument_Click(object sender, EventArgs e)
        {
            string documentName = txtReceiveDocument.Text;

            // Получение документа от организации-источника
            receivedDocuments.Add(documentName);

            MessageBox.Show("Документ успешно получен от организации-источника!");
        }

        private void btnAddToInventory_Click(object sender, EventArgs e)
        {
            string documentName = txtInventoryDocument.Text;

            // Добавление документа в справочный аппарат
            inventoryList.Add(documentName);

            MessageBox.Show("Документ успешно добавлен в справочный аппарат!");
        }

        
    }
}