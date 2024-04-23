namespace ArchiveSimulator
{
    public class DocumentReceiverBaseBase
    {
        public void ReceiveDocuments(List documents)
        {
            foreach (Document doc in documents)
            {
                Document Receive = new Document();
                // Логика получения документа от организации-источника
            }
        }
        public void WriteOffDocuments(List documents)
        {
            foreach (Document doc in documents)
            {
                // Логика списания документа
            }
        }
    }
}