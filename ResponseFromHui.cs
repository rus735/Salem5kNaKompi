using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Mark
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("is_active")]
        public string IsActive { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class PriceList
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("country_id")]
        public string CountryId { get; set; }
    }

    public class Brand
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("is_active")]
        public string IsActive { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("brand")]
        public string BrandId { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("last_price")]
        public string LastPrice { get; set; }

        [JsonProperty("percent_diff")]
        public double PercentDiff { get; set; }

        [JsonProperty("price_diff")]
        public string PriceDiff { get; set; }

        [JsonProperty("valute")]
        public double Valute { get; set; }

        [JsonProperty("price_list")]
        public List<PriceList> PriceList { get; set; }
    }

    public class Price
    {
        [JsonProperty("price")]
        public string PriceValue { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("course")]
        public string Course { get; set; }

        [JsonProperty("dollar")]
        public string Dollar { get; set; }

        [JsonProperty("country_id")]
        public string CountryId { get; set; }
    }

    public class Root
    {
        [JsonProperty("mark")]
        public Mark Mark { get; set; }

        [JsonProperty("brands")]
        public List<Brand> Brands { get; set; }

        [JsonProperty("price")]
        public List<Price> Prices { get; set; }

        [JsonProperty("test")]
        public List<object> Test { get; set; }
    }
}
