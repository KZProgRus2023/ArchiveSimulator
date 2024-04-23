namespace ArchiveSimulator
{
    public class DocumentIssuerBaseBase
    {
        public void IssueDocuments(List documents, User user)
        {
            foreach (Document doc in documents)
            {
                Document issuer = new Document();
                // Логика выдачи документа пользователю
            }
        }
        public void ReturnDocuments(User user, List documents)
        {
            foreach (Document doc in documents)
            {
                Document Return = new Document();
                // Логика возврата документа
            }
        }
    }
}