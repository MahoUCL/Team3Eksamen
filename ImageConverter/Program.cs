
// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            string folderPath = @"\images"; // Change to your folder path
            string connectionString = "Server=(localdb)\\localDB1;Database=Images;Trusted_Connection=True;MultipleActiveResultSets=true"; // Add your connection string

            List<string> base64Images = ConvertImagesToBase64(folderPath);
            UploadToDatabase(base64Images, connectionString);

            Console.WriteLine("Images have been successfully uploaded to the database.");
        }

        public static void UploadToDatabase(IEnumerable<string> base64Images, string connectionString)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            foreach (string base64 in base64Images)
            {
                string query = "INSERT INTO Images (ImageData) VALUES (@ImageData)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ImageData", base64);
                    command.ExecuteNonQuery();
                }
            }
        }

        //Reading Images and converting to Base64
        public static List<string> ConvertImagesToBase64(string folderPath)
        {
            List<string> base64Images = new List<string>();
            foreach (string file in Directory.GetFiles(folderPath, "*.png")) // Ensure the extension matches your needs
            {
                string base64 = ImageToBase64(file);
                base64Images.Add(base64);
            }
            return base64Images;
        }

        //Saveing Image to Database
        public static string ImageToBase64(string imagePath)
        {
            using (Image image = Image.FromFile(imagePath))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    return Convert.ToBase64String(imageBytes);
                }
            }
        }
    }
}