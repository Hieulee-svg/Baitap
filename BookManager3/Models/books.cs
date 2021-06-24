namespace BookManager3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class books
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "ID không được để trống")]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [StringLength(100, ErrorMessage = "Tiêu đề không được vượt quá 100 kí tự")]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Mô tả không được để trống")]
        [StringLength(255)]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Tác giả không được để trống")]
        [StringLength(30, ErrorMessage = "Tên tác giả không được vượt quá 30 kí tự")]
        [Display(Name = "Tác giả")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Ảnh không được để trống")]
        [StringLength(255)]
        [Display(Name = "Ảnh")]
        public string Images { get; set; }

        [Range(1000, 1000000, ErrorMessage = "Giá sách phải từ 1000 VNĐ đến 1000000 VNĐ")]
        [Required(ErrorMessage = "Giá không được để trống")]
        [Display(Name = "Giá")]
        public int Price { get; set; }
    }
}
