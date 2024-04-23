namespace ArchiveSimulator
{
    public class CatalogCreatorBaseBase
    {
        public Catalog CreateCatalog(List documents)
        {
            Catalog catalog = new Catalog();
            foreach (Document doc in documents)
            {
                catalog.AddDocument(doc);
            }
            return catalog;
        }
    }
}