using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsSelling.Classes
{
    public class Cart
    {
        private List<Part> parts = new List<Part>();

        public decimal GetTotalSum()
        {
            return parts.Sum(part => part.Price * part.Quantity);
        }

        public void AddPart(Part part)
        {
            Part existingPart = parts.FirstOrDefault(p => p.PartId == part.PartId);

            if (existingPart != null)
            {
                existingPart.Quantity++;
            }
            else
            {
                part.Quantity = 1;
                parts.Add(part);
            }
            
            // резервируем запчасть на время сессии
            //using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            //{
            //    connection.Open();

            //    using (SqlCommand command = new SqlCommand("UPDATE parts SET quantity_in_stock = quantity_in_stock - @quantity WHERE part_id = @partId", connection))
            //    {
            //        command.Parameters.AddWithValue("@quantity", 1);
            //        command.Parameters.AddWithValue("@partId", part.PartId);
            //        command.ExecuteNonQuery();
            //    }
            //}
        }

        public void RemovePart(Part part)
        {
            Part existingPart = parts.FirstOrDefault(p => p.PartId == part.PartId);

            if (existingPart != null)
            {
                existingPart.Quantity--;

                if (existingPart.Quantity == 0)
                {
                    parts.Remove(existingPart);
                }
            }
        }

        public List<Part> GetParts()
        {
            return parts;
        }

        public void Clear()
        {
            parts.Clear();
        }
    }
}
