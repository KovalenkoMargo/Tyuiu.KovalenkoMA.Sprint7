using System.Globalization;

namespace Tyuiu.KovalenkoMA.Sprint7.V2.Lib
{
    public class DataService
    {
        public class Owner
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public decimal Capital { get; set; }

            public override string ToString()
            {
                return $"{Id},{FullName},{Address},{Phone},{Capital}";
            }
        }


        public bool SaveToFile(string filePath, Owner[] ownersToSave, out string errorMessage)
        {
            errorMessage = "";

            try
            {
                var lines = new string[ownersToSave.Length + 1];
                lines[0] = "Id,FullName,Address,Phone,Capital";

                for (int i = 0; i < ownersToSave.Length; i++)
                {
                    lines[i + 1] = ownersToSave[i].ToString();
                }

                File.WriteAllLines(filePath, lines);
                return true; 
            }
            catch (Exception ex)
            {
                errorMessage = $"Ошибка при сохранении файла: {ex.Message}";
                return false;
            }
        }

        
    }
}