namespace _6_soft_2_calc
{
    public class History
    {
        private List<string> records;

        public History()
        {
            records = new List<string>();
        }

        public void ClearHistory()
        {
            records.Clear();
        }

        public void Add(string record)
        {
            records.Add(record);
        }

        public List<string> GetHistory()
        {
            return records;
        }
    }
}
