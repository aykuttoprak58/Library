using System.Data.SqlClient;

namespace AdoLibrary.DAL
{
    public class Connection
    {
        public static SqlConnection con = new SqlConnection("Data Source=HPISNET;Initial Catalog=KUTUPHANE;Integrated Security=True");
    }
}
