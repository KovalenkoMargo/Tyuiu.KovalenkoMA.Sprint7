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

        public Owner[] LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new Owner[0]; 
            }

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length <= 1)
            {
                return new Owner[0];
            }

            Owner[] owners = new Owner[lines.Length - 1];
            int count = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(',');

                if (parts.Length < 5) continue;

                try
                {
                    owners[count] = new Owner
                    {
                        Id = int.Parse(parts[0]),
                        FullName = parts[1],
                        Address = parts[2],
                        Phone = parts[3],
                        Capital = decimal.Parse(parts[4])
                    };
                    count++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка в строке {i + 1}: {ex.Message}");
                }
            }
            Owner[] result = new Owner[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = owners[i];
            }

            return result;
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



        public decimal GetTotalCapital(Owner[] owners)
        {
            decimal total = 0;
            for (int i = 0; i < owners.Length; i++)
            {
                total += owners[i].Capital;
            }
            return total;
        }

        public decimal GetAverageCapital(Owner[] owners)
        {
            if (owners.Length == 0) return 0;
            return GetTotalCapital(owners) / owners.Length;
        }

        public int GetCount(Owner[] owners)
        {
            return owners.Length;
        }

        public decimal GetMinCapital(Owner[] owners)
        {
            if (owners.Length == 0) return 0;

            decimal min = owners[0].Capital;
            for (int i = 1; i < owners.Length; i++)
            {
                if (owners[i].Capital < min)
                    min = owners[i].Capital;
            }
            return min;
        }

        public decimal GetMaxCapital(Owner[] owners)
        {
            if (owners.Length == 0) return 0;

            decimal max = owners[0].Capital;
            for (int i = 1; i < owners.Length; i++)
            {
                if (owners[i].Capital > max)
                    max = owners[i].Capital;
            }
            return max;
        }




        public Owner[] SearchOwners(Owner[] owners, string searchTerm, string searchField = "FullName")
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return owners;


            bool IsMatch(Owner owner, string term, string field)
            {
                switch (field.ToLower())
                {
                    case "fullname": return owner.FullName.ToLower().Contains(term.ToLower());
                    case "address": return owner.Address.ToLower().Contains(term.ToLower());
                    case "phone": return owner.Phone.ToLower().Contains(term.ToLower());
                    case "id": return owner.Id.ToString().Contains(term);
                    case "capital": return owner.Capital.ToString().Contains(term);
                    default: return owner.FullName.ToLower().Contains(term.ToLower());
                }
            }

            int count = 0;
            for (int i = 0; i < owners.Length; i++)
            {
                if (IsMatch(owners[i], searchTerm, searchField))
                    count++;
            }

            Owner[] result = new Owner[count];
            int index = 0;

            for (int i = 0; i < owners.Length; i++)
            {
                if (IsMatch(owners[i], searchTerm, searchField))
                {
                    result[index] = owners[i];
                    index++;
                }
            }

            return result;
        }




        public Owner[] SortOwnersByCapital(Owner[] owners)
        {
            Owner[] sorted = new Owner[owners.Length];
            for (int i = 0; i < owners.Length; i++)
            {
                sorted[i] = owners[i];
            }

            for (int i = 0; i < sorted.Length - 1; i++)
            {
                for (int j = 0; j < sorted.Length - 1 - i; j++)
                {
                    if (sorted[j].Capital > sorted[j + 1].Capital)
                    {
                        Owner temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }

            return sorted;
        }



        public Owner[] FilterByCapitalRange(Owner[] owners, decimal min, decimal max)
        {
            if (owners == null || owners.Length == 0)
            {
                return new Owner[0];
            }

            if (min > max)
            {
                decimal temp = min;
                min = max;
                max = temp;
            }

            int count = 0;
            for (int i = 0; i < owners.Length; i++)
            {
                if (owners[i].Capital >= min && owners[i].Capital <= max)
                {
                    count++;
                }
            }

            Owner[] filteredOwners = new Owner[count];

            int index = 0;
            for (int i = 0; i < owners.Length; i++)
            {
                if (owners[i].Capital >= min && owners[i].Capital <= max)
                {
                    filteredOwners[index] = owners[i];
                    index++;
                }
            }
            return filteredOwners;
        }
    }
}

    
