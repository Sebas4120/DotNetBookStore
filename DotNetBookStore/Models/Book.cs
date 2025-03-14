﻿using DotNetBookStore.Models;

using System.ComponentModel.DataAnnotations;



namespace DotNetBookstore.Models

{
    
    public class Book

    {

        //PK

        public int BookId { get; set; }



        [Required]

        [MaxLength(100)]

        public string Author { get; set; }



        [Required]
        [MaxLength(200)]

        public string Title { get; set; }



        public string? Image { get; set; }



        [Required]

        [Range(0.01, 999999)]


        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }


        //Esto es para que este nombre aparesca en la interfaz de usuario
        [Display(Name = "Mature Content")]
        public bool MatureContent { get; set; }



        //FK
        [Display(Name ="Category")]
        public int CategoryId { get; set; }



        // child references

        public List<CartItem>? CartItems { get; set; }

        public List<OrderDetail>? OrderDetails { get; set; }



        // parent reference
        // Como un libro tiene una sola categoria, no uso 'List'
        public Category? Category { get; set; }

    }
    

}