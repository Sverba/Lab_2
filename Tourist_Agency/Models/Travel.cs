using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tourist_Agency.Models
{
    public class Travel
    {
        //ID путівки
        public int TravelID { get; set; }
        //Назва путіки
        public string Name { get; set; }
        //Опис путівки
        public string Description { get; set; }
        //Категорія путівки
        public string Category { set; get; }
        //Країна відправлення
        public string SCountry { set; get; }
        //Місто відправлення
        public string STown { set; get; }
        //Країна прибуття
        public string FCountry { set; get; }
        //Місто прибуття
        public string FTown { set; get; }
        //Ціна путівки
        public decimal Price { get; set; }
        //Дата відправки
        public string Date { set; get; }
        //Тривалість путіки у днях
        public int Duration { get; set; }
    }
}