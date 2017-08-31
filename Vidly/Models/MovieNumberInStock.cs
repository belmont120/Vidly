using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class MovieNumberInStock : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;
            return (movie.NumberInStock >= Movie.MinNumberInStock && movie.NumberInStock <= Movie.MaxNumberInStock)
                ? ValidationResult.Success : new ValidationResult("Number In Stock must between " + Movie.MinNumberInStock.ToString() + " and " + Movie.MaxNumberInStock.ToString());

        }
    }
}