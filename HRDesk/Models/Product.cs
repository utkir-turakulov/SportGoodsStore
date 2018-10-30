using System.ComponentModel.DataAnnotations.Schema;

namespace HRDesk.Models
{
    /// <summary>
    /// Модель описывающая продукт 
    /// </summary>
    public class Product
    {
        public int Id { get; set; }        
        public int SectionId { get; set; }
        public int DivisionId { get; set; }
        public int ImageId { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double Weight { get; set; }
        public int SizeId { get; set; }

        [ForeignKey("SectionId")]
        public Section Section { get; set; }
        [ForeignKey("DivisionId")]
        public Division Division { get; set; }
        [ForeignKey("ImageId")]
        public Image Image { get; set; }
        [ForeignKey("SizeId")]
        public Size Size { get; set; }
    }
}
